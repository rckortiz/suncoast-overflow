using Microsoft.EntityFrameworkCore.Migrations;

namespace sdgreacttemplate.Migrations
{
    public partial class addedControllers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswersTable_QuestionsTable_QuestionID",
                table: "AnswersTable");

            migrationBuilder.RenameColumn(
                name: "QuestionID",
                table: "AnswersTable",
                newName: "QuestionsID");

            migrationBuilder.RenameIndex(
                name: "IX_AnswersTable_QuestionID",
                table: "AnswersTable",
                newName: "IX_AnswersTable_QuestionsID");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswersTable_QuestionsTable_QuestionsID",
                table: "AnswersTable",
                column: "QuestionsID",
                principalTable: "QuestionsTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswersTable_QuestionsTable_QuestionsID",
                table: "AnswersTable");

            migrationBuilder.RenameColumn(
                name: "QuestionsID",
                table: "AnswersTable",
                newName: "QuestionID");

            migrationBuilder.RenameIndex(
                name: "IX_AnswersTable_QuestionsID",
                table: "AnswersTable",
                newName: "IX_AnswersTable_QuestionID");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswersTable_QuestionsTable_QuestionID",
                table: "AnswersTable",
                column: "QuestionID",
                principalTable: "QuestionsTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
