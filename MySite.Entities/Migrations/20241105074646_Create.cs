using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MySite.Entities.Migrations
{
    /// <inheritdoc />
    public partial class Create : Migration
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
                    DateBegining = table.Column<DateOnly>(type: "date", nullable: false),
                    DateEnding = table.Column<DateOnly>(type: "date", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Languages = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    ComputerSkills = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    { 1, new DateOnly(2013, 2, 1), new DateTime(2024, 11, 5, 10, 46, 46, 329, DateTimeKind.Local).AddTicks(5446), "Basketball Distict Cup First Place (Basketbol İlçe Kaymakamlik Kupası) with Karşıyaka Anatolian High school Basketball Team", null },
                    { 2, new DateOnly(2015, 2, 1), new DateTime(2024, 11, 5, 10, 46, 46, 329, DateTimeKind.Local).AddTicks(5442), "2014 - 2015 Basketball Young Girls Province Cup Third Place (2014 - 2015 Basketbol Genç Kızlar İl (İzmir) Kupası) with Karşıyaka Anatolian High school Basketball Team", null },
                    { 3, new DateOnly(2015, 1, 17), new DateTime(2024, 11, 5, 10, 46, 46, 329, DateTimeKind.Local).AddTicks(5435), "Turkish Championship Bilecik Youth Group First Place (Türkiye Şampiyonası Bilecik Basketbol Gençler Grup Birinci) with Karşıyaka Anatolian High School Basketball Team", null },
                    { 4, new DateOnly(2016, 9, 1), new DateTime(2024, 11, 5, 10, 46, 46, 329, DateTimeKind.Local).AddTicks(5431), "Decleration of high honor in dean’s honor list for maintaining a high GPA", null },
                    { 5, new DateOnly(2017, 2, 1), new DateTime(2024, 11, 5, 10, 46, 46, 329, DateTimeKind.Local).AddTicks(5427), "Decleration of honor in dean’s honor list for maintaining a high GPA", null },
                    { 6, new DateOnly(2016, 1, 1), new DateTime(2024, 11, 5, 10, 46, 46, 329, DateTimeKind.Local).AddTicks(5422), "Sabanci University Extracurricular Activities Award Awarded for theatre tours around the country and abroad / Organizing the Offtown Festival with\r\nthe Offtown Committee", null },
                    { 7, new DateOnly(2020, 2, 1), new DateTime(2024, 11, 5, 10, 46, 46, 329, DateTimeKind.Local).AddTicks(5378), "Decleration of honor in dean’s honor list for maintaining a high GPA", null }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "CreateDate", "DateBegining", "DateEnding", "Description", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 5, 10, 46, 46, 329, DateTimeKind.Local).AddTicks(8283), new DateOnly(2015, 9, 1), new DateOnly(2016, 5, 1), "Member", "Sabanci University \"SURK\" Robotics Club", null },
                    { 2, new DateTime(2024, 11, 5, 10, 46, 46, 329, DateTimeKind.Local).AddTicks(8278), new DateOnly(2017, 9, 1), new DateOnly(2018, 9, 1), "Organizing a nation-wide theatre festival", "\"Üniversitelerarası Tiyatro Festivali\"", null },
                    { 3, new DateTime(2024, 11, 5, 10, 46, 46, 329, DateTimeKind.Local).AddTicks(8274), new DateOnly(2015, 9, 1), new DateOnly(2018, 9, 1), "Member, media coordinator and media, concert, sponsorship contractor", "Sabanci University Offtown Committee", null },
                    { 4, new DateTime(2024, 11, 5, 10, 46, 46, 329, DateTimeKind.Local).AddTicks(8269), new DateOnly(2017, 9, 1), new DateOnly(2018, 9, 1), "Co- President", "Sabanci University Drama Club", null },
                    { 5, new DateTime(2024, 11, 5, 10, 46, 46, 329, DateTimeKind.Local).AddTicks(8246), new DateOnly(2015, 9, 1), new DateOnly(2021, 9, 1), "Member, director and actress", "Sabanci University Drama Club", null }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CreateDate", "Degree", "Description", "ScBeginning", "ScEndning", "ScName", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(928), "89.90", "", new DateOnly(2010, 9, 1), new DateOnly(2015, 6, 1), "Karşıyaka Anatolian High School", null },
                    { 2, new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(903), "2,91", "BSC Mechatronics Engineering", new DateOnly(2015, 9, 1), new DateOnly(2021, 2, 4), "Sabancı University", null }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "CreateDate", "ExBeginning", "ExDescription", "ExEnding", "ExPlace", "ExTitle", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(3710), new DateOnly(2011, 6, 1), "Kept record of the balance sheet by using Excel efficiently Provided report of the profit and loss account statement", new DateOnly(2011, 8, 31), "Ibrahim Ozturk Independent Accountant And Tax Professional", "Asistant", null },
                    { 2, new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(3703), new DateOnly(2015, 6, 1), "Attended meetings with the manager of the center Provided correlation in mailing system", new DateOnly(2016, 8, 31), "Efesus Outlet Center", "Part-Time Assistant in Administration", null },
                    { 3, new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(3699), new DateOnly(2018, 7, 1), "Planned drama class curriculum Conducted drama and acting class for in the scope of Highschool Summer School", new DateOnly(2018, 8, 31), "Sabanci University", "Creator Drama & Acting Instructor", null },
                    { 4, new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(3694), new DateOnly(2017, 7, 1), "Planned drama class curriculum Conducted drama and acting class for in the scope of Highschool Summer School", new DateOnly(2017, 8, 31), "Sabanci University", "Creator Drama & Acting Instructor", null },
                    { 5, new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(3689), new DateOnly(2018, 6, 1), "Provided introductory campus tour for visitors. Gave additional information though phone calls and the information stand", new DateOnly(2019, 3, 31), "Sabanci University", "Introduction Team Member", null },
                    { 6, new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(3663), new DateOnly(2019, 7, 1), "Assembled and adapted PLC to old German Ring Twisted Machines", new DateOnly(2019, 8, 31), "Kordsa", "Internship", null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreateDate", "Languages", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(6001), "Turkish Mother Language", null },
                    { 2, new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(6021), "English Upper Intermediate", null },
                    { 3, new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(6024), "Germany Elemantary", null }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreateDate", "Date", "Description", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(2041), new DateOnly(2015, 12, 30), "Voluntarily contributed to the social improvements of elementary school students in Istanbul", "Civic Involvement Project", null },
                    { 2, new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(2037), new DateOnly(2016, 12, 30), "Provided market analysis by conducting polls for several products By analyzing polls defined the relationship between consumption choice and Evolutionary Roots", "Researching Evolutionary Roots of Consumption", null },
                    { 3, new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(2032), new DateOnly(2018, 12, 30), "Provided comprehensive 3D construction of a bicycle in Solidworks including dynamic parts", "Implementing Bicycle in to Solidworks", null },
                    { 4, new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(2024), new DateOnly(2019, 12, 30), "Designing a system containing, wiring and coding given as a class project using Siemens Simatic, BECKHOFF Twincat and PLC", "Production Line Design with PLC", null },
                    { 5, new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(2019), new DateOnly(2020, 6, 1), "Simulated desired design using MATLAB Simulink, researched bio-mechatronic market extensively, designed a system using Solidworks", "Designing a Portable Arm Injection System", null },
                    { 6, new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(2015), new DateOnly(2020, 6, 1), "Simulated and analyzed energy harvesting of piezoelectric sensor using MATLAB Simulink", "Piezoelectric Energy Harvesters", null },
                    { 7, new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(2010), new DateOnly(2021, 2, 4), "Designed and simulated a wheeled robot system of 2 DOF using MATLAB Simulink & Solidworks that moves and recognizes the obstacle", "Bilateral Steering for a Mobile Robot", null },
                    { 8, new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(1986), new DateOnly(2021, 9, 1), "Designed a lower-limb exoskeleton and improved the prototypes for the walk and rehabilitation of the paraplegic people. Joined the Biotechnology Innovation Competition with this project in Teknofest 2021", "Lower-Limb Exoskeleton with EEG/Team EXONIX", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "RoleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(4995), "Admin" },
                    { 2, new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(5019), "User" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ComputerSkills", "CreateDate", "UserId" },
                values: new object[,]
                {
                    { 1, "Microsoft Office Tools: Word, Excel, PowerPoint", new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(7452), null },
                    { 2, "PLC", new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(7485), null },
                    { 3, "Arduino", new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(7489), null },
                    { 4, "MATLAB", new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(7492), null },
                    { 5, "Solidworks", new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(7496), null },
                    { 6, "COMSOL", new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(7501), null },
                    { 7, "Xilinx", new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(7505), null },
                    { 8, "Solidworks", new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(7508), null },
                    { 9, "Microsoft Visual Studio, Microsoft Visual Codes, C#", new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(7512), null },
                    { 10, "SQL, PostgreSQL, SQLite", new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(7517), null },
                    { 11, "\r\nObject-Oriented Programming (OOP)", new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(7521), null },
                    { 12, "\r\nEntity Framework (EF) Core", new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(7524), null },
                    { 13, "\r\nHTML, CSS", new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(7528), null }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "CreateDate", "Icon", "Medialink", "Name", "UserId" },
                values: new object[] { 1, new DateTime(2024, 11, 5, 10, 46, 46, 331, DateTimeKind.Local).AddTicks(9831), null, "\r\nhttps://www.linkedin.com/in/idil-erdoğan-725458159/", "LinkedIn", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDate", "Description", "Email", "Name", "Password", "Phone", "SurName", "UserName" },
                values: new object[] { 1, new DateTime(2024, 11, 5, 10, 46, 46, 332, DateTimeKind.Local).AddTicks(4185), "", "idilerdogan@sabanciuniv.edu", "İdil", "qwe", "+90 539 371 69 85", "Erdoğan", "idilerdogan" });

            migrationBuilder.InsertData(
                table: "MainMenus",
                columns: new[] { "Id", "ActionName", "AreaName", "ClassName", "ControllerName", "CreateDate", "CssName", "IconName", "MenuName", "OrderNo", "ParentMenuId", "RoleId" },
                values: new object[,]
                {
                    { 1, "About", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(9121), "#about", null, "About", null, null, 1 },
                    { 2, "Education", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(9127), "#education", null, "Education", null, null, 1 },
                    { 3, "Experience", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(9129), "#experience", null, "Experience", null, null, 1 },
                    { 4, "Project", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(9131), "#project", null, "Projects", null, null, 1 },
                    { 5, "Skill", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(9145), "#skill", null, "Skills", null, null, 1 },
                    { 6, "Achievement", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(9147), "#achievement", null, "Achievements", null, null, 1 },
                    { 7, "Activitie", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(9149), "", null, "Activities", null, null, 1 },
                    { 8, "Language", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 11, 5, 10, 46, 46, 330, DateTimeKind.Local).AddTicks(9151), "#language", null, "Languages", null, null, 1 }
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
                name: "IX_Experiences_Id",
                table: "Experiences",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_UserId",
                table: "Experiences",
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
                name: "Experiences");

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
