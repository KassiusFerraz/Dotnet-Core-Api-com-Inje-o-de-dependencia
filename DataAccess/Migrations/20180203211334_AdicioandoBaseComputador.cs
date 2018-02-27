using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DataAccess.Migrations
{
    public partial class AdicioandoBaseComputador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computadores",
                columns: table => new
                {
                    IdCompuatador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Disponivel = table.Column<bool>(nullable: false),
                    PlacaDeVideo = table.Column<string>(nullable: true),
                    Processador = table.Column<string>(nullable: false),
                    QtdEspacoHd = table.Column<int>(nullable: false),
                    QtdMemoriaRam = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computadores", x => x.IdCompuatador);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computadores");
        }
    }
}
