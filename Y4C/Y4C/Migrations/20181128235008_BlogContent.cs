﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Y4C.Migrations
{
    public partial class BlogContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BlogAuthor",
                table: "AC",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BlogContent",
                table: "AC",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BlogTitle",
                table: "AC",
                nullable: true);

            migrationBuilder.DropColumn(
                name: "BlogAuthor",
                table: "AC");

            migrationBuilder.DropColumn(
                name: "BlogContent",
                table: "AC");

            migrationBuilder.DropColumn(
                name: "BlogTitle",
                table: "AC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
