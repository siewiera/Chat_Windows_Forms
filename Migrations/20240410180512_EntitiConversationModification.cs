using Microsoft.EntityFrameworkCore.Migrations;

namespace Chat.Migrations
{
    public partial class EntitiConversationModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConversationUsers_Conversations_ConversationId",
                table: "ConversationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Conversations_ConversationId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ConversationId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ConversationId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "KeyConversation",
                table: "Conversations");

            migrationBuilder.AddColumn<int>(
                name: "ConversationMessageId",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Conversations_ConversationUserId",
                table: "Conversations",
                column: "ConversationUserId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Conversations_MessageId",
                table: "Conversations",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ConversationMessageId",
                table: "Messages",
                column: "ConversationMessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConversationUsers_Conversations_ConversationId",
                table: "ConversationUsers",
                column: "ConversationId",
                principalTable: "Conversations",
                principalColumn: "ConversationUserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Conversations_ConversationMessageId",
                table: "Messages",
                column: "ConversationMessageId",
                principalTable: "Conversations",
                principalColumn: "MessageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConversationUsers_Conversations_ConversationId",
                table: "ConversationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Conversations_ConversationMessageId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ConversationMessageId",
                table: "Messages");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Conversations_ConversationUserId",
                table: "Conversations");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Conversations_MessageId",
                table: "Conversations");

            migrationBuilder.DropColumn(
                name: "ConversationMessageId",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "ConversationId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KeyConversation",
                table: "Conversations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ConversationId",
                table: "Messages",
                column: "ConversationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConversationUsers_Conversations_ConversationId",
                table: "ConversationUsers",
                column: "ConversationId",
                principalTable: "Conversations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Conversations_ConversationId",
                table: "Messages",
                column: "ConversationId",
                principalTable: "Conversations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
