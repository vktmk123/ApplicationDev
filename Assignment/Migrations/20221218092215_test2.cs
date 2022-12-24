using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7695c175-46f7-4cb2-bcd4-f5f2ea26eeee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5df73657-83c5-4c73-868f-cd34dd6a3914");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "81decac0-3dc0-4e12-a79b-75393c88e4b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ee9c033-9beb-4540-bb34-42c94f3a8ca3", "AQAAAAEAACcQAAAAEPl+4pm+dCZ0nVoV93EUPpTdmSvbtVgPRoRD7+IzxzXEtJI+uSgWZ1p1ane6xJg4PA==", "d433e0a6-19e4-435b-9639-536d9ae686e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1347e85d-4582-43e9-8532-4bc9cbb2cf85", "AQAAAAEAACcQAAAAEElKRdp/4QXoTowrRoKokw87oJKN1MCs5ySqwcFAnCCFO3CJ+J+x5L5NMO6xD+Etzg==", "2afb1f70-f534-4dde-af13-286f170082f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f79d2ad1-0eb4-4d91-a016-64f813f16407", "AQAAAAEAACcQAAAAEF95r/+mXvwwrBsFQHayww4EdUlyan5FJk60y+min+c6yqL7ZCUYjr8wmWl4YJWeaw==", "8d69c61d-d3a6-4bfd-96f6-c0913cd52f82" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4da4f355-f59a-44a9-b35a-a27ba4ab93d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d5443e3b-cee1-4e83-9742-45a48c3e49d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "b9f96099-278f-4462-bfe9-9df3cc16cc94");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24e604b1-4071-4b7f-8f8e-179f7f66ef93", "AQAAAAEAACcQAAAAEHw8peteBQOCnTHfqlu0T6i6kvYlMqT8KvSK4INr1oKk6vH+G79SOnUcNbXzlr+hbg==", "f4d3b2de-7d52-47a0-a8ae-3a2e84476d50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6b62e89-a1b6-4cc0-aa5d-db4bae19665a", "AQAAAAEAACcQAAAAEGPhowwaSCimFDmYOpZUvXuc+CZ2BJpW5S8MkpZ61widONE4kGUWtMsBvtioU09iWw==", "3e20d0b7-5de6-4c22-a14a-2a235df9cd3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af489ffb-b8d6-4052-a33f-222dad4c3f26", "AQAAAAEAACcQAAAAEL+JmASh12jIYGiltLTQ/HqXLiEwkYd0RlaNrpvqQS79GyX75IUNIwLSS9tDE2Hqfg==", "2a9a876a-98f7-45ed-81e5-d5d4a1d27009" });
        }
    }
}
