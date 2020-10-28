using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace United_Youth_Orchestra_with_API.Migrations
{
    public partial class UYOAPIDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Telephone = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Schoolyear = table.Column<int>(nullable: false),
                    MusicInst = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}
