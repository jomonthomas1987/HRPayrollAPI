using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrollAPI.Migrations
{
    public partial class EmployeePayroll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeePayrolls",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SalaryId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Basicpay = table.Column<float>(type: "real", nullable: false),
                    HRA = table.Column<float>(type: "real", nullable: false),
                    ConveyanceAllowance = table.Column<float>(type: "real", nullable: false),
                    DeductionAmount = table.Column<float>(type: "real", nullable: false),
                    DeductionReason = table.Column<float>(type: "real", nullable: false),
                    Active = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePayrolls", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeePayrolls");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0354acd-9219-4621-ba32-282db259c081",
                column: "ConcurrencyStamp",
                value: "fd71e504-c8f2-4562-aa6e-c58d6910c920");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccce14b5-123c-4166-981c-21e23aaef4c2",
                column: "ConcurrencyStamp",
                value: "0fc76769-8252-491e-bb2f-7d3a795ea370");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "330ff8fa-a471-4bf7-8011-21bab7a7a23b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a98f1c0-2646-4b4d-af8d-5afafcdf4189", "AQAAAAEAACcQAAAAEFWhWB3K7yZAZbIdeUKqaJ8sLdxkKhAuEWn2x/I9h12xKwsIMCOUXS/MU7vn4cAD9A==", "5333c55b-9a2f-451d-a017-32e473a01575" });
        }
    }
}
