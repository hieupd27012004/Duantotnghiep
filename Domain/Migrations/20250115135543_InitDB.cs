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
                    TienShip = table.Column<double>(type: "float", nullable: true),
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
                    { new Guid("02523363-205a-44d5-adbd-00656b0ca070"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9788), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Lộn" },
                    { new Guid("0459d56a-8a76-48d3-be4e-c94d23d52683"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Tự Nhiên" },
                    { new Guid("79ebd68e-e0cc-47e9-8c23-31fd2e8b34cc"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da thật" },
                    { new Guid("9a37c26d-394f-4aa3-8a8e-28ad8330214a"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Cotton" },
                    { new Guid("cba1eeff-0364-47c7-8a00-0d93b2ad5689"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Dệt" },
                    { new Guid("e1aba880-20aa-4927-893d-5d4e408f2fd4"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Polyester" }
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
                    { new Guid("0b873b85-4ff6-42c6-bcac-a19f6cc4c1d5"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9836), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Cổ Trung" },
                    { new Guid("b0e346b6-1005-414e-b632-65f509d04e27"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9833), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Da" },
                    { new Guid("e328a42d-9de7-437c-922f-1a173c976fdc"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9837), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Cổ Cao" },
                    { new Guid("e47e93e1-9169-4309-8fb7-dbcf98c57c9e"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9831), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Thể Thao" },
                    { new Guid("f0aee21a-cac3-4993-aa54-6d9cfe1c22d4"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9835), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Cổ Thấp" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("4899f17b-5616-455a-afa6-a26e7f37ea5f"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" },
                    { new Guid("4ddfb7dd-fd92-4047-86e3-9ec852b25f56"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Giày Lười" },
                    { new Guid("59806fe2-fd1b-4dc5-8eb6-66fcee3e0314"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Eva" },
                    { new Guid("5dc96e5b-aba2-4517-a41a-ccc42c7e368a"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chisty" },
                    { new Guid("7cc856ed-e388-47a0-883e-17510ad3b005"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Cao Su Lưu Hóa" },
                    { new Guid("8a9741e7-90a3-41d5-8df6-3574ecdf3bfc"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế BPU" },
                    { new Guid("988347fe-7699-4218-9add-b357326ffb78"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" },
                    { new Guid("b951cfea-2e56-4003-8d16-191e219dc2d7"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" },
                    { new Guid("cf03a119-91af-47d7-a101-0f0cbf799e4c"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế PVC" },
                    { new Guid("fa0df332-3922-4cd3-8ebd-2f4b2918e50a"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chunky" }
                });

            migrationBuilder.InsertData(
                table: "khachHangs",
                columns: new[] { "IdKhachHang", "AuthProvider", "Email", "HoTen", "KichHoat", "MatKhau", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoDienThoai" },
                values: new object[,]
                {
                    { new Guid("0a915a26-54d7-41ad-a46a-4d19dbbe67c4"), "Facebook", "phamvannam@outlook.com", "Phạm Văn Nam", 0, "1", new DateTime(2024, 12, 16, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9973), new DateTime(2024, 10, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9972), "Admin", "Admin", "0919876543" },
                    { new Guid("0dfd45b5-e823-4f2d-bd4a-b073bb3c1a75"), "Facebook", "tranvanly@yahoo.com", "Trần Văn Lý", 1, "1", new DateTime(2024, 11, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9968), new DateTime(2024, 5, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9967), "Admin", "Admin", "0901234567" },
                    { new Guid("12dc10c3-2684-4d8d-bee4-48ebbbdb07f9"), "Google", "tranthibe@gmail.com", "Trần Thị Bé", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0987654321" },
                    { new Guid("19094d9c-6761-42f2-aaf9-432b87060f73"), "Facebook", "lyvanro@gmail.com", "Lý Văn Rô", 0, "1", new DateTime(2025, 1, 5, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9983), new DateTime(2024, 8, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9983), "Admin", "Admin", "0945678901" },
                    { new Guid("321c54f0-2745-452f-9e7e-c741364d3def"), "Local", "nguyenvanvinh@gmail.com", "Nguyễn Văn Vinh", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0912345678" },
                    { new Guid("3d4cbedd-409f-49b5-8651-dfd39a1502df"), "Local", "lethimai@gmail.com", "Lê Thị Mai", 1, "1", new DateTime(2024, 7, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9970), new DateTime(2024, 1, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9970), "Admin", "System", "0387654321" },
                    { new Guid("3d510394-496b-40e7-8c6f-950c8e65f8b3"), "Google", "trinhthiquyen@gmail.com", "Trịnh Thị Quyên", 1, "1", new DateTime(2024, 1, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 1, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9980), "System", "System", "0898765432" },
                    { new Guid("431b274e-8f9f-438b-8515-897bec221b13"), "Facebook", "phamvancanh@gmail.com", "Phạm Văn Cảnh", 0, "1", new DateTime(2025, 1, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9940), new DateTime(2025, 1, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9939), "Admin", "Admin", "0971123456" },
                    { new Guid("614a5e5e-05ab-4f20-a135-fb0dacf1b55a"), "Local", "nguyenhoangp@gmail.com", "Nguyễn Hoàng Phong", 1, "1", new DateTime(2024, 12, 26, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9977), new DateTime(2024, 11, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9977), "Admin", "Admin", "0923456789" },
                    { new Guid("70083af1-b1d9-4129-9c83-9ac9ac34edbf"), "Google", "dangvanem@gmail.com", "Đặng Văn Em", 1, "1", new DateTime(2025, 1, 14, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9952), new DateTime(2024, 11, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9950), "Admin", "Admin", "0398765432" },
                    { new Guid("744c06db-f2b9-4a1f-b6a2-b9062cf60983"), "Google", "dminhai@gmail.com", "Đỗ Minh Hải", 1, "1", new DateTime(2024, 11, 26, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9975), new DateTime(2024, 10, 7, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9975), "System", "System", "0867891234" },
                    { new Guid("84d0868f-17b3-49d9-a809-cb0e837dcfe1"), "Local", "hoanganhgialai@gmail.com", "Hoàng Anh Gia Lai", 1, "1", new DateTime(2024, 12, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9958), new DateTime(2024, 10, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9957), "System", "System", "0965432109" },
                    { new Guid("8ff73b1f-823c-460e-a6f3-57d822a2e4ee"), "Google", "phanthiha@gmail.com", "Phan Thị Hà", 1, "1", new DateTime(2024, 9, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9960), new DateTime(2024, 8, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9959), "Admin", "Admin", "0845678901" },
                    { new Guid("afe21bee-9876-4582-b463-18829b9d5790"), "Facebook", "vuvanich@gmail.com", "Vũ Văn Ich", 0, "Fb@12345", new DateTime(2025, 1, 10, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9963), new DateTime(2024, 12, 26, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9962), "Admin", "Admin", "0856781234" },
                    { new Guid("ba186d08-570d-402e-a320-956f098ffa77"), "Google", "nguyenthikhanh@gmail.com", "Nguyễn Thị Khánh", 1, "1", new DateTime(2025, 1, 5, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9966), new DateTime(2024, 12, 31, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9965), "Admin", "System", "0834567890" },
                    { new Guid("ef634e73-bd1f-4cae-897d-6110a1f5b133"), "Local", "lethidau@gmail.com", "Lê Thị Dậu", 1, "1", new DateTime(2025, 1, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9948), new DateTime(2025, 1, 5, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9941), "Admin", "System", "0356789123" },
                    { new Guid("f07c1a2c-c787-409a-bbbb-1836476b932e"), "Facebook", "ngovanf@gmail.com", "Ngô Văn Phát", 0, "1", new DateTime(2024, 7, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9955), new DateTime(2024, 1, 15, 20, 55, 42, 713, DateTimeKind.Local).AddTicks(9954), "Admin", "Admin", "0376543210" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("02dafa87-33b5-4c9a-b8ed-1605223e0adf"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(95), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(95), "Admin", "Admin", "45" },
                    { new Guid("147ead2b-d854-4185-8466-38b6044d3d88"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(85), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(86), "Admin", "Admin", "39" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("21b9659c-f288-43fe-8a08-a1f0786632b9"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(82), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(83), "Admin", "Admin", "37" },
                    { new Guid("3ca76c73-e68a-42de-9176-f507086553b3"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(93), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(94), "Admin", "Admin", "44" },
                    { new Guid("96dee5dd-2ef0-4079-9886-7b75231b423d"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(90), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(91), "Admin", "Admin", "42" },
                    { new Guid("97e264a3-c9a2-49a2-820f-6591f7aa1010"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(78), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(79), "Admin", "Admin", "35" },
                    { new Guid("a8ab6c00-7bf5-42aa-bcdd-0fde2f506846"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(84), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(84), "Admin", "Admin", "38" },
                    { new Guid("c8d028f0-d430-4b8a-9831-f411a51e214f"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(92), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(92), "Admin", "Admin", "43" },
                    { new Guid("de99ba5d-e586-4953-b545-fd8c1b1dc737"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(81), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(81), "Admin", "Admin", "36" },
                    { new Guid("e7f36217-a34e-493e-b6a9-52a9a05be1c5"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(89), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(89), "Admin", "Admin", "41" },
                    { new Guid("f1d69f03-e3d4-4402-9608-9de80b641b20"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(87), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(87), "Admin", "Admin", "40" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("0c8be782-c5d7-4e10-a094-fbcb49938026"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(117), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(117), "Admin", "Admin", "Cổ Điển" },
                    { new Guid("499c0b08-5559-4bc1-a2eb-4a470fabdf46"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(114), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(114), "Admin", "Admin", "Thể Thao" },
                    { new Guid("a4336330-dba1-42cc-89e3-f258305f7bbb"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(119), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(118), "Admin", "Admin", "Hiện Đại" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("0cdac6b1-eb9a-4ce4-80f5-6b15d57ce54c"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(153), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(154), "Admin", "Admin", "Hồng" },
                    { new Guid("110d17a7-6d8d-485d-a09c-9fba237b7e10"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(145), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(146), "Admin", "Admin", "Đen" },
                    { new Guid("3d6e395c-6992-4cba-a270-ec605bac6c93"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(150), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(151), "Admin", "Admin", "Xanh Navy" },
                    { new Guid("40e5fca3-dd4a-41a0-99b9-52e54d9b48f0"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Xanh lá" },
                    { new Guid("5a294206-da9f-456b-bdfc-e666ecc11e45"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(149), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(149), "Admin", "Admin", "Xám" },
                    { new Guid("832c37cc-c273-4258-a66a-f84af4d05222"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(156), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(157), "Admin", "Admin", "Kim loại" },
                    { new Guid("8c39ba81-d139-479e-9a4c-bb41b8ce2a1b"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(155), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(155), "Admin", "Admin", "Cam" },
                    { new Guid("943dba84-6932-47d7-b221-54c31f4c6c2e"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đỏ" },
                    { new Guid("9468abb4-68d2-486f-b705-e19e51dd32aa"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(158), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(158), "Admin", "Admin", "Phát quang" },
                    { new Guid("afc20e09-6128-4e47-bfbb-591f8dfcd699"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(152), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(152), "Admin", "Admin", "Nâu" },
                    { new Guid("c9c34d93-6a8d-4702-9e26-4ae8e66e4a06"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(144), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(144), "Admin", "Admin", "Xanh dương" },
                    { new Guid("ec7fd966-9000-4501-8047-9cc6159b7974"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(147), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(148), "Admin", "Admin", "Trắng" }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("31bb7515-89e0-4c6f-855b-f26e26931f2d"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(214), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(214), "Admin", "Admin", "Biti’s" },
                    { new Guid("3ce279f6-c625-433c-8f72-e0996d28b18c"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(198), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(197), "Admin", "Admin", "Reebok" },
                    { new Guid("53faf80a-f67a-4a12-aa1f-d5fc649da7c0"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(213), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(212), "Admin", "Admin", "Shondo" },
                    { new Guid("55136cd1-8561-4047-84b1-b722963f4324"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(210), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(209), "Admin", "Admin", "Balenciaga" },
                    { new Guid("66911641-ada4-47b8-bb5d-5b76806ac8d8"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(199), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(199), "Admin", "Admin", "Converse" },
                    { new Guid("77b453b9-ca7a-4820-adf6-d83a503843ef"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(201), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(200), "Admin", "Admin", "Vans" },
                    { new Guid("7f40e88e-69f2-480d-88af-5e1dfb4dd06f"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(196), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(196), "Admin", "Admin", "Puma" },
                    { new Guid("826b9d2b-55d4-495f-812b-3d977cfb5229"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(204), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(203), "Admin", "Admin", "Fila" },
                    { new Guid("ae373afc-0158-4461-be97-84ffca925dd0"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(207), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(206), "Admin", "Admin", "Gucci" },
                    { new Guid("b9789e7f-9741-40d5-a291-935bf7794af4"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(202), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(202), "Admin", "Admin", "New Balance" },
                    { new Guid("c9e3c060-f1e0-400b-a257-cd55d076cdb9"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(205), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(205), "Admin", "Admin", "MLB" },
                    { new Guid("d15794c3-4d2f-4cd3-ab7b-6217989bf952"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(192), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(191), "Admin", "Admin", "Nike" },
                    { new Guid("db255edf-ecc7-4728-b192-8fa55481288a"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(211), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(211), "Admin", "Admin", "Dior" },
                    { new Guid("e20a75db-9a19-475a-9334-837b27cfccaa"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(208), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(208), "Admin", "Admin", "Louis Vuitton" },
                    { new Guid("e9d40766-01f5-48cd-a8a2-84222271a1a1"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(216), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(215), "Admin", "Admin", "Ananas" },
                    { new Guid("ee51a51f-409d-4879-9c2f-e064d49e7dd4"), 1, new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(194), new DateTime(2025, 1, 15, 20, 55, 42, 714, DateTimeKind.Local).AddTicks(194), "Admin", "Admin", "Adidas" }
                });

            migrationBuilder.InsertData(
                table: "diaChi",
                columns: new[] { "IdDiaChi", "DiaChiMacDinh", "DistrictId", "DistrictName", "HoTen", "IdKhachHang", "MoTa", "ProvinceId", "ProvinceName", "SoDienThoai", "WardId", "WardName" },
                values: new object[,]
                {
                    { new Guid("1c6721e1-883f-47af-870c-7309c70a0ca8"), true, 801, "Thành phố Nha Trang", "Phan Thị Hà", new Guid("8ff73b1f-823c-460e-a6f3-57d822a2e4ee"), "Số 15, Đường Hoàng Diệu", 8, "Khánh Hòa", "0845678901", "00801", "Phường Phước Long" },
                    { new Guid("21ca6756-a3df-4a07-aff6-f58c3d7419ed"), false, 501, "Huyện Long Thành", "Đặng Văn Em", new Guid("70083af1-b1d9-4129-9c83-9ac9ac34edbf"), "Ấp An Hòa, Xã An Bình", 5, "Đồng Nai", "0398765432", "00501", "Xã An Bình" },
                    { new Guid("43efa7cf-97e1-4a80-9091-6e5f07214990"), false, 301, "Quận Hải Châu", "Phạm Văn Cảnh", new Guid("431b274e-8f9f-438b-8515-897bec221b13"), "Số 5, Đường Trần Phú", 3, "Đà Nẵng", "0971123456", "00301", "Phường Thạch Thang" },
                    { new Guid("68778857-2471-49d1-8ad1-7f44b5204b38"), false, 901, "Thành phố Hạ Long", "Vũ Văn Ich", new Guid("afe21bee-9876-4582-b463-18829b9d5790"), "Số 30, Đường Lê Lợi", 9, "Quảng Ninh", "0856781234", "00901", "Phường Bãi Cháy" },
                    { new Guid("7599558d-7228-4b2e-8426-b717c0e46b9f"), true, 601, "Thành phố Huế", "Ngô Văn Phát", new Guid("f07c1a2c-c787-409a-bbbb-1836476b932e"), "Số 20, Đường Nguyễn Huệ", 6, "Thừa Thiên Huế", "0376543210", "00601", "Phường Vĩnh Ninh" },
                    { new Guid("a110ea8e-87d4-4a19-b833-9c53bc733ba4"), true, 201, "Quận Bình Thạnh", "Trần Thị Bé", new Guid("12dc10c3-2684-4d8d-bee4-48ebbbdb07f9"), "Tòa nhà Landmark 81, Bình Thạnh", 2, "Hồ Chí Minh", "0987654321", "00201", "Phường 22" },
                    { new Guid("ad5a1bf7-e074-4beb-ac0d-c04dd728d1e0"), false, 701, "Quận Ninh Kiều", "Hoàng Anh Gia Lai", new Guid("84d0868f-17b3-49d9-a809-cb0e837dcfe1"), "Khu dân cư Bình Minh", 7, "Cần Thơ", "0965432109", "00701", "Phường Tân An" },
                    { new Guid("caf5c29c-c0b9-49e8-9f7c-3c94016070eb"), true, 401, "Thị xã Thuận An", "Lê Thị Dậu", new Guid("ef634e73-bd1f-4cae-897d-6110a1f5b133"), "Khu phố 1, Phường Vĩnh Phú", 4, "Bình Dương", "0356789123", "00401", "Phường Vĩnh Phú" },
                    { new Guid("d6203339-0eee-4765-8e7f-45d1e6e91868"), true, 1001, "Huyện Tây Hòa", "Hoàng Anh J", new Guid("ba186d08-570d-402e-a320-956f098ffa77"), "Thôn Hồng Thái, Xã Đông Hòa", 10, "Phú Yên", "0976543210", "01001", "Xã Đông Hòa" },
                    { new Guid("f5720a32-72ba-4bbc-80e3-2b0158474991"), true, 101, "Quận Đống Đa", "Nguyễn Văn Vinh", new Guid("321c54f0-2745-452f-9e7e-c741364d3def"), "Số 10, Ngõ 15, Đường Láng", 1, "Hà Nội", "0912345678", "00101", "Phường Láng Thượng" }
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
