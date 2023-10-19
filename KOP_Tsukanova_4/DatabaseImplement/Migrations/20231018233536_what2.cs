using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseImplement.Migrations
{
    /// <inheritdoc />
    public partial class what2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CostStr",
                table: "Books",
                newName: "PriceString");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PriceString",
                table: "Books",
                newName: "CostStr");
        }
    }
}
