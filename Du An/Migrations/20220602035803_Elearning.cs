using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Du_An.Migrations
{
    public partial class Elearning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    MaLop = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    TenLop = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PhongHoc = table.Column<string>(type: "nchar(250)", fixedLength: true, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.MaLop);
                });

            migrationBuilder.CreateTable(
                name: "Monhoc",
                columns: table => new
                {
                    MaMH = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    TenMH = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monhoc", x => x.MaMH);
                });

            migrationBuilder.CreateTable(
                name: "NienKhoa",
                columns: table => new
                {
                    IDNienKhoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NienKhoa = table.Column<string>(type: "nchar(15)", fixedLength: true, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NienKhoa", x => x.IDNienKhoa);
                });

            migrationBuilder.CreateTable(
                name: "VaiTroGiaoVien",
                columns: table => new
                {
                    IDVaiTro = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    TenVaiTro = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTroGiaoVien", x => x.IDVaiTro);
                });

            migrationBuilder.CreateTable(
                name: "Sinhvien",
                columns: table => new
                {
                    MaSV = table.Column<string>(type: "nchar(15)", fixedLength: true, maxLength: 15, nullable: false),
                    TenSV = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GioiTinh = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: true),
                    GVCN = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IDNienKhoa = table.Column<int>(type: "int", nullable: true),
                    MaLop = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    MaMH = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SV", x => x.MaSV);
                    table.ForeignKey(
                        name: "FK_Sinhvien_Lop",
                        column: x => x.MaLop,
                        principalTable: "Lop",
                        principalColumn: "MaLop");
                    table.ForeignKey(
                        name: "FK_Sinhvien_Monhoc",
                        column: x => x.MaMH,
                        principalTable: "Monhoc",
                        principalColumn: "MaMH");
                    table.ForeignKey(
                        name: "FK_Sinhvien_NienKhoa",
                        column: x => x.IDNienKhoa,
                        principalTable: "NienKhoa",
                        principalColumn: "IDNienKhoa");
                });

            migrationBuilder.CreateTable(
                name: "GiaoVien",
                columns: table => new
                {
                    MaGV = table.Column<string>(type: "nchar(15)", fixedLength: true, maxLength: 15, nullable: false),
                    TenGV = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GioiTinh = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: true),
                    IDVaiTro = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    MaMH = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IDNienKhoa = table.Column<int>(type: "int", nullable: true),
                    MaLop = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoVien", x => x.MaGV);
                    table.ForeignKey(
                        name: "FK_GiaoVien_Lop",
                        column: x => x.MaLop,
                        principalTable: "Lop",
                        principalColumn: "MaLop");
                    table.ForeignKey(
                        name: "FK_GiaoVien_NienKhoa",
                        column: x => x.IDNienKhoa,
                        principalTable: "NienKhoa",
                        principalColumn: "IDNienKhoa");
                    table.ForeignKey(
                        name: "FK_GiaoVien_VaiTroGiaoVien",
                        column: x => x.IDVaiTro,
                        principalTable: "VaiTroGiaoVien",
                        principalColumn: "IDVaiTro");
                });

            migrationBuilder.CreateTable(
                name: "LoginSV",
                columns: table => new
                {
                    IdloginSV = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "nchar(30)", fixedLength: true, maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    MaSV = table.Column<string>(type: "nchar(15)", fixedLength: true, maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.IdloginSV);
                    table.ForeignKey(
                        name: "FK_LoginSV_Sinhvien",
                        column: x => x.MaSV,
                        principalTable: "Sinhvien",
                        principalColumn: "MaSV");
                });

            migrationBuilder.CreateTable(
                name: "Bangdiem",
                columns: table => new
                {
                    MaSV = table.Column<string>(type: "nchar(15)", fixedLength: true, maxLength: 15, nullable: false),
                    MaMH = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    DiemChuyenCan = table.Column<int>(type: "int", nullable: true),
                    DiemMieng = table.Column<int>(type: "int", nullable: true),
                    Diem15p = table.Column<int>(type: "int", nullable: true),
                    DiemHS1 = table.Column<int>(type: "int", nullable: true),
                    DiemHS2 = table.Column<int>(type: "int", nullable: true),
                    DiemHS3 = table.Column<int>(type: "int", nullable: true),
                    DiemTB = table.Column<int>(type: "int", nullable: true),
                    MaGV = table.Column<string>(type: "nchar(15)", fixedLength: true, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bangdiem", x => x.MaSV);
                    table.ForeignKey(
                        name: "FK_Bangdiem_GiaoVien",
                        column: x => x.MaGV,
                        principalTable: "GiaoVien",
                        principalColumn: "MaGV");
                    table.ForeignKey(
                        name: "FK_Bangdiem_Sinhvien",
                        column: x => x.MaSV,
                        principalTable: "Sinhvien",
                        principalColumn: "MaSV");
                });

            migrationBuilder.CreateTable(
                name: "LoginGV",
                columns: table => new
                {
                    IdLoginGV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "nchar(30)", fixedLength: true, maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    MaGV = table.Column<string>(type: "nchar(15)", fixedLength: true, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginGV", x => x.IdLoginGV);
                    table.ForeignKey(
                        name: "FK_LoginGV_GiaoVien",
                        column: x => x.MaGV,
                        principalTable: "GiaoVien",
                        principalColumn: "MaGV");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bangdiem_MaGV",
                table: "Bangdiem",
                column: "MaGV");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoVien_IDNienKhoa",
                table: "GiaoVien",
                column: "IDNienKhoa");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoVien_IDVaiTro",
                table: "GiaoVien",
                column: "IDVaiTro");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoVien_MaLop",
                table: "GiaoVien",
                column: "MaLop");

            migrationBuilder.CreateIndex(
                name: "IX_LoginGV_MaGV",
                table: "LoginGV",
                column: "MaGV");

            migrationBuilder.CreateIndex(
                name: "IX_LoginSV_MaSV",
                table: "LoginSV",
                column: "MaSV");

            migrationBuilder.CreateIndex(
                name: "IX_Sinhvien_IDNienKhoa",
                table: "Sinhvien",
                column: "IDNienKhoa");

            migrationBuilder.CreateIndex(
                name: "IX_Sinhvien_MaLop",
                table: "Sinhvien",
                column: "MaLop");

            migrationBuilder.CreateIndex(
                name: "IX_Sinhvien_MaMH",
                table: "Sinhvien",
                column: "MaMH");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bangdiem");

            migrationBuilder.DropTable(
                name: "LoginGV");

            migrationBuilder.DropTable(
                name: "LoginSV");

            migrationBuilder.DropTable(
                name: "GiaoVien");

            migrationBuilder.DropTable(
                name: "Sinhvien");

            migrationBuilder.DropTable(
                name: "VaiTroGiaoVien");

            migrationBuilder.DropTable(
                name: "Lop");

            migrationBuilder.DropTable(
                name: "Monhoc");

            migrationBuilder.DropTable(
                name: "NienKhoa");
        }
    }
}
