using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class initalize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyShapingPackets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Packet = table.Column<string>(type: "text", nullable: false),
                    MainCategoryId = table.Column<int>(type: "integer", nullable: true),
                    SessionCount = table.Column<int>(type: "integer", nullable: true),
                    SessionDuration = table.Column<int>(type: "integer", nullable: true),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    IsDeactive = table.Column<bool>(type: "boolean", nullable: false),
                    Discount = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyShapingPackets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodyShapingPackets_BodyShapingPackets_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "BodyShapingPackets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CosmetologyCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: false),
                    MainCategoryId = table.Column<int>(type: "integer", nullable: true),
                    IsDeactive = table.Column<bool>(type: "boolean", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    Discount = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CosmetologyCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CosmetologyCategories_CosmetologyCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "CosmetologyCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Filials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FilialName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Masters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PositionName = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: true),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SolariumCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainCategoryId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Minute = table.Column<int>(type: "integer", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: true),
                    UsingPeriod = table.Column<int>(type: "integer", nullable: true),
                    IsDeactive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolariumCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolariumCategories_SolariumCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "SolariumCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "CistkaCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainCategoryId = table.Column<int>(type: "integer", nullable: true),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    Discount = table.Column<bool>(type: "boolean", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CistkaCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CistkaCategories_CistkaCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "CistkaCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CistkaCategories_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true,defaultValue:"01.01.2024"),
                    FullName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    Female = table.Column<bool>(type: "boolean", nullable: false,defaultValue:true),
                    FilialId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false,defaultValue:true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HairCutCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FilialId = table.Column<int>(type: "integer", nullable: false),
                    MainCategoryId = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    Discount = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairCutCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HairCutCategories_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HairCutCategories_HairCutCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "HairCutCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KassaActionCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false),
                    AutoDate = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KassaActionCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KassaActionCategories_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LazerCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    MainCategoryId = table.Column<int>(type: "integer", nullable: true),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false),
                    IsDeactive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LazerCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LazerCategories_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LazerCategories_LazerCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "LazerCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LipuckaCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Category = table.Column<string>(type: "text", nullable: false),
                    MainCategoryId = table.Column<int>(type: "integer", nullable: true),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LipuckaCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LipuckaCategories_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LipuckaCategories_LipuckaCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "LipuckaCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MakeUpCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    MainCategoryId = table.Column<int>(type: "integer", nullable: true),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeUpCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MakeUpCategories_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MakeUpCategories_MakeUpCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MakeUpCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PirsinqCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: false),
                    MainCategoryId = table.Column<int>(type: "integer", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    IsDeactive = table.Column<bool>(type: "boolean", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PirsinqCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PirsinqCategories_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PirsinqCategories_PirsinqCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "PirsinqCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SpendCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false),
                    AutoDate = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpendCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpendCategories_Filials_Id",
                        column: x => x.Id,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    ForgetPasswordCode = table.Column<string>(type: "text", nullable: false),
                    IsBlock = table.Column<bool>(type: "boolean", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterFilials",
                columns: table => new
                {
                    MasterId = table.Column<int>(type: "integer", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterFilials", x => new { x.MasterId, x.FilialId });
                    table.ForeignKey(
                        name: "FK_MasterFilials_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterFilials_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MasterId = table.Column<int>(type: "integer", nullable: false),
                    PositionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MasterPositions_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterPositions_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BodyshapingAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    BuyingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false),
                    MasterId = table.Column<int>(type: "integer", nullable: false),
                    RemaingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeactive = table.Column<bool>(type: "boolean", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    IsInjection = table.Column<bool>(type: "boolean", nullable: false),
                    ReturnMoney = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyshapingAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodyshapingAppointment_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BodyshapingAppointment_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BodyshapingAppointment_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BodyshapingAppointment_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CistkaAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MasterId = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    IsInjection = table.Column<bool>(type: "boolean", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsReserved = table.Column<bool>(type: "boolean", nullable: false),
                    IsStarted = table.Column<bool>(type: "boolean", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    HandDescription = table.Column<bool>(type: "boolean", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ReturnMoney = table.Column<decimal>(type: "numeric", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CistkaAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CistkaAppointment_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CistkaAppointment_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CistkaAppointment_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CistkaAppointment_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CosmetologyAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MasterId = table.Column<int>(type: "integer", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    OutTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    CosmetologyDescription = table.Column<string>(type: "text", nullable: true),
                    IsStart = table.Column<bool>(type: "boolean", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CosmetologyAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CosmetologyAppointment_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CosmetologyAppointment_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CosmetologyAppointment_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CosmetologyAppointment_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HairCutAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MasterId = table.Column<int>(type: "integer", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    IncomeId = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    HandDescription = table.Column<bool>(type: "boolean", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairCutAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HairCutAppointment_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HairCutAppointment_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HairCutAppointment_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HairCutAppointment_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KassaActionList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LastOutMoneyDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    OutMoneyQuantity = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KassaActionList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KassaActionList_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KassaActionList_KassaActionCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "KassaActionCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KassaActionList_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LazersAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReservationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    InCompleteStartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    InCompleteEndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    MasterId = table.Column<int>(type: "integer", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    ImplusCount = table.Column<int>(type: "integer", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false),
                    EditorName = table.Column<string>(type: "text", nullable: true),
                    NextSessionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    HandDescription = table.Column<bool>(type: "boolean", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    IsReserved = table.Column<bool>(type: "boolean", nullable: false),
                    IsStarted = table.Column<bool>(type: "boolean", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsContiued = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    InjectionDecription = table.Column<string>(type: "text", nullable: true),
                    StartForSecond = table.Column<bool>(type: "boolean", nullable: false),
                    EndForSecond = table.Column<bool>(type: "boolean", nullable: false),
                    ReservationForSecond = table.Column<bool>(type: "boolean", nullable: false),
                    PriceUpdateDescription = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LazersAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LazersAppointment_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LazersAppointment_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LazersAppointment_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LazersAppointment_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LipuckaAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    MasterId = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsStart = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LipuckaAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LipuckaAppointment_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LipuckaAppointment_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LipuckaAppointment_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LipuckaAppointment_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MakeUpAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MasterId = table.Column<int>(type: "integer", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    IsReserved = table.Column<bool>(type: "boolean", nullable: false),
                    IsStart = table.Column<bool>(type: "boolean", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsInjection = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeUpAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MakeUpAppointment_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MakeUpAppointment_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MakeUpAppointment_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MakeUpAppointment_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutMoneys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    AddingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    SpendCategoryId = table.Column<int>(type: "integer", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutMoneys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutMoneys_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutMoneys_SpendCategories_Id",
                        column: x => x.Id,
                        principalTable: "SpendCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutMoneys_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PirsinqAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    MasterId = table.Column<int>(type: "integer", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    ReturnMoney = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeactive = table.Column<bool>(type: "boolean", nullable: false),
                    IsStart = table.Column<bool>(type: "boolean", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PirsinqAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PirsinqAppointment_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PirsinqAppointment_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PirsinqAppointment_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PirsinqAppointment_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolariumAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    BuyingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    RemainingMinute = table.Column<int>(type: "integer", nullable: false),
                    MinuteLimit = table.Column<int>(type: "integer", nullable: false),
                    UsingMinute = table.Column<int>(type: "integer", nullable: false),
                    SolariumCategoriesId = table.Column<int>(type: "integer", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    RemainingTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MoneyUpdateDescription = table.Column<string>(type: "text", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsTimeOut = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    ReturnMoney = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolariumAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolariumAppointment_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolariumAppointment_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolariumAppointment_SolariumCategories_SolariumCategoriesId",
                        column: x => x.SolariumCategoriesId,
                        principalTable: "SolariumCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolariumAppointment_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductName = table.Column<string>(type: "text", nullable: false),
                    TotalCount = table.Column<int>(type: "integer", nullable: false),
                    SellingCount = table.Column<int>(type: "integer", nullable: false),
                    RemainCount = table.Column<int>(type: "integer", nullable: false),
                    AddingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    BuyingPrice = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stocks_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BodyShapingReports",
                columns: table => new
                {
                    AppointmentsId = table.Column<int>(type: "integer", nullable: false),
                    PacketId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyShapingReports", x => new { x.PacketId, x.AppointmentsId });
                    table.ForeignKey(
                        name: "FK_BodyShapingReports_BodyShapingPackets_PacketId",
                        column: x => x.PacketId,
                        principalTable: "BodyShapingPackets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BodyShapingReports_BodyshapingAppointment_AppointmentsId",
                        column: x => x.AppointmentsId,
                        principalTable: "BodyshapingAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BodyShapingSessionLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Duration = table.Column<int>(type: "integer", nullable: false),
                    SessionName = table.Column<string>(type: "text", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyShapingSessionLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodyShapingSessionLists_BodyshapingAppointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "BodyshapingAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BodyShapingSessionLists_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CistkaReports",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CistkaReports", x => new { x.AppointmentId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CistkaReports_CistkaAppointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "CistkaAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CistkaReports_CistkaCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CistkaCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CosmetologyReports",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CosmetologyReports", x => new { x.AppointmentId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CosmetologyReports_CosmetologyAppointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "CosmetologyAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CosmetologyReports_CosmetologyCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CosmetologyCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HairCutCategoryReports",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairCutCategoryReports", x => new { x.AppointmentId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_HairCutCategoryReports_HairCutAppointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "HairCutAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HairCutCategoryReports_HairCutCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "HairCutCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LazerAppointmentReports",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    AppointmentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LazerAppointmentReports", x => new { x.AppointmentId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_LazerAppointmentReports_LazerCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "LazerCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LazerAppointmentReports_LazersAppointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "LazersAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LipuckaReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    CategoriesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LipuckaReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LipuckaReports_LipuckaAppointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "LipuckaAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LipuckaReports_LipuckaCategories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "LipuckaCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MakeUpReports",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeUpReports", x => new { x.AppointmentId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_MakeUpReports_MakeUpAppointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "MakeUpAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MakeUpReports_MakeUpCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "MakeUpCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PirsinqReports",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PirsinqReports", x => new { x.AppointmentId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_PirsinqReports_PirsinqAppointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "PirsinqAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PirsinqReports_PirsinqCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "PirsinqCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolariumUsingLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    UsingMinute = table.Column<int>(type: "integer", nullable: false),
                    RemainingMinute = table.Column<int>(type: "integer", nullable: false),
                    UsingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolariumUsingLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolariumUsingLists_SolariumAppointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "SolariumAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolariumUsingLists_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductName = table.Column<string>(type: "text", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    IncomeDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    BuyingPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    StockId = table.Column<int>(type: "integer", nullable: false),
                    FilialId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incomes_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incomes_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incomes_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HairCutItems",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    StockId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    IncomeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairCutItems", x => new { x.StockId, x.AppointmentId });
                    table.ForeignKey(
                        name: "FK_HairCutItems_HairCutAppointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "HairCutAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HairCutItems_Incomes_IncomeId",
                        column: x => x.IncomeId,
                        principalTable: "Incomes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HairCutItems_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BodyshapingAppointment_AppUserId",
                table: "BodyshapingAppointment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyshapingAppointment_CustomerId",
                table: "BodyshapingAppointment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyshapingAppointment_FilialId",
                table: "BodyshapingAppointment",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyshapingAppointment_MasterId",
                table: "BodyshapingAppointment",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyShapingPackets_MainCategoryId",
                table: "BodyShapingPackets",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyShapingReports_AppointmentsId",
                table: "BodyShapingReports",
                column: "AppointmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyShapingSessionLists_AppointmentId",
                table: "BodyShapingSessionLists",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyShapingSessionLists_AppUserId",
                table: "BodyShapingSessionLists",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CistkaAppointment_AppUserId",
                table: "CistkaAppointment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CistkaAppointment_CustomerId",
                table: "CistkaAppointment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CistkaAppointment_FilialId",
                table: "CistkaAppointment",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_CistkaAppointment_MasterId",
                table: "CistkaAppointment",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_CistkaCategories_FilialId",
                table: "CistkaCategories",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_CistkaCategories_MainCategoryId",
                table: "CistkaCategories",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CistkaReports_CategoryId",
                table: "CistkaReports",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CosmetologyAppointment_AppUserId",
                table: "CosmetologyAppointment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CosmetologyAppointment_CustomerId",
                table: "CosmetologyAppointment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CosmetologyAppointment_FilialId",
                table: "CosmetologyAppointment",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_CosmetologyAppointment_MasterId",
                table: "CosmetologyAppointment",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_CosmetologyCategories_MainCategoryId",
                table: "CosmetologyCategories",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CosmetologyReports_CategoryId",
                table: "CosmetologyReports",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_FilialId",
                table: "Customers",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutAppointment_AppUserId",
                table: "HairCutAppointment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutAppointment_CustomerId",
                table: "HairCutAppointment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutAppointment_FilialId",
                table: "HairCutAppointment",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutAppointment_MasterId",
                table: "HairCutAppointment",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutCategories_FilialId",
                table: "HairCutCategories",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutCategories_MainCategoryId",
                table: "HairCutCategories",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutCategoryReports_CategoryId",
                table: "HairCutCategoryReports",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutItems_AppointmentId",
                table: "HairCutItems",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutItems_IncomeId",
                table: "HairCutItems",
                column: "IncomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_AppUserId",
                table: "Incomes",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_FilialId",
                table: "Incomes",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_StockId",
                table: "Incomes",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_KassaActionCategories_FilialId",
                table: "KassaActionCategories",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_KassaActionList_AppUserId",
                table: "KassaActionList",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_KassaActionList_CategoryId",
                table: "KassaActionList",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_KassaActionList_FilialId",
                table: "KassaActionList",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_LazerAppointmentReports_CategoryId",
                table: "LazerAppointmentReports",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LazerCategories_FilialId",
                table: "LazerCategories",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_LazerCategories_MainCategoryId",
                table: "LazerCategories",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LazersAppointment_AppUserId",
                table: "LazersAppointment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LazersAppointment_CustomerId",
                table: "LazersAppointment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_LazersAppointment_FilialId",
                table: "LazersAppointment",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_LazersAppointment_MasterId",
                table: "LazersAppointment",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_LipuckaAppointment_AppUserId",
                table: "LipuckaAppointment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LipuckaAppointment_CustomerId",
                table: "LipuckaAppointment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_LipuckaAppointment_FilialId",
                table: "LipuckaAppointment",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_LipuckaAppointment_MasterId",
                table: "LipuckaAppointment",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_LipuckaCategories_FilialId",
                table: "LipuckaCategories",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_LipuckaCategories_MainCategoryId",
                table: "LipuckaCategories",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LipuckaReports_AppointmentId",
                table: "LipuckaReports",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LipuckaReports_CategoriesId",
                table: "LipuckaReports",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_MakeUpAppointment_AppUserId",
                table: "MakeUpAppointment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MakeUpAppointment_CustomerId",
                table: "MakeUpAppointment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_MakeUpAppointment_FilialId",
                table: "MakeUpAppointment",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_MakeUpAppointment_MasterId",
                table: "MakeUpAppointment",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_MakeUpCategories_FilialId",
                table: "MakeUpCategories",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_MakeUpCategories_MainCategoryId",
                table: "MakeUpCategories",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MakeUpReports_CategoryId",
                table: "MakeUpReports",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterFilials_FilialId",
                table: "MasterFilials",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterPositions_MasterId",
                table: "MasterPositions",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterPositions_PositionId",
                table: "MasterPositions",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_OutMoneys_AppUserId",
                table: "OutMoneys",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OutMoneys_FilialId",
                table: "OutMoneys",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_PirsinqAppointment_AppUserId",
                table: "PirsinqAppointment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PirsinqAppointment_CustomerId",
                table: "PirsinqAppointment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PirsinqAppointment_FilialId",
                table: "PirsinqAppointment",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_PirsinqAppointment_MasterId",
                table: "PirsinqAppointment",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PirsinqCategories_FilialId",
                table: "PirsinqCategories",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_PirsinqCategories_MainCategoryId",
                table: "PirsinqCategories",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PirsinqReports_CategoryId",
                table: "PirsinqReports",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SolariumAppointment_AppUserId",
                table: "SolariumAppointment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SolariumAppointment_CustomerId",
                table: "SolariumAppointment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SolariumAppointment_FilialId",
                table: "SolariumAppointment",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_SolariumAppointment_SolariumCategoriesId",
                table: "SolariumAppointment",
                column: "SolariumCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_SolariumCategories_MainCategoryId",
                table: "SolariumCategories",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SolariumUsingLists_AppointmentId",
                table: "SolariumUsingLists",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SolariumUsingLists_AppUserId",
                table: "SolariumUsingLists",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_AppUserId",
                table: "Stocks",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_FilialId",
                table: "Stocks",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FilialId",
                table: "Users",
                column: "FilialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyShapingReports");

            migrationBuilder.DropTable(
                name: "BodyShapingSessionLists");

            migrationBuilder.DropTable(
                name: "CistkaReports");

            migrationBuilder.DropTable(
                name: "CosmetologyReports");

            migrationBuilder.DropTable(
                name: "HairCutCategoryReports");

            migrationBuilder.DropTable(
                name: "HairCutItems");

            migrationBuilder.DropTable(
                name: "KassaActionList");

            migrationBuilder.DropTable(
                name: "LazerAppointmentReports");

            migrationBuilder.DropTable(
                name: "LipuckaReports");

            migrationBuilder.DropTable(
                name: "MakeUpReports");

            migrationBuilder.DropTable(
                name: "MasterFilials");

            migrationBuilder.DropTable(
                name: "MasterPositions");

            migrationBuilder.DropTable(
                name: "OutMoneys");

            migrationBuilder.DropTable(
                name: "PirsinqReports");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SolariumUsingLists");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "BodyShapingPackets");

            migrationBuilder.DropTable(
                name: "BodyshapingAppointment");

            migrationBuilder.DropTable(
                name: "CistkaAppointment");

            migrationBuilder.DropTable(
                name: "CistkaCategories");

            migrationBuilder.DropTable(
                name: "CosmetologyAppointment");

            migrationBuilder.DropTable(
                name: "CosmetologyCategories");

            migrationBuilder.DropTable(
                name: "HairCutCategories");

            migrationBuilder.DropTable(
                name: "HairCutAppointment");

            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.DropTable(
                name: "KassaActionCategories");

            migrationBuilder.DropTable(
                name: "LazerCategories");

            migrationBuilder.DropTable(
                name: "LazersAppointment");

            migrationBuilder.DropTable(
                name: "LipuckaAppointment");

            migrationBuilder.DropTable(
                name: "LipuckaCategories");

            migrationBuilder.DropTable(
                name: "MakeUpAppointment");

            migrationBuilder.DropTable(
                name: "MakeUpCategories");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "SpendCategories");

            migrationBuilder.DropTable(
                name: "PirsinqAppointment");

            migrationBuilder.DropTable(
                name: "PirsinqCategories");

            migrationBuilder.DropTable(
                name: "SolariumAppointment");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Masters");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "SolariumCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Filials");
        }
    }
}
