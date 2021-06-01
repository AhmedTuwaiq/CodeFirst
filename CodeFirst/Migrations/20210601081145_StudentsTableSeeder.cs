using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class StudentsTableSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Email", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { 1, "philip@privacy.net", "Barbara", "Hall" },
                    { 2, "mark@example.com", "Beryl", "Johnson" },
                    { 3, "harold@yahoo.com", "Edward", "Garcia" },
                    { 4, "wendy26@gmail.com", "Robert", "Peters" },
                    { 5, "simon@privacy.net", "Dorothy", "Thatcher" },
                    { 6, "wendy@example.com", "Donna", "Peters" },
                    { 7, "sharon@example.com", "Michelle", "Anderson" },
                    { 8, "edwin65@privacy.net", "Donald", "Kirby" },
                    { 9, "george@msn.com", "Betty", "Hall" },
                    { 10, "maria@privacy.net", "Judith", "Davidson" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 10);
        }
    }
}
