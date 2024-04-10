using Microsoft.EntityFrameworkCore.Migrations;

namespace Chat.Migrations
{
    public partial class EntitiConversationModification_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConversationUsers_Conversations_ConversationId",
                table: "ConversationUsers");

            migrationBuilder.DropIndex(
                name: "IX_ConversationUsers_ConversationId",
                table: "ConversationUsers");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_ConversationUserId",
                table: "Conversations",
                column: "ConversationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conversations_ConversationUsers_ConversationUserId",
                table: "Conversations",
                column: "ConversationUserId",
                principalTable: "ConversationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conversations_ConversationUsers_ConversationUserId",
                table: "Conversations");

            migrationBuilder.DropIndex(
                name: "IX_Conversations_ConversationUserId",
                table: "Conversations");

            migrationBuilder.CreateIndex(
                name: "IX_ConversationUsers_ConversationId",
                table: "ConversationUsers",
                column: "ConversationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConversationUsers_Conversations_ConversationId",
                table: "ConversationUsers",
                column: "ConversationId",
                principalTable: "Conversations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
