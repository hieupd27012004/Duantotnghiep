using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chatLieus",
                columns: table => new
                {
                    IdChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenChatLieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichHoat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chatLieus", x => x.IdChatLieu);
                });

            migrationBuilder.CreateTable(
                name: "chuVu",
                columns: table => new
                {
                    IdChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chuVu", x => x.IdChucVu);
                });

            migrationBuilder.CreateTable(
                name: "danhMuc",
                columns: table => new
                {
                    IdDanhMuc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDanhMuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichHoat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danhMuc", x => x.IdDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "deGiay",
                columns: table => new
                {
                    IdDeGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDeGiay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichHoat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deGiay", x => x.IdDeGiay);
                });

            migrationBuilder.CreateTable(
                name: "diaChiHoaDons",
                columns: table => new
                {
                    IdDiaChiHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    WardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WardId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiMacDinh = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diaChiHoaDons", x => x.IdDiaChiHoaDon);
                });

            migrationBuilder.CreateTable(
                name: "districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_districts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "khachHangs",
                columns: table => new
                {
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AuthProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiCapNhat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KichHoat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHangs", x => x.IdKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "kichCos",
                columns: table => new
                {
                    IdKichCo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKichCo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichHoat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kichCos", x => x.IdKichCo);
                });

            migrationBuilder.CreateTable(
                name: "kieuDangs",
                columns: table => new
                {
                    IdKieuDang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKieuDang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiCapNhat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichHoat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kieuDangs", x => x.IdKieuDang);
                });

            migrationBuilder.CreateTable(
                name: "mauSacs",
                columns: table => new
                {
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMauSac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichHoat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mauSacs", x => x.IdMauSac);
                });

            migrationBuilder.CreateTable(
                name: "promotions",
                columns: table => new
                {
                    IdPromotion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenPromotion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhanTramGiam = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_promotions", x => x.IdPromotion);
                });

            migrationBuilder.CreateTable(
                name: "provinces",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provinces", x => x.ProvinceId);
                });

            migrationBuilder.CreateTable(
                name: "thuongHieus",
                columns: table => new
                {
                    IdThuongHieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenThuongHieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichHoat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_thuongHieus", x => x.IdThuongHieu);
                });

            migrationBuilder.CreateTable(
                name: "vouchers",
                columns: table => new
                {
                    VoucherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaVoucher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTaVoucher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiGiamGia = table.Column<int>(type: "int", nullable: false),
                    GiaTriGiam = table.Column<int>(type: "int", nullable: false),
                    GiaTriDonHangToiThieu = table.Column<int>(type: "int", nullable: true),
                    SoTienToiDa = table.Column<int>(type: "int", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vouchers", x => x.VoucherId);
                });

            migrationBuilder.CreateTable(
                name: "wards",
                columns: table => new
                {
                    WardId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wards", x => x.WardId);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnhNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiCapNhat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KichHoat = table.Column<int>(type: "int", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    IdchucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.IdNhanVien);
                    table.ForeignKey(
                        name: "FK_nhanViens_chuVu_IdchucVu",
                        column: x => x.IdchucVu,
                        principalTable: "chuVu",
                        principalColumn: "IdChucVu");
                });

            migrationBuilder.CreateTable(
                name: "diaChi",
                columns: table => new
                {
                    IdDiaChi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    WardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WardId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiMacDinh = table.Column<bool>(type: "bit", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diaChi", x => x.IdDiaChi);
                    table.ForeignKey(
                        name: "FK_diaChi_khachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "khachHangs",
                        principalColumn: "IdKhachHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gioHang",
                columns: table => new
                {
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gioHang", x => x.IdGioHang);
                    table.ForeignKey(
                        name: "FK_gioHang_khachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "khachHangs",
                        principalColumn: "IdKhachHang");
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KichHoat = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sale = table.Column<double>(type: "float", nullable: false),
                    IdChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKieuDang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdThuongHieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDanhMuc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDeGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.IdSanPham);
                    table.ForeignKey(
                        name: "FK_sanPhams_chatLieus_IdChatLieu",
                        column: x => x.IdChatLieu,
                        principalTable: "chatLieus",
                        principalColumn: "IdChatLieu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhams_danhMuc_IdDanhMuc",
                        column: x => x.IdDanhMuc,
                        principalTable: "danhMuc",
                        principalColumn: "IdDanhMuc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhams_deGiay_IdDeGiay",
                        column: x => x.IdDeGiay,
                        principalTable: "deGiay",
                        principalColumn: "IdDeGiay",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhams_kieuDangs_IdKieuDang",
                        column: x => x.IdKieuDang,
                        principalTable: "kieuDangs",
                        principalColumn: "IdKieuDang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhams_thuongHieus_IdThuongHieu",
                        column: x => x.IdThuongHieu,
                        principalTable: "thuongHieus",
                        principalColumn: "IdThuongHieu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaDon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoaiNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiGiaoHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiHoaDon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TienShip = table.Column<double>(type: "float", nullable: false),
                    TienGiam = table.Column<double>(type: "float", nullable: true),
                    TongTienDonHang = table.Column<double>(type: "float", nullable: false),
                    TongTienHoaDon = table.Column<double>(type: "float", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichHoat = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdDiaChiHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.IdHoaDon);
                    table.ForeignKey(
                        name: "FK_hoaDons_diaChiHoaDons_IdDiaChiHoaDon",
                        column: x => x.IdDiaChiHoaDon,
                        principalTable: "diaChiHoaDons",
                        principalColumn: "IdDiaChiHoaDon");
                    table.ForeignKey(
                        name: "FK_hoaDons_khachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "khachHangs",
                        principalColumn: "IdKhachHang");
                    table.ForeignKey(
                        name: "FK_hoaDons_nhanViens_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "nhanViens",
                        principalColumn: "IdNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "sanPhamChiTiets",
                columns: table => new
                {
                    IdSanPhamChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    MaSp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
                    GiaGiam = table.Column<double>(type: "float", nullable: true),
                    CoHienThi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XuatXu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KichHoat = table.Column<int>(type: "int", nullable: false),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhamChiTiets", x => x.IdSanPhamChiTiet);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiets_sanPhams_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "sanPhams",
                        principalColumn: "IdSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lichSuHoaDons",
                columns: table => new
                {
                    IdLichSuHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThaoTac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiThaoTac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lichSuHoaDons", x => x.IdLichSuHoaDon);
                    table.ForeignKey(
                        name: "FK_lichSuHoaDons_hoaDons_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "hoaDons",
                        principalColumn: "IdHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lichSuHoaDons_nhanViens_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "nhanViens",
                        principalColumn: "IdNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LichSuSuDungVouchers",
                columns: table => new
                {
                    IdVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLichSuVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgaySuDungVoucher = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThaiVoucher = table.Column<int>(type: "int", nullable: false),
                    HoaDonIdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuSuDungVouchers", x => new { x.IdVoucher, x.IdKhachHang });
                    table.ForeignKey(
                        name: "FK_LichSuSuDungVouchers_hoaDons_HoaDonIdHoaDon",
                        column: x => x.HoaDonIdHoaDon,
                        principalTable: "hoaDons",
                        principalColumn: "IdHoaDon");
                    table.ForeignKey(
                        name: "FK_LichSuSuDungVouchers_khachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "khachHangs",
                        principalColumn: "IdKhachHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LichSuSuDungVouchers_vouchers_IdVoucher",
                        column: x => x.IdVoucher,
                        principalTable: "vouchers",
                        principalColumn: "VoucherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "lichSuThanhToans",
                columns: table => new
                {
                    IdLichSuThanhToan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoTien = table.Column<double>(type: "float", nullable: false),
                    TienThua = table.Column<double>(type: "float", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoaiGiaoDich = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pttt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiThaoTac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lichSuThanhToans", x => x.IdLichSuThanhToan);
                    table.ForeignKey(
                        name: "FK_lichSuThanhToans_hoaDons_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "hoaDons",
                        principalColumn: "IdHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lichSuThanhToans_nhanViens_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "nhanViens",
                        principalColumn: "IdNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "gioHangChiTiets",
                columns: table => new
                {
                    IdGioHangChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
                    TongTien = table.Column<double>(type: "float", nullable: false),
                    KichHoat = table.Column<int>(type: "int", nullable: false),
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPhamChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gioHangChiTiets", x => x.IdGioHangChiTiet);
                    table.ForeignKey(
                        name: "FK_gioHangChiTiets_gioHang_IdGioHang",
                        column: x => x.IdGioHang,
                        principalTable: "gioHang",
                        principalColumn: "IdGioHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gioHangChiTiets_sanPhamChiTiets_IdSanPhamChiTiet",
                        column: x => x.IdSanPhamChiTiet,
                        principalTable: "sanPhamChiTiets",
                        principalColumn: "IdSanPhamChiTiet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hinhAnh",
                columns: table => new
                {
                    IdHinhAnh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataHinhAnh = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LoaiFileHinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    IdSanPhamChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hinhAnh", x => x.IdHinhAnh);
                    table.ForeignKey(
                        name: "FK_hinhAnh_sanPhamChiTiets_IdSanPhamChiTiet",
                        column: x => x.IdSanPhamChiTiet,
                        principalTable: "sanPhamChiTiets",
                        principalColumn: "IdSanPhamChiTiet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiets",
                columns: table => new
                {
                    IdHoaDonChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    TienGiam = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
                    TongTien = table.Column<double>(type: "float", nullable: false),
                    KichHoat = table.Column<double>(type: "float", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPhamChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiets", x => x.IdHoaDonChiTiet);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_hoaDons_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "hoaDons",
                        principalColumn: "IdHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_sanPhamChiTiets_IdSanPhamChiTiet",
                        column: x => x.IdSanPhamChiTiet,
                        principalTable: "sanPhamChiTiets",
                        principalColumn: "IdSanPhamChiTiet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "promotionSanPhamChiTiets",
                columns: table => new
                {
                    IdPromotion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPhamChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_promotionSanPhamChiTiets", x => new { x.IdPromotion, x.IdSanPhamChiTiet });
                    table.ForeignKey(
                        name: "FK_promotionSanPhamChiTiets_promotions_IdPromotion",
                        column: x => x.IdPromotion,
                        principalTable: "promotions",
                        principalColumn: "IdPromotion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_promotionSanPhamChiTiets_sanPhamChiTiets_IdSanPhamChiTiet",
                        column: x => x.IdSanPhamChiTiet,
                        principalTable: "sanPhamChiTiets",
                        principalColumn: "IdSanPhamChiTiet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sanPhamChiTietKichCos",
                columns: table => new
                {
                    IdSanPhamChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKichCo = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhamChiTietKichCos", x => new { x.IdSanPhamChiTiet, x.IdKichCo });
                    table.ForeignKey(
                        name: "FK_sanPhamChiTietKichCos_kichCos_IdKichCo",
                        column: x => x.IdKichCo,
                        principalTable: "kichCos",
                        principalColumn: "IdKichCo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTietKichCos_sanPhamChiTiets_IdSanPhamChiTiet",
                        column: x => x.IdSanPhamChiTiet,
                        principalTable: "sanPhamChiTiets",
                        principalColumn: "IdSanPhamChiTiet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sanPhamChiTietMausacs",
                columns: table => new
                {
                    IdSanPhamChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhamChiTietMausacs", x => new { x.IdSanPhamChiTiet, x.IdMauSac });
                    table.ForeignKey(
                        name: "FK_sanPhamChiTietMausacs_mauSacs_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "mauSacs",
                        principalColumn: "IdMauSac",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTietMausacs_sanPhamChiTiets_IdSanPhamChiTiet",
                        column: x => x.IdSanPhamChiTiet,
                        principalTable: "sanPhamChiTiets",
                        principalColumn: "IdSanPhamChiTiet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "chatLieus",
                columns: new[] { "IdChatLieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenChatLieu" },
                values: new object[,]
                {
                    { new Guid("0eef75ef-3a67-4751-ae6d-084bea667990"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Tự Nhiên" },
                    { new Guid("2c93c258-ce58-4817-bbc1-e7fcdcb6e844"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5327), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Lộn" },
                    { new Guid("3a7d4ee1-b970-49b8-8328-2dcb53295aa2"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da thật" },
                    { new Guid("6e814493-58b3-4e13-9923-8ceae6123c77"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Polyester" },
                    { new Guid("7b93e1f4-bb7b-4f0d-ba97-d296615627b6"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Cotton" },
                    { new Guid("a952daa6-e5cd-420f-9f13-cf016a6b3612"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Dệt" }
                });

            migrationBuilder.InsertData(
                table: "chuVu",
                columns: new[] { "IdChucVu", "Code", "TenChucVu" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "QL", "Quản lý" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "NV", "Nhân viên" }
                });

            migrationBuilder.InsertData(
                table: "danhMuc",
                columns: new[] { "IdDanhMuc", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("39edc153-9845-4446-9077-aad658058dcb"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5355), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "High – top" },
                    { new Guid("9491b1d0-aee8-4f06-9f5f-798d696b6c6b"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5353), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Da" },
                    { new Guid("9b4e81c8-554b-42f4-825d-a24f620d7d2c"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5354), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Mid – top" },
                    { new Guid("e837b83d-edd2-4008-bcf6-96eda708268f"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5351), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Thể Thao" },
                    { new Guid("f00b1a3f-607b-420c-b0ff-74b99e77be70"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5354), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Low-top" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("1e44a9d7-969b-4d55-a8ec-42e3295dc26e"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế BPU" },
                    { new Guid("381c6b62-36c2-4fcf-be3e-aedb6ca93b04"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế PVC" },
                    { new Guid("707552fa-4dfd-41c8-81c0-4ce6a115b943"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chisty" },
                    { new Guid("7f25737e-553b-4c6e-bbd7-ce9e15394268"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Giày Lười" },
                    { new Guid("8940e78a-11e7-4bb7-85a6-3eabdbd5f10d"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Eva" },
                    { new Guid("d2405ed7-0e11-4f2b-aa65-1d351e5e6712"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" },
                    { new Guid("d3fab0f6-23a4-4dea-855f-ea758a863c4d"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" },
                    { new Guid("d6a1b7cd-799e-4a6d-b754-b80aa414db3e"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chunky" },
                    { new Guid("e19cc640-4118-430f-9a60-fa67d729e985"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Cao Su Lưu Hóa" },
                    { new Guid("e801dd4b-a106-4b85-b80f-e36653f594b9"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" }
                });

            migrationBuilder.InsertData(
                table: "khachHangs",
                columns: new[] { "IdKhachHang", "AuthProvider", "Email", "HoTen", "KichHoat", "MatKhau", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoDienThoai" },
                values: new object[,]
                {
                    { new Guid("077d5972-461c-48b6-8482-1533571d1291"), "Local", "nguyenhoangp@gmail.com", "Nguyễn Hoàng Phong", 1, "1", new DateTime(2024, 12, 20, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5438), new DateTime(2024, 11, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5438), "Admin", "Admin", "0923456789" },
                    { new Guid("0c6e114a-aee4-492a-8808-8914afd25570"), "Local", "hoanganhgialai@gmail.com", "Hoàng Anh Gia Lai", 1, "1", new DateTime(2024, 12, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5425), new DateTime(2024, 10, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5425), "System", "System", "0965432109" },
                    { new Guid("0fb2976b-1de3-48ad-a52d-552cb0a92e54"), "Google", "phanthiha@gmail.com", "Phan Thị Hà", 1, "1", new DateTime(2024, 9, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5427), new DateTime(2024, 8, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5426), "Admin", "Admin", "0845678901" },
                    { new Guid("4ade52fb-7ac8-4f22-b0a2-eb20084a4052"), "Local", "lethidau@gmail.com", "Lê Thị Dậu", 1, "1", new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5420), new DateTime(2024, 12, 30, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5414), "Admin", "System", "0356789123" },
                    { new Guid("6dd76300-844f-4b95-8422-2b94ea26755d"), "Facebook", "vuvanich@gmail.com", "Vũ Văn Ich", 0, "Fb@12345", new DateTime(2025, 1, 4, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5428), new DateTime(2024, 12, 20, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5428), "Admin", "Admin", "0856781234" },
                    { new Guid("711e94e2-02b2-4da6-b02d-8da5ab9cca4a"), "Google", "dangvanem@gmail.com", "Đặng Văn Em", 1, "1", new DateTime(2025, 1, 8, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5422), new DateTime(2024, 11, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5421), "Admin", "Admin", "0398765432" },
                    { new Guid("728eef72-d4a7-478c-80d7-03ac9d4337d9"), "Google", "tranthibe@gmail.com", "Trần Thị Bé", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0987654321" },
                    { new Guid("75b1d43f-fd7a-4b3f-a30c-9c03f0131db2"), "Google", "dminhai@gmail.com", "Đỗ Minh Hải", 1, "1", new DateTime(2024, 11, 20, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5437), new DateTime(2024, 10, 1, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5437), "System", "System", "0867891234" },
                    { new Guid("8ea9b140-7820-49b5-8657-fcab71d417be"), "Facebook", "phamvannam@outlook.com", "Phạm Văn Nam", 0, "1", new DateTime(2024, 12, 10, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5436), new DateTime(2024, 10, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5435), "Admin", "Admin", "0919876543" },
                    { new Guid("8f31895e-8de5-4300-adc7-9a63e1725345"), "Google", "nguyenthikhanh@gmail.com", "Nguyễn Thị Khánh", 1, "1", new DateTime(2024, 12, 30, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5430), new DateTime(2024, 12, 25, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5429), "Admin", "System", "0834567890" },
                    { new Guid("96e73dea-a969-42d3-a64b-342cac135349"), "Local", "nguyenvanvinh@gmail.com", "Nguyễn Văn Vinh", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0912345678" },
                    { new Guid("99c8798a-0fbd-4ae1-8e72-16f58eac8cb9"), "Facebook", "phamvancanh@gmail.com", "Phạm Văn Cảnh", 0, "1", new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5413), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5413), "Admin", "Admin", "0971123456" },
                    { new Guid("bb9cfae7-5e0f-4662-847f-29cc51bf6740"), "Local", "lethimai@gmail.com", "Lê Thị Mai", 1, "1", new DateTime(2024, 7, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5433), new DateTime(2024, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5432), "Admin", "System", "0387654321" },
                    { new Guid("be6ed5e8-71d2-4f48-a756-4537f3a0a817"), "Facebook", "lyvanro@gmail.com", "Lý Văn Rô", 0, "1", new DateTime(2024, 12, 30, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5442), new DateTime(2024, 8, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5441), "Admin", "Admin", "0945678901" },
                    { new Guid("d111f598-1a5a-4b4b-8038-b7c51785217b"), "Google", "trinhthiquyen@gmail.com", "Trịnh Thị Quyên", 1, "1", new DateTime(2024, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5440), new DateTime(2023, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5439), "System", "System", "0898765432" },
                    { new Guid("ef900edc-9d6f-4d3e-921d-e4216ffef825"), "Facebook", "ngovanf@gmail.com", "Ngô Văn Phát", 0, "1", new DateTime(2024, 7, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5424), new DateTime(2024, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5423), "Admin", "Admin", "0376543210" },
                    { new Guid("fb4ec2fe-2632-4b60-8f2f-867561f197ca"), "Facebook", "tranvanly@yahoo.com", "Trần Văn Lý", 1, "1", new DateTime(2024, 11, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5431), new DateTime(2024, 5, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5431), "Admin", "Admin", "0901234567" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("0505e6cb-c76b-4115-9527-0ceff486bb7f"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5491), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5492), "Admin", "Admin", "Size 43" },
                    { new Guid("3bb65d0e-25ea-4086-a35d-cd2dcad6a2db"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5485), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5485), "Admin", "Admin", "Size 36" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("59361596-47e1-4cbc-aab0-ef5b199b97e3"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5483), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5483), "Admin", "Admin", "Size 35" },
                    { new Guid("61f0bbdf-8a38-402d-b21b-549ed6c44443"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5492), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5493), "Admin", "Admin", "Size 44" },
                    { new Guid("737b8b17-43c2-4e32-974e-be6c874afbd8"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5489), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5490), "Admin", "Admin", "Size 41" },
                    { new Guid("73afbc0e-3df6-4cea-8c84-e31806e4132f"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5486), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5486), "Admin", "Admin", "Size 37" },
                    { new Guid("8066a9f8-b96a-4de4-bf82-cadd60928d50"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5490), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5491), "Admin", "Admin", "Size 42" },
                    { new Guid("86a18d09-ee77-4e9f-a601-b6c90b3f1062"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5488), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5489), "Admin", "Admin", "Size 40" },
                    { new Guid("9fb3027d-dbe0-42ba-942e-0e73598aa656"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5487), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5487), "Admin", "Admin", "Size 38" },
                    { new Guid("a25ebf1c-2431-4589-9959-ac653557f28a"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5493), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5494), "Admin", "Admin", "Size 45" },
                    { new Guid("c14928cb-bff4-4dd4-a87a-cafb86fd5251"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5487), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5488), "Admin", "Admin", "Size 39" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("0c94703e-b30b-4a56-b375-7e6a5c26cba5"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5504), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5504), "Admin", "Admin", "Thể Thao" },
                    { new Guid("4a1ec0d2-da8a-4fd5-94c3-9e44469ffeb0"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5507), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5507), "Admin", "Admin", "Hiện Đại" },
                    { new Guid("b1fb635f-4db7-4f05-9c79-69e5e6d35701"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5506), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5506), "Admin", "Admin", "Cổ Điển" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("23ae2468-d272-4b3e-bdb2-4619373393d7"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Green" },
                    { new Guid("2f78de5a-28eb-4ec1-bda1-f9e4bf96dcdf"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5529), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5529), "Admin", "Admin", "pink" },
                    { new Guid("31e394b7-3ee6-49b1-a3ab-82eedb0aceba"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5524), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5524), "Admin", "Admin", "Black" },
                    { new Guid("399152f9-2e30-4b4a-a6a7-4ee598da66da"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5530), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5530), "Admin", "Admin", "orange" },
                    { new Guid("3e55ba1f-4ca3-49b3-9cab-7536b8c9608f"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Red" },
                    { new Guid("3f8964d6-d1d7-41d7-ad67-d0533036b7d4"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5530), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5531), "Admin", "Admin", "metallics" },
                    { new Guid("4ccaa609-1e79-4be7-925b-0f6cb32ff7ca"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5526), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5526), "Admin", "Admin", "grey" },
                    { new Guid("608397d8-f99c-4540-a3d2-46ba99b887aa"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5527), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5527), "Admin", "Admin", "navy blue" },
                    { new Guid("7d1f6839-efa6-40c8-88b3-f5320bd50fd3"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5523), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5523), "Admin", "Admin", "Blue" },
                    { new Guid("8981e6f8-2040-4dc0-b6a1-2a1d1a80840a"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5535), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5538), "Admin", "Admin", "fluorescents" },
                    { new Guid("b6a1f8f1-6471-4463-9890-96cf3834869c"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5525), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5525), "Admin", "Admin", "white" },
                    { new Guid("df12e2ee-e563-418d-8ce9-ece90862046b"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5528), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5528), "Admin", "Admin", "Brown" }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("019630b6-2b32-4555-a4c0-f6bc887feac0"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5558), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5558), "Admin", "Admin", "Puma" },
                    { new Guid("371ca178-e0dd-415b-ab6d-9e02e68c6b41"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5568), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5568), "Admin", "Admin", "Dior" },
                    { new Guid("4332377f-f685-4d8c-8556-6ba22715f006"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5556), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5555), "Admin", "Admin", "Nike" },
                    { new Guid("518a8dd7-969a-4f4c-ba80-45ef0082d021"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5571), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5570), "Admin", "Admin", "Ananas" },
                    { new Guid("57b6ac45-fa4e-416f-a3ae-eb21085638e3"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5570), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5569), "Admin", "Admin", "Biti’s" },
                    { new Guid("5ee08b65-0843-4bc1-8d31-36ce8a92cb39"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5565), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5565), "Admin", "Admin", "Gucci" },
                    { new Guid("73027988-df57-4040-9455-860a86fd054f"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5569), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5568), "Admin", "Admin", "Shondo" },
                    { new Guid("8388936f-369d-4e5b-85e4-8c7c0e805c79"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5566), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5566), "Admin", "Admin", "Louis Vuitton" },
                    { new Guid("86af958e-de5e-4de3-a549-3cfbe18712e7"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5563), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5563), "Admin", "Admin", "Fila" },
                    { new Guid("8a68bc9f-4ba7-4031-95f6-3c6e0bb41fe1"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5561), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5561), "Admin", "Admin", "Vans" },
                    { new Guid("975d5892-a59d-49c0-a036-cc4fe78adb31"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5557), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5557), "Admin", "Admin", "Adidas" },
                    { new Guid("9b6a8574-27ee-48ec-abb7-a70c8a790a58"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5567), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5567), "Admin", "Admin", "Balenciaga" },
                    { new Guid("d7fed001-984c-4f7a-b75a-0d62663a2a1a"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5560), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5560), "Admin", "Admin", "Converse" },
                    { new Guid("e55f3f5f-cf56-4ef1-963a-ce43da2b7ca8"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5562), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5562), "Admin", "Admin", "New Balance" },
                    { new Guid("ec90d482-7d74-47d1-bad0-195852c902d5"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5564), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5564), "Admin", "Admin", "MLB" },
                    { new Guid("fddc9d68-8448-4caf-a43b-772c8439bf90"), 1, new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5559), new DateTime(2025, 1, 9, 15, 11, 23, 340, DateTimeKind.Local).AddTicks(5559), "Admin", "Admin", "Reebok" }
                });

            migrationBuilder.InsertData(
                table: "diaChi",
                columns: new[] { "IdDiaChi", "DiaChiMacDinh", "DistrictId", "DistrictName", "HoTen", "IdKhachHang", "MoTa", "ProvinceId", "ProvinceName", "SoDienThoai", "WardId", "WardName" },
                values: new object[,]
                {
                    { new Guid("11ac3474-175e-4d28-8189-385c57b059fa"), true, 1001, "Huyện Tây Hòa", "Hoàng Anh J", new Guid("8f31895e-8de5-4300-adc7-9a63e1725345"), "Thôn Hồng Thái, Xã Đông Hòa", 10, "Phú Yên", "0976543210", "01001", "Xã Đông Hòa" },
                    { new Guid("1495c081-5c1d-4c62-b835-495bdbdf1821"), true, 801, "Thành phố Nha Trang", "Phan Thị Hà", new Guid("0fb2976b-1de3-48ad-a52d-552cb0a92e54"), "Số 15, Đường Hoàng Diệu", 8, "Khánh Hòa", "0845678901", "00801", "Phường Phước Long" },
                    { new Guid("2a164ec5-c7b0-4fad-8ff7-b7a94043e06f"), false, 701, "Quận Ninh Kiều", "Hoàng Anh Gia Lai", new Guid("0c6e114a-aee4-492a-8808-8914afd25570"), "Khu dân cư Bình Minh", 7, "Cần Thơ", "0965432109", "00701", "Phường Tân An" },
                    { new Guid("41b5a75d-8632-403c-865a-40c8b3c18335"), true, 101, "Quận Đống Đa", "Nguyễn Văn Vinh", new Guid("96e73dea-a969-42d3-a64b-342cac135349"), "Số 10, Ngõ 15, Đường Láng", 1, "Hà Nội", "0912345678", "00101", "Phường Láng Thượng" },
                    { new Guid("6f76da83-6dc1-448c-b65b-21d8cac17beb"), true, 601, "Thành phố Huế", "Ngô Văn Phát", new Guid("ef900edc-9d6f-4d3e-921d-e4216ffef825"), "Số 20, Đường Nguyễn Huệ", 6, "Thừa Thiên Huế", "0376543210", "00601", "Phường Vĩnh Ninh" },
                    { new Guid("b6699ecb-8347-4402-9f9b-ef8137f7ef3e"), false, 501, "Huyện Long Thành", "Đặng Văn Em", new Guid("711e94e2-02b2-4da6-b02d-8da5ab9cca4a"), "Ấp An Hòa, Xã An Bình", 5, "Đồng Nai", "0398765432", "00501", "Xã An Bình" },
                    { new Guid("c5e7807d-2e42-48f4-9f85-59f42983940f"), false, 301, "Quận Hải Châu", "Phạm Văn Cảnh", new Guid("99c8798a-0fbd-4ae1-8e72-16f58eac8cb9"), "Số 5, Đường Trần Phú", 3, "Đà Nẵng", "0971123456", "00301", "Phường Thạch Thang" },
                    { new Guid("d8ccfbce-7abf-48fe-8763-834c67e78435"), true, 201, "Quận Bình Thạnh", "Trần Thị Bé", new Guid("728eef72-d4a7-478c-80d7-03ac9d4337d9"), "Tòa nhà Landmark 81, Bình Thạnh", 2, "Hồ Chí Minh", "0987654321", "00201", "Phường 22" },
                    { new Guid("e5d63794-7ccf-44b1-bc4f-84f5d4b2bad9"), false, 901, "Thành phố Hạ Long", "Vũ Văn Ich", new Guid("6dd76300-844f-4b95-8422-2b94ea26755d"), "Số 30, Đường Lê Lợi", 9, "Quảng Ninh", "0856781234", "00901", "Phường Bãi Cháy" },
                    { new Guid("fbf5d595-2104-4399-aac1-4453628d88ba"), true, 401, "Thị xã Thuận An", "Lê Thị Dậu", new Guid("4ade52fb-7ac8-4f22-b0a2-eb20084a4052"), "Khu phố 1, Phường Vĩnh Phú", 4, "Bình Dương", "0356789123", "00401", "Phường Vĩnh Phú" }
                });

            migrationBuilder.InsertData(
                table: "nhanViens",
                columns: new[] { "IdNhanVien", "AnhNhanVien", "AuthProvider", "DiaChi", "Email", "IdchucVu", "KichHoat", "MatKhau", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoDienThoai", "TenNhanVien", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("55555555-5555-5555-5555-555555555555"), "1.png", "Local", "Hà Nội", "hieupdph40428@fpt.edu.vn", new Guid("11111111-1111-1111-1111-111111111111"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0976819974", "Phạm Đức Hiếu", 1 },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "1.png", "Local", "Đà Nẵng", "tranha10112004@gmail.com", new Guid("11111111-1111-1111-1111-111111111111"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0969293263", "Trần Ngọc Hà", 1 },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "1.png", "Local", "Đà Nẵng", "longkhph35837@fpt.edu.vn", new Guid("22222222-2222-2222-2222-222222222222"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0377804800", "Kim Hoàng Long", 1 },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "1.png", "Local", "Đà Nẵng", "namdtph39830@fpt.edu.vn", new Guid("22222222-2222-2222-2222-222222222222"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0855896668", "Đào Thành Nam", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_diaChi_IdKhachHang",
                table: "diaChi",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_gioHang_IdKhachHang",
                table: "gioHang",
                column: "IdKhachHang",
                unique: true,
                filter: "[IdKhachHang] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangChiTiets_IdGioHang",
                table: "gioHangChiTiets",
                column: "IdGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangChiTiets_IdSanPhamChiTiet",
                table: "gioHangChiTiets",
                column: "IdSanPhamChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_hinhAnh_IdSanPhamChiTiet",
                table: "hinhAnh",
                column: "IdSanPhamChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_IdHoaDon",
                table: "hoaDonChiTiets",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_IdSanPhamChiTiet",
                table: "hoaDonChiTiets",
                column: "IdSanPhamChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_IdDiaChiHoaDon",
                table: "hoaDons",
                column: "IdDiaChiHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_IdKhachHang",
                table: "hoaDons",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_IdNhanVien",
                table: "hoaDons",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_lichSuHoaDons_IdHoaDon",
                table: "lichSuHoaDons",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_lichSuHoaDons_IdNhanVien",
                table: "lichSuHoaDons",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuSuDungVoucher_IdVoucher_IdKhachHang_IdHoaDon",
                table: "LichSuSuDungVouchers",
                columns: new[] { "IdVoucher", "IdKhachHang", "IdHoaDon" },
                unique: true,
                filter: "[IdHoaDon] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuSuDungVouchers_HoaDonIdHoaDon",
                table: "LichSuSuDungVouchers",
                column: "HoaDonIdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuSuDungVouchers_IdKhachHang",
                table: "LichSuSuDungVouchers",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_lichSuThanhToans_IdHoaDon",
                table: "lichSuThanhToans",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_lichSuThanhToans_IdNhanVien",
                table: "lichSuThanhToans",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_IdchucVu",
                table: "nhanViens",
                column: "IdchucVu");

            migrationBuilder.CreateIndex(
                name: "IX_promotionSanPhamChiTiets_IdSanPhamChiTiet",
                table: "promotionSanPhamChiTiets",
                column: "IdSanPhamChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTietKichCos_IdKichCo",
                table: "sanPhamChiTietKichCos",
                column: "IdKichCo");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTietMausacs_IdMauSac",
                table: "sanPhamChiTietMausacs",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiets_IdSanPham",
                table: "sanPhamChiTiets",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_IdChatLieu",
                table: "sanPhams",
                column: "IdChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_IdDanhMuc",
                table: "sanPhams",
                column: "IdDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_IdDeGiay",
                table: "sanPhams",
                column: "IdDeGiay");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_IdKieuDang",
                table: "sanPhams",
                column: "IdKieuDang");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_IdThuongHieu",
                table: "sanPhams",
                column: "IdThuongHieu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "diaChi");

            migrationBuilder.DropTable(
                name: "districts");

            migrationBuilder.DropTable(
                name: "gioHangChiTiets");

            migrationBuilder.DropTable(
                name: "hinhAnh");

            migrationBuilder.DropTable(
                name: "hoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "lichSuHoaDons");

            migrationBuilder.DropTable(
                name: "LichSuSuDungVouchers");

            migrationBuilder.DropTable(
                name: "lichSuThanhToans");

            migrationBuilder.DropTable(
                name: "promotionSanPhamChiTiets");

            migrationBuilder.DropTable(
                name: "provinces");

            migrationBuilder.DropTable(
                name: "sanPhamChiTietKichCos");

            migrationBuilder.DropTable(
                name: "sanPhamChiTietMausacs");

            migrationBuilder.DropTable(
                name: "wards");

            migrationBuilder.DropTable(
                name: "gioHang");

            migrationBuilder.DropTable(
                name: "vouchers");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "promotions");

            migrationBuilder.DropTable(
                name: "kichCos");

            migrationBuilder.DropTable(
                name: "mauSacs");

            migrationBuilder.DropTable(
                name: "sanPhamChiTiets");

            migrationBuilder.DropTable(
                name: "diaChiHoaDons");

            migrationBuilder.DropTable(
                name: "khachHangs");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "sanPhams");

            migrationBuilder.DropTable(
                name: "chuVu");

            migrationBuilder.DropTable(
                name: "chatLieus");

            migrationBuilder.DropTable(
                name: "danhMuc");

            migrationBuilder.DropTable(
                name: "deGiay");

            migrationBuilder.DropTable(
                name: "kieuDangs");

            migrationBuilder.DropTable(
                name: "thuongHieus");
        }
    }
}
