using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SLCSCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    L_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    L_Location = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    L_Address = table.Column<string>(maxLength: 250, nullable: true),
                    L_Phone = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.L_Id);
                });

            migrationBuilder.CreateTable(
                name: "ParameterSet",
                columns: table => new
                {
                    PS_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PS_Type = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PS_Value = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PS_Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PS_Remark = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterSet", x => x.PS_Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    U_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    U_Account = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    U_IdNumber = table.Column<string>(type: "varchar(10)", nullable: true),
                    U_Password = table.Column<string>(type: "nvarchar(12)", nullable: true),
                    U_Phone = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    U_Email = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.U_Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    B_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    B_BookName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    B_Author = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    B_Publisher = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    B_PublishPlace = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    B_PublishYear = table.Column<string>(type: "varchar(4)", nullable: true),
                    B_Isbn = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    B_TopicCode = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    B_BookStatusCode = table.Column<string>(nullable: true),
                    L_Id = table.Column<int>(nullable: false),
                    LocationL_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.B_Id);
                    table.ForeignKey(
                        name: "FK_Book_Location_LocationL_Id",
                        column: x => x.LocationL_Id,
                        principalTable: "Location",
                        principalColumn: "L_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BrorrowLog",
                columns: table => new
                {
                    BL_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BL_BorrowTime = table.Column<DateTime>(nullable: false),
                    BL_ReturnTime = table.Column<DateTime>(nullable: false),
                    B_Id = table.Column<int>(nullable: false),
                    BookB_Id = table.Column<int>(nullable: true),
                    U_Id = table.Column<int>(nullable: false),
                    UserU_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrorrowLog", x => x.BL_Id);
                    table.ForeignKey(
                        name: "FK_BrorrowLog_Book_BookB_Id",
                        column: x => x.BookB_Id,
                        principalTable: "Book",
                        principalColumn: "B_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BrorrowLog_User_UserU_Id",
                        column: x => x.UserU_Id,
                        principalTable: "User",
                        principalColumn: "U_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reserve",
                columns: table => new
                {
                    R_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    R_ReverseTime = table.Column<DateTime>(nullable: false),
                    B_Id = table.Column<int>(type: "int", nullable: false),
                    BookB_Id = table.Column<int>(nullable: true),
                    U_Id = table.Column<int>(type: "int", nullable: false),
                    UserU_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserve", x => x.R_Id);
                    table.ForeignKey(
                        name: "FK_Reserve_Book_BookB_Id",
                        column: x => x.BookB_Id,
                        principalTable: "Book",
                        principalColumn: "B_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reserve_User_UserU_Id",
                        column: x => x.UserU_Id,
                        principalTable: "User",
                        principalColumn: "U_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_LocationL_Id",
                table: "Book",
                column: "LocationL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BrorrowLog_BookB_Id",
                table: "BrorrowLog",
                column: "BookB_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BrorrowLog_UserU_Id",
                table: "BrorrowLog",
                column: "UserU_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reserve_BookB_Id",
                table: "Reserve",
                column: "BookB_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reserve_UserU_Id",
                table: "Reserve",
                column: "UserU_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrorrowLog");

            migrationBuilder.DropTable(
                name: "ParameterSet");

            migrationBuilder.DropTable(
                name: "Reserve");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
