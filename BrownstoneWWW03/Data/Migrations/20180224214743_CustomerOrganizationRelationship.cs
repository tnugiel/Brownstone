using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BrownstoneWWW03.Data.Migrations
{
    public partial class CustomerOrganizationRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplicationOrganizationID",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ApplicationOrganizationID",
                table: "Customer",
                column: "ApplicationOrganizationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_ApplicationOrganization_ApplicationOrganizationID",
                table: "Customer",
                column: "ApplicationOrganizationID",
                principalTable: "ApplicationOrganization",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_ApplicationOrganization_ApplicationOrganizationID",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_ApplicationOrganizationID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ApplicationOrganizationID",
                table: "Customer");
        }
    }
}
