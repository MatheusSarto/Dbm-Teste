using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dbm.Api.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false),
                    Endereco = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "StatusProtocolos",
                columns: table => new
                {
                    IdStatus = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeStatus = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusProtocolos", x => x.IdStatus);
                });

            migrationBuilder.CreateTable(
                name: "Protocolo",
                columns: table => new
                {
                    IdProtocolo = table.Column<long>(type: "BIGINT", nullable: false),
                    Titulo = table.Column<string>(type: "NVARCHAR(128)", maxLength: 128, nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR(280)", maxLength: 280, nullable: false),
                    DataAbertura = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "getdate()"),
                    DataFechamento = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    ClienteId = table.Column<long>(type: "BIGINT", nullable: false),
                    ProtocoloStatusId = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protocolo", x => x.IdProtocolo);
                    table.ForeignKey(
                        name: "FK_Protocolo_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Protocolo_StatusProtocolos_IdProtocolo",
                        column: x => x.IdProtocolo,
                        principalTable: "StatusProtocolos",
                        principalColumn: "IdStatus",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProtocoloFollow",
                columns: table => new
                {
                    IdFollow = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProtocoloId = table.Column<long>(type: "BIGINT", nullable: false),
                    DataAcao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "getdate()"),
                    DescricaoAcao = table.Column<string>(type: "NVARCHAR(280)", maxLength: 280, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtocoloFollow", x => x.IdFollow);
                    table.ForeignKey(
                        name: "FK_ProtocoloFollow_Protocolo_ProtocoloId",
                        column: x => x.ProtocoloId,
                        principalTable: "Protocolo",
                        principalColumn: "IdProtocolo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Protocolo_ClienteId",
                table: "Protocolo",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocoloFollow_ProtocoloId",
                table: "ProtocoloFollow",
                column: "ProtocoloId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProtocoloFollow");

            migrationBuilder.DropTable(
                name: "Protocolo");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "StatusProtocolos");
        }
    }
}
