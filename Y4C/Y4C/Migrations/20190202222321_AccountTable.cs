using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Y4C.Migrations
{
    public partial class AccountTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentDob = table.Column<string>(nullable: true),
                    StudentEmail = table.Column<string>(nullable: true),
                    StudentFName = table.Column<string>(nullable: true),
                    StudentLName = table.Column<string>(nullable: true),
                    StudentPwd = table.Column<string>(nullable: true),
                    StudentTakenYogaClass = table.Column<string>(nullable: true),
                    StudentUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
