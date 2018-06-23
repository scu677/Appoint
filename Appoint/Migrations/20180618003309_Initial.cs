using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Appoint.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EndTime = table.Column<int>(nullable: false),
                    PartnerFK = table.Column<int>(nullable: false),
                    ServiceFK = table.Column<int>(nullable: false),
                    StartTime = table.Column<int>(nullable: false),
                    TimeBook = table.Column<int>(nullable: false),
                    UserFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingID);
                });

            migrationBuilder.CreateTable(
                name: "Partner_Clients",
                columns: table => new
                {
                    Partner_ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BizDescription = table.Column<string>(nullable: false),
                    BizName = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    File = table.Column<byte[]>(nullable: true),
                    FileName = table.Column<string>(nullable: false),
                    OpeningHours = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Postcode = table.Column<string>(nullable: false),
                    Province = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partner_Clients", x => x.Partner_ClientID);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EndTime = table.Column<int>(nullable: false),
                    PartnerFK = table.Column<int>(nullable: false),
                    ScheduleDuration = table.Column<int>(nullable: false),
                    ServiceName = table.Column<string>(nullable: true),
                    StartTime = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    Duration = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    PartnerFK = table.Column<int>(nullable: false),
                    Price = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "User_Clients",
                columns: table => new
                {
                    User_ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Postcode = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Clients", x => x.User_ClientID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Partner_Clients");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "User_Clients");
        }
    }
}
