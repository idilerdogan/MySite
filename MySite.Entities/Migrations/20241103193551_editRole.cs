using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySite.Entities.Migrations
{
    /// <inheritdoc />
    public partial class editRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainMenus_Roles_RolesId",
                table: "MainMenus");

            migrationBuilder.RenameColumn(
                name: "RolesId",
                table: "MainMenus",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_MainMenus_RolesId",
                table: "MainMenus",
                newName: "IX_MainMenus_RoleId");

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "RoleId" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 35, 51, 50, DateTimeKind.Local).AddTicks(1855), 1 });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "RoleId" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 35, 51, 50, DateTimeKind.Local).AddTicks(1868), 1 });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "RoleId" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 35, 51, 50, DateTimeKind.Local).AddTicks(1869), 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_MainMenus_Roles_RoleId",
                table: "MainMenus",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainMenus_Roles_RoleId",
                table: "MainMenus");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "MainMenus",
                newName: "RolesId");

            migrationBuilder.RenameIndex(
                name: "IX_MainMenus_RoleId",
                table: "MainMenus",
                newName: "IX_MainMenus_RolesId");

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "RolesId" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 32, 41, 681, DateTimeKind.Local).AddTicks(4505), null });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "RolesId" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 32, 41, 681, DateTimeKind.Local).AddTicks(4516), null });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "RolesId" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 32, 41, 681, DateTimeKind.Local).AddTicks(4518), null });

            migrationBuilder.AddForeignKey(
                name: "FK_MainMenus_Roles_RolesId",
                table: "MainMenus",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id");
        }
    }
}
