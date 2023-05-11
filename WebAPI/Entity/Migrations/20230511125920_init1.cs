using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumHouse = table.Column<int>(type: "int", nullable: false),
                    Date_of_birth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Corona_Details",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    recoveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    memberId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corona_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Corona_Details_Members_memberId",
                        column: x => x.memberId,
                        principalTable: "Members",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vaccines",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccineDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    vaccine_manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    memberIdentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    memberId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaccines_Members_memberId",
                        column: x => x.memberId,
                        principalTable: "Members",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Corona_Details_memberId",
                table: "Corona_Details",
                column: "memberId",
                unique: true,
                filter: "[memberId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccines_memberId",
                table: "Vaccines",
                column: "memberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Corona_Details");

            migrationBuilder.DropTable(
                name: "Vaccines");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
