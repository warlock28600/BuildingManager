using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuldingManager.Migrations
{
    /// <inheritdoc />
    public partial class attributeEntityUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Attributes_AttributeId",
                table: "Expenses");

            migrationBuilder.RenameColumn(
                name: "AttributeId",
                table: "Expenses",
                newName: "CostTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Expenses_AttributeId",
                table: "Expenses",
                newName: "IX_Expenses_CostTypeId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Attributes",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Attributes_CostTypeId",
                table: "Expenses",
                column: "CostTypeId",
                principalTable: "Attributes",
                principalColumn: "AttributeId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Attributes_CostTypeId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Attributes");

            migrationBuilder.RenameColumn(
                name: "CostTypeId",
                table: "Expenses",
                newName: "AttributeId");

            migrationBuilder.RenameIndex(
                name: "IX_Expenses_CostTypeId",
                table: "Expenses",
                newName: "IX_Expenses_AttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Attributes_AttributeId",
                table: "Expenses",
                column: "AttributeId",
                principalTable: "Attributes",
                principalColumn: "AttributeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
