using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFT_Hud.DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    IconName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Merchant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IconName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Merchant_Id = table.Column<int>(nullable: false),
                    Done = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quest_Merchant_Merchant_Id",
                        column: x => x.Merchant_Id,
                        principalTable: "Merchant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemObjective",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quest_Id = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    FindInRaid = table.Column<bool>(nullable: false),
                    Item_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemObjective", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemObjective_Item_Item_Id",
                        column: x => x.Item_Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemObjective_Quest_Quest_Id",
                        column: x => x.Quest_Id,
                        principalTable: "Quest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_LocationToQuest_Locations_QuestId",
                        column: x => x.QuestId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Objective",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Quest_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objective", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objective_Quest_Quest_Id",
                        column: x => x.Quest_Id,
                        principalTable: "Quest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reward",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false),
                    Quest_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reward", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reward_Quest_Quest_Id",
                        column: x => x.Quest_Id,
                        principalTable: "Quest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Locations",
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
                name: "IX_ItemObjective_Item_Id",
                table: "ItemObjective",
                column: "Item_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemObjective_Quest_Id",
                table: "ItemObjective",
                column: "Quest_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LocationToQuest_QuestId",
                table: "LocationToQuest",
                column: "QuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Objective_Quest_Id",
                table: "Objective",
                column: "Quest_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Quest_Merchant_Id",
                table: "Quest",
                column: "Merchant_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reward_Quest_Id",
                table: "Reward",
                column: "Quest_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemObjective");

            migrationBuilder.DropTable(
                name: "LocationToQuest");

            migrationBuilder.DropTable(
                name: "Objective");

            migrationBuilder.DropTable(
                name: "Reward");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Quest");

            migrationBuilder.DropTable(
                name: "Merchant");
        }
    }
}
