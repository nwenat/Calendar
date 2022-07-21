using Calendar.Models;
using Calendar.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Calendar.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly ILogger<AdministrationController> logger;

        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, ILogger<AdministrationController> logger)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult CreateGroup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateGroup(CreateGruopViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.GroupName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    var user = await userManager.FindByNameAsync(model.userName);

                    if (user == null)
                    {
                        ViewBag.ErrorMessage = $"Not found user with name: {model.userName}";
                        return View("NotFound");
                    }

                    result = await userManager.AddClaimAsync(user, new Claim(ClaimsStore.AllClaims[0].Type, model.GroupName));

                    if (!result.Succeeded)
                    {
                        ModelState.AddModelError("", "Cannot add Group Admin claim to user");
                        return View(model);
                    }

                    result = await userManager.AddToRoleAsync(user, identityRole.Name);

                    if (!result.Succeeded)
                    {
                        ModelState.AddModelError("", "Cannot add Group Admin claim to user");
                        return View(model);
                    }

                    return RedirectToAction("MyGroups", "Administration", new { uN = model.userName});
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        [Authorize(Policy = "AdminGroupRolePolicy")]
        public async Task<IActionResult> MyGroups(string uN)
        {
            var userAdministrator = await userManager.FindByNameAsync(uN);
            var adminClaims = await userManager.GetClaimsAsync(userAdministrator);

            List<IdentityRole> groups = new List<IdentityRole>();

            foreach (var role in roleManager.Roles)
            {
                if (adminClaims.Any(c => c.Type == ClaimsStore.AllClaims[0].Type && c.Value == role.Name))
                {
                    groups.Add(role);
                }
            }
            return View(groups);
        }

        [HttpGet]
        [Authorize(Policy = "AdminGroupRolePolicy")]
        public async Task<IActionResult> EditGroup(string id)
        {
            var group = await roleManager.FindByIdAsync(id);

            if (group == null)
            {
                ViewBag.ErrorMessage = $"Not found group with id: {id}";
                return View("NotFound");
            }

            var model = new EditGroupViewModel
            {
                Id = group.Id,
                GroupName = group.Name
            };

            foreach (var user in userManager.Users)
            {
                if (await userManager.IsInRoleAsync(user, group.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "AdminGroupRolePolicy")]
        public async Task<IActionResult> EditGroup(EditGroupViewModel model)
        {
            var group = await roleManager.FindByIdAsync(model.Id);
            string oldGroupName = group.Name;
            if (group == null)
            {
                ViewBag.ErrorMessage = $"Not found group with id: {model.Id}";
                return View("NotFound");
            }
            else
            {
                group.Name = model.GroupName;
                var result = await roleManager.UpdateAsync(group);

                if (result.Succeeded)
                {
                    var user = await userManager.FindByNameAsync(model.UN);

                    if(user != null)
                    {
                        Claim oldClaim = ((List<Claim>)(await userManager.GetClaimsAsync(user))).Where(c => c.Value == oldGroupName).First();
                        await userManager.ReplaceClaimAsync(user, oldClaim, new Claim(ClaimsStore.AllClaims[0].Type, model.GroupName));
                    }
                    return RedirectToAction("MyGroups", "Administration", new { uN = model.UN });
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }

        [HttpGet]
        [Authorize(Policy = "AdminGroupRolePolicy")]
        public async Task<IActionResult> EditUsersInGroup(string Id)
        {
            ViewBag.roleId = Id;
            var role = await roleManager.FindByIdAsync(Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Not found role with id: {Id}";
                return View("NotFound");
            }
            var model = new List<UserRoleViewModel>();

            foreach (var user in userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }
                model.Add(userRoleViewModel);
            }
            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "AdminGroupRolePolicy")]
        public async Task<IActionResult> EditUsersInGroup(List<UserRoleViewModel> model, string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Not found role with id: {roleId}";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);
                IdentityResult result = null;

                if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);

                }
                else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditGroup", new { id = roleId });
                }
            }

            return RedirectToAction("EditGroup", new { id = roleId });
        }

        [HttpPost]
        [Authorize(Policy = "SuperAdminRolePolicy")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Not found user with id: {id}";
                return View("NotFound");
            }
            else
            {
                var result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListUsers");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("ListUsers");
            }
        }

        [HttpGet]
        [Authorize(Policy = "SuperAdminRolePolicy")]
        public async Task<IActionResult> ManageUserClaims(string userId)
        {
            ViewBag.userId = userId;

            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Not found user with id: {userId}";
                return View("NotFound");
            }

            var existingUserClaims = await userManager.GetClaimsAsync(user);

            var model = new UserClaimsViewModel
            {
                UserId = userId
            };

            foreach (Claim claim in ClaimsStore.AllClaims)
            {
                UserClaim userClaim = new UserClaim
                {
                    ClaimType = claim.Type
                };
                if (existingUserClaims.Any(c => c.Type == claim.Type && c.Value == "true"))
                {
                    userClaim.IsSelected = true;
                }
                model.Claims.Add(userClaim);
            }
            return View(model);
        }


        [HttpPost]
        [Authorize(Policy = "SuperAdminRolePolicy")]
        public async Task<IActionResult> ManageUserClaims(UserClaimsViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.UserId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Not found user with id: {model.UserId}";
                return View("NotFound");
            }

            var claims = await userManager.GetClaimsAsync(user);
            var result = await userManager.RemoveClaimsAsync(user, claims);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user exitsting claims");
                return View(model);
            }

            result = await userManager.AddClaimsAsync(user, model.Claims.Select(c => new Claim(c.ClaimType, c.IsSelected ? "true" : "false")));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected claims to user");
                return View(model);
            }

            return RedirectToAction("EditUser", new { Id = model.UserId });
        }

        [HttpGet]
        [Authorize(Policy = "SuperAdminRolePolicy")]
        public async Task<IActionResult> ManageUserRoles(string userId)
        {
            ViewBag.userId = userId;

            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Not found user with id: {userId}";
                return View("NotFound");
            }

            var model = new List<UserRolesViewModel>();

            foreach(var role in roleManager.Roles)
            {
                var userRoleViewModel = new UserRolesViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };

                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                model.Add(userRoleViewModel);
            }

            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "SuperAdminRolePolicy")]
        public async Task<IActionResult> ManageUserRoles(List<UserRolesViewModel> model, string userId)
        {
            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Not found user with id: {userId}";
                return View("NotFound");
            }

            var roles = await userManager.GetRolesAsync(user);
            var result = await userManager.RemoveFromRolesAsync(user, roles);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user exitsting roles");
                return View(model);
            }

            result = await userManager.AddToRolesAsync(user, model.Where(x => x.IsSelected).Select(y => y.RoleName));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return View(model);
            }

            return RedirectToAction("EditUser", new { Id = userId });
        }

        [HttpPost]
        [Authorize(Policy = "AdminGroupRolePolicy")]
        public async Task<IActionResult> DeleteRole(string id, string uN)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Not found role with id: {id}";
                return View("NotFound");
            }
            else
            {
                try
                {
                    var result = await roleManager.DeleteAsync(role);
                    if (result.Succeeded)
                    {
                        if(uN == null)
                        {
                            return RedirectToAction("ListRoles");
                        }
                        else
                        {
                            return RedirectToAction("MyGroups", "Administration", new { uN = uN});
                        }
                    }
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    if (uN == null)
                    {
                        return RedirectToAction("ListRoles");
                    }
                    else
                    {
                        return RedirectToAction("MyGroups", "Administration", new { uN = uN });
                    }
                }
                catch(DbUpdateException ex)
                {
                    logger.LogError($"Error deleting role {ex}");

                    ViewBag.ErrorTitle = $"{role.Name} - grupa w użyciu";
                    ViewBag.ErrorMessage = $"{role.Name} aby usunąć grupę nie może ona zawierać użytkowników, usuń użytkowników z tej grupy a następnie usuń grupę.";
                    return View("Error");
                }
            }
        }

        [HttpGet]
        [Authorize(Policy = "SuperAdminRolePolicy")]
        public IActionResult ListUsers()
        {
            var users = userManager.Users;
            return View(users);
        }

        [HttpGet]
        [Authorize(Policy = "SuperAdminRolePolicy")]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Not found user with id: {id}";
                return View("NotFound");
            }

            var userClaims = await userManager.GetClaimsAsync(user);
            var userRoles = await userManager.GetRolesAsync(user);

            var model = new EditUserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Claims = userClaims.Select(c => c.Type + " : " + c.Value).ToList(),
                Roles = userRoles.ToList()
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "SuperAdminRolePolicy")]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Not found user with id: {model.Id}";
                return View("NotFound");
            }
            else
            {
                user.UserName = model.UserName;

                var result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Listusers");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }

        [HttpGet]
        [Authorize(Policy = "SuperAdminRolePolicy")]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        [Authorize(Policy = "SuperAdminRolePolicy")]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Not found role with id: {id}";
                return View("NotFound");
            }

            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            foreach (var user in userManager.Users)
            {
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "SuperAdminRolePolicy")]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await roleManager.FindByIdAsync(model.Id);
            var oldGroupName = role.Name;
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Not found role with id: {model.Id}";
                return View("NotFound");
            }
            else
            {
                role.Name = model.RoleName;
                var result = await roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    IdentityUser adminUser = null;

                    foreach (var user in userManager.Users)
                    {
                        var userClaims = await userManager.GetClaimsAsync(user);
                        if (userClaims.Any(c => c.Type == ClaimsStore.AllClaims[0].Type && c.Value == oldGroupName))
                        {
                            adminUser = user;
                        }
                    }

                    if (adminUser != null)
                    {
                        Claim oldClaim = ((List<Claim>)(await userManager.GetClaimsAsync(adminUser))).Where(c => c.Value == oldGroupName).First();
                        await userManager.ReplaceClaimAsync(adminUser, oldClaim, new Claim(ClaimsStore.AllClaims[0].Type, model.RoleName));
                    }
                    return RedirectToAction("ListRoles", "Administration");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }

        [HttpGet]
        [Authorize(Policy = "SuperAdminRolePolicy")]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;

            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Not found role with id: {roleId}";
                return View("NotFound");
            }

            var model = new List<UserRoleViewModel>();

            foreach (var user in userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                model.Add(userRoleViewModel);
            }

            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "SuperAdminRolePolicy")]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> moel, string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Not found role with id: {roleId}";
                return View("NotFound");
            }

            for (int i = 0; i < moel.Count; i++)
            {
                var user = await userManager.FindByIdAsync(moel[i].UserId);
                IdentityResult result = null;

                if (moel[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);

                }
                else if (!moel[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (moel.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditRole", new { Id = roleId });
                }
            }
            return RedirectToAction("EditRole", new { Id = roleId });
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
