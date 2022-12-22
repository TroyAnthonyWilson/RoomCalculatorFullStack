using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomCalculatorAPI.Migrations
{
    /// <inheritdoc />
    public partial class two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "RoomHistory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Perimeter",
                table: "RoomHistory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SurfaceArea",
                table: "RoomHistory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Volume",
                table: "RoomHistory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "RoomHistory");

            migrationBuilder.DropColumn(
                name: "Perimeter",
                table: "RoomHistory");

            migrationBuilder.DropColumn(
                name: "SurfaceArea",
                table: "RoomHistory");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "RoomHistory");
        }
    }
}
