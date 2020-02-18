using Microsoft.EntityFrameworkCore.Migrations;

namespace EFT_Hud.DAL.Migrations
{
    public partial class AddingRewards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Reward",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "IconName", "Name", "ShortName" },
                values: new object[] { 13, null, "Secure container Kappa", null });

            migrationBuilder.InsertData(
                table: "Objective",
                columns: new[] { "Id", "Count", "CountDone", "Description", "ItemId", "LocationId", "QuestId", "Type" },
                values: new object[,]
                {
                    { 13, 1, 0, null, 1, null, 24, 1 },
                    { 14, 1, 0, null, 2, null, 24, 1 },
                    { 15, 1, 0, null, 3, null, 24, 1 },
                    { 16, 1, 0, null, 4, null, 24, 1 },
                    { 17, 1, 0, null, 5, null, 24, 1 },
                    { 18, 1, 0, null, 6, null, 24, 1 },
                    { 19, 1, 0, null, 7, null, 24, 1 },
                    { 20, 1, 0, null, 8, null, 24, 1 },
                    { 21, 1, 0, null, 9, null, 24, 1 },
                    { 22, 1, 0, null, 10, null, 24, 1 },
                    { 23, 1, 0, null, 11, null, 24, 1 },
                    { 24, 1, 0, null, 12, null, 24, 1 }
                });

            migrationBuilder.InsertData(
                table: "Reward",
                columns: new[] { "Id", "Count", "Description", "ItemId", "Quest_Id", "Type" },
                values: new object[] { 1, 1, null, 13, 24, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Reward_ItemId",
                table: "Reward",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reward_Item_ItemId",
                table: "Reward",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reward_Item_ItemId",
                table: "Reward");

            migrationBuilder.DropIndex(
                name: "IX_Reward_ItemId",
                table: "Reward");

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Reward");
        }
    }
}
