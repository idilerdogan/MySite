using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySite.Entities.Migrations
{
    /// <inheritdoc />
    public partial class languageupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 344, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 344, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 344, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 344, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 344, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 344, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 344, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 345, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 345, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 345, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 345, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 345, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 345, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 345, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 345, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 345, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 345, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 345, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 345, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 345, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Languages" },
                values: new object[] { new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(60), "Mother Language", "Turkish" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Languages" },
                values: new object[] { new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(88), "Upper Intermediate", "English" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Description", "Languages" },
                values: new object[] { new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(93), "Elemantary", "Germany" });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 346, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 347, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 11, 38, 45, 348, DateTimeKind.Local).AddTicks(1119));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Languages");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 102, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Languages" },
                values: new object[] { new DateTime(2024, 11, 7, 11, 24, 8, 103, DateTimeKind.Local).AddTicks(1803), "Turkish Mother Language" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Languages" },
                values: new object[] { new DateTime(2024, 11, 7, 11, 24, 8, 103, DateTimeKind.Local).AddTicks(1832), "English Upper Intermediate" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Languages" },
                values: new object[] { new DateTime(2024, 11, 7, 11, 24, 8, 103, DateTimeKind.Local).AddTicks(1837), "Germany Elemantary" });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 103, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 103, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 103, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 103, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 103, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 103, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 103, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 103, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 104, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 104, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 104, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 104, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 104, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 104, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 104, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 104, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 104, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 104, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 105, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 105, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 105, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 105, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 105, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 105, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 105, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 105, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 105, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 105, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 105, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 105, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 105, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 105, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 7, 11, 24, 8, 107, DateTimeKind.Local).AddTicks(951));
        }
    }
}
