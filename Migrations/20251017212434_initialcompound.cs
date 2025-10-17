using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuldingManager.Migrations
{
    /// <inheritdoc />
    public partial class initialcompound : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Residents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Residents",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Residents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Residents",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompoundId",
                table: "BuildingEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Compounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compounds", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildingEntities_CompoundId",
                table: "BuildingEntities",
                column: "CompoundId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingEntities_Compounds_CompoundId",
                table: "BuildingEntities",
                column: "CompoundId",
                principalTable: "Compounds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingEntities_Compounds_CompoundId",
                table: "BuildingEntities");

            migrationBuilder.DropTable(
                name: "Compounds");

            migrationBuilder.DropIndex(
                name: "IX_BuildingEntities_CompoundId",
                table: "BuildingEntities");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Residents");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Residents");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Residents");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Residents");

            migrationBuilder.DropColumn(
                name: "CompoundId",
                table: "BuildingEntities");
        }
    }
}
