using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyShapingPackets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Packet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCategoryId = table.Column<int>(type: "int", nullable: true),
                    SessionCount = table.Column<int>(type: "int", nullable: true),
                    SessionDuration = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false),
                    Discount = table.Column<bool>(type: "bit", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCategoryId = table.Column<int>(type: "int", nullable: true),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<bool>(type: "bit", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilialName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Masters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SolariumCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainCategoryId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UsingPeriod = table.Column<int>(type: "int", nullable: true),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false)
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ForgetPasswordCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBlock = table.Column<bool>(type: "bit", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CistkaCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainCategoryId = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<bool>(type: "bit", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: true)
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<double>(type: "float", nullable: true),
                    GiveNumber = table.Column<bool>(type: "bit", nullable: false),
                    GiveBirthDate = table.Column<bool>(type: "bit", nullable: false),
                    Female = table.Column<bool>(type: "bit", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
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
                name: "KassaActionCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false),
                    AutoDate = table.Column<bool>(type: "bit", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCategoryId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCategoryId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCategoryId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeUpCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MakeUpCategories_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id");
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCategoryId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PirsinqCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PirsinqCategories_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id");
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false),
                    AutoDate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpendCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpendCategories_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterFilials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilialId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterFilials", x => x.Id);
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KassaActionList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastOutMoneyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OutMoneyQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KassaActionList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KassaActionList_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KassaActionList_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalCount = table.Column<int>(type: "int", nullable: false),
                    SellingCount = table.Column<int>(type: "int", nullable: false),
                    RemainCount = table.Column<int>(type: "int", nullable: false),
                    AddingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BuyingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stocks_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BodyshapingAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BuyingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<int>(type: "int", nullable: false),
                    RemaingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsInjection = table.Column<bool>(type: "bit", nullable: false),
                    ReturnMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyshapingAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodyshapingAppointment_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                });

            migrationBuilder.CreateTable(
                name: "CistkaAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsInjection = table.Column<bool>(type: "bit", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IsReserved = table.Column<bool>(type: "bit", nullable: false),
                    IsStarted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    HandDescription = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FilialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CistkaAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CistkaAppointment_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CistkaAppointment_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CosmetologyAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OutTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CosmetologyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsStart = table.Column<bool>(type: "bit", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CosmetologyAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CosmetologyAppointment_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CosmetologyAppointment_Customers_CustomersId",
                        column: x => x.CustomersId,
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
                });

            migrationBuilder.CreateTable(
                name: "HairCutAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncomeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HandDescription = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FilialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairCutAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HairCutAppointment_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HairCutAppointment_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LazersAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InCompleteStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InCompleteEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImplusCount = table.Column<int>(type: "int", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false),
                    EditorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextSessionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HandDescription = table.Column<bool>(type: "bit", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsReserved = table.Column<bool>(type: "bit", nullable: false),
                    IsStarted = table.Column<bool>(type: "bit", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IsContiued = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InjectionDecription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartForSecond = table.Column<bool>(type: "bit", nullable: false),
                    EndForSecond = table.Column<bool>(type: "bit", nullable: false),
                    ReservationForSecond = table.Column<bool>(type: "bit", nullable: false),
                    PriceUpdateDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LazersAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LazersAppointment_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LazersAppointment_Customers_CustomersId",
                        column: x => x.CustomersId,
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
                });

            migrationBuilder.CreateTable(
                name: "LipuckaAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IsStart = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LipuckaAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LipuckaAppointment_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                });

            migrationBuilder.CreateTable(
                name: "MakeUpAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<int>(type: "int", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    IsReserved = table.Column<bool>(type: "bit", nullable: false),
                    IsStart = table.Column<bool>(type: "bit", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IsInjection = table.Column<bool>(type: "bit", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FilialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeUpAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MakeUpAppointment_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MakeUpAppointment_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PirsinqAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false),
                    IsStart = table.Column<bool>(type: "bit", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PirsinqAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PirsinqAppointment_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                });

            migrationBuilder.CreateTable(
                name: "SolariumAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    BuyingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RemainingMinute = table.Column<int>(type: "int", nullable: false),
                    MinuteLimit = table.Column<int>(type: "int", nullable: false),
                    UsingMinute = table.Column<int>(type: "int", nullable: false),
                    SolariumCategoriesId = table.Column<int>(type: "int", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RemainingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MoneyUpdateDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IsTimeOut = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ReturnMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolariumAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolariumAppointment_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                });

            migrationBuilder.CreateTable(
                name: "OutMoneys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpendCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutMoneys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutMoneys_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutMoneys_SpendCategories_SpendCategoryId",
                        column: x => x.SpendCategoryId,
                        principalTable: "SpendCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    IncomeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BuyingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StockId1 = table.Column<int>(type: "int", nullable: false),
                    StockId = table.Column<long>(type: "bigint", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incomes_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incomes_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incomes_Stocks_StockId1",
                        column: x => x.StockId1,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BodyShapingReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyshapingAppointmentsId = table.Column<int>(type: "int", nullable: false),
                    BodyShapingPacketsId = table.Column<int>(type: "int", nullable: false),
                    BodyShapingPacketCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyShapingReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodyShapingReports_BodyShapingPackets_BodyShapingPacketsId",
                        column: x => x.BodyShapingPacketsId,
                        principalTable: "BodyShapingPackets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BodyShapingReports_BodyshapingAppointment_BodyshapingAppointmentsId",
                        column: x => x.BodyshapingAppointmentsId,
                        principalTable: "BodyshapingAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BodyShapingSessionLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyShapingAppointmentId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    SessionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyShapingSessionLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodyShapingSessionLists_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BodyShapingSessionLists_BodyshapingAppointment_BodyShapingAppointmentId",
                        column: x => x.BodyShapingAppointmentId,
                        principalTable: "BodyshapingAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CosmetologyReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CosmetologyAppointmentId = table.Column<int>(type: "int", nullable: false),
                    CosmetologyCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CosmetologyReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CosmetologyReports_CosmetologyAppointment_CosmetologyAppointmentId",
                        column: x => x.CosmetologyAppointmentId,
                        principalTable: "CosmetologyAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CosmetologyReports_CosmetologyCategories_CosmetologyCategoryId",
                        column: x => x.CosmetologyCategoryId,
                        principalTable: "CosmetologyCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HairCutCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainCategoryId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Discount = table.Column<bool>(type: "bit", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: true),
                    HairCutAppointmentId = table.Column<int>(type: "int", nullable: true),
                    HairCutAppointmentId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairCutCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HairCutCategories_Filials_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filials",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HairCutCategories_HairCutAppointment_HairCutAppointmentId",
                        column: x => x.HairCutAppointmentId,
                        principalTable: "HairCutAppointment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HairCutCategories_HairCutAppointment_HairCutAppointmentId1",
                        column: x => x.HairCutAppointmentId1,
                        principalTable: "HairCutAppointment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HairCutCategories_HairCutCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "HairCutCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LazerAppointmentReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LazerCategoryId = table.Column<int>(type: "int", nullable: false),
                    LazerAppointmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LazerAppointmentReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LazerAppointmentReports_LazerCategories_LazerCategoryId",
                        column: x => x.LazerCategoryId,
                        principalTable: "LazerCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LazerAppointmentReports_LazersAppointment_LazerAppointmentId",
                        column: x => x.LazerAppointmentId,
                        principalTable: "LazersAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LipuckaReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LipuckaAppointmentId = table.Column<int>(type: "int", nullable: false),
                    LipuckaCategoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LipuckaReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LipuckaReports_LipuckaAppointment_LipuckaAppointmentId",
                        column: x => x.LipuckaAppointmentId,
                        principalTable: "LipuckaAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LipuckaReports_LipuckaCategories_LipuckaCategoriesId",
                        column: x => x.LipuckaCategoriesId,
                        principalTable: "LipuckaCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PirsinqReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PirsinqAppointmentId = table.Column<int>(type: "int", nullable: false),
                    PirsinqCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PirsinqReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PirsinqReports_PirsinqAppointment_PirsinqAppointmentId",
                        column: x => x.PirsinqAppointmentId,
                        principalTable: "PirsinqAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PirsinqReports_PirsinqCategories_PirsinqCategoryId",
                        column: x => x.PirsinqCategoryId,
                        principalTable: "PirsinqCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolariumUsingLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolariumAppointmentId = table.Column<int>(type: "int", nullable: false),
                    UsingMinute = table.Column<int>(type: "int", nullable: false),
                    RemainingMinute = table.Column<int>(type: "int", nullable: false),
                    UsingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolariumUsingLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolariumUsingLists_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SolariumUsingLists_SolariumAppointment_SolariumAppointmentId",
                        column: x => x.SolariumAppointmentId,
                        principalTable: "SolariumAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HairCutItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HairCutAppointmentId = table.Column<int>(type: "int", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: true),
                    IncomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairCutItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HairCutItems_HairCutAppointment_HairCutAppointmentId",
                        column: x => x.HairCutAppointmentId,
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HairCutCategoryReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HairCutAppointmentId = table.Column<int>(type: "int", nullable: false),
                    HairCutCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairCutCategoryReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HairCutCategoryReports_HairCutAppointment_HairCutAppointmentId",
                        column: x => x.HairCutAppointmentId,
                        principalTable: "HairCutAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HairCutCategoryReports_HairCutCategories_HairCutCategoryId",
                        column: x => x.HairCutCategoryId,
                        principalTable: "HairCutCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FilialId",
                table: "AspNetUsers",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "IX_BodyShapingReports_BodyshapingAppointmentsId",
                table: "BodyShapingReports",
                column: "BodyshapingAppointmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyShapingReports_BodyShapingPacketsId",
                table: "BodyShapingReports",
                column: "BodyShapingPacketsId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyShapingSessionLists_AppUserId",
                table: "BodyShapingSessionLists",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyShapingSessionLists_BodyShapingAppointmentId",
                table: "BodyShapingSessionLists",
                column: "BodyShapingAppointmentId");

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
                name: "IX_CosmetologyAppointment_AppUserId",
                table: "CosmetologyAppointment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CosmetologyAppointment_CustomersId",
                table: "CosmetologyAppointment",
                column: "CustomersId");

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
                name: "IX_CosmetologyReports_CosmetologyAppointmentId",
                table: "CosmetologyReports",
                column: "CosmetologyAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CosmetologyReports_CosmetologyCategoryId",
                table: "CosmetologyReports",
                column: "CosmetologyCategoryId");

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
                name: "IX_HairCutCategories_HairCutAppointmentId",
                table: "HairCutCategories",
                column: "HairCutAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutCategories_HairCutAppointmentId1",
                table: "HairCutCategories",
                column: "HairCutAppointmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutCategories_MainCategoryId",
                table: "HairCutCategories",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutCategoryReports_HairCutAppointmentId",
                table: "HairCutCategoryReports",
                column: "HairCutAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutCategoryReports_HairCutCategoryId",
                table: "HairCutCategoryReports",
                column: "HairCutCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutItems_HairCutAppointmentId",
                table: "HairCutItems",
                column: "HairCutAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutItems_IncomeId",
                table: "HairCutItems",
                column: "IncomeId");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutItems_StockId",
                table: "HairCutItems",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_AppUserId",
                table: "Incomes",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_FilialId",
                table: "Incomes",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_StockId1",
                table: "Incomes",
                column: "StockId1");

            migrationBuilder.CreateIndex(
                name: "IX_KassaActionCategories_FilialId",
                table: "KassaActionCategories",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_KassaActionList_AppUserId",
                table: "KassaActionList",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_KassaActionList_FilialId",
                table: "KassaActionList",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_LazerAppointmentReports_LazerAppointmentId",
                table: "LazerAppointmentReports",
                column: "LazerAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LazerAppointmentReports_LazerCategoryId",
                table: "LazerAppointmentReports",
                column: "LazerCategoryId");

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
                name: "IX_LazersAppointment_CustomersId",
                table: "LazersAppointment",
                column: "CustomersId");

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
                name: "IX_LipuckaReports_LipuckaAppointmentId",
                table: "LipuckaReports",
                column: "LipuckaAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LipuckaReports_LipuckaCategoriesId",
                table: "LipuckaReports",
                column: "LipuckaCategoriesId");

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
                name: "IX_MasterFilials_FilialId",
                table: "MasterFilials",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterFilials_MasterId",
                table: "MasterFilials",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_OutMoneys_AppUserId",
                table: "OutMoneys",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OutMoneys_SpendCategoryId",
                table: "OutMoneys",
                column: "SpendCategoryId");

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
                name: "IX_PirsinqReports_PirsinqAppointmentId",
                table: "PirsinqReports",
                column: "PirsinqAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PirsinqReports_PirsinqCategoryId",
                table: "PirsinqReports",
                column: "PirsinqCategoryId");

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
                name: "IX_SolariumUsingLists_AppUserId",
                table: "SolariumUsingLists",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SolariumUsingLists_SolariumAppointmentId",
                table: "SolariumUsingLists",
                column: "SolariumAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SpendCategories_FilialId",
                table: "SpendCategories",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_AppUserId",
                table: "Stocks",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_FilialId",
                table: "Stocks",
                column: "FilialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BodyShapingReports");

            migrationBuilder.DropTable(
                name: "BodyShapingSessionLists");

            migrationBuilder.DropTable(
                name: "CistkaAppointment");

            migrationBuilder.DropTable(
                name: "CistkaCategories");

            migrationBuilder.DropTable(
                name: "CosmetologyReports");

            migrationBuilder.DropTable(
                name: "HairCutCategoryReports");

            migrationBuilder.DropTable(
                name: "HairCutItems");

            migrationBuilder.DropTable(
                name: "KassaActionCategories");

            migrationBuilder.DropTable(
                name: "KassaActionList");

            migrationBuilder.DropTable(
                name: "LazerAppointmentReports");

            migrationBuilder.DropTable(
                name: "LipuckaReports");

            migrationBuilder.DropTable(
                name: "MakeUpAppointment");

            migrationBuilder.DropTable(
                name: "MakeUpCategories");

            migrationBuilder.DropTable(
                name: "MasterFilials");

            migrationBuilder.DropTable(
                name: "MasterPositions");

            migrationBuilder.DropTable(
                name: "OutMoneys");

            migrationBuilder.DropTable(
                name: "PirsinqReports");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "SolariumUsingLists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "BodyShapingPackets");

            migrationBuilder.DropTable(
                name: "BodyshapingAppointment");

            migrationBuilder.DropTable(
                name: "CosmetologyAppointment");

            migrationBuilder.DropTable(
                name: "CosmetologyCategories");

            migrationBuilder.DropTable(
                name: "HairCutCategories");

            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.DropTable(
                name: "LazerCategories");

            migrationBuilder.DropTable(
                name: "LazersAppointment");

            migrationBuilder.DropTable(
                name: "LipuckaAppointment");

            migrationBuilder.DropTable(
                name: "LipuckaCategories");

            migrationBuilder.DropTable(
                name: "SpendCategories");

            migrationBuilder.DropTable(
                name: "PirsinqAppointment");

            migrationBuilder.DropTable(
                name: "PirsinqCategories");

            migrationBuilder.DropTable(
                name: "SolariumAppointment");

            migrationBuilder.DropTable(
                name: "HairCutAppointment");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "SolariumCategories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Masters");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Filials");
        }
    }
}
