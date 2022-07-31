using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APITelefonia.Migrations
{
    public partial class MigrationV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id_estado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id_estado);
                });

            migrationBuilder.CreateTable(
                name: "Fabricante",
                columns: table => new
                {
                    Id_fab = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fab_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fab_desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricante", x => x.Id_fab);
                });

            migrationBuilder.CreateTable(
                name: "Terminal",
                columns: table => new
                {
                    Id_terminal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_fab = table.Column<int>(type: "int", nullable: false),
                    Id_estado = table.Column<int>(type: "int", nullable: false),
                    Fecha_fabricacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_estado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Terminal_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Terminal_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminal", x => x.Id_terminal);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Fabricante");

            migrationBuilder.DropTable(
                name: "Terminal");
        }
    }
}
