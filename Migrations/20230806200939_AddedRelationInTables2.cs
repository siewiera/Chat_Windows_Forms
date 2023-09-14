using Microsoft.EntityFrameworkCore.Migrations;

namespace Chat.Migrations
{
    public partial class AddedRelationInTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RigthRoles_Rights_RightId",
                table: "RigthRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_RigthRoles_Roles_RoleId",
                table: "RigthRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RigthRoles",
                table: "RigthRoles");

            migrationBuilder.RenameTable(
                name: "RigthRoles",
                newName: "RightRoles");

            migrationBuilder.RenameIndex(
                name: "IX_RigthRoles_RoleId",
                table: "RightRoles",
                newName: "IX_RightRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_RigthRoles_RightId",
                table: "RightRoles",
                newName: "IX_RightRoles_RightId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RightRoles",
                table: "RightRoles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RightRoles_Rights_RightId",
                table: "RightRoles",
                column: "RightId",
                principalTable: "Rights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RightRoles_Roles_RoleId",
                table: "RightRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RightRoles_Rights_RightId",
                table: "RightRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_RightRoles_Roles_RoleId",
                table: "RightRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RightRoles",
                table: "RightRoles");

            migrationBuilder.RenameTable(
                name: "RightRoles",
                newName: "RigthRoles");

            migrationBuilder.RenameIndex(
                name: "IX_RightRoles_RoleId",
                table: "RigthRoles",
                newName: "IX_RigthRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_RightRoles_RightId",
                table: "RigthRoles",
                newName: "IX_RigthRoles_RightId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RigthRoles",
                table: "RigthRoles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RigthRoles_Rights_RightId",
                table: "RigthRoles",
                column: "RightId",
                principalTable: "Rights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RigthRoles_Roles_RoleId",
                table: "RigthRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
