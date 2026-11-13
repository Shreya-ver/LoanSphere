using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanSphere.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanApplications",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicantName = table.Column<string>(type: "text", nullable: false),
                    PAN = table.Column<string>(type: "text", nullable: false),
                    RequestedAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    TenureMonths = table.Column<int>(type: "integer", nullable: false),
                    AnnualInterestRate = table.Column<decimal>(type: "numeric", nullable: false),
                    InterestPaymentFrequency = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanApplications", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanApplications");
        }
    }
}
