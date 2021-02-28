using Microsoft.EntityFrameworkCore.Migrations;

namespace Steps_Assignment.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Steps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StepNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StepId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Steps_StepId",
                        column: x => x.StepId,
                        principalTable: "Steps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Steps",
                columns: new[] { "Id", "StepNumber" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Steps",
                columns: new[] { "Id", "StepNumber" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "StepId", "Title" },
                values: new object[] { 1, "description 1", 1, "title 1" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "StepId", "Title" },
                values: new object[] { 2, "description 2", 1, "title 2" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "StepId", "Title" },
                values: new object[] { 3, "description 1", 2, "title 1" });

            migrationBuilder.CreateIndex(
                name: "IX_Items_StepId",
                table: "Items",
                column: "StepId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Steps");
        }
    }
}
