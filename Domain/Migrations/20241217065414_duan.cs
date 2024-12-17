using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    public partial class duan : Migration
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
                    { new Guid("39fd6ad8-70c0-411d-974c-1e6abc15765c"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Dệt" },
                    { new Guid("43cd4cf0-3f6f-442d-8d30-149759859577"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Polyester" },
                    { new Guid("72d9b676-13f3-4181-834e-8ad00c1e8032"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Tự Nhiên" },
                    { new Guid("b4467a0c-408c-4e36-8fd8-d7e470b53ba6"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(882), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Lộn" },
                    { new Guid("d7a4b27c-48a5-483a-8978-0532196107c9"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Cotton" },
                    { new Guid("f49186b9-0cf6-45b1-8d0a-9cb784b198c2"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da thật" }
                });

            migrationBuilder.InsertData(
                table: "chuVu",
                columns: new[] { "IdChucVu", "Code", "TenChucVu" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "QL", "Quản lý" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "NV", "Nhân viên" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "KT", "Kế toán" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "KK", "Thủ kho" }
                });

            migrationBuilder.InsertData(
                table: "danhMuc",
                columns: new[] { "IdDanhMuc", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("1b500b79-47e2-49ce-ab15-a6371cd3ea2b"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(926), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Low-top" },
                    { new Guid("5846db15-afc2-4a68-b0c2-b2a2b08073c9"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(924), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Da" },
                    { new Guid("5f5c4c00-37ed-40cb-8bd8-f49a2631be10"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(927), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Mid – top" },
                    { new Guid("7a9f66ca-5e4e-4937-8467-914963511160"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(923), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Thể Thao" },
                    { new Guid("89dd9dfa-f730-4e76-bef8-0e3d81e8144f"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(928), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "High – top" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("037ac5bb-4aef-4860-b956-a724eb039477"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Eva" },
                    { new Guid("190f8680-9522-499e-bb9c-de0896d63b14"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế PVC" },
                    { new Guid("443f789e-e4e5-47ab-8d9f-4cba878b91af"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chisty" },
                    { new Guid("64ba6287-b388-4753-be97-ed23d5f743de"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chunky" },
                    { new Guid("86f304d3-52b7-480c-bcdf-1053e852c21f"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" },
                    { new Guid("b2bb95a5-2158-4906-98d1-1ddb32b7c7a6"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" },
                    { new Guid("b4f977d9-89c6-4d00-9a3e-51bf814a2722"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Cao Su Lưu Hóa" },
                    { new Guid("c9327b8b-5a44-4ce2-a9a4-1082fbb5a434"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế BPU" },
                    { new Guid("d3fc3db9-acd7-4cd3-af52-908e70feb508"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Giày Lười" },
                    { new Guid("da37f4b1-652f-462d-8e4d-6aba3538609a"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" }
                });

            migrationBuilder.InsertData(
                table: "khachHangs",
                columns: new[] { "IdKhachHang", "AuthProvider", "Email", "HoTen", "KichHoat", "MatKhau", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoDienThoai" },
                values: new object[,]
                {
                    { new Guid("2d1b86e5-1903-4312-9b07-6ded698a35cb"), "Local", "lethimai@gmail.com", "Lê Thị Mai", 1, "1", new DateTime(2024, 6, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1030), new DateTime(2023, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1030), "Admin", "System", "0387654321" },
                    { new Guid("39ec066b-a0b5-45ec-ab61-f4fb19e747be"), "Local", "nguyenhoangp@gmail.com", "Nguyễn Hoàng Phong", 1, "1", new DateTime(2024, 11, 27, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1037), new DateTime(2024, 10, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1037), "Admin", "Admin", "0923456789" },
                    { new Guid("3c297fe1-1a6e-4b13-ad99-70327f842128"), "Facebook", "vuvanich@gmail.com", "Vũ Văn Ich", 0, "Fb@12345", new DateTime(2024, 12, 12, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1025), new DateTime(2024, 11, 27, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1024), "Admin", "Admin", "0856781234" },
                    { new Guid("4e84e79c-6536-4611-9b13-beac879efe5f"), "Google", "nguyenthikhanh@gmail.com", "Nguyễn Thị Khánh", 1, "1", new DateTime(2024, 12, 7, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1026), new DateTime(2024, 12, 2, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1026), "Admin", "System", "0834567890" },
                    { new Guid("5e9f9bab-e84b-455f-968a-f737a0a038b2"), "Local", "nguyenvanvinh@gmail.com", "Nguyễn Văn Vinh", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0912345678" },
                    { new Guid("7e320f5c-7363-4f31-ba20-de02feb8baa0"), "Google", "dminhai@gmail.com", "Đỗ Minh Hải", 1, "1", new DateTime(2024, 10, 28, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1036), new DateTime(2024, 9, 8, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1035), "System", "System", "0867891234" },
                    { new Guid("7fd5e2a8-a7f6-48a4-b443-22ad8f8aa5ef"), "Google", "phanthiha@gmail.com", "Phan Thị Hà", 1, "1", new DateTime(2024, 8, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1023), new DateTime(2024, 7, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1022), "Admin", "Admin", "0845678901" },
                    { new Guid("86cd07c4-2542-4c9b-9b42-1d595a81da93"), "Google", "tranthibe@gmail.com", "Trần Thị Bé", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0987654321" },
                    { new Guid("929c2bbd-b77f-4ca2-afb9-7b6623952fdb"), "Facebook", "ngovanf@gmail.com", "Ngô Văn Phát", 0, "1", new DateTime(2024, 6, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1019), new DateTime(2023, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1018), "Admin", "Admin", "0376543210" },
                    { new Guid("9cbea067-a28f-4657-a8d9-70da56339c72"), "Google", "trinhthiquyen@gmail.com", "Trịnh Thị Quyên", 1, "1", new DateTime(2023, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1039), new DateTime(2022, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1039), "System", "System", "0898765432" },
                    { new Guid("a0dc2ee1-8983-46ef-a2c8-5a06523d1c3b"), "Facebook", "phamvancanh@gmail.com", "Phạm Văn Cảnh", 0, "1", new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1007), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1006), "Admin", "Admin", "0971123456" },
                    { new Guid("a35caf2b-d6c0-40b6-9578-da5382424d80"), "Google", "dangvanem@gmail.com", "Đặng Văn Em", 1, "1", new DateTime(2024, 12, 16, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1016), new DateTime(2024, 10, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1015), "Admin", "Admin", "0398765432" },
                    { new Guid("c88ea207-de5f-4311-b569-abbd17530b6c"), "Facebook", "lyvanro@gmail.com", "Lý Văn Rô", 0, "1", new DateTime(2024, 12, 7, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1045), new DateTime(2024, 7, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1041), "Admin", "Admin", "0945678901" },
                    { new Guid("d32c8575-82e5-4de2-936e-4d3b323f9f1d"), "Local", "hoanganhgialai@gmail.com", "Hoàng Anh Gia Lai", 1, "1", new DateTime(2024, 11, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1021), new DateTime(2024, 9, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1020), "System", "System", "0965432109" },
                    { new Guid("d56be133-fa1a-4988-acfd-e930c352c97c"), "Facebook", "tranvanly@yahoo.com", "Trần Văn Lý", 1, "1", new DateTime(2024, 10, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1028), new DateTime(2024, 4, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1028), "Admin", "Admin", "0901234567" },
                    { new Guid("e1e27207-7a88-4275-a334-a3d600dbd6ad"), "Facebook", "phamvannam@outlook.com", "Phạm Văn Nam", 0, "1", new DateTime(2024, 11, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1034), new DateTime(2024, 9, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1033), "Admin", "Admin", "0919876543" },
                    { new Guid("fce92e7e-233c-4bba-a7c5-1ae1ee7d8e0d"), "Local", "lethidau@gmail.com", "Lê Thị Dậu", 1, "1", new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1013), new DateTime(2024, 12, 7, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1008), "Admin", "System", "0356789123" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("1eb54511-ea11-4352-a6b2-fd45275240e4"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1130), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1130), "Admin", "Admin", "Size 36" },
                    { new Guid("34bdf6c5-9113-42a5-8b09-15e57f9acfd9"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1136), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1137), "Admin", "Admin", "Size 41" },
                    { new Guid("3b88f29a-5f42-41c4-8186-8c301dd74d1a"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1134), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1134), "Admin", "Admin", "Size 39" },
                    { new Guid("583e9a24-637c-4be5-a720-980595bcf0de"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1133), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1133), "Admin", "Admin", "Size 38" },
                    { new Guid("5e28ae2f-9ddf-409f-942f-13b453ce49ca"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1135), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1135), "Admin", "Admin", "Size 40" },
                    { new Guid("6da6562b-dd01-460b-b5c4-b27a337b7730"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1141), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1142), "Admin", "Admin", "Size 45" },
                    { new Guid("98278304-0816-48ab-8ade-c75e9ab421a7"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1127), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1128), "Admin", "Admin", "Size 35" },
                    { new Guid("9e9d7d23-d02f-4a2c-8d96-7f961328799e"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1139), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1139), "Admin", "Admin", "Size 43" },
                    { new Guid("d57a4fbb-8ca9-41ee-98b6-fc04350be0a2"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1131), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1132), "Admin", "Admin", "Size 37" },
                    { new Guid("e768f39b-e3fd-4a80-a2cc-47b722745b41"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1140), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1141), "Admin", "Admin", "Size 44" },
                    { new Guid("ed2cbdde-4706-4f09-91d7-910aef0c064e"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1138), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1138), "Admin", "Admin", "Size 42" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("17294338-4e0f-4599-98cb-5c213c101537"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1166), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1166), "Admin", "Admin", "Hiện Đại" },
                    { new Guid("41f870bb-ccd5-44c5-a4ac-f5eb28e10bf1"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1164), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1164), "Admin", "Admin", "Cổ Điển" },
                    { new Guid("8d72c2bb-1d2f-4e52-b7fe-b12a6e6c64b9"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1162), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1162), "Admin", "Admin", "Thể Thao" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("19d966be-7a45-4a3d-bb38-6046c91cbbac"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Green" },
                    { new Guid("33253005-361b-4e68-b148-8c2b27b218fa"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1201), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1201), "Admin", "Admin", "navy blue" },
                    { new Guid("4ab93cb2-3a0b-451c-8f85-816ecc629415"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1202), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1202), "Admin", "Admin", "Brown" },
                    { new Guid("554a5998-19cd-4a45-a209-5990a51f424b"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1206), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1206), "Admin", "Admin", "metallics" },
                    { new Guid("87f90ee3-2dc4-43ce-a24f-a3303fab04c8"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1199), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1200), "Admin", "Admin", "grey" },
                    { new Guid("96d8a2d8-1644-4b20-b5ac-05a4ab45db5b"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1204), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1205), "Admin", "Admin", "orange" },
                    { new Guid("a544d2d2-0f52-4b96-b7ea-c2e996a83d1e"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Red" },
                    { new Guid("d95c4dbe-2600-4ec5-ae95-24aed529df91"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1207), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1207), "Admin", "Admin", "fluorescents" },
                    { new Guid("dad5b1f4-987d-477f-a1be-01fb2bcdf344"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1197), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1197), "Admin", "Admin", "Black" },
                    { new Guid("dd2c97ba-e6ce-4729-a54e-75fe39797b33"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1203), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1204), "Admin", "Admin", "pink" },
                    { new Guid("eb90ec87-8068-4add-8c99-779bd1b3f010"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1195), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1196), "Admin", "Admin", "Blue" },
                    { new Guid("f1e633b8-78ad-4eea-9c4d-9cbaed24ceb9"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1198), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1199), "Admin", "Admin", "white" }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("1bb4b1ff-8ac0-443e-86f7-8b994372aa1b"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1243), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1243), "Admin", "Admin", "Converse" },
                    { new Guid("294bbe89-f768-4820-96ca-e07f2ff3900b"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1256), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1256), "Admin", "Admin", "Biti’s" },
                    { new Guid("2a636ecc-791f-48d3-b9f0-694470be4a96"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1236), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1235), "Admin", "Admin", "Nike" },
                    { new Guid("306a53e5-a667-4cef-9ffe-618ee9cf5fab"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1251), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1251), "Admin", "Admin", "Balenciaga" },
                    { new Guid("5dbd3664-5f74-46a8-ac47-d3c0155ab0d6"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1254), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1253), "Admin", "Admin", "Dior" },
                    { new Guid("61b33489-878f-4eb8-8dcc-32218cb020e0"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1249), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1249), "Admin", "Admin", "Gucci" },
                    { new Guid("6e053523-577b-4a3a-88dd-c56f72fad1ff"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1255), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1255), "Admin", "Admin", "Shondo" },
                    { new Guid("7fc25cdc-bf1a-44ea-850e-bf5eff3f9fd5"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1245), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1245), "Admin", "Admin", "New Balance" },
                    { new Guid("84c729be-577d-48dc-9cd5-1e20a1cda417"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1244), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1244), "Admin", "Admin", "Vans" },
                    { new Guid("8c5e1c3d-c83e-4666-909d-eb802d1e1b1c"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1240), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1240), "Admin", "Admin", "Puma" },
                    { new Guid("ac92bff5-c507-486f-82ff-63e9e40daf79"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1250), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1250), "Admin", "Admin", "Louis Vuitton" },
                    { new Guid("afbf5988-3277-420e-a0a4-ac43d60d4880"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1248), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1247), "Admin", "Admin", "MLB" },
                    { new Guid("b1533736-dabb-4afc-97f9-4366f6ecb1b2"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1258), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1257), "Admin", "Admin", "Ananas" },
                    { new Guid("d3c98015-db5b-4623-8889-c2db40cf15c3"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1242), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1241), "Admin", "Admin", "Reebok" },
                    { new Guid("e6cacc4c-e596-4678-91a3-d417d7a12536"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1247), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1246), "Admin", "Admin", "Fila" },
                    { new Guid("e7180111-89a6-4575-986a-508df1a1b29b"), 1, new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1239), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1239), "Admin", "Admin", "Adidas" }
                });

            migrationBuilder.InsertData(
                table: "vouchers",
                columns: new[] { "VoucherId", "GiaTriDonHangToiThieu", "GiaTriGiam", "LoaiGiamGia", "MaVoucher", "MoTaVoucher", "NgayBatDau", "NgayKetThuc", "NgayTao", "NgayUpdate", "NguoiTao", "NguoiUpdate", "SoTienToiDa", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("0567d718-300f-441e-8c4f-2315fa48b65a"), 300000, 20, 1, "VOUCHER20", "Giảm 20% cho đơn hàng trên 300.000 VNĐ", new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1297), new DateTime(2025, 3, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1298), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1298), null, "Admin", null, 100000, 2 },
                    { new Guid("0d78d56e-3cd2-4e47-a522-12de7754798e"), 100000, 10, 1, "VOUCHER10", "Giảm 10% cho đơn hàng trên 100.000 VNĐ", new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1291), new DateTime(2025, 1, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1291), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1292), null, "Admin", null, null, 2 },
                    { new Guid("0ea23ae4-d7e2-4668-9513-b2ff5295d15e"), 200000, 50000, 2, "VOUCHER50K", "Giảm 50.000 VNĐ cho đơn hàng trên 200.000 VNĐ", new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1295), new DateTime(2025, 2, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1295), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1296), null, "Admin", null, 50000, 1 },
                    { new Guid("91f1dea7-1850-4f80-bc41-799e276a39e7"), 500000, 100000, 2, "VOUCHER100K", "Giảm 100.000 VNĐ cho đơn hàng trên 500.000 VNĐ", new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1300), new DateTime(2025, 4, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1300), new DateTime(2024, 12, 17, 13, 54, 14, 202, DateTimeKind.Local).AddTicks(1301), null, "Admin", null, 100000, 1 }
                });

            migrationBuilder.InsertData(
                table: "diaChi",
                columns: new[] { "IdDiaChi", "DiaChiMacDinh", "DistrictId", "DistrictName", "HoTen", "IdKhachHang", "MoTa", "ProvinceId", "ProvinceName", "SoDienThoai", "WardId", "WardName" },
                values: new object[,]
                {
                    { new Guid("01514a2d-6c09-40cb-b172-a44358996735"), false, 501, "Huyện Long Thành", "Đặng Văn Em", new Guid("a35caf2b-d6c0-40b6-9578-da5382424d80"), "Ấp An Hòa, Xã An Bình", 5, "Đồng Nai", "0398765432", "00501", "Xã An Bình" },
                    { new Guid("62c520fe-c28a-4ff4-9f34-09d76c35a418"), false, 701, "Quận Ninh Kiều", "Hoàng Anh Gia Lai", new Guid("d32c8575-82e5-4de2-936e-4d3b323f9f1d"), "Khu dân cư Bình Minh", 7, "Cần Thơ", "0965432109", "00701", "Phường Tân An" },
                    { new Guid("73fffd07-4dba-4677-af21-1df3a384b048"), true, 801, "Thành phố Nha Trang", "Phan Thị Hà", new Guid("7fd5e2a8-a7f6-48a4-b443-22ad8f8aa5ef"), "Số 15, Đường Hoàng Diệu", 8, "Khánh Hòa", "0845678901", "00801", "Phường Phước Long" },
                    { new Guid("7e39a4e0-9516-4c4e-9eff-6fe39bf79323"), true, 401, "Thị xã Thuận An", "Lê Thị Dậu", new Guid("fce92e7e-233c-4bba-a7c5-1ae1ee7d8e0d"), "Khu phố 1, Phường Vĩnh Phú", 4, "Bình Dương", "0356789123", "00401", "Phường Vĩnh Phú" },
                    { new Guid("87f0532c-9bfe-43e8-9fdb-076a91639470"), true, 101, "Quận Đống Đa", "Nguyễn Văn Vinh", new Guid("5e9f9bab-e84b-455f-968a-f737a0a038b2"), "Số 10, Ngõ 15, Đường Láng", 1, "Hà Nội", "0912345678", "00101", "Phường Láng Thượng" },
                    { new Guid("af139c5a-7600-4387-a38b-17a615a186b0"), false, 301, "Quận Hải Châu", "Phạm Văn Cảnh", new Guid("a0dc2ee1-8983-46ef-a2c8-5a06523d1c3b"), "Số 5, Đường Trần Phú", 3, "Đà Nẵng", "0971123456", "00301", "Phường Thạch Thang" },
                    { new Guid("cd40e6a7-f2c7-4349-afb3-9d0beab4aaea"), false, 901, "Thành phố Hạ Long", "Vũ Văn Ich", new Guid("3c297fe1-1a6e-4b13-ad99-70327f842128"), "Số 30, Đường Lê Lợi", 9, "Quảng Ninh", "0856781234", "00901", "Phường Bãi Cháy" },
                    { new Guid("e9b5d112-717b-458d-81cb-d7ab22705308"), true, 601, "Thành phố Huế", "Ngô Văn Phát", new Guid("929c2bbd-b77f-4ca2-afb9-7b6623952fdb"), "Số 20, Đường Nguyễn Huệ", 6, "Thừa Thiên Huế", "0376543210", "00601", "Phường Vĩnh Ninh" },
                    { new Guid("ee2250a9-bc31-4116-9ad6-d110d64bfc6e"), true, 1001, "Huyện Tây Hòa", "Hoàng Anh J", new Guid("4e84e79c-6536-4611-9b13-beac879efe5f"), "Thôn Hồng Thái, Xã Đông Hòa", 10, "Phú Yên", "0976543210", "01001", "Xã Đông Hòa" },
                    { new Guid("fd53bab4-a498-4b11-960f-2f821e1a442a"), true, 201, "Quận Bình Thạnh", "Trần Thị Bé", new Guid("86cd07c4-2542-4c9b-9b42-1d595a81da93"), "Tòa nhà Landmark 81, Bình Thạnh", 2, "Hồ Chí Minh", "0987654321", "00201", "Phường 22" }
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
