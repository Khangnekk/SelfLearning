using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst_WebAPI.Migrations
{
    public partial class DbVersion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PlayerInstruments_InstrumentTypeId",
                table: "PlayerInstruments",
                column: "InstrumentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerInstruments_InstrumentTypes_InstrumentTypeId",
                table: "PlayerInstruments",
                column: "InstrumentTypeId",
                principalTable: "InstrumentTypes",
                principalColumn: "InstrumentTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerInstruments_InstrumentTypes_InstrumentTypeId",
                table: "PlayerInstruments");

            migrationBuilder.DropIndex(
                name: "IX_PlayerInstruments_InstrumentTypeId",
                table: "PlayerInstruments");
        }
    }
}
