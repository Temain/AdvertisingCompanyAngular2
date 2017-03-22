using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApplicationBasic.DataAccess;

namespace AdvertisingCompanyAngular2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170321123021_AddAllTables")]
    partial class AddAllTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.ActivityCategory", b =>
                {
                    b.Property<int>("ActivityCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActivityCategoryName")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("ActivityCategoryId");

                    b.ToTable("ActivityCategory","dict");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.ActivityType", b =>
                {
                    b.Property<int>("ActivityTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActivityCategoryId");

                    b.Property<string>("ActivityTypeName")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("ActivityTypeId");

                    b.HasIndex("ActivityCategoryId");

                    b.ToTable("ActivityType","dict");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BuildingId");

                    b.Property<int>("CityId");

                    b.Property<DateTime?>("ContractDate");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<int?>("DistrictId");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("ManagementCompanyName")
                        .IsRequired();

                    b.Property<int>("MicrodistrictId");

                    b.Property<int>("NumberOfEntrances");

                    b.Property<int>("NumberOfFloors");

                    b.Property<int>("NumberOfSurfaces");

                    b.Property<int>("RegionId");

                    b.Property<int>("StreetId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("AddressId");

                    b.HasIndex("BuildingId");

                    b.HasIndex("CityId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("MicrodistrictId");

                    b.HasIndex("RegionId");

                    b.HasIndex("StreetId");

                    b.ToTable("Address","dbo");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.AddressReport", b =>
                {
                    b.Property<int>("AddressReportId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<byte[]>("ImageData");

                    b.Property<long?>("ImageLength");

                    b.Property<string>("ImageMimeType");

                    b.Property<string>("ImageName");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("AddressReportId");

                    b.HasIndex("AddressId");

                    b.ToTable("AddressReport","dbo");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int?>("ClientId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("DisplayName");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<int?>("PersonId");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("PersonId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.Campaign", b =>
                {
                    b.Property<int>("CampaignId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<string>("Comment")
                        .HasMaxLength(5000);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<int>("PaymentOrderId");

                    b.Property<int>("PaymentStatusId");

                    b.Property<double>("PlacementCost");

                    b.Property<int>("PlacementFormatId");

                    b.Property<int>("PlacementMonthId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("CampaignId");

                    b.HasIndex("ClientId");

                    b.HasIndex("PaymentOrderId");

                    b.HasIndex("PaymentStatusId");

                    b.HasIndex("PlacementFormatId");

                    b.ToTable("Campaign","dbo");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.CampaignMicrodistricts", b =>
                {
                    b.Property<int>("CampaignId");

                    b.Property<int>("MicrodistrictId");

                    b.HasKey("CampaignId", "MicrodistrictId");

                    b.HasIndex("MicrodistrictId");

                    b.ToTable("CampaignMicrodistricts","dbo");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActivityTypeId");

                    b.Property<string>("AdditionalPhoneNumber");

                    b.Property<int>("ClientStatusId");

                    b.Property<string>("Comment");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("ResponsiblePersonId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("ClientId");

                    b.HasIndex("ActivityTypeId");

                    b.HasIndex("ClientStatusId");

                    b.HasIndex("ResponsiblePersonId");

                    b.ToTable("Client","dbo");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.ClientStatus", b =>
                {
                    b.Property<int>("ClientStatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientStatusLabelClass");

                    b.Property<string>("ClientStatusName")
                        .IsRequired();

                    b.HasKey("ClientStatusId");

                    b.ToTable("ClientStatus","dict");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<int>("LocationLevelId");

                    b.Property<string>("LocationName");

                    b.Property<int>("LocationTypeId");

                    b.Property<string>("Okato");

                    b.Property<int?>("ParentId");

                    b.Property<string>("Zip");

                    b.HasKey("LocationId");

                    b.HasIndex("LocationLevelId");

                    b.HasIndex("LocationTypeId");

                    b.HasIndex("ParentId");

                    b.ToTable("Location","kladr");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.LocationLevel", b =>
                {
                    b.Property<int>("LocationLevelId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LocationLevelName")
                        .IsRequired();

                    b.HasKey("LocationLevelId");

                    b.ToTable("LocationLevel","kladr");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.LocationType", b =>
                {
                    b.Property<int>("LocationTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LocationTypeName")
                        .IsRequired();

                    b.Property<string>("LocationTypeShortName")
                        .IsRequired();

                    b.HasKey("LocationTypeId");

                    b.ToTable("LocationType","kladr");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.Microdistrict", b =>
                {
                    b.Property<int>("MicrodistrictId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityId");

                    b.Property<string>("MicrodistrictName")
                        .IsRequired();

                    b.Property<string>("MicrodistrictShortName")
                        .IsRequired();

                    b.HasKey("MicrodistrictId");

                    b.HasIndex("CityId");

                    b.ToTable("Microdistrict","dict");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.PaymentOrder", b =>
                {
                    b.Property<int>("PaymentOrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PaymentOrderName")
                        .IsRequired();

                    b.HasKey("PaymentOrderId");

                    b.ToTable("PaymentOrder","dict");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.PaymentStatus", b =>
                {
                    b.Property<int>("PaymentStatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PaymentStatusLabelClass");

                    b.Property<string>("PaymentStatusName")
                        .IsRequired();

                    b.HasKey("PaymentStatusId");

                    b.ToTable("PaymentStatus","dict");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("Birthday");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("LastName")
                        .HasMaxLength(500);

                    b.Property<string>("MiddleName")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("PersonId");

                    b.ToTable("Person","dbo");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.PlacementFormat", b =>
                {
                    b.Property<int>("PlacementFormatId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PlacementFormatName")
                        .IsRequired();

                    b.HasKey("PlacementFormatId");

                    b.ToTable("PlacementFormat","dict");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebApplicationBasic.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebApplicationBasic.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplicationBasic.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplicationBasic.Models.ActivityType", b =>
                {
                    b.HasOne("WebApplicationBasic.Models.ActivityCategory", "ActivityCategory")
                        .WithMany("ActivityTypes")
                        .HasForeignKey("ActivityCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplicationBasic.Models.Address", b =>
                {
                    b.HasOne("WebApplicationBasic.Models.Location", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplicationBasic.Models.Location", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplicationBasic.Models.Location", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.HasOne("WebApplicationBasic.Models.Microdistrict", "Microdistrict")
                        .WithMany("Addresses")
                        .HasForeignKey("MicrodistrictId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplicationBasic.Models.Location", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplicationBasic.Models.Location", "Street")
                        .WithMany()
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplicationBasic.Models.AddressReport", b =>
                {
                    b.HasOne("WebApplicationBasic.Models.Address", "Address")
                        .WithMany("Reports")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplicationBasic.Models.ApplicationUser", b =>
                {
                    b.HasOne("WebApplicationBasic.Models.Client")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("ClientId");

                    b.HasOne("WebApplicationBasic.Models.Person")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.Campaign", b =>
                {
                    b.HasOne("WebApplicationBasic.Models.Client", "Client")
                        .WithMany("Campaigns")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplicationBasic.Models.PaymentOrder", "PaymentOrder")
                        .WithMany("Campaigns")
                        .HasForeignKey("PaymentOrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplicationBasic.Models.PaymentStatus", "PaymentStatus")
                        .WithMany("Campaigns")
                        .HasForeignKey("PaymentStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplicationBasic.Models.PlacementFormat", "PlacementFormat")
                        .WithMany("Campaigns")
                        .HasForeignKey("PlacementFormatId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplicationBasic.Models.CampaignMicrodistricts", b =>
                {
                    b.HasOne("WebApplicationBasic.Models.Campaign", "Campaign")
                        .WithMany("CampaignMicrodistricts")
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplicationBasic.Models.Microdistrict", "Microdistrict")
                        .WithMany("CampaignMicrodistricts")
                        .HasForeignKey("MicrodistrictId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplicationBasic.Models.Client", b =>
                {
                    b.HasOne("WebApplicationBasic.Models.ActivityType", "ActivityType")
                        .WithMany("Clients")
                        .HasForeignKey("ActivityTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplicationBasic.Models.ClientStatus", "ClientStatus")
                        .WithMany("Clients")
                        .HasForeignKey("ClientStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplicationBasic.Models.Person", "ResponsiblePerson")
                        .WithMany("Clients")
                        .HasForeignKey("ResponsiblePersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplicationBasic.Models.Location", b =>
                {
                    b.HasOne("WebApplicationBasic.Models.LocationLevel", "LocationLevel")
                        .WithMany("Locations")
                        .HasForeignKey("LocationLevelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplicationBasic.Models.LocationType", "LocationType")
                        .WithMany("Locations")
                        .HasForeignKey("LocationTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplicationBasic.Models.Location", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.Microdistrict", b =>
                {
                    b.HasOne("WebApplicationBasic.Models.Location", "City")
                        .WithMany("Microdistricts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
