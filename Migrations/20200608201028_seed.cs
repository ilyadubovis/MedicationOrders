using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicationOrders.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    Frequency = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    DaysSupply = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    StreetAddress = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    ZipCode = table.Column<string>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders1_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders2_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Date" },
                values: new object[] { 1, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Date" },
                values: new object[] { 2, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "Id", "DaysSupply", "Frequency", "Name", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { 1, 30, "Every Day", "Collagen Dressing", 1, 30 },
                    { 2, 30, "Every Day", "Collagen Powder", 1, 30 },
                    { 3, 30, "Every Day", "WaterProof Tape", 1, 1 },
                    { 10, 30, "Every Day", "Collagen Dressing", 2, 30 },
                    { 11, 30, "Once A Week", "Botox", 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Orders1",
                columns: new[] { "Id", "City", "FirstName", "LastName", "OrderId", "State", "StreetAddress", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Tampa", "Kim", "Wise", 1, "FL", "1234 8th St.", "33606" },
                    { 2, "Tampa", "Elvin", "Sharvill", 2, "FL", "567 Gulf Ave.", "33609" }
                });

            migrationBuilder.InsertData(
                table: "Orders2",
                columns: new[] { "Id", "Name", "OrderId" },
                values: new object[,]
                {
                    { 1, "Dr. Collins", 1 },
                    { 2, "Dr. Collins", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders1_OrderId",
                table: "Orders1",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders2_OrderId",
                table: "Orders2",
                column: "OrderId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Orders1");

            migrationBuilder.DropTable(
                name: "Orders2");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
