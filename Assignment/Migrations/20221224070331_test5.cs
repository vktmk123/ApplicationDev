using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "fdfdb46b-53c4-467f-825f-46fbde20782f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "90dde135-5e96-4421-b0fb-570e72340da1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "bad2c023-e603-4204-99ac-f88094407e16");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e2b3b3e-31d3-45db-92a8-f5834a1e7630", "AQAAAAEAACcQAAAAEJ663m3TD1RR+8bl0u33MJxb+K+0tFhQbFFfqzkPk3DMW27IPn9ntB5jCUG0LX7JeA==", "10ed47ca-0025-47fe-8477-2899cd59d1d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "065649a1-7d77-4cb2-a173-70e4470bebf8", "AQAAAAEAACcQAAAAEOVWelRzVJVbpUiAMueabopo80ko8dQJLrDFfmC8P3zOKuZK0KD8xeqop5bg7tmc8A==", "805e8b3d-d869-4f34-a618-de7cd8c58cd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58dd57e3-231e-4b55-880c-a77eedd6d175", "AQAAAAEAACcQAAAAEJOjKtSdQrwAE/97WVWJk1tsAQtwnjJHoEmfGnYy66Tnjx23w+jorAId0c8+1fewZA==", "b22dfda8-cd0d-48c7-8ecd-a1f387a416b5" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Title" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhN3A-fGPBHEBNaFFdpeDY9rr3n34jWylMEg&usqp=CAU", "C# book" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Image", "Title" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTpFrRPIX8FeWA8QgN9bH8aDAgXKsg38maanA&usqp=CAU", "Best english book" });
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

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Title" },
                values: new object[] { "https://sach86.com/wp-content/uploads/2020/10/Lam-Di.jpg", "Làm ĐĨ" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Image", "Title" },
                values: new object[] { "https://cdn.vox-cdn.com/thumbor/dyjy2i3y73CS3m1uHvkgFMEJzqE=/1400x0/filters:no_upscale()/cdn.vox-cdn.com/uploads/chorus_asset/file/21960146/61JfGcL2ljL.jpg", "The Hunger Games" });
        }
    }
}
