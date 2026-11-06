using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IoTPlatform.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeviceAssets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    InstalledDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceAssets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlertRules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceAssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RuleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MinValue = table.Column<double>(type: "float", nullable: false),
                    MaxValue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlertRules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlertRules_DeviceAssets_DeviceAssetId",
                        column: x => x.DeviceAssetId,
                        principalTable: "DeviceAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceAssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaintenanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Technician = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaintenanceLogs_DeviceAssets_DeviceAssetId",
                        column: x => x.DeviceAssetId,
                        principalTable: "DeviceAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TelemetryMetrics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceAssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MetricName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelemetryMetrics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelemetryMetrics_DeviceAssets_DeviceAssetId",
                        column: x => x.DeviceAssetId,
                        principalTable: "DeviceAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlertRules_DeviceAssetId",
                table: "AlertRules",
                column: "DeviceAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceAssets_SerialNumber",
                table: "DeviceAssets",
                column: "SerialNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceLogs_DeviceAssetId",
                table: "MaintenanceLogs",
                column: "DeviceAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_TelemetryMetrics_DeviceAssetId",
                table: "TelemetryMetrics",
                column: "DeviceAssetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlertRules");

            migrationBuilder.DropTable(
                name: "MaintenanceLogs");

            migrationBuilder.DropTable(
                name: "TelemetryMetrics");

            migrationBuilder.DropTable(
                name: "DeviceAssets");
        }
    }
}
