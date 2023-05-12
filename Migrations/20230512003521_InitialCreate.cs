﻿using System;
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
                name: "Users",
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
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Lbls_Bin",
                columns: table => new
                {
                    Lbl_BinID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    addDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    qty = table.Column<int>(type: "INTEGER", nullable: false),
                    binID = table.Column<string>(type: "TEXT", nullable: false),
                    binName = table.Column<string>(type: "TEXT", nullable: false),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lbls_Bin", x => x.Lbl_BinID);
                    table.ForeignKey(
                        name: "FK_Lbls_Bin_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lbls_Item",
                columns: table => new
                {
                    Lbl_ItemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    addDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    qty = table.Column<int>(type: "INTEGER", nullable: false),
                    item = table.Column<string>(type: "TEXT", nullable: false),
                    upc = table.Column<string>(type: "TEXT", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: false),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lbls_Item", x => x.Lbl_ItemID);
                    table.ForeignKey(
                        name: "FK_Lbls_Item_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lbls_Bin_UserID",
                table: "Lbls_Bin",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Lbls_Item_UserID",
                table: "Lbls_Item",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lbls_Bin");

            migrationBuilder.DropTable(
                name: "Lbls_Item");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
