using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calendar.Migrations
{
    public partial class FullWeek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Priority",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Priority",
                value: 2);

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "From", "Name", "Priority", "To", "UserId" },
                values: new object[,]
                {
                    { 5, new DateTime(2020, 4, 7, 7, 0, 0, 0, DateTimeKind.Unspecified), "Praca", 0, new DateTime(2020, 4, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, new DateTime(2020, 4, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), "Zakupy", 1, new DateTime(2020, 4, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, new DateTime(2020, 4, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), "Call", 0, new DateTime(2020, 4, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, new DateTime(2020, 4, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), "Kino", 2, new DateTime(2020, 4, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, new DateTime(2020, 4, 8, 7, 0, 0, 0, DateTimeKind.Unspecified), "Praca", 0, new DateTime(2020, 4, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, new DateTime(2020, 4, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), "Zakupy", 1, new DateTime(2020, 4, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, new DateTime(2020, 4, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), "Call", 0, new DateTime(2020, 4, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, new DateTime(2020, 4, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "Kino", 2, new DateTime(2020, 4, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 13, new DateTime(2020, 4, 9, 7, 0, 0, 0, DateTimeKind.Unspecified), "Praca", 0, new DateTime(2020, 4, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, new DateTime(2020, 4, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), "Zakupy", 1, new DateTime(2020, 4, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 15, new DateTime(2020, 4, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), "Praca", 0, new DateTime(2020, 4, 7, 1, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 16, new DateTime(2020, 4, 7, 2, 0, 0, 0, DateTimeKind.Unspecified), "Zakupy", 1, new DateTime(2020, 4, 7, 3, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 17, new DateTime(2020, 4, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Odpoczynek", 1, new DateTime(2020, 4, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 18, new DateTime(2020, 4, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), "Basen", 1, new DateTime(2020, 4, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Priority",
                value: 1);
        }
    }
}
