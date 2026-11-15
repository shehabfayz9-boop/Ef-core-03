using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ef_core_03.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "Programming Courses", "Programming", null },
                    { 5, "Database Courses", "Database", null }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Bio", "Email", "FullName", "JoinDate" },
                values: new object[,]
                {
                    { 1, "C# Instructor", "ahmed@gmail.com", "Ahmed Mohamed", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Database Instructor", "sara@gmail.com", "Sara Ali", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, "omar@gmail.com", "Omar Hassan", new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 2, "Backend Development", "Backend", 1 },
                    { 3, "Frontend Development", "Frontend", 1 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "InstructorId", "IsPublished", "Level", "Price", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Learn C# fundamentals", 1, true, 0, 500m, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "C# Basics" },
                    { 3, 5, "Database Fundamentals", 2, true, 0, 700m, new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "SQL Server" },
                    { 4, 5, "Advanced Database Topics", 2, false, 2, 1500m, null, "Advanced SQL" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "ParentCategoryId" },
                values: new object[] { 4, "ASP.NET Courses", "ASP.NET", 2 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "InstructorId", "IsPublished", "Level", "Price", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 5, 3, "Frontend Basics", 3, true, 0, 400m, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "HTML and CSS" },
                    { 6, 3, "Advanced JavaScript", 3, false, 2, 900m, null, "JavaScript Advanced" },
                    { 2, 4, "Build Web Applications", 1, true, 1, 1200m, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET Core" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
