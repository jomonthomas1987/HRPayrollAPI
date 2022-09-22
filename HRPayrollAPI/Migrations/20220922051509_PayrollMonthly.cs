using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrollAPI.Migrations
{
    public partial class PayrollMonthly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeePayrollMonthly",
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
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePayrollMonthly", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0354acd-9219-4621-ba32-282db259c081",
                column: "ConcurrencyStamp",
                value: "3a4f42d5-c5ac-4050-8ab9-b2bd2155e8a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccce14b5-123c-4166-981c-21e23aaef4c2",
                column: "ConcurrencyStamp",
                value: "d0933ce2-907e-4e47-aa5d-4ce3d698c858");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "330ff8fa-a471-4bf7-8011-21bab7a7a23b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc7e3fec-3308-4a93-a754-ef8e901f6143", "AQAAAAEAACcQAAAAEJlUfpsGS0yMiyYyv2Uyj4MAH+Wsrdlo/Fq3xQL+kZRtV93OFFlnQ6EW9knsZJv5nQ==", "006a03be-2618-49f2-ba33-91eeb5e99a43" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeePayrollMonthly");

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
    }
}
