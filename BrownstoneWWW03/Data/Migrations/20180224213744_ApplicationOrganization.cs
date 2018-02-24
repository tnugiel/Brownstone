using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BrownstoneWWW03.Data.Migrations
{
    public partial class ApplicationOrganization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MerchantID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RouteNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationOrganizationID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ApplicationOrganization",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountNumber = table.Column<string>(maxLength: 80, nullable: true),
                    Address = table.Column<string>(maxLength: 80, nullable: true),
                    Address2 = table.Column<string>(maxLength: 80, nullable: true),
                    City = table.Column<string>(maxLength: 80, nullable: true),
                    Company = table.Column<string>(maxLength: 80, nullable: true),
                    Country = table.Column<string>(maxLength: 80, nullable: true),
                    EIN = table.Column<string>(maxLength: 80, nullable: true),
                    MerchantID = table.Column<string>(maxLength: 80, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 12, nullable: true),
                    RouteNumber = table.Column<string>(maxLength: 80, nullable: true),
                    State = table.Column<string>(maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationOrganization", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ApplicationOrganizationID",
                table: "AspNetUsers",
                column: "ApplicationOrganizationID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ApplicationOrganization_ApplicationOrganizationID",
                table: "AspNetUsers",
                column: "ApplicationOrganizationID",
                principalTable: "ApplicationOrganization",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ApplicationOrganization_ApplicationOrganizationID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ApplicationOrganization");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ApplicationOrganizationID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationOrganizationID",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "AspNetUsers",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "AspNetUsers",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "AspNetUsers",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MerchantID",
                table: "AspNetUsers",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RouteNumber",
                table: "AspNetUsers",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AspNetUsers",
                maxLength: 5,
                nullable: true);
        }
    }
}
