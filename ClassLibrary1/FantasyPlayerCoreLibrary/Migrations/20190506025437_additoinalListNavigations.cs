using Microsoft.EntityFrameworkCore.Migrations;

namespace StraussDa.FantasyPlayerCoreLibrary.Migrations
{
    public partial class additoinalListNavigations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "PlayerRanking",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerRanking_PlayerId",
                table: "PlayerRanking",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerRanking_Player_PlayerId",
                table: "PlayerRanking",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerRanking_Player_PlayerId",
                table: "PlayerRanking");

            migrationBuilder.DropIndex(
                name: "IX_PlayerRanking_PlayerId",
                table: "PlayerRanking");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "PlayerRanking");
        }
    }
}
