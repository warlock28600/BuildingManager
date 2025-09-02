using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BuldingManager.Migrations
{
    /// <inheritdoc />
    public partial class BuildingComponentsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuildingEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "varchar(24)", maxLength: 24, nullable: false),
                    BuildingAddress = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    BuildingNumber = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitEntities",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BuildingId = table.Column<int>(type: "integer", nullable: false),
                    UnitNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    UnitTitle = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Floor = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitEntities", x => x.UnitId);
                    table.ForeignKey(
                        name: "FK_UnitEntities_BuildingEntities_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "BuildingEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitOwners",
                columns: table => new
                {
                    UnitOwnerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UnitId = table.Column<int>(type: "integer", nullable: false),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    OwnerShipPercent = table.Column<double>(type: "double precision", nullable: true),
                    HouseholdCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOwners", x => x.UnitOwnerId);
                    table.ForeignKey(
                        name: "FK_UnitOwners_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitOwners_UnitEntities_UnitId",
                        column: x => x.UnitId,
                        principalTable: "UnitEntities",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnitEntities_BuildingId",
                table: "UnitEntities",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitOwners_PersonId",
                table: "UnitOwners",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitOwners_UnitId",
                table: "UnitOwners",
                column: "UnitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitOwners");

            migrationBuilder.DropTable(
                name: "UnitEntities");

            migrationBuilder.DropTable(
                name: "BuildingEntities");
        }
    }
}
