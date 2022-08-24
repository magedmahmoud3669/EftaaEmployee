using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lookups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lookups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LookupsValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LookupsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupsValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LookupsValue_Lookups_LookupsId",
                        column: x => x.LookupsId,
                        principalTable: "Lookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ScoialStatusId = table.Column<int>(type: "int", nullable: true),
                    CurrentFiqhSchoolId = table.Column<int>(type: "int", nullable: true),
                    LastFiqhSchoolId = table.Column<int>(type: "int", nullable: true),
                    FiqhInPreparatorySchoolId = table.Column<int>(type: "int", nullable: true),
                    FiqhInSecondarySchoolId = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressInCairo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressOutCairo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChangingReason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_LookupsValue_CurrentFiqhSchoolId",
                        column: x => x.CurrentFiqhSchoolId,
                        principalTable: "LookupsValue",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_LookupsValue_FiqhInPreparatorySchoolId",
                        column: x => x.FiqhInPreparatorySchoolId,
                        principalTable: "LookupsValue",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_LookupsValue_FiqhInSecondarySchoolId",
                        column: x => x.FiqhInSecondarySchoolId,
                        principalTable: "LookupsValue",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_LookupsValue_LastFiqhSchoolId",
                        column: x => x.LastFiqhSchoolId,
                        principalTable: "LookupsValue",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_LookupsValue_ScoialStatusId",
                        column: x => x.ScoialStatusId,
                        principalTable: "LookupsValue",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CurrentFiqhSchoolId",
                table: "Employees",
                column: "CurrentFiqhSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FiqhInPreparatorySchoolId",
                table: "Employees",
                column: "FiqhInPreparatorySchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FiqhInSecondarySchoolId",
                table: "Employees",
                column: "FiqhInSecondarySchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_LastFiqhSchoolId",
                table: "Employees",
                column: "LastFiqhSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ScoialStatusId",
                table: "Employees",
                column: "ScoialStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_LookupsValue_LookupsId",
                table: "LookupsValue",
                column: "LookupsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "LookupsValue");

            migrationBuilder.DropTable(
                name: "Lookups");
        }
    }
}
