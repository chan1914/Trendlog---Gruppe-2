using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trendlog___Gruppe_2.Migrations
{
    public partial class Virkforhelvede : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Channels",
                columns: table => new
                {
                    ChannelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Timezone = table.Column<string>(nullable: true),
                    Lifetime = table.Column<int>(nullable: false),
                    Longitume = table.Column<int>(nullable: false),
                    Elevation = table.Column<int>(nullable: false),
                    EmailId = table.Column<int>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    MaxSize = table.Column<int>(nullable: false),
                    PCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channels", x => x.ChannelId);
                    table.ForeignKey(
                        name: "FK_Channels_AlarmSettings_EmailId",
                        column: x => x.EmailId,
                        principalTable: "AlarmSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Feeds",
                columns: table => new
                {
                    FeedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    Scale = table.Column<int>(nullable: false),
                    Alarm = table.Column<int>(nullable: false),
                    EnableAlarm = table.Column<bool>(nullable: false),
                    AlarmSettings = table.Column<string>(nullable: true),
                    ChannelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feeds", x => x.FeedId);
                    table.ForeignKey(
                        name: "FK_Feeds_Channels_ChannelId",
                        column: x => x.ChannelId,
                        principalTable: "Channels",
                        principalColumn: "ChannelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Points",
                columns: table => new
                {
                    PointId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    FeedId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.PointId);
                    table.ForeignKey(
                        name: "FK_Points_Feeds_FeedId",
                        column: x => x.FeedId,
                        principalTable: "Feeds",
                        principalColumn: "FeedId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Channels_EmailId",
                table: "Channels",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_Feeds_ChannelId",
                table: "Feeds",
                column: "ChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_Points_FeedId",
                table: "Points",
                column: "FeedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Points");

            migrationBuilder.DropTable(
                name: "Feeds");

            migrationBuilder.DropTable(
                name: "Channels");

            migrationBuilder.DropTable(
                name: "AlarmSettings");
        }
    }
}
