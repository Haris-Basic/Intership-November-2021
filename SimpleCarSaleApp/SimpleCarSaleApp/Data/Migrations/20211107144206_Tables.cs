using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleCarSaleApp.Data.Migrations
{
    public partial class Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DriveType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriveTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriveType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fuel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PathToImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transmission",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransmissionType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmission", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CarModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivModela = table.Column<string>(nullable: true),
                    BrandID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarModel_Brand_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brand",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandID = table.Column<int>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    FuelID = table.Column<int>(nullable: false),
                    VehicleTypeID = table.Column<int>(nullable: false),
                    ColorID = table.Column<int>(nullable: false),
                    DriveTypeID = table.Column<int>(nullable: false),
                    TransmissionID = table.Column<int>(nullable: false),
                    NumberOfSeats = table.Column<int>(nullable: false),
                    NumberOfDors = table.Column<int>(nullable: false),
                    NumberOfGears = table.Column<string>(nullable: true),
                    PowerPS = table.Column<int>(nullable: false),
                    PowerKw = table.Column<int>(nullable: false),
                    WheelSize = table.Column<float>(nullable: false),
                    Ccm = table.Column<float>(nullable: false),
                    Kilometre = table.Column<float>(nullable: false),
                    DateOfManufacture = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Car_Brand_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brand",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_Color_ColorID",
                        column: x => x.ColorID,
                        principalTable: "Color",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_DriveType_DriveTypeID",
                        column: x => x.DriveTypeID,
                        principalTable: "DriveType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_Fuel_FuelID",
                        column: x => x.FuelID,
                        principalTable: "Fuel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_Transmission_TransmissionID",
                        column: x => x.TransmissionID,
                        principalTable: "Transmission",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_VehicleType_VehicleTypeID",
                        column: x => x.VehicleTypeID,
                        principalTable: "VehicleType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarImage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(nullable: false),
                    ImageID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarImage_Car_CarID",
                        column: x => x.CarID,
                        principalTable: "Car",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarImage_Image_ImageID",
                        column: x => x.ImageID,
                        principalTable: "Image",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_BrandID",
                table: "Car",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_ColorID",
                table: "Car",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_DriveTypeID",
                table: "Car",
                column: "DriveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_FuelID",
                table: "Car",
                column: "FuelID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_TransmissionID",
                table: "Car",
                column: "TransmissionID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_VehicleTypeID",
                table: "Car",
                column: "VehicleTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CarImage_CarID",
                table: "CarImage",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_CarImage_ImageID",
                table: "CarImage",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_CarModel_BrandID",
                table: "CarModel",
                column: "BrandID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarImage");

            migrationBuilder.DropTable(
                name: "CarModel");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "DriveType");

            migrationBuilder.DropTable(
                name: "Fuel");

            migrationBuilder.DropTable(
                name: "Transmission");

            migrationBuilder.DropTable(
                name: "VehicleType");
        }
    }
}
