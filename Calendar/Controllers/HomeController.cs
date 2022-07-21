using Calendar.Models;
using Calendar.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEventRepository _eventRepository;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ILogger logger;
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public HomeController(IEventRepository eventRepository, IHostingEnvironment hostingEnvironment, ILogger<HomeController> logger,
                                UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _eventRepository = eventRepository;
            this.hostingEnvironment = hostingEnvironment;
            this.logger = logger;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpGet]
        public async Task<ViewResult> Index(string uN, int? page)
        {
            // dayNumer from 1 to 7
            int dayNumber = (int)DateTime.Today.DayOfWeek == 0 ? 7 : (int)DateTime.Today.DayOfWeek;
            int indexWeek = page.HasValue ? page.Value : 0;

            IndexViewModel model = new IndexViewModel
            {
                page = indexWeek
            };

            if (uN != null)
            {
                var user = await userManager.FindByNameAsync(uN);
                if (user != null)
                {
                    model.eventsInWeek = _eventRepository.GetWeekEventsPerUser(dayNumber, indexWeek, user.Id);

                    List<IdentityUser> anotherUsersInGroup = new List<IdentityUser>();
                    var userGroups = await userManager.GetRolesAsync(user);
                    foreach (var group in userGroups)
                    {
                        foreach(var u in await userManager.GetUsersInRoleAsync(group))
                        {
                            anotherUsersInGroup.Add(u);
                        }
                    }

                    var anotherUsers = anotherUsersInGroup.Distinct().ToList();
                    anotherUsers.Remove(user);
                    foreach(var u in anotherUsers)
                    {
                        model.eventsOtherUsers.Add(new WeekEventsPerUserViewModel
                        {
                            userName = u.UserName,
                            eventsInWeek = _eventRepository.GetWeekEventsPerUser(dayNumber, indexWeek, u.Id)
                        });
                    }
                }
            }
            ViewBag.Today = dayNumber;
            ViewBag.Monday = DateTime.Today.AddDays(-dayNumber);
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateEvent(IndexViewModel model)
        {
            if ((ModelState.IsValid) )
            {
                EventCrateViewModel eModel = model.eventCreate;
                DateTime fromModel = eModel.Date.AddHours(eModel.FromHour).AddMinutes(eModel.FromMinutes);
                DateTime toModel = eModel.Date.AddHours(eModel.ToHour).AddMinutes(eModel.ToMinutes);

                if (toModel < fromModel)
                {
                    toModel = fromModel;
                }
                if (model.uN != null)
                {
                    var user = await userManager.FindByNameAsync(model.uN);

                    Event newEvent = new Event
                    {
                        Name = eModel.Name,
                        UserId = user.Id,
                        From = fromModel,
                        To = toModel,
                        Priority = eModel.Priority
                    };
                    _eventRepository.Add(newEvent);
                }
                return RedirectToAction("index", new { uN = model.uN, page = model.page });
            }
            return RedirectToAction("index", new { uN = model.uN, page = model.page });
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditEvent(IndexViewModel model)
        {
            if ((ModelState.IsValid))
            {
                EventEditViewModel eModel = model.eventEdit;

                Event editEvent = _eventRepository.GetEvent(eModel.Id);
                editEvent.Name = eModel.Name;

                DateTime fromModel = eModel.Date.AddHours(eModel.FromHour).AddMinutes(eModel.FromMinutes);
                DateTime toModel = eModel.Date.AddHours(eModel.ToHour).AddMinutes(eModel.ToMinutes);

                if (toModel < fromModel)
                {
                    toModel = fromModel;
                }
                editEvent.From = fromModel;
                editEvent.To = toModel;
                editEvent.Priority = eModel.Priority;
                _eventRepository.Update(editEvent);
                return RedirectToAction("index", new { uN = model.uN, page = model.page });
            }
            return RedirectToAction("index", new { uN = model.uN, page = model.page });
        }

        [HttpPost]
        [Authorize]
        public IActionResult DeleteEvent(IndexViewModel model)
        {
            _eventRepository.Delete(model.deleteId);
            return RedirectToAction("index", new { uN = model.uN, page = model.page });
        }
    }
}
