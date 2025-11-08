using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuldingManager.Migrations
{
    /// <inheritdoc />
    public partial class unitEntityUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExtraParkingCount",
                table: "UnitEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitArea",
                table: "UnitEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraParkingCount",
                table: "UnitEntities");

            migrationBuilder.DropColumn(
                name: "UnitArea",
                table: "UnitEntities");
        }
    }
}
