using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BrownstoneWWW03.Data.Migrations
{
    public partial class CustomerAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customer");
        }
    }
}
