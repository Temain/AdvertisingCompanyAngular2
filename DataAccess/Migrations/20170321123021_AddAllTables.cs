using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AdvertisingCompanyAngular2.Migrations
{
    public partial class AddAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dict");

            migrationBuilder.EnsureSchema(
                name: "kladr");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ActivityCategory",
                schema: "dict",
                columns: table => new
                {
                    ActivityCategoryId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ActivityCategoryName = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityCategory", x => x.ActivityCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ClientStatus",
                schema: "dict",
                columns: table => new
                {
                    ClientStatusId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ClientStatusLabelClass = table.Column<string>(nullable: true),
                    ClientStatusName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientStatus", x => x.ClientStatusId);
                });

            migrationBuilder.CreateTable(
                name: "LocationLevel",
                schema: "kladr",
                columns: table => new
                {
                    LocationLevelId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LocationLevelName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationLevel", x => x.LocationLevelId);
                });

            migrationBuilder.CreateTable(
                name: "LocationType",
                schema: "kladr",
                columns: table => new
                {
                    LocationTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LocationTypeName = table.Column<string>(nullable: false),
                    LocationTypeShortName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationType", x => x.LocationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentOrder",
                schema: "dict",
                columns: table => new
                {
                    PaymentOrderId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PaymentOrderName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOrder", x => x.PaymentOrderId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
                schema: "dict",
                columns: table => new
                {
                    PaymentStatusId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PaymentStatusLabelClass = table.Column<string>(nullable: true),
                    PaymentStatusName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatus", x => x.PaymentStatusId);
                });

            migrationBuilder.CreateTable(
                name: "PlacementFormat",
                schema: "dict",
                columns: table => new
                {
                    PlacementFormatId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PlacementFormatName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacementFormat", x => x.PlacementFormatId);
                });

            migrationBuilder.CreateTable(
                name: "ActivityType",
                schema: "dict",
                columns: table => new
                {
                    ActivityTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ActivityCategoryId = table.Column<int>(nullable: false),
                    ActivityTypeName = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityType", x => x.ActivityTypeId);
                    table.ForeignKey(
                        name: "FK_ActivityType_ActivityCategory_ActivityCategoryId",
                        column: x => x.ActivityCategoryId,
                        principalSchema: "dict",
                        principalTable: "ActivityCategory",
                        principalColumn: "ActivityCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                schema: "kladr",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Code = table.Column<string>(nullable: true),
                    LocationLevelId = table.Column<int>(nullable: false),
                    LocationName = table.Column<string>(nullable: true),
                    LocationTypeId = table.Column<int>(nullable: false),
                    Okato = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    Zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Location_LocationLevel_LocationLevelId",
                        column: x => x.LocationLevelId,
                        principalSchema: "kladr",
                        principalTable: "LocationLevel",
                        principalColumn: "LocationLevelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Location_LocationType_LocationTypeId",
                        column: x => x.LocationTypeId,
                        principalSchema: "kladr",
                        principalTable: "LocationType",
                        principalColumn: "LocationTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Location_Location_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "kladr",
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                schema: "dbo",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ActivityTypeId = table.Column<int>(nullable: false),
                    AdditionalPhoneNumber = table.Column<string>(nullable: true),
                    ClientStatusId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(maxLength: 1000, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 100, nullable: false),
                    ResponsiblePersonId = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Client_ActivityType_ActivityTypeId",
                        column: x => x.ActivityTypeId,
                        principalSchema: "dict",
                        principalTable: "ActivityType",
                        principalColumn: "ActivityTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_ClientStatus_ClientStatusId",
                        column: x => x.ClientStatusId,
                        principalSchema: "dict",
                        principalTable: "ClientStatus",
                        principalColumn: "ClientStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Person_ResponsiblePersonId",
                        column: x => x.ResponsiblePersonId,
                        principalSchema: "dbo",
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Microdistrict",
                schema: "dict",
                columns: table => new
                {
                    MicrodistrictId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CityId = table.Column<int>(nullable: false),
                    MicrodistrictName = table.Column<string>(nullable: false),
                    MicrodistrictShortName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Microdistrict", x => x.MicrodistrictId);
                    table.ForeignKey(
                        name: "FK_Microdistrict_Location_CityId",
                        column: x => x.CityId,
                        principalSchema: "kladr",
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Campaign",
                schema: "dbo",
                columns: table => new
                {
                    CampaignId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ClientId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(maxLength: 5000, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    PaymentOrderId = table.Column<int>(nullable: false),
                    PaymentStatusId = table.Column<int>(nullable: false),
                    PlacementCost = table.Column<double>(nullable: false),
                    PlacementFormatId = table.Column<int>(nullable: false),
                    PlacementMonthId = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaign", x => x.CampaignId);
                    table.ForeignKey(
                        name: "FK_Campaign_Client_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "dbo",
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Campaign_PaymentOrder_PaymentOrderId",
                        column: x => x.PaymentOrderId,
                        principalSchema: "dict",
                        principalTable: "PaymentOrder",
                        principalColumn: "PaymentOrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Campaign_PaymentStatus_PaymentStatusId",
                        column: x => x.PaymentStatusId,
                        principalSchema: "dict",
                        principalTable: "PaymentStatus",
                        principalColumn: "PaymentStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Campaign_PlacementFormat_PlacementFormatId",
                        column: x => x.PlacementFormatId,
                        principalSchema: "dict",
                        principalTable: "PlacementFormat",
                        principalColumn: "PlacementFormatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "dbo",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BuildingId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    ContractDate = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DistrictId = table.Column<int>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    ManagementCompanyName = table.Column<string>(nullable: false),
                    MicrodistrictId = table.Column<int>(nullable: false),
                    NumberOfEntrances = table.Column<int>(nullable: false),
                    NumberOfFloors = table.Column<int>(nullable: false),
                    NumberOfSurfaces = table.Column<int>(nullable: false),
                    RegionId = table.Column<int>(nullable: false),
                    StreetId = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Address_Location_BuildingId",
                        column: x => x.BuildingId,
                        principalSchema: "kladr",
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_Location_CityId",
                        column: x => x.CityId,
                        principalSchema: "kladr",
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_Location_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "kladr",
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Microdistrict_MicrodistrictId",
                        column: x => x.MicrodistrictId,
                        principalSchema: "dict",
                        principalTable: "Microdistrict",
                        principalColumn: "MicrodistrictId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_Location_RegionId",
                        column: x => x.RegionId,
                        principalSchema: "kladr",
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_Location_StreetId",
                        column: x => x.StreetId,
                        principalSchema: "kladr",
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignMicrodistricts",
                schema: "dbo",
                columns: table => new
                {
                    CampaignId = table.Column<int>(nullable: false),
                    MicrodistrictId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignMicrodistricts", x => new { x.CampaignId, x.MicrodistrictId });
                    table.ForeignKey(
                        name: "FK_CampaignMicrodistricts_Campaign_CampaignId",
                        column: x => x.CampaignId,
                        principalSchema: "dbo",
                        principalTable: "Campaign",
                        principalColumn: "CampaignId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignMicrodistricts_Microdistrict_MicrodistrictId",
                        column: x => x.MicrodistrictId,
                        principalSchema: "dict",
                        principalTable: "Microdistrict",
                        principalColumn: "MicrodistrictId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressReport",
                schema: "dbo",
                columns: table => new
                {
                    AddressReportId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AddressId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true),
                    ImageLength = table.Column<long>(nullable: true),
                    ImageMimeType = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressReport", x => x.AddressReportId);
                    table.ForeignKey(
                        name: "FK_AddressReport_Address_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "dbo",
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClientId",
                table: "AspNetUsers",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityType_ActivityCategoryId",
                schema: "dict",
                table: "ActivityType",
                column: "ActivityCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_BuildingId",
                schema: "dbo",
                table: "Address",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CityId",
                schema: "dbo",
                table: "Address",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_DistrictId",
                schema: "dbo",
                table: "Address",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_MicrodistrictId",
                schema: "dbo",
                table: "Address",
                column: "MicrodistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_RegionId",
                schema: "dbo",
                table: "Address",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_StreetId",
                schema: "dbo",
                table: "Address",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressReport_AddressId",
                schema: "dbo",
                table: "AddressReport",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_ClientId",
                schema: "dbo",
                table: "Campaign",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_PaymentOrderId",
                schema: "dbo",
                table: "Campaign",
                column: "PaymentOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_PaymentStatusId",
                schema: "dbo",
                table: "Campaign",
                column: "PaymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_PlacementFormatId",
                schema: "dbo",
                table: "Campaign",
                column: "PlacementFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignMicrodistricts_MicrodistrictId",
                schema: "dbo",
                table: "CampaignMicrodistricts",
                column: "MicrodistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ActivityTypeId",
                schema: "dbo",
                table: "Client",
                column: "ActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ClientStatusId",
                schema: "dbo",
                table: "Client",
                column: "ClientStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ResponsiblePersonId",
                schema: "dbo",
                table: "Client",
                column: "ResponsiblePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_LocationLevelId",
                schema: "kladr",
                table: "Location",
                column: "LocationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_LocationTypeId",
                schema: "kladr",
                table: "Location",
                column: "LocationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_ParentId",
                schema: "kladr",
                table: "Location",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Microdistrict_CityId",
                schema: "dict",
                table: "Microdistrict",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Client_ClientId",
                table: "AspNetUsers",
                column: "ClientId",
                principalSchema: "dbo",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Client_ClientId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AddressReport",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CampaignMicrodistricts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Address",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Campaign",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Microdistrict",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "Client",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PaymentOrder",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "PaymentStatus",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "PlacementFormat",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "Location",
                schema: "kladr");

            migrationBuilder.DropTable(
                name: "ActivityType",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "ClientStatus",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "LocationLevel",
                schema: "kladr");

            migrationBuilder.DropTable(
                name: "LocationType",
                schema: "kladr");

            migrationBuilder.DropTable(
                name: "ActivityCategory",
                schema: "dict");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClientId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "AspNetUsers");
        }
    }
}
