using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Security.Persistence.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class branch_cqrs_update : Migration
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarPlates",
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
                    table.PrimaryKey("PK_CarPlates", x => x.Id);
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
                name: "Personels",
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
                    table.PrimaryKey("PK_Personels", x => x.Id);
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
                name: "Units",
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
                    table.PrimaryKey("PK_Units", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Units_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
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
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visitors_Personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchAndUnitRelationShips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    UnitId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchAndUnitRelationShips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchAndUnitRelationShips_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BranchAndUnitRelationShips_Personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchAndUnitRelationShips_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id");
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
                        name: "FK_PersonelUnit_Personels_PersonelsId",
                        column: x => x.PersonelsId,
                        principalTable: "Personels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonelUnit_Units_unitsId",
                        column: x => x.unitsId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branches",
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
                table: "CarPlates",
                columns: new[] { "Id", "EntryDate", "IsDeleted", "IsPersonel", "PlateName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 7, 16, 35, 37, 408, DateTimeKind.Local).AddTicks(2995), false, true, "69 AAA 13" },
                    { 2, new DateTime(2024, 5, 7, 16, 35, 37, 408, DateTimeKind.Local).AddTicks(3014), false, false, "69 AB 25" },
                    { 3, new DateTime(2024, 5, 7, 16, 35, 37, 408, DateTimeKind.Local).AddTicks(3015), false, true, "25 ACH 361" },
                    { 4, new DateTime(2024, 5, 7, 16, 35, 37, 408, DateTimeKind.Local).AddTicks(3015), false, false, "34 PLK 45" },
                    { 5, new DateTime(2024, 5, 7, 16, 35, 37, 408, DateTimeKind.Local).AddTicks(3016), false, false, "69 AS 89" }
                });

            migrationBuilder.InsertData(
                table: "Personels",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DatabaseName", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ServerName", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "ec90e142-3bbf-4433-91ed-c80b6aa7ffa1", null, null, false, "Derya", false, "Yorulmaz", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 2, 0, "4ac75fea-96a3-41bf-88a8-70c43876dc99", null, null, false, "Derya", false, "Yorulmaz", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 3, 0, "b1b12da6-dea2-4705-8bea-8e469e72762a", null, null, false, "Derya", false, "Yorulmaz", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 4, 0, "78068992-96bb-4508-8c77-16fc1afefd16", null, null, false, "Derya", false, "Yorulmaz", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 5, 0, "394a923a-dcf6-44dd-aa9e-9d442a7ee5f4", null, null, false, "Derya", true, "Yorulmaz", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 6, 0, "1f448e56-c23c-4500-8f26-123db0be28fa", null, null, false, "Derya", false, "Yorulmaz", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 7, 0, "5e876096-746b-4b3d-895c-261be11ecedd", null, null, false, "Derya", false, "Yorulmaz", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 8, 0, "decbeb94-8f26-410b-99fc-c3a78d207488", null, null, false, "Derya", false, "Yorulmaz", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 9, 0, "f844e5a2-22ce-49f9-81c7-405478c29699", null, null, false, "Derya", false, "Yorulmaz", false, null, null, null, null, null, null, false, null, null, false, null, null },
                    { 10, 0, "c9ad527d-77f2-4c9f-8dec-5e6e880761eb", null, null, false, "Derya", true, "Yorulmaz", false, null, null, null, null, null, null, false, null, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Units",
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
                table: "Visitors",
                columns: new[] { "Id", "BranchId", "CarPlateName", "EntryDate", "FirstName", "IdentityNumber", "IsDeleted", "JobInterview", "LastName", "PersonelId", "ReleaseDate", "UnitId", "Visit" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(2779), "Tanyeli", "197612153960", false, true, "Gümüşpala", 1, null, null, false },
                    { 2, null, null, new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4137), "Tanyeli", "197612153960", false, true, "Gümüşpala", 1, new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4142), 2, false },
                    { 3, 3, null, new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4144), "Tanyeli", "197612153960", true, true, "Gümüşpala", 1, null, null, false },
                    { 4, null, null, new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4146), "Tanyeli", "197612153960", false, true, "Gümüşpala", 1, new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4148), 4, false },
                    { 5, 2, null, new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4149), "Tanyeli", "197612153960", false, true, "Gümüşpala", 1, new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4151), null, false },
                    { 6, 5, null, new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4151), "Tanyeli", "197612153960", true, true, "Gümüşpala", 1, null, null, false }
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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BranchAndUnitRelationShips_BranchId",
                table: "BranchAndUnitRelationShips",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchAndUnitRelationShips_PersonelId",
                table: "BranchAndUnitRelationShips",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchAndUnitRelationShips_UnitId",
                table: "BranchAndUnitRelationShips",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelUnit_unitsId",
                table: "PersonelUnit",
                column: "unitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_BranchId",
                table: "Units",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_PersonelId",
                table: "Visitors",
                column: "PersonelId");
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
                name: "BranchAndUnitRelationShips");

            migrationBuilder.DropTable(
                name: "CarPlates");

            migrationBuilder.DropTable(
                name: "PersonelChartOfAccounts");

            migrationBuilder.DropTable(
                name: "PersonelUnit");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
