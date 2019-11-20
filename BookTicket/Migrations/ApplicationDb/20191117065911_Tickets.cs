using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookTicket.Migrations.ApplicationDb
{
    public partial class Tickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TicketBiletNumberId",
                table: "Movies",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    BiletNumberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullorEmpty = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.BiletNumberId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_TicketBiletNumberId",
                table: "Movies",
                column: "TicketBiletNumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Tickets_TicketBiletNumberId",
                table: "Movies",
                column: "TicketBiletNumberId",
                principalTable: "Tickets",
                principalColumn: "BiletNumberId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Tickets_TicketBiletNumberId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Movies_TicketBiletNumberId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "TicketBiletNumberId",
                table: "Movies");
        }
    }
}
