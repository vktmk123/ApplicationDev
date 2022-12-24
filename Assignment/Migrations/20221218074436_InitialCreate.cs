using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5853b943-3a80-49f9-bbbe-477de984c30c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2a8cd641-6497-477b-b2e1-7a9e723e63b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "857f5d79-1f12-482c-8dae-49eed4800967");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7ae4fd2-bb0b-4f5e-a8ce-7860f2136126", "AQAAAAEAACcQAAAAEB3ZncNYP5L+ZLRSUgEMyWtoKOuzsi/ZMvC/u1caYRh/ZWee9v7s002MUMfpkkR7/A==", "9a66dd34-3ac6-4fcb-bb64-23a4a2880477" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50d348b5-aacb-4455-9046-5479d984f957", "AQAAAAEAACcQAAAAEEWG7ltEzA92bcUWGDHHM5vNq1dY5yMSEzjrSkqKH2JSY1+gUqaCC+jX4OnO9Prr+w==", "5efa5ebf-39b9-4fe2-a0b6-f3f6a482b008" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37f882f3-d1ff-43a3-90e7-371f37992afd", "AQAAAAEAACcQAAAAEOtsNoSRuGiS0sRRGMa16sJaeTLcPO0SwVC0hYrgnIGBGZjMEcSaBLn/CWBxbgQkbQ==", "3036f144-b69a-47e7-bb5c-ca599e7ef6cd" });
        }
    }
}
