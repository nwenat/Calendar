using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calendar.Migrations
{
    public partial class NewTableEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    From = table.Column<DateTime>(nullable: false),
                    To = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "From", "Name", "To", "UserId" },
                values: new object[] { 1, new DateTime(2020, 4, 12, 7, 0, 0, 0, DateTimeKind.Unspecified), "Praca", new DateTime(2020, 4, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "From", "Name", "To", "UserId" },
                values: new object[] { 2, new DateTime(2020, 4, 13, 7, 0, 0, 0, DateTimeKind.Unspecified), "Pracaaaa", new DateTime(2020, 4, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
