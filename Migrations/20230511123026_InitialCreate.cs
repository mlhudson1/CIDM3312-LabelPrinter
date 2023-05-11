using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CIDM3312_LabelPrinter.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Lbl_Bin",
                columns: table => new
                {
                    Lbl_BinID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    addUserUserID = table.Column<int>(type: "INTEGER", nullable: false),
                    addDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    printed = table.Column<bool>(type: "INTEGER", nullable: false),
                    printDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    qty = table.Column<int>(type: "INTEGER", nullable: false),
                    binID = table.Column<string>(type: "TEXT", nullable: false),
                    binName = table.Column<string>(type: "TEXT", nullable: false),
                    dueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PrintError = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lbl_Bin", x => x.Lbl_BinID);
                    table.ForeignKey(
                        name: "FK_Lbl_Bin_User_addUserUserID",
                        column: x => x.addUserUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lbl_Item",
                columns: table => new
                {
                    Lbl_ItemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    addUserUserID = table.Column<int>(type: "INTEGER", nullable: false),
                    addDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    printed = table.Column<bool>(type: "INTEGER", nullable: false),
                    printDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    qty = table.Column<int>(type: "INTEGER", nullable: false),
                    item = table.Column<string>(type: "TEXT", nullable: false),
                    upc = table.Column<string>(type: "TEXT", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: false),
                    PrintError = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lbl_Item", x => x.Lbl_ItemID);
                    table.ForeignKey(
                        name: "FK_Lbl_Item_User_addUserUserID",
                        column: x => x.addUserUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLbl_Bin",
                columns: table => new
                {
                    Lbl_BinID = table.Column<int>(type: "INTEGER", nullable: false),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLbl_Bin", x => new { x.Lbl_BinID, x.UserID });
                    table.ForeignKey(
                        name: "FK_UserLbl_Bin_Lbl_Bin_Lbl_BinID",
                        column: x => x.Lbl_BinID,
                        principalTable: "Lbl_Bin",
                        principalColumn: "Lbl_BinID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLbl_Bin_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLbl_Item",
                columns: table => new
                {
                    Lbl_ItemID = table.Column<int>(type: "INTEGER", nullable: false),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLbl_Item", x => new { x.Lbl_ItemID, x.UserID });
                    table.ForeignKey(
                        name: "FK_UserLbl_Item_Lbl_Item_Lbl_ItemID",
                        column: x => x.Lbl_ItemID,
                        principalTable: "Lbl_Item",
                        principalColumn: "Lbl_ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLbl_Item_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lbl_Bin_addUserUserID",
                table: "Lbl_Bin",
                column: "addUserUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Lbl_Item_addUserUserID",
                table: "Lbl_Item",
                column: "addUserUserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserLbl_Bin_UserID",
                table: "UserLbl_Bin",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserLbl_Item_UserID",
                table: "UserLbl_Item",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLbl_Bin");

            migrationBuilder.DropTable(
                name: "UserLbl_Item");

            migrationBuilder.DropTable(
                name: "Lbl_Bin");

            migrationBuilder.DropTable(
                name: "Lbl_Item");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
