using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    public partial class UpdateHinhAnhTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hinhAnh_mauSacs_IdMauSac",
                table: "hinhAnh");

            migrationBuilder.DropForeignKey(
                name: "FK_hinhAnh_sanPhams_IdSanPham",
                table: "hinhAnh");

            migrationBuilder.DropIndex(
                name: "IX_hinhAnh_IdMauSac",
                table: "hinhAnh");

            migrationBuilder.DropIndex(
                name: "IX_hinhAnh_IdSanPham",
                table: "hinhAnh");

            migrationBuilder.DropColumn(
                name: "HienThi",
                table: "hinhAnh");

            migrationBuilder.DropColumn(
                name: "IdMauSac",
                table: "hinhAnh");

            migrationBuilder.DropColumn(
                name: "IdSanPham",
                table: "hinhAnh");

            migrationBuilder.DropColumn(
                name: "LaAnhChinh",
                table: "hinhAnh");

            migrationBuilder.RenameColumn(
                name: "TenAnh",
                table: "hinhAnh",
                newName: "LoaiFileHinhAnh");

            migrationBuilder.AddColumn<byte[]>(
                name: "DataHinhAnh",
                table: "hinhAnh",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<Guid>(
                name: "IdSanPhamChiTiet",
                table: "hinhAnh",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SanPhamIdSanPham",
                table: "hinhAnh",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "hinhAnh",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_hinhAnh_IdSanPhamChiTiet",
                table: "hinhAnh",
                column: "IdSanPhamChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_hinhAnh_SanPhamIdSanPham",
                table: "hinhAnh",
                column: "SanPhamIdSanPham");

            migrationBuilder.AddForeignKey(
                name: "FK_hinhAnh_sanPhamChiTiets_IdSanPhamChiTiet",
                table: "hinhAnh",
                column: "IdSanPhamChiTiet",
                principalTable: "sanPhamChiTiets",
                principalColumn: "IdSanPhamChiTiet");

            migrationBuilder.AddForeignKey(
                name: "FK_hinhAnh_sanPhams_SanPhamIdSanPham",
                table: "hinhAnh",
                column: "SanPhamIdSanPham",
                principalTable: "sanPhams",
                principalColumn: "IdSanPham");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hinhAnh_sanPhamChiTiets_IdSanPhamChiTiet",
                table: "hinhAnh");

            migrationBuilder.DropForeignKey(
                name: "FK_hinhAnh_sanPhams_SanPhamIdSanPham",
                table: "hinhAnh");

            migrationBuilder.DropIndex(
                name: "IX_hinhAnh_IdSanPhamChiTiet",
                table: "hinhAnh");

            migrationBuilder.DropIndex(
                name: "IX_hinhAnh_SanPhamIdSanPham",
                table: "hinhAnh");

            migrationBuilder.DropColumn(
                name: "DataHinhAnh",
                table: "hinhAnh");

            migrationBuilder.DropColumn(
                name: "IdSanPhamChiTiet",
                table: "hinhAnh");

            migrationBuilder.DropColumn(
                name: "SanPhamIdSanPham",
                table: "hinhAnh");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "hinhAnh");

            migrationBuilder.RenameColumn(
                name: "LoaiFileHinhAnh",
                table: "hinhAnh",
                newName: "TenAnh");

            migrationBuilder.AddColumn<string>(
                name: "HienThi",
                table: "hinhAnh",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "IdMauSac",
                table: "hinhAnh",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdSanPham",
                table: "hinhAnh",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "LaAnhChinh",
                table: "hinhAnh",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_hinhAnh_IdMauSac",
                table: "hinhAnh",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_hinhAnh_IdSanPham",
                table: "hinhAnh",
                column: "IdSanPham");

            migrationBuilder.AddForeignKey(
                name: "FK_hinhAnh_mauSacs_IdMauSac",
                table: "hinhAnh",
                column: "IdMauSac",
                principalTable: "mauSacs",
                principalColumn: "IdMauSac",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hinhAnh_sanPhams_IdSanPham",
                table: "hinhAnh",
                column: "IdSanPham",
                principalTable: "sanPhams",
                principalColumn: "IdSanPham",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
