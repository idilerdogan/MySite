using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MySite.Entities.Migrations
{
    /// <inheritdoc />
    public partial class experience : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiances");

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExPlace = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ExTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExBeginning = table.Column<DateOnly>(type: "date", nullable: false),
                    ExEnding = table.Column<DateOnly>(type: "date", nullable: false),
                    ExDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "CreateDate", "ExBeginning", "ExDescription", "ExEnding", "ExPlace", "ExTitle", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(8190), new DateOnly(2011, 6, 1), "Kept record of the balance sheet by using Excel efficiently Provided report of the profit and loss account statement", new DateOnly(2011, 8, 31), "Ibrahim Ozturk Independent Accountant And Tax Professional", "Asistant", null },
                    { 2, new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(8184), new DateOnly(2015, 6, 1), "Attended meetings with the manager of the center Provided correlation in mailing system", new DateOnly(2016, 8, 31), "Efesus Outlet Center", "Part-Time Assistant in Administration", null },
                    { 3, new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(8181), new DateOnly(2018, 7, 1), "Planned drama class curriculum Conducted drama and acting class for in the scope of Highschool Summer School", new DateOnly(2018, 8, 31), "Sabanci University", "Creator Drama & Acting Instructor", null },
                    { 4, new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(8177), new DateOnly(2017, 7, 1), "Planned drama class curriculum Conducted drama and acting class for in the scope of Highschool Summer School", new DateOnly(2017, 8, 31), "Sabanci University", "Creator Drama & Acting Instructor", null },
                    { 5, new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(8173), new DateOnly(2018, 6, 1), "Provided introductory campus tour for visitors. Gave additional information though phone calls and the information stand", new DateOnly(2019, 3, 31), "Sabanci University", "Introduction Team Member", null },
                    { 6, new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(8156), new DateOnly(2019, 7, 1), "Assembled and adapted PLC to old German Ring Twisted Machines", new DateOnly(2019, 8, 31), "Kordsa", "Internship", null }
                });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 818, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActionName", "CreateDate", "MenuName" },
                values: new object[] { "Experience", new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(1519), "Experience" });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 819, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 2, 8, 6, 820, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_Id",
                table: "Experiences",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_UserId",
                table: "Experiences",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.CreateTable(
                name: "Experiances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExBeginning = table.Column<DateOnly>(type: "date", nullable: false),
                    ExDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ExEnding = table.Column<DateOnly>(type: "date", nullable: false),
                    ExPlace = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ExTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiances_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 512, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 512, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 512, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 512, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 512, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 512, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 512, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.InsertData(
                table: "Experiances",
                columns: new[] { "Id", "CreateDate", "ExBeginning", "ExDescription", "ExEnding", "ExPlace", "ExTitle", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(4102), new DateOnly(2011, 6, 1), "Kept record of the balance sheet by using Excel efficiently Provided report of the profit and loss account statement", new DateOnly(2011, 8, 31), "Ibrahim Ozturk Independent Accountant And Tax Professional", "Asistant", null },
                    { 2, new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(4062), new DateOnly(2015, 6, 1), "Attended meetings with the manager of the center Provided correlation in mailing system", new DateOnly(2016, 8, 31), "Efesus Outlet Center", "Part-Time Assistant in Administration", null },
                    { 3, new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(4050), new DateOnly(2018, 7, 1), "Planned drama class curriculum Conducted drama and acting class for in the scope of Highschool Summer School", new DateOnly(2018, 8, 31), "Sabanci University", "Creator Drama & Acting Instructor", null },
                    { 4, new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(4047), new DateOnly(2017, 7, 1), "Planned drama class curriculum Conducted drama and acting class for in the scope of Highschool Summer School", new DateOnly(2017, 8, 31), "Sabanci University", "Creator Drama & Acting Instructor", null },
                    { 5, new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(4043), new DateOnly(2018, 6, 1), "Provided introductory campus tour for visitors. Gave additional information though phone calls and the information stand", new DateOnly(2019, 3, 31), "Sabanci University", "Introduction Team Member", null },
                    { 6, new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(4027), new DateOnly(2019, 7, 1), "Assembled and adapted PLC to old German Ring Twisted Machines", new DateOnly(2019, 8, 31), "Kordsa", "Internship", null }
                });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActionName", "CreateDate", "MenuName" },
                values: new object[] { "Experince", new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(7417), "Experince" });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 513, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 34, 20, 514, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.CreateIndex(
                name: "IX_Experiances_Id",
                table: "Experiances",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Experiances_UserId",
                table: "Experiances",
                column: "UserId");
        }
    }
}
