using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaNexos.Migrations
{
    public partial class Inicial_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicoPacientes",
                columns: table => new
                {
                    Id_MedicoPaciente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Paciente_Id = table.Column<int>(nullable: false),
                    Medico_Id = table.Column<int>(nullable: false),
                    FechaHora = table.Column<DateTime>(nullable: false),
                    Activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoPacientes", x => x.Id_MedicoPaciente);
                    table.ForeignKey(
                        name: "FK_MEDP_MED",
                        column: x => x.Medico_Id,
                        principalTable: "Medicos",
                        principalColumn: "Id_Medico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MEDP_PAC",
                        column: x => x.Paciente_Id,
                        principalTable: "Pacientes",
                        principalColumn: "Id_Paciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicoPacientes_Medico_Id",
                table: "MedicoPacientes",
                column: "Medico_Id");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoPacientes_Paciente_Id",
                table: "MedicoPacientes",
                column: "Paciente_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicoPacientes");
        }
    }
}
