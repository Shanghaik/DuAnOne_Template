using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class testDA2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuizChitiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenQuiz = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Batdau = table.Column<DateTime>(type: "Datetime", nullable: false),
                    Ketthuc = table.Column<DateTime>(type: "Datetime", nullable: false),
                    Socauhoi = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    MaxGrade = table.Column<int>(type: "int", nullable: false),
                    Trangthai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizChitiet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSV = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MaSV = table.Column<string>(type: "varchar(30)", nullable: false),
                    EmailSV = table.Column<string>(type: "varchar(100)", nullable: false),
                    Nganh = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ChuyenNganh = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SinhvienLamQuiz",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdQuizChitiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TakeQuizTime = table.Column<DateTime>(type: "Datetime", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhvienLamQuiz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinhvienLamQuiz_QuizChitiet_IdQuizChitiet",
                        column: x => x.IdQuizChitiet,
                        principalTable: "QuizChitiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinhvienLamQuiz_SinhVien_IdSV",
                        column: x => x.IdSV,
                        principalTable: "SinhVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SinhvienLamQuiz_IdQuizChitiet",
                table: "SinhvienLamQuiz",
                column: "IdQuizChitiet");

            migrationBuilder.CreateIndex(
                name: "IX_SinhvienLamQuiz_IdSV",
                table: "SinhvienLamQuiz",
                column: "IdSV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhvienLamQuiz");

            migrationBuilder.DropTable(
                name: "QuizChitiet");

            migrationBuilder.DropTable(
                name: "SinhVien");
        }
    }
}
