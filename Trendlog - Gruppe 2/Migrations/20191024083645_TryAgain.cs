using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trendlog___Gruppe_2.Migrations
{
    public partial class TryAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Channels_AlarmSettings_EmailId",
                table: "Channels");

            migrationBuilder.DropTable(
                name: "AlarmSettings");

            migrationBuilder.DropIndex(
                name: "IX_Channels_EmailId",
                table: "Channels");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Channels");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Channels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Channels");

            migrationBuilder.AddColumn<int>(
                name: "EmailId",
                table: "Channels",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AlarmSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlarmSettings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Channels_EmailId",
                table: "Channels",
                column: "EmailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Channels_AlarmSettings_EmailId",
                table: "Channels",
                column: "EmailId",
                principalTable: "AlarmSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
