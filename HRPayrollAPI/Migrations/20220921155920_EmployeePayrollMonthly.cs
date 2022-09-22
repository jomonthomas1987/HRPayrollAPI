using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrollAPI.Migrations
{
    public partial class EmployeePayrollMonthly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0354acd-9219-4621-ba32-282db259c081",
                column: "ConcurrencyStamp",
                value: "8cf32e7f-75b8-41b7-a5a9-8d46c07d163d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccce14b5-123c-4166-981c-21e23aaef4c2",
                column: "ConcurrencyStamp",
                value: "949bd004-238a-4a72-9c8c-754e220a3cfb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "330ff8fa-a471-4bf7-8011-21bab7a7a23b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b74411cc-e365-481c-9018-57327bcf9c82", "AQAAAAEAACcQAAAAEIk7vMZ2HbXOLqMfNR+xLiNuaPX4hbeV4m5m2B0nvSIyhDvfr5ikTueSG6P/8xYWwA==", "f4b00a1e-95eb-4574-b4c1-7e944e1fdcd7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0354acd-9219-4621-ba32-282db259c081",
                column: "ConcurrencyStamp",
                value: "00f4fe69-167c-4a49-9dc1-ec0eee05be85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccce14b5-123c-4166-981c-21e23aaef4c2",
                column: "ConcurrencyStamp",
                value: "ca9911d7-3662-4ddb-acd8-df217eb48dd9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "330ff8fa-a471-4bf7-8011-21bab7a7a23b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d43466c3-8718-493f-bb3d-7a1ee23ac5e7", "AQAAAAEAACcQAAAAEB1Ygp79IPDXQ2/7lyyaY///RFuYQsBoHEoLWtLegc3rtuli566iAQeiWEtlhrxPlw==", "e74bd37c-9bc1-4c23-bdd6-0009d532cabf" });
        }
    }
}
