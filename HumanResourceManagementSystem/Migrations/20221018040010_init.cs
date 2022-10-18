using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResourceManagementSystem.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addressInfo",
                columns: table => new
                {
                    AddressInfoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    street1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    street2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addressInfo", x => x.AddressInfoID);
                });

            migrationBuilder.CreateTable(
                name: "civilInfo",
                columns: table => new
                {
                    CivilInfoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanCard = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_civilInfo", x => x.CivilInfoID);
                });

            migrationBuilder.CreateTable(
                name: "educationalInfo",
                columns: table => new
                {
                    EducationalInfoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BDegree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BMarks = table.Column<int>(type: "int", nullable: false),
                    MDegree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MMarks = table.Column<int>(type: "int", nullable: false),
                    AEC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educationalInfo", x => x.EducationalInfoID);
                });

            migrationBuilder.CreateTable(
                name: "officialInfo",
                columns: table => new
                {
                    OfficialInfoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_officialInfo", x => x.OfficialInfoID);
                });

            migrationBuilder.CreateTable(
                name: "personalInfo",
                columns: table => new
                {
                    PersonalInfoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personalInfo", x => x.PersonalInfoID);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalInfoID = table.Column<int>(type: "int", nullable: false),
                    AddressInfoID = table.Column<int>(type: "int", nullable: false),
                    EducationalInfoID = table.Column<int>(type: "int", nullable: false),
                    CivilInfoID = table.Column<int>(type: "int", nullable: false),
                    OfficialInfoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_employees_addressInfo_AddressInfoID",
                        column: x => x.AddressInfoID,
                        principalTable: "addressInfo",
                        principalColumn: "AddressInfoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_civilInfo_CivilInfoID",
                        column: x => x.CivilInfoID,
                        principalTable: "civilInfo",
                        principalColumn: "CivilInfoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_educationalInfo_EducationalInfoID",
                        column: x => x.EducationalInfoID,
                        principalTable: "educationalInfo",
                        principalColumn: "EducationalInfoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_officialInfo_OfficialInfoID",
                        column: x => x.OfficialInfoID,
                        principalTable: "officialInfo",
                        principalColumn: "OfficialInfoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_personalInfo_PersonalInfoID",
                        column: x => x.PersonalInfoID,
                        principalTable: "personalInfo",
                        principalColumn: "PersonalInfoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_AddressInfoID",
                table: "employees",
                column: "AddressInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_CivilInfoID",
                table: "employees",
                column: "CivilInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_EducationalInfoID",
                table: "employees",
                column: "EducationalInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_OfficialInfoID",
                table: "employees",
                column: "OfficialInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_PersonalInfoID",
                table: "employees",
                column: "PersonalInfoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "addressInfo");

            migrationBuilder.DropTable(
                name: "civilInfo");

            migrationBuilder.DropTable(
                name: "educationalInfo");

            migrationBuilder.DropTable(
                name: "officialInfo");

            migrationBuilder.DropTable(
                name: "personalInfo");
        }
    }
}
