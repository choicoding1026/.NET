using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.DAL.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CateNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CateName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CateNo);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Cate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemNo);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPW = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Money = table.Column<int>(type: "int", nullable: false),
                    SignUpDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserNo);
                });

            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    NoticeNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoticeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoticeContents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoticeWriteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notices", x => x.NoticeNo);
                    table.ForeignKey(
                        name: "FK_Notices_Users_UserNo",
                        column: x => x.UserNo,
                        principalTable: "Users",
                        principalColumn: "UserNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewContents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewWriteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserNo = table.Column<int>(type: "int", nullable: false),
                    ItemNo = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewNo);
                    table.ForeignKey(
                        name: "FK_Reviews_Items_ItemNo",
                        column: x => x.ItemNo,
                        principalTable: "Items",
                        principalColumn: "ItemNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserNo",
                        column: x => x.UserNo,
                        principalTable: "Users",
                        principalColumn: "UserNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notices_UserNo",
                table: "Notices",
                column: "UserNo");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ItemNo",
                table: "Reviews",
                column: "ItemNo");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserNo",
                table: "Reviews",
                column: "UserNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Notices");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
