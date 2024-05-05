using Microsoft.EntityFrameworkCore.Migrations;

namespace Chat.Migrations
{
    public partial class adding_addtional_column_ControlType_to_ControlForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ControlType",
                table: "ControlForm",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ControlType",
                table: "ControlForm");
        }
    }
}
