using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calendar.Migrations
{
    public partial class UserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 1,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 27, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), "9607d42e-a830-490e-bf81-f27ea8978e96" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), "9607d42e-a830-490e-bf81-f27ea8978e96" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), "9607d42e-a830-490e-bf81-f27ea8978e96" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), "9607d42e-a830-490e-bf81-f27ea8978e96" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 28, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), "9607d42e-a830-490e-bf81-f27ea8978e96" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), "9607d42e-a830-490e-bf81-f27ea8978e96" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), "9607d42e-a830-490e-bf81-f27ea8978e96" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), "9607d42e-a830-490e-bf81-f27ea8978e96" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 20, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), "1" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), "1" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), "1" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), "1" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 21, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), "1" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), "1" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), "1" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "To", "UserId" },
                values: new object[] { new DateTime(2020, 4, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 21, 22, 0, 0, 0, DateTimeKind.Unspecified), "1" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "From", "Name", "Priority", "To", "UserId" },
                values: new object[,]
                {
                    { 16, new DateTime(2020, 4, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "Zakupy", 1, new DateTime(2020, 4, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 15, new DateTime(2020, 4, 24, 7, 0, 0, 0, DateTimeKind.Unspecified), "Praca pt", 0, new DateTime(2020, 4, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 14, new DateTime(2020, 4, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), "Zakupy", 1, new DateTime(2020, 4, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 13, new DateTime(2020, 4, 23, 7, 0, 0, 0, DateTimeKind.Unspecified), "Praca czw", 0, new DateTime(2020, 4, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 9, new DateTime(2020, 4, 22, 7, 0, 0, 0, DateTimeKind.Unspecified), "Praca sr", 0, new DateTime(2020, 4, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 11, new DateTime(2020, 4, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), "Call", 0, new DateTime(2020, 4, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 10, new DateTime(2020, 4, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), "Zakupy", 1, new DateTime(2020, 4, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 17, new DateTime(2020, 4, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "Odpoczynek sobota", 1, new DateTime(2020, 4, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 12, new DateTime(2020, 4, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), "Kino", 2, new DateTime(2020, 4, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 18, new DateTime(2020, 4, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), "Basen niedziela", 2, new DateTime(2020, 4, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), "1" }
                });
        }
    }
}
