using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst_WebAPI.Migrations
{
    public partial class DbVersion3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InstrumentTypes",
                columns: new[] { "InstrumentTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Acoustic Guitar" },
                    { 2, "Electric Guitar" },
                    { 3, "Drums" },
                    { 4, "Bass" },
                    { 5, "Keyboard" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "JoinedDate", "NickName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 7, 14, 41, 1, 491, DateTimeKind.Local).AddTicks(1962), "Khang" },
                    { 2, new DateTime(2024, 5, 7, 14, 41, 1, 491, DateTimeKind.Local).AddTicks(1971), "Hoang" }
                });

            migrationBuilder.InsertData(
                table: "PlayerInstruments",
                columns: new[] { "PlayerInstrumentId", "InstrumentTypeId", "Level", "ModelName", "PlayerId" },
                values: new object[] { 1, 1, "Good", "Gui", 1 });

            migrationBuilder.InsertData(
                table: "PlayerInstruments",
                columns: new[] { "PlayerInstrumentId", "InstrumentTypeId", "Level", "ModelName", "PlayerId" },
                values: new object[] { 2, 1, "Good", "Gui", 2 });

            migrationBuilder.InsertData(
                table: "PlayerInstruments",
                columns: new[] { "PlayerInstrumentId", "InstrumentTypeId", "Level", "ModelName", "PlayerId" },
                values: new object[] { 3, 2, "Good", "Gui", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InstrumentTypes",
                keyColumn: "InstrumentTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InstrumentTypes",
                keyColumn: "InstrumentTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InstrumentTypes",
                keyColumn: "InstrumentTypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PlayerInstruments",
                keyColumn: "PlayerInstrumentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlayerInstruments",
                keyColumn: "PlayerInstrumentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlayerInstruments",
                keyColumn: "PlayerInstrumentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InstrumentTypes",
                keyColumn: "InstrumentTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InstrumentTypes",
                keyColumn: "InstrumentTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2);
        }
    }
}
