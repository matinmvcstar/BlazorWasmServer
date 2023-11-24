using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWasmServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserAddresses_UserAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserPayments_UserPaymentId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderItems_OrderItemsId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingSessions_CartItems_CartItemId",
                table: "ShoppingSessions");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingSessions_CartItemId",
                table: "ShoppingSessions");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderItemsId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserPaymentId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CartItemId",
                table: "ShoppingSessions");

            migrationBuilder.DropColumn(
                name: "OrderItemsId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "UserAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserPaymentId",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartItemId",
                table: "ShoppingSessions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OrderItemsId",
                table: "OrderDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserAddressId",
                table: "AspNetUsers",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserPaymentId",
                table: "AspNetUsers",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingSessions_CartItemId",
                table: "ShoppingSessions",
                column: "CartItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderItemsId",
                table: "OrderDetails",
                column: "OrderItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserAddressId",
                table: "AspNetUsers",
                column: "UserAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserPaymentId",
                table: "AspNetUsers",
                column: "UserPaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserAddresses_UserAddressId",
                table: "AspNetUsers",
                column: "UserAddressId",
                principalTable: "UserAddresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserPayments_UserPaymentId",
                table: "AspNetUsers",
                column: "UserPaymentId",
                principalTable: "UserPayments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderItems_OrderItemsId",
                table: "OrderDetails",
                column: "OrderItemsId",
                principalTable: "OrderItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingSessions_CartItems_CartItemId",
                table: "ShoppingSessions",
                column: "CartItemId",
                principalTable: "CartItems",
                principalColumn: "Id");
        }
    }
}
