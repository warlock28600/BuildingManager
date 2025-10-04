using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuldingManager.Migrations
{
    /// <inheritdoc />
    public partial class unitEntoryUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExtraParkingCount",
                table: "UnitOwners",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "unitArea",
                table: "UnitOwners",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraParkingCount",
                table: "UnitOwners");

            migrationBuilder.DropColumn(
                name: "unitArea",
                table: "UnitOwners");
        }
    }
}
