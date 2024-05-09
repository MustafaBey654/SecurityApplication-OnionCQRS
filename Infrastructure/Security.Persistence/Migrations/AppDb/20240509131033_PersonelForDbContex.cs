using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Security.Persistence.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class PersonelForDbContex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarPlates",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryDate",
                value: new DateTime(2024, 5, 9, 16, 10, 32, 351, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "CarPlates",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryDate",
                value: new DateTime(2024, 5, 9, 16, 10, 32, 351, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "CarPlates",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryDate",
                value: new DateTime(2024, 5, 9, 16, 10, 32, 351, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "CarPlates",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryDate",
                value: new DateTime(2024, 5, 9, 16, 10, 32, 351, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "CarPlates",
                keyColumn: "Id",
                keyValue: 5,
                column: "EntryDate",
                value: new DateTime(2024, 5, 9, 16, 10, 32, 351, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "00cf295d-0182-4e4f-9ca5-07de0278869d", "Şadan", "Çamdalı" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "ea2208d0-96d0-47b8-887d-2971aed6ca8e", "Şadan", "Çamdalı" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "20a42d2d-0fc0-4b5c-aaa2-2e8e37532d18", "Şadan", "Çamdalı" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "875a0986-b37b-4277-afd6-37331189d9cf", "Şadan", "Çamdalı" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "7643b32d-148c-4b84-b7c3-c38efaf7c5c0", "Şadan", "Çamdalı" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "80aec085-d3fd-438f-960b-64e37ac91dbe", "Şadan", "Çamdalı" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "44325c18-0c4c-47b6-81b4-b0af084de62e", "Şadan", "Çamdalı" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "1bbcf8d0-6bf4-4ac2-9810-a2e3e821d4ad", "Şadan", "Çamdalı" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "ee7bbed2-869a-4678-af3e-391c57f0341e", "Şadan", "Çamdalı" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "eb32c43d-ed65-41a0-828f-2db6642fca95", "Şadan", "Çamdalı" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EntryDate", "FirstName", "IdentityNumber", "LastName" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 10, 32, 356, DateTimeKind.Local).AddTicks(1014), "Özden", "195605050599", "Aybar" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EntryDate", "FirstName", "IdentityNumber", "LastName", "ReleaseDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 10, 32, 356, DateTimeKind.Local).AddTicks(3592), "Özden", "195605050599", "Aybar", new DateTime(2024, 5, 9, 16, 10, 32, 356, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EntryDate", "FirstName", "IdentityNumber", "LastName" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 10, 32, 356, DateTimeKind.Local).AddTicks(3604), "Özden", "195605050599", "Aybar" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EntryDate", "FirstName", "IdentityNumber", "LastName", "ReleaseDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 10, 32, 356, DateTimeKind.Local).AddTicks(3607), "Özden", "195605050599", "Aybar", new DateTime(2024, 5, 9, 16, 10, 32, 356, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EntryDate", "FirstName", "IdentityNumber", "LastName", "ReleaseDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 10, 32, 356, DateTimeKind.Local).AddTicks(3610), "Özden", "195605050599", "Aybar", new DateTime(2024, 5, 9, 16, 10, 32, 356, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EntryDate", "FirstName", "IdentityNumber", "LastName" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 10, 32, 356, DateTimeKind.Local).AddTicks(3613), "Özden", "195605050599", "Aybar" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarPlates",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryDate",
                value: new DateTime(2024, 5, 7, 16, 35, 37, 408, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "CarPlates",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryDate",
                value: new DateTime(2024, 5, 7, 16, 35, 37, 408, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "CarPlates",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryDate",
                value: new DateTime(2024, 5, 7, 16, 35, 37, 408, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "CarPlates",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryDate",
                value: new DateTime(2024, 5, 7, 16, 35, 37, 408, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "CarPlates",
                keyColumn: "Id",
                keyValue: 5,
                column: "EntryDate",
                value: new DateTime(2024, 5, 7, 16, 35, 37, 408, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "ec90e142-3bbf-4433-91ed-c80b6aa7ffa1", "Derya", "Yorulmaz" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "4ac75fea-96a3-41bf-88a8-70c43876dc99", "Derya", "Yorulmaz" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "b1b12da6-dea2-4705-8bea-8e469e72762a", "Derya", "Yorulmaz" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "78068992-96bb-4508-8c77-16fc1afefd16", "Derya", "Yorulmaz" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "394a923a-dcf6-44dd-aa9e-9d442a7ee5f4", "Derya", "Yorulmaz" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "1f448e56-c23c-4500-8f26-123db0be28fa", "Derya", "Yorulmaz" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "5e876096-746b-4b3d-895c-261be11ecedd", "Derya", "Yorulmaz" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "decbeb94-8f26-410b-99fc-c3a78d207488", "Derya", "Yorulmaz" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "f844e5a2-22ce-49f9-81c7-405478c29699", "Derya", "Yorulmaz" });

            migrationBuilder.UpdateData(
                table: "Personels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "c9ad527d-77f2-4c9f-8dec-5e6e880761eb", "Derya", "Yorulmaz" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EntryDate", "FirstName", "IdentityNumber", "LastName" },
                values: new object[] { new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(2779), "Tanyeli", "197612153960", "Gümüşpala" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EntryDate", "FirstName", "IdentityNumber", "LastName", "ReleaseDate" },
                values: new object[] { new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4137), "Tanyeli", "197612153960", "Gümüşpala", new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EntryDate", "FirstName", "IdentityNumber", "LastName" },
                values: new object[] { new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4144), "Tanyeli", "197612153960", "Gümüşpala" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EntryDate", "FirstName", "IdentityNumber", "LastName", "ReleaseDate" },
                values: new object[] { new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4146), "Tanyeli", "197612153960", "Gümüşpala", new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EntryDate", "FirstName", "IdentityNumber", "LastName", "ReleaseDate" },
                values: new object[] { new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4149), "Tanyeli", "197612153960", "Gümüşpala", new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EntryDate", "FirstName", "IdentityNumber", "LastName" },
                values: new object[] { new DateTime(2024, 5, 7, 16, 35, 37, 412, DateTimeKind.Local).AddTicks(4151), "Tanyeli", "197612153960", "Gümüşpala" });
        }
    }
}
