using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Net6APISample.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5735fbd-425f-4ac0-b075-5dd09f49df43", "bd07a57c-7a55-401e-93e2-e4249d21e840", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eac84aef-df13-4e60-8c80-42cb298dc8ae", "e3015386-9e1d-4839-a33e-2ef7a9978017", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5735fbd-425f-4ac0-b075-5dd09f49df43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eac84aef-df13-4e60-8c80-42cb298dc8ae");
        }
    }
}
