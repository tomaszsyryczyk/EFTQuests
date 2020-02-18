using Microsoft.EntityFrameworkCore.Migrations;

namespace EFT_Hud.DAL.Migrations
{
    public partial class RewardsCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Count",
                table: "Reward",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "IconName", "Name", "ShortName" },
                values: new object[,]
                {
                    { 14, null, "MP-133 pump-action shotguns", null },
                    { 15, null, "Roubles", null },
                    { 16, null, "Euro", null },
                    { 17, null, "Dollars", null },
                    { 18, null, "PM 9x18PM pistol", null },
                    { 19, null, "90-93 9x18PM Magazine, for 8 PM rounds", null }
                });

            migrationBuilder.InsertData(
                table: "Objective",
                columns: new[] { "Id", "Count", "CountDone", "Description", "ItemId", "LocationId", "QuestId", "Type" },
                values: new object[] { 25, 5, 0, "Scav", null, 4, 1, 10 });

            migrationBuilder.UpdateData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 1.0);

            migrationBuilder.InsertData(
                table: "Reward",
                columns: new[] { "Id", "Count", "Description", "ItemId", "Quest_Id", "Type" },
                values: new object[,]
                {
                    { 2, 600.0, null, null, 1, 1 },
                    { 3, 0.080000000000000002, null, null, 1, 3 },
                    { 7, null, "Unlocks purchase of Kalashnikov AKS-74U 5.45x39 at LL1", null, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Objective",
                columns: new[] { "Id", "Count", "CountDone", "Description", "ItemId", "LocationId", "QuestId", "Type" },
                values: new object[] { 26, 2, 0, null, 14, null, 1, 1 });

            migrationBuilder.InsertData(
                table: "Reward",
                columns: new[] { "Id", "Count", "Description", "ItemId", "Quest_Id", "Type" },
                values: new object[,]
                {
                    { 4, 5000.0, null, 15, 1, 0 },
                    { 5, 1.0, null, 18, 1, 0 },
                    { 6, 1.0, null, 19, 1, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.AlterColumn<int>(
                name: "Count",
                table: "Reward",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 1);
        }
    }
}
