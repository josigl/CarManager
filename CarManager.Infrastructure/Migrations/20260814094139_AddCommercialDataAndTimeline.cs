using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCommercialDataAndTimeline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarCommercialData",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false),
                    CurrentValue = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    PurchaseDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Dealer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InvoiceNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    WarrantyUntil = table.Column<DateOnly>(type: "date", nullable: true),
                    AnnualInsuranceCost = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    AnnualRoadTax = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    AnnualFuelCost = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    AnnualMaintenanceCost = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCommercialData", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_CarCommercialData_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarTimelineItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTimelineItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarTimelineItem_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarTimelineItem_CarId",
                table: "CarTimelineItem",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarCommercialData");

            migrationBuilder.DropTable(
                name: "CarTimelineItem");
        }
    }
}
