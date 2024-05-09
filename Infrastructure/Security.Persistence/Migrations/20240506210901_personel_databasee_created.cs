using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Security.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class personel_databasee_created : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarPlate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPersonel = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPlate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ServerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatabaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Personel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonelChartOfAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonelType = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelChartOfAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unit_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visitor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarPlateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JobInterview = table.Column<bool>(type: "bit", nullable: false),
                    Visit = table.Column<bool>(type: "bit", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    UnitId = table.Column<int>(type: "int", nullable: true),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visitor_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonelUnit",
                columns: table => new
                {
                    PersonelsId = table.Column<int>(type: "int", nullable: false),
                    unitsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelUnit", x => new { x.PersonelsId, x.unitsId });
                    table.ForeignKey(
                        name: "FK_PersonelUnit_Personel_PersonelsId",
                        column: x => x.PersonelsId,
                        principalTable: "Personel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonelUnit_Unit_unitsId",
                        column: x => x.unitsId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branch",
                columns: new[] { "Id", "BranchName", "IsDeleted" },
                values: new object[,]
                {
                    { 1, "İdari Mali İşler Şube Müdürlüğü", false },
                    { 2, "Destek Hizmetleri Şube Müdürlüğü", false },
                    { 3, "Personel Şube Müdürlüğü", false },
                    { 4, "Eğitim Şube Müdürlüğü", false },
                    { 5, "Öğrenci İşleri Şube Müdürlüğü", false },
                    { 6, "Pomem Şube Müdürlüğü", false }
                });

            migrationBuilder.InsertData(
                table: "CarPlate",
                columns: new[] { "Id", "EntryDate", "IsDeleted", "IsPersonel", "PlateName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 7, 0, 9, 0, 635, DateTimeKind.Local).AddTicks(2996), false, true, "69 AAA 13" },
                    { 2, new DateTime(2024, 5, 7, 0, 9, 0, 635, DateTimeKind.Local).AddTicks(3022), false, false, "69 AB 25" },
                    { 3, new DateTime(2024, 5, 7, 0, 9, 0, 635, DateTimeKind.Local).AddTicks(3023), false, true, "25 ACH 361" },
                    { 4, new DateTime(2024, 5, 7, 0, 9, 0, 635, DateTimeKind.Local).AddTicks(3024), false, false, "34 PLK 45" },
                    { 5, new DateTime(2024, 5, 7, 0, 9, 0, 635, DateTimeKind.Local).AddTicks(3024), false, false, "69 AS 89" }
                });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DatabaseName", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ServerName", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "0e7341dd-04e0-4c65-9095-2128387ea789", null, null, false, "İlayda", false, "Erçetin", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 2, 0, "e146bd80-8afd-4cf7-84bc-acd480f42674", null, null, false, "İlayda", false, "Erçetin", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 3, 0, "c1bf7932-0422-47f7-b7f7-93f141250da9", null, null, false, "İlayda", false, "Erçetin", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 4, 0, "19ef57db-a01c-4767-808a-4a066ea2068f", null, null, false, "İlayda", false, "Erçetin", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 5, 0, "184e8bf5-7831-476c-87e2-ea1be05b87c8", null, null, false, "İlayda", true, "Erçetin", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 6, 0, "7eb462fe-aff6-4b82-a6c4-cdfb0edf76af", null, null, false, "İlayda", false, "Erçetin", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 7, 0, "1c170303-c425-49ef-8887-c49af5b6fbc6", null, null, false, "İlayda", false, "Erçetin", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 8, 0, "3e3c73a4-9b65-4a2f-9ef5-7c1f7ed9a51e", null, null, false, "İlayda", false, "Erçetin", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 9, 0, "a880e9f1-fb5a-4329-b8ac-6430e3d13f2a", null, null, false, "İlayda", false, "Erçetin", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 10, 0, "a0b6c049-f58d-43ca-9aeb-9ea045e64ee6", null, null, false, "İlayda", true, "Erçetin", false, null, null, null, null, null, null, false, null, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Unit",
                columns: new[] { "Id", "BranchId", "IsDeleted", "UnitName" },
                values: new object[,]
                {
                    { 1, 1, false, "Satın Alma Büro Amirliği" },
                    { 2, 1, false, "Tahakkuk Büro Amirliği" },
                    { 3, 2, false, "Atış Büro Amirliği" },
                    { 4, 3, false, "Personel Kayıt Amirliği" },
                    { 5, 4, false, "Öğrenci Özlük Amirliği" },
                    { 6, 6, false, "Belge Yönetimi Amirliği" }
                });

            migrationBuilder.InsertData(
                table: "Visitor",
                columns: new[] { "Id", "BranchId", "CarPlateName", "EntryDate", "FirstName", "IdentityNumber", "IsDeleted", "JobInterview", "LastName", "PersonelId", "ReleaseDate", "UnitId", "Visit" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2024, 5, 7, 0, 9, 0, 643, DateTimeKind.Local).AddTicks(9097), "Işıl", "199308296442", false, true, "Karabulut", 1, null, null, false },
                    { 2, null, null, new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1413), "Işıl", "199308296442", false, true, "Karabulut", 1, new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1419), 2, false },
                    { 3, 3, null, new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1421), "Işıl", "199308296442", true, true, "Karabulut", 1, null, null, false },
                    { 4, null, null, new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1423), "Işıl", "199308296442", false, true, "Karabulut", 1, new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1425), 4, false },
                    { 5, 2, null, new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1426), "Işıl", "199308296442", false, true, "Karabulut", 1, new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1428), null, false },
                    { 6, 5, null, new DateTime(2024, 5, 7, 0, 9, 0, 644, DateTimeKind.Local).AddTicks(1429), "Işıl", "199308296442", true, true, "Karabulut", 1, null, null, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonelUnit_unitsId",
                table: "PersonelUnit",
                column: "unitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_BranchId",
                table: "Unit",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitor_PersonelId",
                table: "Visitor",
                column: "PersonelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarPlate");

            migrationBuilder.DropTable(
                name: "PersonelChartOfAccounts");

            migrationBuilder.DropTable(
                name: "PersonelUnit");

            migrationBuilder.DropTable(
                name: "Visitor");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "Branch");
        }
    }
}
