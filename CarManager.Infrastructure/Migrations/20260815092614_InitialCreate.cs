using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1001, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Variant = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BodyType = table.Column<int>(type: "int", nullable: false),
                    ModelYear = table.Column<int>(type: "int", nullable: false),
                    FirstRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vin = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Condition = table.Column<int>(type: "int", nullable: false),
                    PreviousOwners = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

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
                name: "CarTechnicalData",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false),
                    PowerKw = table.Column<int>(type: "int", nullable: false),
                    TorqueNm = table.Column<int>(type: "int", nullable: false),
                    Acceleration = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false),
                    TopSpeedKmh = table.Column<int>(type: "int", nullable: false),
                    TransmissionType = table.Column<int>(type: "int", nullable: false),
                    DriveType = table.Column<int>(type: "int", nullable: false),
                    FuelType = table.Column<int>(type: "int", nullable: true),
                    CurbWeightKg = table.Column<int>(type: "int", nullable: false),
                    TrunkCapacityLiters = table.Column<int>(type: "int", nullable: false),
                    ExteriorColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InteriorColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PowerTrain = table.Column<int>(type: "int", nullable: false),
                    EngineType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DisplacementCc = table.Column<int>(type: "int", nullable: true),
                    Cylinders = table.Column<int>(type: "int", nullable: true),
                    FuelTankCapacityLiters = table.Column<int>(type: "int", nullable: true),
                    FuelConsumption = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    Co2Emissions = table.Column<int>(type: "int", nullable: true),
                    EmissionStandard = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MotorType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BatteryCapacityKwh = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    UsableBatteryCapacityKwh = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    ElectricRangeKm = table.Column<int>(type: "int", nullable: true),
                    EnergyConsumption = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    ChargingPowerAcKw = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    ChargingPowerDcKw = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    BatteryType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTechnicalData", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_CarTechnicalData_Car_CarId",
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
                name: "IX_Car_Vin",
                table: "Car",
                column: "Vin",
                unique: true);

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
                name: "CarTechnicalData");

            migrationBuilder.DropTable(
                name: "CarTimelineItem");

            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
