using Microsoft.EntityFrameworkCore.Migrations;

namespace EFT_Hud.DAL.Migrations
{
    public partial class ObjectivesUsingItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "Quest");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Quest",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsingItemId",
                table: "Objective",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "IconName", "Name", "ShortName" },
                values: new object[,]
                {
                    { 28, null, "Marker 2000", null },
                    { 29, null, "secure folder 0031", null },
                    { 30, null, "Key ZB-014", null },
                    { 31, null, "Portable cabin key of customs Factory zone", null },
                    { 32, null, "60-round mags for AK", null },
                    { 33, null, "Sealed letter", null }
                });

            migrationBuilder.InsertData(
                table: "Objective",
                columns: new[] { "Id", "Count", "CountDone", "Description", "Done", "ItemId", "LocationId", "Optional", "QuestId", "Type", "UsingItemId" },
                values: new object[,]
                {
                    { 40, 1, 0, "Gain access to the closed room in offices", false, null, 5, true, 6, 5, null },
                    { 43, 1, 0, null, false, null, 4, false, 6, 7, null },
                    { 46, 1, 0, "Locate the right bunker", false, null, 2, false, 7, 5, null },
                    { 49, 1, 0, null, false, null, 5, false, 8, 7, null }
                });

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Postman part - part 1");

            migrationBuilder.InsertData(
                table: "Quest",
                columns: new[] { "Id", "MerchantId", "Name", "Status" },
                values: new object[,]
                {
                    { 26, 2, "Sanitary Standards - Part 1", 0 },
                    { 46, 2, "Decontamination service", 0 },
                    { 45, 2, "Athlete", 0 },
                    { 44, 2, "Private clinic", 0 },
                    { 43, 2, "Hippocratic Vow", 0 },
                    { 42, 2, "Trust regain", 0 },
                    { 41, 2, "Out of curiosity", 0 },
                    { 40, 2, "Postman Pat - Part 2", 0 },
                    { 39, 2, "Health Care Privacy - Part 5", 0 },
                    { 38, 2, "Health Care Privacy - Part 4", 0 },
                    { 25, 2, "Shortage", 0 },
                    { 37, 2, "Health Care Privacy - Part 3", 0 },
                    { 35, 2, "Health Care Privacy - Part 1", 0 },
                    { 34, 2, "Car repair", 0 },
                    { 33, 2, "General wares", 0 },
                    { 32, 2, "Supply plans", 0 },
                    { 47, 2, "An apple a day - keeps the doctor away", 0 },
                    { 30, 2, "Painkiller", 0 },
                    { 29, 2, "Operation Aquarius - Part 2", 0 },
                    { 28, 2, "Operation Aquarius - Part 1", 0 },
                    { 27, 2, "Sanitary Standards - Part 2", 0 },
                    { 36, 2, "Health Care Privacy - Part 2", 0 },
                    { 31, 2, "Pharmacist", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 34,
                column: "UsingItemId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 35,
                column: "UsingItemId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 36,
                column: "UsingItemId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 37,
                column: "UsingItemId",
                value: 28);

            migrationBuilder.InsertData(
                table: "Objective",
                columns: new[] { "Id", "Count", "CountDone", "Description", "Done", "ItemId", "LocationId", "Optional", "QuestId", "Type", "UsingItemId" },
                values: new object[,]
                {
                    { 39, 1, 0, null, false, 29, 4, false, 6, 2, null },
                    { 42, 1, 0, null, false, 29, 4, false, 6, 1, null },
                    { 45, 1, 0, null, false, 30, 4, false, 7, 2, null },
                    { 41, 1, 0, null, false, 31, 5, true, 6, 2, null },
                    { 44, 6, 0, null, false, 32, null, false, 7, 2, null },
                    { 47, 6, 0, null, false, 32, null, false, 7, 1, null },
                    { 48, 1, 0, null, false, 33, 5, false, 8, 2, null },
                    { 50, 1, 0, null, false, 33, null, false, 8, 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Objective_UsingItemId",
                table: "Objective",
                column: "UsingItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Objective_Item_UsingItemId",
                table: "Objective",
                column: "UsingItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Objective_Item_UsingItemId",
                table: "Objective");

            migrationBuilder.DropIndex(
                name: "IX_Objective_UsingItemId",
                table: "Objective");

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Quest");

            migrationBuilder.DropColumn(
                name: "UsingItemId",
                table: "Objective");

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Quest",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Postman pat - part 1");
        }
    }
}
