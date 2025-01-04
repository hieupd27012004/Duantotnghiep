using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    public partial class @long : Migration
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
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { new Guid("1c3d0d5a-b12b-47b6-a24d-7068c547a5f3"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Tự Nhiên" },
                    { new Guid("4d603551-f97c-4bfd-8e9a-9d6e6998ee96"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Cotton" },
                    { new Guid("6961b63f-334e-4c5c-a3e5-ffbaf34c7654"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Dệt" },
                    { new Guid("d869a183-ed63-4e7c-8da8-13c3366b6724"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da thật" },
                    { new Guid("dd33b794-d851-4216-9715-2e5d34ad3470"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3049), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Lộn" },
                    { new Guid("f3b7605f-df4a-4f06-bfe2-6aea9da5c33e"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Polyester" }
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
                    { new Guid("31abf32b-1e23-4089-a1dc-da5e1df55699"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3088), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Thể Thao" },
                    { new Guid("4b470845-996d-4606-bbde-923b496164bb"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3093), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "High – top" },
                    { new Guid("7ba77eee-6134-4c8a-9999-12efd441fb0c"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3091), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Low-top" },
                    { new Guid("88443050-48c9-497f-8eb2-c2fba9ce66a7"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3092), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Mid – top" },
                    { new Guid("acfa91c0-82c8-458c-a41f-abac97081409"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3090), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Da" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("3aa6a373-d9eb-4b1f-9d76-58a034745468"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" },
                    { new Guid("3ac52090-52f5-4507-be48-61acd638041e"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chisty" },
                    { new Guid("425e9229-fcf7-4330-b282-989dd9bbf0c1"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Giày Lười" },
                    { new Guid("56f6c434-8bf5-4279-8a63-c4298f6df0e4"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế PVC" },
                    { new Guid("574f2d18-a836-4e13-a309-2f524657ddf9"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Eva" },
                    { new Guid("7f63c53a-f04c-4a0a-a9a4-805c87da9a38"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Cao Su Lưu Hóa" },
                    { new Guid("bba1adb7-dac9-4621-9be1-ebb39b1cfff9"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" },
                    { new Guid("ce9ae7f3-2c43-466b-a760-7684f71ef8fc"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế BPU" },
                    { new Guid("d8e0ca15-39d8-4de7-80df-3233aea18bc0"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" },
                    { new Guid("f7930d15-cad3-425e-90ba-6786dbdc55ed"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chunky" }
                });

            migrationBuilder.InsertData(
                table: "khachHangs",
                columns: new[] { "IdKhachHang", "AuthProvider", "Email", "HoTen", "KichHoat", "MatKhau", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoDienThoai" },
                values: new object[,]
                {
                    { new Guid("113552dc-6bf6-4b05-a42f-83fb3943b51d"), "Facebook", "phamvannam@outlook.com", "Phạm Văn Nam", 0, "1", new DateTime(2024, 11, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3202), new DateTime(2024, 9, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3201), "Admin", "Admin", "0919876543" },
                    { new Guid("23e31185-742b-4a67-af7f-b635623a60f3"), "Facebook", "ngovanf@gmail.com", "Ngô Văn Phát", 0, "1", new DateTime(2024, 6, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3186), new DateTime(2023, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3185), "Admin", "Admin", "0376543210" },
                    { new Guid("283c7c23-a216-46fb-b76e-956c145bff5f"), "Local", "nguyenvanvinh@gmail.com", "Nguyễn Văn Vinh", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0912345678" },
                    { new Guid("40cefc22-0a5e-41d2-b267-cc979d85c36f"), "Google", "trinhthiquyen@gmail.com", "Trịnh Thị Quyên", 1, "1", new DateTime(2023, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3208), new DateTime(2022, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3207), "System", "System", "0898765432" },
                    { new Guid("4cb915c9-85cc-45bf-84de-5a5e8147949f"), "Google", "tranthibe@gmail.com", "Trần Thị Bé", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0987654321" },
                    { new Guid("58721397-1a0a-414c-82aa-c76607ed0690"), "Facebook", "phamvancanh@gmail.com", "Phạm Văn Cảnh", 0, "1", new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3172), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3172), "Admin", "Admin", "0971123456" },
                    { new Guid("6542f121-42df-48b4-851e-5927a1a356cc"), "Local", "lethimai@gmail.com", "Lê Thị Mai", 1, "1", new DateTime(2024, 6, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3200), new DateTime(2023, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3199), "Admin", "System", "0387654321" },
                    { new Guid("6ca4e763-9423-44cd-9da6-3ae5d900ae31"), "Local", "lethidau@gmail.com", "Lê Thị Dậu", 1, "1", new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3179), new DateTime(2024, 12, 19, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3174), "Admin", "System", "0356789123" },
                    { new Guid("792a0b0b-90a2-4087-a998-ad487ba71b44"), "Google", "nguyenthikhanh@gmail.com", "Nguyễn Thị Khánh", 1, "1", new DateTime(2024, 12, 19, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3195), new DateTime(2024, 12, 14, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3195), "Admin", "System", "0834567890" },
                    { new Guid("8baae0e7-5c46-4007-bc5a-cbb9d0909d36"), "Local", "hoanganhgialai@gmail.com", "Hoàng Anh Gia Lai", 1, "1", new DateTime(2024, 11, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3188), new DateTime(2024, 9, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3187), "System", "System", "0965432109" },
                    { new Guid("94ba53fb-5f6a-4d02-9621-f48ebec6b35b"), "Facebook", "lyvanro@gmail.com", "Lý Văn Rô", 0, "1", new DateTime(2024, 12, 19, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3210), new DateTime(2024, 7, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3209), "Admin", "Admin", "0945678901" },
                    { new Guid("b8de06f6-a700-4ffc-a122-7ac46ffa3f51"), "Google", "phanthiha@gmail.com", "Phan Thị Hà", 1, "1", new DateTime(2024, 8, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3190), new DateTime(2024, 7, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3189), "Admin", "Admin", "0845678901" },
                    { new Guid("c0d6c1f0-2ac6-4ae5-8e84-7ef5320fcf8b"), "Local", "nguyenhoangp@gmail.com", "Nguyễn Hoàng Phong", 1, "1", new DateTime(2024, 12, 9, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3206), new DateTime(2024, 10, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3205), "Admin", "Admin", "0923456789" },
                    { new Guid("d0b1c894-96c2-4b7d-9298-d93ac9d73850"), "Facebook", "tranvanly@yahoo.com", "Trần Văn Lý", 1, "1", new DateTime(2024, 10, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3197), new DateTime(2024, 4, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3197), "Admin", "Admin", "0901234567" },
                    { new Guid("d1ecce85-8720-4997-a68b-a7ad12de322f"), "Facebook", "vuvanich@gmail.com", "Vũ Văn Ich", 0, "Fb@12345", new DateTime(2024, 12, 24, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3192), new DateTime(2024, 12, 9, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3192), "Admin", "Admin", "0856781234" },
                    { new Guid("e7089609-32ff-4645-88bf-f02a092cc289"), "Google", "dangvanem@gmail.com", "Đặng Văn Em", 1, "1", new DateTime(2024, 12, 28, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3182), new DateTime(2024, 10, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3181), "Admin", "Admin", "0398765432" },
                    { new Guid("f7cb1c4f-bc1c-434f-a6a9-462a2dc0c7bd"), "Google", "dminhai@gmail.com", "Đỗ Minh Hải", 1, "1", new DateTime(2024, 11, 9, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3204), new DateTime(2024, 9, 20, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3203), "System", "System", "0867891234" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("015b73ed-4cb7-418a-a984-d712af52ee0c"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3300), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3301), "Admin", "Admin", "Size 40" },
                    { new Guid("1d18408f-de80-4b61-b8a5-03364010a356"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3306), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3307), "Admin", "Admin", "Size 44" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("1d218d44-b6bf-4652-9e14-3930588c7f84"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3305), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3305), "Admin", "Admin", "Size 43" },
                    { new Guid("39bd8953-742b-407a-a2d4-11eb1a2221e7"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3298), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3298), "Admin", "Admin", "Size 38" },
                    { new Guid("402afda0-b163-4712-94dc-225b8024544b"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3292), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3293), "Admin", "Admin", "Size 35" },
                    { new Guid("7cd411dc-e876-4922-b3d0-364912c489a7"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3294), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3295), "Admin", "Admin", "Size 36" },
                    { new Guid("888f9b36-cf35-49af-8fd9-f5aad2fa37bd"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3302), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3302), "Admin", "Admin", "Size 41" },
                    { new Guid("bfd6e7b8-9e24-435d-92eb-68412a984900"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3296), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3297), "Admin", "Admin", "Size 37" },
                    { new Guid("cfa61eec-d59c-48c7-a490-9e36af027ecc"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3308), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3308), "Admin", "Admin", "Size 45" },
                    { new Guid("daa8884c-4f40-4b93-8828-5e59dd112154"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3299), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3299), "Admin", "Admin", "Size 39" },
                    { new Guid("e93495bf-c672-429d-9fc8-4fe852963a62"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3303), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3304), "Admin", "Admin", "Size 42" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("1a5bb968-0e83-4d06-8b01-edf6f0e3f3d2"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3332), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3332), "Admin", "Admin", "Cổ Điển" },
                    { new Guid("9a50a5bd-150d-452c-a303-db2d72ea1fda"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3334), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3333), "Admin", "Admin", "Hiện Đại" },
                    { new Guid("e3545ce5-8ff1-4a8c-989b-9d49f2cf7aee"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3330), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3329), "Admin", "Admin", "Thể Thao" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("07fa9320-be9e-44ff-89de-5e377de92af3"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3363), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3363), "Admin", "Admin", "grey" },
                    { new Guid("3acac49e-e127-496b-9f25-563c29907ca6"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3371), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3372), "Admin", "Admin", "fluorescents" },
                    { new Guid("3be47e2b-1645-459b-ad78-d2e3e2cd92a5"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3366), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3366), "Admin", "Admin", "Brown" },
                    { new Guid("4ab01ec3-edfa-4568-8b75-cbb210c9c83e"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3360), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3361), "Admin", "Admin", "Black" },
                    { new Guid("4ede1efc-bec6-4020-b75f-ba3d369e6852"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3364), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3365), "Admin", "Admin", "navy blue" },
                    { new Guid("51f38f74-97ef-44df-b8ff-9e2e5e956f1a"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Red" },
                    { new Guid("64d417a2-621a-40b9-af55-721d92bddd55"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3362), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3362), "Admin", "Admin", "white" },
                    { new Guid("cedb4ca4-515e-4abe-a110-8ae25d336bf2"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Green" },
                    { new Guid("e1645d83-6e61-4212-9512-ac81d429f418"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3370), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3370), "Admin", "Admin", "metallics" },
                    { new Guid("e18452a9-f0c5-493f-8bbf-75ffecaa30e4"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3367), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3368), "Admin", "Admin", "pink" },
                    { new Guid("e4060135-7cf0-4a8a-bf23-e1c54ea48e83"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3359), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3359), "Admin", "Admin", "Blue" },
                    { new Guid("fb06e4b0-9ee6-4cf5-9c10-0e754f8084ec"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3368), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3369), "Admin", "Admin", "orange" }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("09bff636-c0f6-47ad-b65f-7c6195c22a65"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3400), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3400), "Admin", "Admin", "Nike" },
                    { new Guid("189662ab-40ed-4c73-8ac0-0470428b7cdd"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3419), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3419), "Admin", "Admin", "Shondo" },
                    { new Guid("2ec1ea33-b53a-440f-95b9-23d9fb279754"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3408), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3408), "Admin", "Admin", "Vans" },
                    { new Guid("2fa6e32e-f256-419a-9a6a-80faead6131b"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3412), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3412), "Admin", "Admin", "MLB" },
                    { new Guid("42553e27-d0b9-47f9-90d6-e6f110e8afbd"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3422), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3422), "Admin", "Admin", "Ananas" },
                    { new Guid("509cec44-7a0d-4079-b26e-146ffaf52ae2"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3411), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3411), "Admin", "Admin", "Fila" },
                    { new Guid("67d69751-9439-4d60-9589-115d4b45b387"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3404), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3404), "Admin", "Admin", "Puma" },
                    { new Guid("81b1d30c-4454-4cdb-a456-0aa0053c5ba6"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3403), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3402), "Admin", "Admin", "Adidas" },
                    { new Guid("83780462-245e-4387-9c46-d1ac2a43f580"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3407), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3406), "Admin", "Admin", "Converse" },
                    { new Guid("944f6fb5-75f0-4111-bf37-f78f6a88ac76"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3410), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3409), "Admin", "Admin", "New Balance" },
                    { new Guid("9ccd21e8-9a4e-4780-902b-d08694af6a3a"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3415), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3415), "Admin", "Admin", "Louis Vuitton" },
                    { new Guid("be08177b-7503-4cec-add4-b8a7d511e300"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3421), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3420), "Admin", "Admin", "Biti’s" },
                    { new Guid("cedec90b-bf3e-4d41-9027-8c79d7b60458"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3417), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3416), "Admin", "Admin", "Balenciaga" },
                    { new Guid("d16c132c-69e9-4c7f-81a1-0ecd410b66ec"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3414), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3413), "Admin", "Admin", "Gucci" },
                    { new Guid("d50749ba-9227-4378-a85e-5e8c784b76b4"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3418), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3418), "Admin", "Admin", "Dior" },
                    { new Guid("f2906cef-936e-421a-bd40-327625086da4"), 1, new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3406), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3405), "Admin", "Admin", "Reebok" }
                });

            migrationBuilder.InsertData(
                table: "vouchers",
                columns: new[] { "VoucherId", "GiaTriDonHangToiThieu", "GiaTriGiam", "LoaiGiamGia", "MaVoucher", "MoTaVoucher", "NgayBatDau", "NgayKetThuc", "NgayTao", "NgayUpdate", "NguoiTao", "NguoiUpdate", "SoTienToiDa", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("2e6cc565-9c72-4177-9513-43b1850f5e38"), 100000, 10, 1, "VOUCHER10", "Giảm 10% cho đơn hàng trên 100.000 VNĐ", new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3451), new DateTime(2025, 1, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3451), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3452), null, "Admin", null, null, 2 },
                    { new Guid("363b298f-b9de-4d5a-b50d-81573260a8ce"), 300000, 20, 1, "VOUCHER20", "Giảm 20% cho đơn hàng trên 300.000 VNĐ", new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3458), new DateTime(2025, 3, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3458), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3459), null, "Admin", null, 100000, 2 }
                });

            migrationBuilder.InsertData(
                table: "vouchers",
                columns: new[] { "VoucherId", "GiaTriDonHangToiThieu", "GiaTriGiam", "LoaiGiamGia", "MaVoucher", "MoTaVoucher", "NgayBatDau", "NgayKetThuc", "NgayTao", "NgayUpdate", "NguoiTao", "NguoiUpdate", "SoTienToiDa", "TrangThai" },
                values: new object[] { new Guid("6d448536-5f1d-4a62-a3d4-a2593a86194f"), 500000, 100000, 2, "VOUCHER100K", "Giảm 100.000 VNĐ cho đơn hàng trên 500.000 VNĐ", new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3461), new DateTime(2025, 4, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3461), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3462), null, "Admin", null, 100000, 1 });

            migrationBuilder.InsertData(
                table: "vouchers",
                columns: new[] { "VoucherId", "GiaTriDonHangToiThieu", "GiaTriGiam", "LoaiGiamGia", "MaVoucher", "MoTaVoucher", "NgayBatDau", "NgayKetThuc", "NgayTao", "NgayUpdate", "NguoiTao", "NguoiUpdate", "SoTienToiDa", "TrangThai" },
                values: new object[] { new Guid("cf72ec6e-c946-4138-a679-1867c4a460e4"), 200000, 50000, 2, "VOUCHER50K", "Giảm 50.000 VNĐ cho đơn hàng trên 200.000 VNĐ", new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3455), new DateTime(2025, 2, 28, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3455), new DateTime(2024, 12, 29, 20, 30, 32, 202, DateTimeKind.Local).AddTicks(3456), null, "Admin", null, 50000, 1 });

            migrationBuilder.InsertData(
                table: "diaChi",
                columns: new[] { "IdDiaChi", "DiaChiMacDinh", "DistrictId", "DistrictName", "HoTen", "IdKhachHang", "MoTa", "ProvinceId", "ProvinceName", "SoDienThoai", "WardId", "WardName" },
                values: new object[,]
                {
                    { new Guid("0baa40db-2c54-4888-8392-b0bb5ab18950"), true, 201, "Quận Bình Thạnh", "Trần Thị Bé", new Guid("4cb915c9-85cc-45bf-84de-5a5e8147949f"), "Tòa nhà Landmark 81, Bình Thạnh", 2, "Hồ Chí Minh", "0987654321", "00201", "Phường 22" },
                    { new Guid("10315f3a-8825-4fec-ae0c-9ad43441f684"), true, 401, "Thị xã Thuận An", "Lê Thị Dậu", new Guid("6ca4e763-9423-44cd-9da6-3ae5d900ae31"), "Khu phố 1, Phường Vĩnh Phú", 4, "Bình Dương", "0356789123", "00401", "Phường Vĩnh Phú" },
                    { new Guid("3d2cff85-6793-4560-b29b-17a0eb301ec9"), true, 1001, "Huyện Tây Hòa", "Hoàng Anh J", new Guid("792a0b0b-90a2-4087-a998-ad487ba71b44"), "Thôn Hồng Thái, Xã Đông Hòa", 10, "Phú Yên", "0976543210", "01001", "Xã Đông Hòa" },
                    { new Guid("3f39705e-cd04-4c37-8c5f-d46f0f671586"), false, 901, "Thành phố Hạ Long", "Vũ Văn Ich", new Guid("d1ecce85-8720-4997-a68b-a7ad12de322f"), "Số 30, Đường Lê Lợi", 9, "Quảng Ninh", "0856781234", "00901", "Phường Bãi Cháy" },
                    { new Guid("4e16c2b3-eacb-41dd-8ecc-9fed847475b9"), true, 801, "Thành phố Nha Trang", "Phan Thị Hà", new Guid("b8de06f6-a700-4ffc-a122-7ac46ffa3f51"), "Số 15, Đường Hoàng Diệu", 8, "Khánh Hòa", "0845678901", "00801", "Phường Phước Long" },
                    { new Guid("702bc3a5-c92a-47c6-af6d-f3ca86e9fbc0"), false, 501, "Huyện Long Thành", "Đặng Văn Em", new Guid("e7089609-32ff-4645-88bf-f02a092cc289"), "Ấp An Hòa, Xã An Bình", 5, "Đồng Nai", "0398765432", "00501", "Xã An Bình" },
                    { new Guid("837ea655-9508-4e4f-8e43-ac9248965f0d"), false, 301, "Quận Hải Châu", "Phạm Văn Cảnh", new Guid("58721397-1a0a-414c-82aa-c76607ed0690"), "Số 5, Đường Trần Phú", 3, "Đà Nẵng", "0971123456", "00301", "Phường Thạch Thang" },
                    { new Guid("95070c3e-8c0a-4960-893b-ae7c3ece8602"), false, 701, "Quận Ninh Kiều", "Hoàng Anh Gia Lai", new Guid("8baae0e7-5c46-4007-bc5a-cbb9d0909d36"), "Khu dân cư Bình Minh", 7, "Cần Thơ", "0965432109", "00701", "Phường Tân An" },
                    { new Guid("dbde5173-db10-4d7f-a369-98839ab2be31"), true, 601, "Thành phố Huế", "Ngô Văn Phát", new Guid("23e31185-742b-4a67-af7f-b635623a60f3"), "Số 20, Đường Nguyễn Huệ", 6, "Thừa Thiên Huế", "0376543210", "00601", "Phường Vĩnh Ninh" },
                    { new Guid("ddfc1743-8e29-4043-86c0-1ed8f9e939e5"), true, 101, "Quận Đống Đa", "Nguyễn Văn Vinh", new Guid("283c7c23-a216-46fb-b76e-956c145bff5f"), "Số 10, Ngõ 15, Đường Láng", 1, "Hà Nội", "0912345678", "00101", "Phường Láng Thượng" }
                });

            migrationBuilder.InsertData(
                table: "nhanViens",
                columns: new[] { "IdNhanVien", "AnhNhanVien", "AuthProvider", "DiaChi", "Email", "IdchucVu", "KichHoat", "MatKhau", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoDienThoai", "TenNhanVien", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("55555555-5555-5555-5555-555555555555"), "anh_a.jpg", "Local", "Hà Nội", "hieupdph40428@fpt.edu.vn", new Guid("11111111-1111-1111-1111-111111111111"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0976819974", "Phạm Đức Hiếu", 1 },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "anh_b.jpg", "Local", "Đà Nẵng", "tranha10112004@gmail.com", new Guid("11111111-1111-1111-1111-111111111111"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0969293263", "Trần Ngọc Hà", 1 },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "anh_b.jpg", "Local", "Đà Nẵng", "longkhph35837@fpt.edu.vn", new Guid("22222222-2222-2222-2222-222222222222"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0377804800", "Kim Hoàng Long", 1 },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "anh_b.jpg", "Local", "Đà Nẵng", "namdtph39830@fpt.edu.vn", new Guid("22222222-2222-2222-2222-222222222222"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0855896668", "Đào Thành Nam", 1 }
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
