using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calendar.Migrations
{
    public partial class MondayEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 6, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 6, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "Name", "Priority", "To" },
                values: new object[] { new DateTime(2020, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), "Zakupy", 1, new DateTime(2020, 4, 6, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "From", "Name", "Priority", "To", "UserId" },
                values: new object[,]
                {
                    { 3, new DateTime(2020, 4, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), "Call", 1, new DateTime(2020, 4, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, new DateTime(2020, 4, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), "Kino", 1, new DateTime(2020, 4, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 12, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 12, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "Name", "Priority", "To" },
                values: new object[] { new DateTime(2020, 4, 13, 7, 0, 0, 0, DateTimeKind.Unspecified), "Pracaaaa", 2, new DateTime(2020, 4, 13, 15, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
