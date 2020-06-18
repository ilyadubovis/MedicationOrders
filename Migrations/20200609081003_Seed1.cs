using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicationOrders.Migrations
{
    public partial class Seed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders1",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders1",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders2",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders2",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Date" },
                values: new object[,]
                {
                    { 12345, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23986, new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76543, new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81276, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99088, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "Id", "DaysSupply", "Frequency", "Name", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { 1, 30, "Every Day", "Collagen Dressing", 12345, 30 },
                    { 41, 30, "Once A Day", "Essential Oils", 99088, 2 },
                    { 40, 30, "Every Day", "Collagen Mask", 99088, 1 },
                    { 31, 30, "Once A Day", "Essential Oils", 81276, 2 },
                    { 30, 30, "Every Day", "Collagen Mask", 81276, 1 },
                    { 20, 30, "Every Day", "Collagen Dressing", 76543, 30 },
                    { 10, 30, "Every Day", "Collagen Dressing", 23986, 30 },
                    { 21, 60, "Once A Day", "Essential Oils", 76543, 2 },
                    { 2, 30, "Every Day", "Collagen Powder", 12345, 30 },
                    { 3, 30, "Every Day", "WaterProof Tape", 12345, 1 },
                    { 11, 30, "Once A Week", "Botox", 23986, 4 }
                });

            migrationBuilder.InsertData(
                table: "Orders1",
                columns: new[] { "Id", "City", "FirstName", "LastName", "OrderId", "State", "StreetAddress", "ZipCode" },
                values: new object[,]
                {
                    { 2, "Tampa", "Elvin", "Sharvill", 23986, "FL", "567 Gulf Ave.", "33609" },
                    { 5, "Miami Beach", "Hans", "Hedman", 99088, "FL", "12 Collins Blvd.", "34567" },
                    { 3, "Chicago", "Roman", "Kutepov", 76543, "IL", "123 North Ave.", "60606" },
                    { 4, "Sanny Isles", "Ariana", "Barros", 81276, "FL", "9865 Collins Blvd.", "34566" },
                    { 1, "Tampa", "Kim", "Wise", 12345, "FL", "1234 8th St.", "33606" }
                });

            migrationBuilder.InsertData(
                table: "Orders2",
                columns: new[] { "Id", "Name", "OrderId" },
                values: new object[,]
                {
                    { 2, "Dr. Williams", 23986 },
                    { 3, "Dr. Schwarz", 76543 },
                    { 4, "Dr. Brown", 81276 },
                    { 1, "Dr. Collins", 12345 },
                    { 5, "Dr. Green", 99088 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Orders1",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders1",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders1",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders1",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders1",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders2",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders2",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders2",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders2",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders2",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12345);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23986);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 76543);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 81276);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 99088);

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
                    { 3, 30, "Every Day", "WaterProof Tape", 1, 1 },
                    { 2, 30, "Every Day", "Collagen Powder", 1, 30 },
                    { 11, 30, "Once A Week", "Botox", 2, 4 },
                    { 10, 30, "Every Day", "Collagen Dressing", 2, 30 }
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
        }
    }
}
