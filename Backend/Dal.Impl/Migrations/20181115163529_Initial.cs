using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AstralVacancy.Dal.Impl.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Login = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false),
                    FullName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VacancySet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    SyncId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Salary_From = table.Column<double>(nullable: true),
                    Salary_To = table.Column<double>(nullable: true),
                    Salary_Gross = table.Column<bool>(nullable: true),
                    Salary_Currency = table.Column<string>(nullable: true),
                    EmployerName = table.Column<string>(nullable: true),
                    Published = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancySet", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserSet",
                columns: new[] { "Id", "FullName", "IsAdmin", "Login", "PasswordHash" },
                values: new object[] { 1, "Админ Админыч Админов", true, "admin", "AQAAAAEAACcQAAAAEAHzy0ies5x3G6daN4jbaKXfQ7+gmXZeEegCg6vJkysfGBZziXF6O4BBxgqiAeByqw==" });

            migrationBuilder.InsertData(
                table: "UserSet",
                columns: new[] { "Id", "FullName", "IsAdmin", "Login", "PasswordHash" },
                values: new object[] { 2, "Юзер Юзерович Юзеров", false, "user", "AQAAAAEAACcQAAAAEGSxyWsqQyUCBluehUw5jOfZuk73R4RYfKDmMumxwm0lp2l9faeQu2rr2mVBrW7vNw==" });

            migrationBuilder.CreateIndex(
                name: "IX_UserSet_Login",
                table: "UserSet",
                column: "Login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VacancySet_SyncId",
                table: "VacancySet",
                column: "SyncId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSet");

            migrationBuilder.DropTable(
                name: "VacancySet");
        }
    }
}
