using Microsoft.EntityFrameworkCore.Migrations;

namespace Steps_Assignment.Data.Migrations
{
    public partial class RestrictDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Steps_StepId",
                table: "Items");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Steps_StepId",
                table: "Items",
                column: "StepId",
                principalTable: "Steps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Steps_StepId",
                table: "Items");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Steps_StepId",
                table: "Items",
                column: "StepId",
                principalTable: "Steps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
