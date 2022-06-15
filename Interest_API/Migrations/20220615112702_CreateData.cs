using Microsoft.EntityFrameworkCore.Migrations;

namespace Interest_API.Migrations
{
    public partial class CreateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "Role_Name",
                table: "Roles",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Role_Id", "Role_Name" },
                values: new object[,]
                {
                    { 1, "administrator" },
                    { 2, "user" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Description", "Email", "Password", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1, "Web developer", "lademor@gmail.com", "1234", 1, "LadeMor" },
                    { 2, "Artist", "jabe@gmail.com", "1111", 2, "Jabe" },
                    { 3, "Gamer", "flomy@gmail.com", "2222", 2, "Flomic" },
                    { 4, "C++ game developer", "swon@gmail.com", "3333", 2, "Swonsonn" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Post_Id", "Author", "Image", "Post_Description", "Title", "User_Id" },
                values: new object[,]
                {
                    { 1, "LadeMor", "https://i.pinimg.com/474x/ff/13/f3/ff13f379c308e9753a6f94ea179caf47.jpg", "First post in my app", "Post1", 1 },
                    { 2, "LadeMor", "https://i.pinimg.com/474x/3b/ff/38/3bff3800984503efe1edaeb596755b22.jpg", "Really cool car", "Cool car", 1 },
                    { 3, "LadeMor", "https://i.pinimg.com/474x/ee/cc/60/eecc60d000dbe7c6d5bf91ec9e46ed45.jpg", "Really cool anime", "Cool anime", 1 },
                    { 4, "LadeMor", "https://i.pinimg.com/474x/3b/ff/38/3bff3800984503efe1edaeb596755b22.jpg", "Really cool car", "Cool car", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Role_Name",
                table: "Roles",
                column: "Role_Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_User_Id",
                table: "Posts",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_User_Id",
                table: "Posts",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_User_Id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Roles_Role_Name",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Posts_User_Id",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Post_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Post_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Post_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Post_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Role_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Role_Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Role_Name",
                table: "Roles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Posts",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
