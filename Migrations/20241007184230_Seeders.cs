using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaNET_SimónArias.Migrations
{
    /// <inheritdoc />
    public partial class Seeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Floor",
                table: "rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "room_types",
                columns: new[] { "id", "Capacity", "description", "name", "Price" },
                values: new object[,]
                {
                    { 1, 0, "Una acogedora habitación básica con una cama individual, ideal para viajeros solos.", "Habitación Simple", 0 },
                    { 2, 0, "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos.", "Habitación Doble", 0 },
                    { 3, 0, "Espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad.", "Suite", 0 },
                    { 4, 0, "Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda.", "Habitación Familiar", 0 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "id", "availability", "Floor", "max_ocupancy_persons", "Number", "price_per_night", "room_number", "room_type_id" },
                values: new object[,]
                {
                    { 1, true, 0, 1, 0, 50.0, "101", 1 },
                    { 2, true, 0, 2, 0, 80.0, "102", 2 },
                    { 3, true, 0, 2, 0, 150.0, "103", 3 },
                    { 4, true, 0, 4, 0, 200.0, "104", 4 },
                    { 5, true, 0, 1, 0, 50.0, "105", 1 },
                    { 6, true, 0, 2, 0, 80.0, "106", 2 },
                    { 7, true, 0, 2, 0, 150.0, "107", 3 },
                    { 8, true, 0, 4, 0, 200.0, "108", 4 },
                    { 9, true, 0, 1, 0, 50.0, "109", 1 },
                    { 10, true, 0, 2, 0, 80.0, "110", 2 },
                    { 11, true, 0, 1, 0, 50.0, "201", 1 },
                    { 12, true, 0, 2, 0, 80.0, "202", 2 },
                    { 13, true, 0, 2, 0, 150.0, "203", 3 },
                    { 14, true, 0, 4, 0, 200.0, "204", 4 },
                    { 15, true, 0, 1, 0, 50.0, "205", 1 },
                    { 16, true, 0, 2, 0, 80.0, "206", 2 },
                    { 17, true, 0, 2, 0, 150.0, "207", 3 },
                    { 18, true, 0, 4, 0, 200.0, "208", 4 },
                    { 19, true, 0, 1, 0, 50.0, "209", 1 },
                    { 20, true, 0, 2, 0, 80.0, "210", 2 },
                    { 21, true, 0, 1, 0, 50.0, "301", 1 },
                    { 22, true, 0, 2, 0, 80.0, "302", 2 },
                    { 23, true, 0, 2, 0, 150.0, "303", 3 },
                    { 24, true, 0, 4, 0, 200.0, "304", 4 },
                    { 25, true, 0, 1, 0, 50.0, "305", 1 },
                    { 26, true, 0, 2, 0, 80.0, "306", 2 },
                    { 27, true, 0, 2, 0, 150.0, "307", 3 },
                    { 28, true, 0, 4, 0, 200.0, "308", 4 },
                    { 29, true, 0, 1, 0, 50.0, "309", 1 },
                    { 30, true, 0, 2, 0, 80.0, "310", 2 },
                    { 31, true, 0, 1, 0, 50.0, "401", 1 },
                    { 32, true, 0, 2, 0, 80.0, "402", 2 },
                    { 33, true, 0, 2, 0, 150.0, "403", 3 },
                    { 34, true, 0, 4, 0, 200.0, "404", 4 },
                    { 35, true, 0, 1, 0, 50.0, "405", 1 },
                    { 36, true, 0, 2, 0, 80.0, "406", 2 },
                    { 37, true, 0, 2, 0, 150.0, "407", 3 },
                    { 38, true, 0, 4, 0, 200.0, "408", 4 },
                    { 39, true, 0, 1, 0, 50.0, "409", 1 },
                    { 40, true, 0, 2, 0, 80.0, "410", 2 },
                    { 41, true, 0, 1, 0, 50.0, "501", 1 },
                    { 42, true, 0, 2, 0, 80.0, "502", 2 },
                    { 43, true, 0, 2, 0, 150.0, "503", 3 },
                    { 44, true, 0, 4, 0, 200.0, "504", 4 },
                    { 45, true, 0, 1, 0, 50.0, "505", 1 },
                    { 46, true, 0, 2, 0, 80.0, "506", 2 },
                    { 47, true, 0, 2, 0, 150.0, "507", 3 },
                    { 48, true, 0, 4, 0, 200.0, "508", 4 },
                    { 49, true, 0, 1, 0, 50.0, "509", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_guests_identification_number",
                table: "guests",
                column: "identification_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_identification_number",
                table: "employees",
                column: "identification_number",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_guests_identification_number",
                table: "guests");

            migrationBuilder.DropIndex(
                name: "IX_employees_identification_number",
                table: "employees");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Floor",
                table: "rooms");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "rooms");
        }
    }
}
