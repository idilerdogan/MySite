using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySite.Entities.Migrations
{
    /// <inheritdoc />
    public partial class addmenues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 446, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActionName", "CreateDate" },
                values: new object[] { "About", new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(1932) });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActionName", "ControllerName", "CreateDate" },
                values: new object[] { "Education", "Home", new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActionName", "ControllerName", "CreateDate", "MenuName" },
                values: new object[] { "Experince", "Home", new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(1939), "Experinces" });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActionName", "ControllerName", "CreateDate" },
                values: new object[] { "Project", "Home", new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActionName", "ControllerName", "CreateDate" },
                values: new object[] { "Skill", "Home", new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActionName", "ControllerName", "CreateDate" },
                values: new object[] { "Achievement", "Home", new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActionName", "ControllerName", "CreateDate" },
                values: new object[] { "Activitie", "Home", new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.InsertData(
                table: "MainMenus",
                columns: new[] { "Id", "ActionName", "AreaName", "ClassName", "ControllerName", "CreateDate", "CssName", "IconName", "MenuName", "OrderNo", "ParentMenuId", "RoleId" },
                values: new object[] { 8, "Language", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(1947), "", null, "Languages", null, null, 1 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 447, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 5, 0, 32, 19, 448, DateTimeKind.Local).AddTicks(3804));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActionName", "CreateDate" },
                values: new object[] { "Index", new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActionName", "ControllerName", "CreateDate" },
                values: new object[] { "Index", "Account", new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActionName", "ControllerName", "CreateDate", "MenuName" },
                values: new object[] { "Index", "Account", new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(5827), "Work Experinces" });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActionName", "ControllerName", "CreateDate" },
                values: new object[] { "Index", "Account", new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActionName", "ControllerName", "CreateDate" },
                values: new object[] { "Index", "Account", new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActionName", "ControllerName", "CreateDate" },
                values: new object[] { "Index", "Account", new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActionName", "ControllerName", "CreateDate" },
                values: new object[] { "Index", "Account", new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(5554));
        }
    }
}
