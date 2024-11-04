using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MySite.Entities.Migrations
{
    /// <inheritdoc />
    public partial class infoadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Activities",
                newName: "DateEnding");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ComputerSkills",
                table: "Skills",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Languages",
                table: "Languages",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ExPlace",
                table: "Experiances",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateBegining",
                table: "Activities",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcDate", "CreateDate", "Description" },
                values: new object[] { new DateOnly(2013, 2, 1), new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(7872), "Basketball Distict Cup First Place (Basketbol İlçe Kaymakamlik Kupası) with Karşıyaka Anatolian High school Basketball Team" });

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AcDate", "CreateDate", "Description" },
                values: new object[] { new DateOnly(2015, 2, 1), new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(7868), "2014 - 2015 Basketball Young Girls Province Cup Third Place (2014 - 2015 Basketbol Genç Kızlar İl (İzmir) Kupası) with Karşıyaka Anatolian High school Basketball Team" });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "AcDate", "CreateDate", "Description", "UserId" },
                values: new object[,]
                {
                    { 3, new DateOnly(2015, 1, 17), new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(7864), "Turkish Championship Bilecik Youth Group First Place (Türkiye Şampiyonası Bilecik Basketbol Gençler Grup Birinci) with Karşıyaka Anatolian High School Basketball Team", null },
                    { 4, new DateOnly(2016, 9, 1), new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(7861), "Decleration of high honor in dean’s honor list for maintaining a high GPA", null },
                    { 5, new DateOnly(2017, 2, 1), new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(7857), "Decleration of honor in dean’s honor list for maintaining a high GPA", null },
                    { 6, new DateOnly(2016, 1, 1), new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(7853), "Sabanci University Extracurricular Activities Award Awarded for theatre tours around the country and abroad / Organizing the Offtown Festival with\r\nthe Offtown Committee", null },
                    { 7, new DateOnly(2020, 2, 1), new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(7826), "Decleration of honor in dean’s honor list for maintaining a high GPA", null }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "CreateDate", "DateBegining", "DateEnding", "Description", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(9462), new DateOnly(2015, 9, 1), new DateOnly(2016, 5, 1), "Member", "Sabanci University \"SURK\" Robotics Club", null },
                    { 2, new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(9458), new DateOnly(2017, 9, 1), new DateOnly(2018, 9, 1), "Organizing a nation-wide theatre festival", "\"Üniversitelerarası Tiyatro Festivali\"", null },
                    { 3, new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(9454), new DateOnly(2015, 9, 1), new DateOnly(2018, 9, 1), "Member, media coordinator and media, concert, sponsorship contractor", "Sabanci University Offtown Committee", null },
                    { 4, new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(9450), new DateOnly(2017, 9, 1), new DateOnly(2018, 9, 1), "Co- President", "Sabanci University Drama Club", null },
                    { 5, new DateTime(2024, 11, 4, 23, 47, 43, 6, DateTimeKind.Local).AddTicks(9434), new DateOnly(2015, 9, 1), new DateOnly(2021, 9, 1), "Member, director and actress", "Sabanci University Drama Club", null }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CreateDate", "Degree", "Description", "ScBeginning", "ScEndning", "ScName", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(1132), "89.90", "", new DateOnly(2010, 9, 1), new DateOnly(2015, 6, 1), "Karşıyaka Anatolian High School", null },
                    { 2, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(1115), "2,91", "BSC Mechatronics Engineering", new DateOnly(2015, 9, 1), new DateOnly(2021, 2, 4), "Sabancı University", null }
                });

            migrationBuilder.InsertData(
                table: "Experiances",
                columns: new[] { "Id", "CreateDate", "ExBeginning", "ExDescription", "ExEnding", "ExPlace", "ExTitle", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(2700), new DateOnly(2011, 6, 1), "Kept record of the balance sheet by using Excel efficiently Provided report of the profit and loss account statement", new DateOnly(2011, 8, 31), "Ibrahim Ozturk Independent Accountant And Tax Professional", "Asistant", null },
                    { 2, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(2696), new DateOnly(2015, 6, 1), "Attended meetings with the manager of the center Provided correlation in mailing system", new DateOnly(2016, 8, 31), "Efesus Outlet Center", "Part-Time Assistant in Administration", null },
                    { 3, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(2692), new DateOnly(2018, 7, 1), "Planned drama class curriculum Conducted drama and acting class for in the scope of Highschool Summer School", new DateOnly(2018, 8, 31), "Sabanci University", "Creator Drama & Acting Instructor", null },
                    { 4, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(2688), new DateOnly(2017, 7, 1), "Planned drama class curriculum Conducted drama and acting class for in the scope of Highschool Summer School", new DateOnly(2017, 8, 31), "Sabanci University", "Creator Drama & Acting Instructor", null },
                    { 5, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(2684), new DateOnly(2018, 6, 1), "Provided introductory campus tour for visitors. Gave additional information though phone calls and the information stand", new DateOnly(2019, 3, 31), "Sabanci University", "Introduction Team Member", null },
                    { 6, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(2668), new DateOnly(2019, 7, 1), "Assembled and adapted PLC to old German Ring Twisted Machines", new DateOnly(2019, 8, 31), "Kordsa", "Internship", null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreateDate", "Languages", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(4183), "Turkish Mother Language", null },
                    { 2, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(4197), "English Upper Intermediate", null },
                    { 3, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(4201), "Germany Elemantary", null }
                });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreateDate", "Date", "Description", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7457), new DateOnly(2015, 12, 30), "Voluntarily contributed to the social improvements of elementary school students in Istanbul", "Civic Involvement Project", null },
                    { 2, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7453), new DateOnly(2016, 12, 30), "Provided market analysis by conducting polls for several products By analyzing polls defined the relationship between consumption choice and Evolutionary Roots", "Researching Evolutionary Roots of Consumption", null },
                    { 3, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7449), new DateOnly(2018, 12, 30), "Provided comprehensive 3D construction of a bicycle in Solidworks including dynamic parts", "Implementing Bicycle in to Solidworks", null },
                    { 4, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7444), new DateOnly(2019, 12, 30), "Designing a system containing, wiring and coding given as a class project using Siemens Simatic, BECKHOFF Twincat and PLC", "Production Line Design with PLC", null },
                    { 5, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7433), new DateOnly(2020, 6, 1), "Simulated desired design using MATLAB Simulink, researched bio-mechatronic market extensively, designed a system using Solidworks", "Designing a Portable Arm Injection System", null },
                    { 6, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7425), new DateOnly(2020, 6, 1), "Simulated and analyzed energy harvesting of piezoelectric sensor using MATLAB Simulink", "Piezoelectric Energy Harvesters", null },
                    { 7, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7420), new DateOnly(2021, 2, 4), "Designed and simulated a wheeled robot system of 2 DOF using MATLAB Simulink & Solidworks that moves and recognizes the obstacle", "Bilateral Steering for a Mobile Robot", null },
                    { 8, new DateTime(2024, 11, 4, 23, 47, 43, 7, DateTimeKind.Local).AddTicks(7404), new DateOnly(2021, 9, 1), "Designed a lower-limb exoskeleton and improved the prototypes for the walk and rehabilitation of the paraplegic people. Joined the Biotechnology Innovation Competition with this project in Teknofest 2021", "Lower-Limb Exoskeleton with EEG/Team EXONIX", null }
                });

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

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ComputerSkills", "CreateDate", "UserId" },
                values: new object[,]
                {
                    { 1, "Microsoft Office Tools: Word, Excel, PowerPoint", new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(763), null },
                    { 2, "PLC", new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(776), null },
                    { 3, "Arduino", new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(779), null },
                    { 4, "MATLAB", new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(782), null },
                    { 5, "Solidworks", new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(785), null },
                    { 6, "COMSOL", new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(789), null },
                    { 7, "Xilinx", new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(792), null },
                    { 8, "Solidworks", new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(800), null },
                    { 9, "Microsoft Visual Studio, Microsoft Visual Codes, C#", new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(803), null },
                    { 10, "SQL, PostgreSQL, SQLite", new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(807), null },
                    { 11, "\r\nObject-Oriented Programming (OOP)", new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(809), null },
                    { 12, "\r\nEntity Framework (EF) Core", new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(812), null },
                    { 13, "\r\nHTML, CSS", new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(815), null }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "CreateDate", "Icon", "Medialink", "Name", "UserId" },
                values: new object[] { 1, new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(2183), null, "\r\nhttps://www.linkedin.com/in/idil-erdoğan-725458159/", "LinkedIn", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description" },
                values: new object[] { new DateTime(2024, 11, 4, 23, 47, 43, 8, DateTimeKind.Local).AddTicks(5554), "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "DateBegining",
                table: "Activities");

            migrationBuilder.RenameColumn(
                name: "DateEnding",
                table: "Activities",
                newName: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ComputerSkills",
                table: "Skills",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Languages",
                table: "Languages",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ExPlace",
                table: "Experiances",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcDate", "CreateDate", "Description" },
                values: new object[] { new DateOnly(2020, 2, 1), new DateTime(2024, 11, 4, 21, 27, 27, 212, DateTimeKind.Local).AddTicks(8873), "Decleration of honor in dean’s honor list for maintaining a high GPA" });

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AcDate", "CreateDate", "Description" },
                values: new object[] { new DateOnly(2016, 1, 1), new DateTime(2024, 11, 4, 21, 27, 27, 212, DateTimeKind.Local).AddTicks(8905), "Sabanci University Extracurricular Activities Award Awarded for theatre tours around the country and abroad / Organizing the Offtown Festival with\r\nthe Offtown Committee" });

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 21, 27, 27, 213, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 21, 27, 27, 213, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 21, 27, 27, 213, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 21, 27, 27, 213, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 21, 27, 27, 213, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 21, 27, 27, 213, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "MainMenus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 21, 27, 27, 213, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 21, 27, 27, 214, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 4, 21, 27, 27, 214, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description" },
                values: new object[] { new DateTime(2024, 11, 4, 21, 27, 27, 214, DateTimeKind.Local).AddTicks(5695), null });
        }
    }
}
