using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaNET_SimónArias.Migrations
{
    /// <inheritdoc />
    public partial class RoomTypesSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "room_types",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "room_types",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "room_types");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "room_types");
        }
    }
}
