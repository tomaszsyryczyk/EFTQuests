using Microsoft.EntityFrameworkCore.Migrations;

namespace EFT_Hud.DAL.Migrations
{
    public partial class OptionalQuests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Optional",
                table: "Objective",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "IconName", "Name", "ShortName" },
                values: new object[,]
                {
                    { 20, null, "bronze pocket watch", null },
                    { 21, null, "TT pistol 7.62x25 TT", null },
                    { 22, null, "TT-105 7.62x25 TT Magazine", null }
                });

            migrationBuilder.InsertData(
                table: "Objective",
                columns: new[] { "Id", "Count", "CountDone", "Description", "ItemId", "LocationId", "Optional", "QuestId", "Type" },
                values: new object[] { 28, 0, 0, "Find the key to the tank truck", null, 4, true, 2, 2 });

            migrationBuilder.InsertData(
                table: "Reward",
                columns: new[] { "Id", "Count", "Description", "ItemId", "Quest_Id", "Type" },
                values: new object[,]
                {
                    { 8, 8000.0, null, null, 2, 1 },
                    { 9, 0.080000000000000002, null, null, 2, 3 },
                    { 10, 4000.0, null, 15, 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Objective",
                columns: new[] { "Id", "Count", "CountDone", "Description", "ItemId", "LocationId", "Optional", "QuestId", "Type" },
                values: new object[,]
                {
                    { 27, 1, 0, null, 20, 4, false, 2, 2 },
                    { 29, 1, 0, null, 20, 4, false, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Reward",
                columns: new[] { "Id", "Count", "Description", "ItemId", "Quest_Id", "Type" },
                values: new object[,]
                {
                    { 11, 1.0, null, 21, 2, 0 },
                    { 12, 3.0, null, 22, 2, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DropColumn(
                name: "Optional",
                table: "Objective");
        }
    }
}
