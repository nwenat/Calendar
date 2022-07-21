using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calendar.Migrations
{
    public partial class NextWeekII : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 20, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 20, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 20, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 20, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 20, 22, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 21, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 21, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 21, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 21, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 21, 22, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 22, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 22, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 22, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 22, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 22, 22, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 23, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 23, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 23, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 24, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 24, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 24, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 25, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 26, 17, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 13, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 13, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 13, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 13, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 13, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 13, 22, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 14, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 14, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 14, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 14, 22, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 15, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 15, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 15, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 15, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 15, 22, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 16, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 16, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 7, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 18, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2020, 4, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
