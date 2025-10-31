using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuldingManager.Migrations
{
    /// <inheritdoc />
    public partial class expenceDataBaseChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Persons_PersonId",
                table: "Residents");

            migrationBuilder.DropForeignKey(
                name: "FK_Residents_UnitEntities_UnitId",
                table: "Residents");

            migrationBuilder.DropIndex(
                name: "IX_Residents_PersonId",
                table: "Residents");

            migrationBuilder.AlterColumn<string>(
                name: "ResidentType",
                table: "Residents",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MoveInDate",
                table: "Residents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonsId",
                table: "Residents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnitEntityUnitId",
                table: "Residents",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "FinancialPeriods",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "FinancialPeriods",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "FinancialPeriods",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Compounds",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    FinancialPeriodId = table.Column<int>(type: "int", nullable: false),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    ExpanseType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "AttributeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Expenses_FinancialPeriods_FinancialPeriodId",
                        column: x => x.FinancialPeriodId,
                        principalTable: "FinancialPeriods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Residents_PersonId_UnitId",
                table: "Residents",
                columns: new[] { "PersonId", "UnitId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Residents_PersonsId",
                table: "Residents",
                column: "PersonsId");

            migrationBuilder.CreateIndex(
                name: "IX_Residents_UnitEntityUnitId",
                table: "Residents",
                column: "UnitEntityUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_AttributeId",
                table: "Expenses",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_FinancialPeriodId",
                table: "Expenses",
                column: "FinancialPeriodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Persons_PersonId",
                table: "Residents",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Persons_PersonsId",
                table: "Residents",
                column: "PersonsId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_UnitEntities_UnitEntityUnitId",
                table: "Residents",
                column: "UnitEntityUnitId",
                principalTable: "UnitEntities",
                principalColumn: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_UnitEntities_UnitId",
                table: "Residents",
                column: "UnitId",
                principalTable: "UnitEntities",
                principalColumn: "UnitId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Persons_PersonId",
                table: "Residents");

            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Persons_PersonsId",
                table: "Residents");

            migrationBuilder.DropForeignKey(
                name: "FK_Residents_UnitEntities_UnitEntityUnitId",
                table: "Residents");

            migrationBuilder.DropForeignKey(
                name: "FK_Residents_UnitEntities_UnitId",
                table: "Residents");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Residents_PersonId_UnitId",
                table: "Residents");

            migrationBuilder.DropIndex(
                name: "IX_Residents_PersonsId",
                table: "Residents");

            migrationBuilder.DropIndex(
                name: "IX_Residents_UnitEntityUnitId",
                table: "Residents");

            migrationBuilder.DropColumn(
                name: "PersonsId",
                table: "Residents");

            migrationBuilder.DropColumn(
                name: "UnitEntityUnitId",
                table: "Residents");

            migrationBuilder.AlterColumn<string>(
                name: "ResidentType",
                table: "Residents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MoveInDate",
                table: "Residents",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "FinancialPeriods",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "FinancialPeriods",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "FinancialPeriods",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Compounds",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.CreateIndex(
                name: "IX_Residents_PersonId",
                table: "Residents",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Persons_PersonId",
                table: "Residents",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_UnitEntities_UnitId",
                table: "Residents",
                column: "UnitId",
                principalTable: "UnitEntities",
                principalColumn: "UnitId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
