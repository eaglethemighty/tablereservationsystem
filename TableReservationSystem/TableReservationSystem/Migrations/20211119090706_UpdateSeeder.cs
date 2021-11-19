using Microsoft.EntityFrameworkCore.Migrations;

namespace TableReservationSystem.Migrations
{
    public partial class UpdateSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "Id", "HighChair", "Seats", "Shape", "Size", "Window" },
                values: new object[,]
                {
                    { 1, true, 2, 1, 0, false },
                    { 30, false, 1, 0, 0, false },
                    { 29, false, 1, 0, 0, false },
                    { 28, false, 1, 0, 0, false },
                    { 27, false, 1, 0, 0, false },
                    { 26, false, 1, 0, 0, false },
                    { 25, false, 1, 0, 0, false },
                    { 24, false, 1, 0, 0, false },
                    { 23, false, 1, 0, 0, false },
                    { 22, false, 1, 0, 0, false },
                    { 21, false, 1, 0, 0, false },
                    { 20, true, 12, 1, 2, true },
                    { 19, false, 2, 3, 0, false },
                    { 18, false, 2, 3, 0, false },
                    { 31, false, 1, 0, 0, false },
                    { 17, false, 2, 3, 0, false },
                    { 15, true, 2, 3, 0, false },
                    { 14, false, 2, 3, 0, false },
                    { 12, true, 4, 1, 1, false },
                    { 11, true, 4, 1, 1, false },
                    { 10, true, 4, 3, 1, false },
                    { 9, true, 4, 3, 1, false },
                    { 8, true, 4, 3, 1, false },
                    { 7, false, 4, 1, 1, false },
                    { 6, false, 4, 1, 1, false },
                    { 5, false, 4, 1, 1, false },
                    { 4, false, 4, 2, 1, true },
                    { 3, false, 5, 2, 1, true },
                    { 2, true, 4, 1, 1, true },
                    { 16, false, 2, 3, 0, false },
                    { 32, false, 1, 0, 0, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 32);
        }
    }
}
