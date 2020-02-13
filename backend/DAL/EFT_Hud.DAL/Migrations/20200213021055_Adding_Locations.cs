using Microsoft.EntityFrameworkCore.Migrations;

namespace EFT_Hud.DAL.Migrations
{
    public partial class Adding_Locations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationToQuest",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false),
                    QuestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationToQuest", x => new { x.LocationId, x.QuestId });
                    table.ForeignKey(
                        name: "FK_LocationToQuest_Quest_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Quest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationToQuest_Location_QuestId",
                        column: x => x.QuestId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Shoreline" },
                    { 2, "Woods" },
                    { 3, "Interchange" },
                    { 4, "Customs" },
                    { 5, "Factory" },
                    { 6, "Reserve" },
                    { 7, "The Lab" }
                });

            migrationBuilder.InsertData(
                table: "Merchant",
                columns: new[] { "Id", "IconName", "Name" },
                values: new object[,]
                {
                    { 1, "Prapor_Portrait.png", "Prapor" },
                    { 2, "Therapist_Portrait.png", "Therapist" },
                    { 3, "Skier_Portrait.png", "Skier" },
                    { 4, "Peacekeeper_Portrait.png", "Peacekeeper" },
                    { 5, "Mechanic_Portrait.png", "Mechanic" },
                    { 6, "Ragman_Portrait.png", "Ragman" },
                    { 7, "Jaeger_Portrait.png", "Jaeger" },
                    { 8, "Fence_Portrait.png", "Fence" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocationToQuest_QuestId",
                table: "LocationToQuest",
                column: "QuestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationToQuest");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DeleteData(
                table: "Merchant",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Merchant",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Merchant",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Merchant",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Merchant",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Merchant",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Merchant",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Merchant",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
