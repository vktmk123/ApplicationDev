using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Migrations
{
    public partial class tesst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ddc55ca9-d0b9-450f-bd04-c40df933901b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4c564ba0-2b66-4086-8779-a4bc23c87389");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "094864a3-804d-43d1-a0c3-22dc3e5f5b8c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbb7ab51-8681-438f-8bb3-ec1b891fba36", "AQAAAAEAACcQAAAAEKnK3G6BzQC/m3f9Y1Zodu90YDQFW3NL6tqosWGggqQP9nw0GkbGZxJ5pZ55kLjsSA==", "445cfbb1-f8f6-4df6-b1d4-b293a771bae9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a5dd62a-7770-4125-8ff1-6d7dee6abddb", "AQAAAAEAACcQAAAAECU3eiE6szDNYO0m6YLlKL0Ocye5cHxYRZILvtVvChBJimDz5W0dw4S5F1Mn9vtPmQ==", "ffb4b74e-56d5-405d-b385-a6ddc8ccdf8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec62ad86-c143-434f-9065-51bf128e5c17", "AQAAAAEAACcQAAAAEIA3FovVyVWsohJ5ILaroUyTfzI0kltMFSU72a1ZskAJUvdU0PRIZNgIJurolKeGjw==", "78d05667-1628-4f18-9f52-5af9d76d493e" });
        }
    }
}
