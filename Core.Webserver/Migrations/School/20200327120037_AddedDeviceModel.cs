using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Webserver.Migrations.School
{
    public partial class AddedDeviceModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomMessageId = table.Column<long>(nullable: false),
                    MacAdress = table.Column<string>(nullable: false),
                    SignalStrength = table.Column<int>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_RoomMessages_RoomMessageId",
                        column: x => x.RoomMessageId,
                        principalTable: "RoomMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_RoomMessageId",
                table: "Devices",
                column: "RoomMessageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
