using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBanDienThoai.Migrations
{
    /// <inheritdoc />
    public partial class momo1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "MomoInfos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_MomoInfos_OrderId",
                table: "MomoInfos",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_MomoInfos_Orders_OrderId",
                table: "MomoInfos",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MomoInfos_Orders_OrderId",
                table: "MomoInfos");

            migrationBuilder.DropIndex(
                name: "IX_MomoInfos_OrderId",
                table: "MomoInfos");

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "MomoInfos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
