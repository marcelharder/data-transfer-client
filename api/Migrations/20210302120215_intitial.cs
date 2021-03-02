using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class intitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    image = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    profession = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    user_name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    password = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    liscense_to_kill = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    selected_hospital_id = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    active = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Selected_Hospital_Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    HospitalName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    HospitalNo = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Address = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Telephone = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Fax = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    City = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Country = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SampleMrn = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    RegExpr = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ImageUrl = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    OpReportDetails1 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    OpReportDetails2 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    OpReportDetails3 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    OpReportDetails4 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    OpReportDetails5 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    OpReportDetails6 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    OpReportDetails7 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    OpReportDetails8 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    OpReportDetails9 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    hospital_id = table.Column<int>(type: "int", nullable: false),
                    worked_in = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Username = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Role = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "longblob", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "longblob", nullable: true),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhotoUrl = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastActive = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    KnownAs = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Introduction = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LookingFor = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Email = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Interests = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    City = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Address = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IBAN = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Mobile = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Country = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    active = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ltk = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
