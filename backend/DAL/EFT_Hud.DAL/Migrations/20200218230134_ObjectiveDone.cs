using Microsoft.EntityFrameworkCore.Migrations;

namespace EFT_Hud.DAL.Migrations
{
    public partial class ObjectiveDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Objective",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "IconName", "Name", "ShortName" },
                values: new object[,]
                {
                    { 23, null, "Kalashnikov AKS-74U 5.45x39", null },
                    { 24, null, "6L20 30-round 5.45x39 magazine for AK-74 and compatible weapons", null },
                    { 25, null, "Saiga 12ga ver. 10 12/76 shotgun", null },
                    { 26, null, "Sb.5 5-round 12/76 magazine for SOK-12 and compatible weapons", null },
                    { 27, null, "RGD-5 hand grenade", null }
                });

            migrationBuilder.InsertData(
                table: "Objective",
                columns: new[] { "Id", "Count", "CountDone", "Description", "Done", "ItemId", "LocationId", "Optional", "QuestId", "Type" },
                values: new object[,]
                {
                    { 38, 0, 0, null, false, null, 4, false, 5, 7 },
                    { 36, 0, 0, "fuel tank №3", false, null, 4, false, 5, 8 },
                    { 35, 0, 0, "fuel tank №2", false, null, 4, false, 5, 8 },
                    { 34, 0, 0, "fuel tank №1", false, null, 4, false, 5, 8 },
                    { 37, 0, 0, "fuel tank №4", false, null, 4, false, 5, 8 },
                    { 32, 0, 0, "swing room, on 2nd", false, null, 5, false, 4, 9 },
                    { 31, 1, 0, "secure case in the Tarcone Director's Office", false, null, 4, false, 4, 2 },
                    { 30, 15, 0, "Scav", false, null, 2, false, 3, 10 },
                    { 33, 0, 0, null, false, null, 5, false, 4, 7 }
                });

            migrationBuilder.InsertData(
                table: "Reward",
                columns: new[] { "Id", "Count", "Description", "ItemId", "Quest_Id", "Type" },
                values: new object[,]
                {
                    { 26, -0.01, null, null, 5, 9 },
                    { 13, 2000.0, null, null, 3, 1 },
                    { 14, 0.10000000000000001, null, null, 3, 3 },
                    { 15, 6000.0, null, 15, 3, 0 },
                    { 18, 4100.0, null, null, 4, 1 },
                    { 19, 0.11, null, null, 4, 3 },
                    { 20, 12000.0, null, 15, 4, 0 },
                    { 23, null, "Unlocks purchase of 5.45x39 mm PS at LL1", null, 4, 2 },
                    { 24, 2900.0, null, null, 5, 1 },
                    { 25, 0.080000000000000002, null, null, 5, 3 },
                    { 27, 8000.0, null, 15, 5, 0 }
                });

            migrationBuilder.InsertData(
                table: "Reward",
                columns: new[] { "Id", "Count", "Description", "ItemId", "Quest_Id", "Type" },
                values: new object[,]
                {
                    { 16, 3.0, null, 23, 3, 0 },
                    { 17, 3.0, null, 24, 3, 0 },
                    { 21, 3.0, null, 25, 4, 0 },
                    { 22, 3.0, null, 26, 4, 0 },
                    { 28, 3.0, null, 27, 5, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DropColumn(
                name: "Done",
                table: "Objective");
        }
    }
}
