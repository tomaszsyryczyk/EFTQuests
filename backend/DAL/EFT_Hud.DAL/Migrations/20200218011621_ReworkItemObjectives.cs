using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFT_Hud.DAL.Migrations
{
    public partial class ReworkItemObjectives : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Objective_Quest_Quest_Id",
                table: "Objective");

            migrationBuilder.DropForeignKey(
                name: "FK_Quest_Merchant_Merchant_Id",
                table: "Quest");

            migrationBuilder.DropTable(
                name: "ItemObjective");

            migrationBuilder.DropTable(
                name: "LocationToQuest");

            migrationBuilder.RenameColumn(
                name: "Merchant_Id",
                table: "Quest",
                newName: "MerchantId");

            migrationBuilder.RenameIndex(
                name: "IX_Quest_Merchant_Id",
                table: "Quest",
                newName: "IX_Quest_MerchantId");

            migrationBuilder.RenameColumn(
                name: "Quest_Id",
                table: "Objective",
                newName: "QuestId");

            migrationBuilder.RenameIndex(
                name: "IX_Objective_Quest_Id",
                table: "Objective",
                newName: "IX_Objective_QuestId");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Objective",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountDone",
                table: "Objective",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Objective",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Objective",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "IconName", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, null, "Old firesteel", null },
                    { 11, null, "Fake mustache", null },
                    { 10, null, "Can of sprats", null },
                    { 9, null, "Jar of DevilDog mayo", null },
                    { 8, null, "Golden 1GPhone", null },
                    { 7, null, "Deadlyslob's beard oil", null },
                    { 12, null, "Kotton beanie", null },
                    { 5, null, "Golden rooster", null },
                    { 4, null, "FireKlean gun lube", null },
                    { 3, null, "Battered antique Book", null },
                    { 2, null, "Antique axe", null },
                    { 6, null, "Silver Badge", null }
                });

            migrationBuilder.InsertData(
                table: "Quest",
                columns: new[] { "Id", "Done", "MerchantId", "Name" },
                values: new object[,]
                {
                    { 13, false, 1, "The Punisher - part 4" },
                    { 22, false, 1, "Test drive - Part 1" },
                    { 21, false, 1, "Insomnia" },
                    { 20, false, 1, "Perfect mediator" },
                    { 19, false, 1, "Grenadier" },
                    { 18, false, 1, "No offence" },
                    { 17, false, 1, "Big customer" },
                    { 16, false, 1, "Polikhim hobo" },
                    { 15, false, 1, "The Punisher - part 6" },
                    { 14, false, 1, "The Punisher - part 5" },
                    { 12, false, 1, "The Punisher - part 3" },
                    { 6, false, 1, "Bad rep evidence" },
                    { 10, false, 1, "The Punisher - part 1" },
                    { 9, false, 1, "Shaking up teller" },
                    { 8, false, 1, "Postman pat - part 1" },
                    { 7, false, 1, "Ice cream cones" },
                    { 23, false, 1, "Regulated materials" },
                    { 5, false, 1, "BP Depot" },
                    { 4, false, 1, "Delivery from the past" },
                    { 3, false, 1, "Shootout picnic" },
                    { 2, false, 1, "Checking" },
                    { 1, false, 1, "Debiut" },
                    { 11, false, 1, "The Punisher - part 2" },
                    { 24, false, 8, "Collector" }
                });

            migrationBuilder.InsertData(
                table: "Objective",
                columns: new[] { "Id", "Count", "CountDone", "Description", "ItemId", "LocationId", "QuestId", "Type" },
                values: new object[,]
                {
                    { 1, 1, 0, null, 1, null, 24, 3 },
                    { 2, 1, 0, null, 2, null, 24, 3 },
                    { 3, 1, 0, null, 3, null, 24, 3 },
                    { 4, 1, 0, null, 4, null, 24, 3 },
                    { 5, 1, 0, null, 5, null, 24, 3 },
                    { 6, 1, 0, null, 6, null, 24, 3 },
                    { 7, 1, 0, null, 7, null, 24, 3 },
                    { 8, 1, 0, null, 8, null, 24, 3 },
                    { 9, 1, 0, null, 9, null, 24, 3 },
                    { 10, 1, 0, null, 10, null, 24, 3 },
                    { 11, 1, 0, null, 11, null, 24, 3 },
                    { 12, 1, 0, null, 12, null, 24, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Objective_ItemId",
                table: "Objective",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Objective_LocationId",
                table: "Objective",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Objective_Item_ItemId",
                table: "Objective",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Objective_Locations_LocationId",
                table: "Objective",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Objective_Quest_QuestId",
                table: "Objective",
                column: "QuestId",
                principalTable: "Quest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quest_Merchant_MerchantId",
                table: "Quest",
                column: "MerchantId",
                principalTable: "Merchant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Objective_Item_ItemId",
                table: "Objective");

            migrationBuilder.DropForeignKey(
                name: "FK_Objective_Locations_LocationId",
                table: "Objective");

            migrationBuilder.DropForeignKey(
                name: "FK_Objective_Quest_QuestId",
                table: "Objective");

            migrationBuilder.DropForeignKey(
                name: "FK_Quest_Merchant_MerchantId",
                table: "Quest");

            migrationBuilder.DropIndex(
                name: "IX_Objective_ItemId",
                table: "Objective");

            migrationBuilder.DropIndex(
                name: "IX_Objective_LocationId",
                table: "Objective");

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Objective");

            migrationBuilder.DropColumn(
                name: "CountDone",
                table: "Objective");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Objective");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Objective");

            migrationBuilder.RenameColumn(
                name: "MerchantId",
                table: "Quest",
                newName: "Merchant_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Quest_MerchantId",
                table: "Quest",
                newName: "IX_Quest_Merchant_Id");

            migrationBuilder.RenameColumn(
                name: "QuestId",
                table: "Objective",
                newName: "Quest_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Objective_QuestId",
                table: "Objective",
                newName: "IX_Objective_Quest_Id");

            migrationBuilder.CreateTable(
                name: "ItemObjective",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<int>(type: "int", nullable: false),
                    FindInRaid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Item_Id = table.Column<int>(type: "int", nullable: false),
                    Quest_Id = table.Column<int>(type: "int", nullable: false)
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
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    QuestId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.AddForeignKey(
                name: "FK_Objective_Quest_Quest_Id",
                table: "Objective",
                column: "Quest_Id",
                principalTable: "Quest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quest_Merchant_Merchant_Id",
                table: "Quest",
                column: "Merchant_Id",
                principalTable: "Merchant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
