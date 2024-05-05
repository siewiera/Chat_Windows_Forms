using Microsoft.EntityFrameworkCore.Migrations;

namespace Chat.Migrations
{
    public partial class _ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RightControl_ControlForm_ControlId",
                table: "RightControl");

            migrationBuilder.DropForeignKey(
                name: "FK_RightControl_Rights_RightId",
                table: "RightControl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RightControl",
                table: "RightControl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ControlForm",
                table: "ControlForm");

            migrationBuilder.RenameTable(
                name: "RightControl",
                newName: "RightControls");

            migrationBuilder.RenameTable(
                name: "ControlForm",
                newName: "ControlForms");

            migrationBuilder.RenameIndex(
                name: "IX_RightControl_RightId",
                table: "RightControls",
                newName: "IX_RightControls_RightId");

            migrationBuilder.RenameIndex(
                name: "IX_RightControl_ControlId",
                table: "RightControls",
                newName: "IX_RightControls_ControlId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RightControls",
                table: "RightControls",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ControlForms",
                table: "ControlForms",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RightControls_ControlForms_ControlId",
                table: "RightControls",
                column: "ControlId",
                principalTable: "ControlForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RightControls_Rights_RightId",
                table: "RightControls",
                column: "RightId",
                principalTable: "Rights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RightControls_ControlForms_ControlId",
                table: "RightControls");

            migrationBuilder.DropForeignKey(
                name: "FK_RightControls_Rights_RightId",
                table: "RightControls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RightControls",
                table: "RightControls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ControlForms",
                table: "ControlForms");

            migrationBuilder.RenameTable(
                name: "RightControls",
                newName: "RightControl");

            migrationBuilder.RenameTable(
                name: "ControlForms",
                newName: "ControlForm");

            migrationBuilder.RenameIndex(
                name: "IX_RightControls_RightId",
                table: "RightControl",
                newName: "IX_RightControl_RightId");

            migrationBuilder.RenameIndex(
                name: "IX_RightControls_ControlId",
                table: "RightControl",
                newName: "IX_RightControl_ControlId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RightControl",
                table: "RightControl",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ControlForm",
                table: "ControlForm",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RightControl_ControlForm_ControlId",
                table: "RightControl",
                column: "ControlId",
                principalTable: "ControlForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RightControl_Rights_RightId",
                table: "RightControl",
                column: "RightId",
                principalTable: "Rights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
