using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddTechnicalData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarTechnicalData",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false),
                    PowerKw = table.Column<int>(type: "int", nullable: false),
                    TorgueNm = table.Column<int>(type: "int", nullable: false),
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarTechnicalData");
        }
    }
}
