using Microsoft.EntityFrameworkCore.Migrations;

namespace Chat.Migrations
{
    public partial class rename_table_Control_ControlForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RightControl_Control_ControlId",
                table: "RightControl");

            migrationBuilder.DropTable(
                name: "Control");

            migrationBuilder.CreateTable(
                name: "ControlForm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TabIndex = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FormName = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlForm", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_RightControl_ControlForm_ControlId",
                table: "RightControl",
                column: "ControlId",
                principalTable: "ControlForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RightControl_ControlForm_ControlId",
                table: "RightControl");

            migrationBuilder.DropTable(
                name: "ControlForm");

            migrationBuilder.CreateTable(
                name: "Control",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TabIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Control", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_RightControl_Control_ControlId",
                table: "RightControl",
                column: "ControlId",
                principalTable: "Control",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
