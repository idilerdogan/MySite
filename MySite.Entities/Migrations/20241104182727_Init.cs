using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MySite.Entities.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(19)", maxLength: 19, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ControllerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CssName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IconName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    ParentMenuId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainMenus_MainMenus_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "MainMenus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MainMenus_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Achievements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ScBeginning = table.Column<DateOnly>(type: "date", nullable: false),
                    ScEndning = table.Column<DateOnly>(type: "date", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Degree = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Experiances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExPlace = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ExTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExBeginning = table.Column<DateOnly>(type: "date", nullable: false),
                    ExEnding = table.Column<DateOnly>(type: "date", nullable: false),
                    ExDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Languages = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Languages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerSkills = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Medialink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialMedias_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "AcDate", "CreateDate", "Description", "UserId" },
                values: new object[,]
                {
                    { 1, new DateOnly(2020, 2, 1), new DateTime(2024, 11, 4, 21, 27, 27, 212, DateTimeKind.Local).AddTicks(8873), "Decleration of honor in dean’s honor list for maintaining a high GPA", null },
                    { 2, new DateOnly(2016, 1, 1), new DateTime(2024, 11, 4, 21, 27, 27, 212, DateTimeKind.Local).AddTicks(8905), "Sabanci University Extracurricular Activities Award Awarded for theatre tours around the country and abroad / Organizing the Offtown Festival with\r\nthe Offtown Committee", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "RoleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 4, 21, 27, 27, 214, DateTimeKind.Local).AddTicks(210), "Admin" },
                    { 2, new DateTime(2024, 11, 4, 21, 27, 27, 214, DateTimeKind.Local).AddTicks(227), "User" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDate", "Description", "Email", "Name", "Password", "Phone", "SurName", "UserName" },
                values: new object[] { 1, new DateTime(2024, 11, 4, 21, 27, 27, 214, DateTimeKind.Local).AddTicks(5695), null, "idilerdogan@sabanciuniv.edu", "İdil", "qwe", "+90 539 371 69 85", "Erdoğan", "idilerdogan" });

            migrationBuilder.InsertData(
                table: "MainMenus",
                columns: new[] { "Id", "ActionName", "AreaName", "ClassName", "ControllerName", "CreateDate", "CssName", "IconName", "MenuName", "OrderNo", "ParentMenuId", "RoleId" },
                values: new object[,]
                {
                    { 1, "Index", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 11, 4, 21, 27, 27, 213, DateTimeKind.Local).AddTicks(6783), "", null, "About", null, null, 1 },
                    { 2, "Index", null, "far fa-circle nav-icon", "Account", new DateTime(2024, 11, 4, 21, 27, 27, 213, DateTimeKind.Local).AddTicks(6788), "", null, "Education", null, null, 1 },
                    { 3, "Index", null, "far fa-circle nav-icon", "Account", new DateTime(2024, 11, 4, 21, 27, 27, 213, DateTimeKind.Local).AddTicks(6790), "", null, "Work Experinces", null, null, 1 },
                    { 4, "Index", null, "far fa-circle nav-icon", "Account", new DateTime(2024, 11, 4, 21, 27, 27, 213, DateTimeKind.Local).AddTicks(6792), "", null, "Projects", null, null, 1 },
                    { 5, "Index", null, "far fa-circle nav-icon", "Account", new DateTime(2024, 11, 4, 21, 27, 27, 213, DateTimeKind.Local).AddTicks(6793), "", null, "Skills", null, null, 1 },
                    { 6, "Index", null, "far fa-circle nav-icon", "Account", new DateTime(2024, 11, 4, 21, 27, 27, 213, DateTimeKind.Local).AddTicks(6795), "", null, "Achievement", null, null, 1 },
                    { 7, "Index", null, "far fa-circle nav-icon", "Account", new DateTime(2024, 11, 4, 21, 27, 27, 213, DateTimeKind.Local).AddTicks(6796), "", null, "Activities", null, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_Id",
                table: "Achievements",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_UserId",
                table: "Achievements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_Id",
                table: "Activities",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_UserId",
                table: "Activities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_Id",
                table: "Educations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_UserId",
                table: "Educations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiances_Id",
                table: "Experiances",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Experiances_UserId",
                table: "Experiances",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Id",
                table: "Languages",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_UserId",
                table: "Languages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MainMenus_Id",
                table: "MainMenus",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MainMenus_ParentMenuId",
                table: "MainMenus",
                column: "ParentMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MainMenus_RoleId",
                table: "MainMenus",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_Id",
                table: "Projects",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Id",
                table: "Roles",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_RoleName",
                table: "Roles",
                column: "RoleName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersId",
                table: "RoleUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_Id",
                table: "Skills",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_UserId",
                table: "Skills",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_Id",
                table: "SocialMedias",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_UserId",
                table: "SocialMedias",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Id",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiances");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "MainMenus");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
