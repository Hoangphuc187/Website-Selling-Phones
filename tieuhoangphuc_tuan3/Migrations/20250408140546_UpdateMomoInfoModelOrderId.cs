using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBanDienThoai.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMomoInfoModelOrderId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MomoOrderId",
                table: "MomoInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MomoOrderId",
                table: "MomoInfos");
        }
    }
}
