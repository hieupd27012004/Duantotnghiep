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
                    { new Guid("191b6b48-d6af-4ed6-8a1a-042a1d591d58"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2421), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Lộn" },
                    { new Guid("55cba2a9-9247-4f1b-ba8b-fd59f05a613e"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Dệt" },
                    { new Guid("5f4527a5-d17c-4d95-9d59-394fff9d7cf8"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Cotton" },
                    { new Guid("a80c2095-fd16-48d7-af81-741d63c740df"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Polyester" },
                    { new Guid("c324adbb-35a2-403c-8e49-f8563c9e1fd9"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Tự Nhiên" },
                    { new Guid("e7889e6d-ec4c-4c26-8da1-bcf6bcc515a7"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da thật" }
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
                    { new Guid("1a592d10-3cea-4fc7-8cc5-b93d1e2095bc"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2485), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Da" },
                    { new Guid("2304a119-e792-4c00-b077-d7845656ce57"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2487), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Low-top" },
                    { new Guid("2e6dd10f-eab5-4296-a554-85763c552717"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2489), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Mid – top" },
                    { new Guid("5070b4bf-140f-45ec-81f9-e757e118c0e0"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2478), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Thể Thao" },
                    { new Guid("5de09ac7-1c5f-4b0f-8c95-3603d2fa9f06"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2491), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "High – top" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("0bd1cba7-c601-4a29-8ea4-916b36823a07"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" },
                    { new Guid("375cc5ad-4825-407e-a377-29d930b9ba76"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế PVC" },
                    { new Guid("7e951212-18d6-4307-93cb-a8c89b38219b"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" },
                    { new Guid("88ad287e-5d91-4af9-af32-389bacfb96a1"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chunky" },
                    { new Guid("921460bb-1ecb-4ce5-8480-a57acce49d61"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" },
                    { new Guid("98840637-0f32-4d2a-b8e4-b1d9193ec6ba"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế BPU" },
                    { new Guid("bbf7fafe-e15a-432d-8b3c-c0356daa9adc"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Cao Su Lưu Hóa" },
                    { new Guid("bde1d5a6-8906-4184-abe4-5734739ac310"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Giày Lười" },
                    { new Guid("c84d293e-dcac-432a-9edf-a9a712ff1608"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Eva" },
                    { new Guid("e58d73be-fdef-4cca-9bc0-cfa517820e24"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chisty" }
                });

            migrationBuilder.InsertData(
                table: "khachHangs",
                columns: new[] { "IdKhachHang", "AuthProvider", "Email", "HoTen", "KichHoat", "MatKhau", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoDienThoai" },
                values: new object[,]
                {
                    { new Guid("0702d5f0-9fbb-43b9-b637-9c40eb5a1cfa"), "Local", "nguyenhoangp@gmail.com", "Nguyễn Hoàng Phong", 1, "1", new DateTime(2024, 12, 9, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2651), new DateTime(2024, 10, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2650), "Admin", "Admin", "0923456789" },
                    { new Guid("092126a1-e629-4297-bc64-3560b0bd6b78"), "Google", "tranthibe@gmail.com", "Trần Thị Bé", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0987654321" },
                    { new Guid("215930e2-00f7-47da-8a20-86415634429d"), "Google", "phanthiha@gmail.com", "Phan Thị Hà", 1, "1", new DateTime(2024, 8, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2634), new DateTime(2024, 7, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2633), "Admin", "Admin", "0845678901" },
                    { new Guid("24d69d86-9656-4b01-ac47-f27ac89960dc"), "Google", "trinhthiquyen@gmail.com", "Trịnh Thị Quyên", 1, "1", new DateTime(2023, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2653), new DateTime(2022, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2652), "System", "System", "0898765432" },
                    { new Guid("31e5bc2f-9a54-4483-bc03-edaf0c69f616"), "Local", "hoanganhgialai@gmail.com", "Hoàng Anh Gia Lai", 1, "1", new DateTime(2024, 11, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2631), new DateTime(2024, 9, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2630), "System", "System", "0965432109" },
                    { new Guid("53b09e2e-1096-4b1b-94b6-951ee58af1ba"), "Facebook", "phamvannam@outlook.com", "Phạm Văn Nam", 0, "1", new DateTime(2024, 11, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2646), new DateTime(2024, 9, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2645), "Admin", "Admin", "0919876543" },
                    { new Guid("627ada74-33ad-4dc0-aad1-5e23a2a72cf6"), "Google", "nguyenthikhanh@gmail.com", "Nguyễn Thị Khánh", 1, "1", new DateTime(2024, 12, 19, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2639), new DateTime(2024, 12, 14, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2638), "Admin", "System", "0834567890" },
                    { new Guid("733f706c-2355-42e8-9222-6bf639904092"), "Facebook", "phamvancanh@gmail.com", "Phạm Văn Cảnh", 0, "1", new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2611), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2611), "Admin", "Admin", "0971123456" },
                    { new Guid("7834cd5b-8e1d-4336-b514-6a3839cb8066"), "Google", "dminhai@gmail.com", "Đỗ Minh Hải", 1, "1", new DateTime(2024, 11, 9, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2648), new DateTime(2024, 9, 20, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2647), "System", "System", "0867891234" },
                    { new Guid("8bf116bc-1c1f-4267-b947-c0de79e708f7"), "Facebook", "vuvanich@gmail.com", "Vũ Văn Ich", 0, "Fb@12345", new DateTime(2024, 12, 24, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2636), new DateTime(2024, 12, 9, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2636), "Admin", "Admin", "0856781234" },
                    { new Guid("8d370b91-7cf1-4e44-a290-bec2eadb645e"), "Facebook", "ngovanf@gmail.com", "Ngô Văn Phát", 0, "1", new DateTime(2024, 6, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2628), new DateTime(2023, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2626), "Admin", "Admin", "0376543210" },
                    { new Guid("a8112d52-f8be-4f30-9b78-55eb4f3e3468"), "Local", "lethidau@gmail.com", "Lê Thị Dậu", 1, "1", new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2619), new DateTime(2024, 12, 19, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2613), "Admin", "System", "0356789123" },
                    { new Guid("bd1e0ee1-ec32-4d81-a69f-5e093a1c0fab"), "Facebook", "lyvanro@gmail.com", "Lý Văn Rô", 0, "1", new DateTime(2024, 12, 19, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2655), new DateTime(2024, 7, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2654), "Admin", "Admin", "0945678901" },
                    { new Guid("e1f5327b-94b1-46ac-ba00-1c86075d5024"), "Google", "dangvanem@gmail.com", "Đặng Văn Em", 1, "1", new DateTime(2024, 12, 28, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2624), new DateTime(2024, 10, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2622), "Admin", "Admin", "0398765432" },
                    { new Guid("e5b2e309-7ece-4d95-bb1c-af4ba2236cad"), "Facebook", "tranvanly@yahoo.com", "Trần Văn Lý", 1, "1", new DateTime(2024, 10, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2641), new DateTime(2024, 4, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2640), "Admin", "Admin", "0901234567" },
                    { new Guid("e697f60a-8861-463e-8db8-ded66a39420e"), "Local", "nguyenvanvinh@gmail.com", "Nguyễn Văn Vinh", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0912345678" },
                    { new Guid("f955819c-eba7-4480-8aa6-6c3642b6406a"), "Local", "lethimai@gmail.com", "Lê Thị Mai", 1, "1", new DateTime(2024, 6, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2643), new DateTime(2023, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2643), "Admin", "System", "0387654321" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("1b5817bf-59ad-4d55-ad87-f228dce02b0f"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2790), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2791), "Admin", "Admin", "Size 45" },
                    { new Guid("37b453fe-d997-4498-942c-576ae7ef5a47"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2780), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2780), "Admin", "Admin", "Size 38" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("3c634912-b8e1-496e-9cc2-3d3354389eb2"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2778), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2779), "Admin", "Admin", "Size 37" },
                    { new Guid("56511b0a-6f2c-429d-a553-c9c42248a123"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2772), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2773), "Admin", "Admin", "Size 35" },
                    { new Guid("64fe9c7f-be70-48a4-bdb4-bf3d521714b6"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2775), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2776), "Admin", "Admin", "Size 36" },
                    { new Guid("7af2e41a-8731-48f0-a62c-ce1229ccbfa8"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2789), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2789), "Admin", "Admin", "Size 44" },
                    { new Guid("8ca64aa7-3c75-485e-9997-4db388974c81"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2781), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2782), "Admin", "Admin", "Size 39" },
                    { new Guid("9c459492-2f40-43fa-ae84-cdc09db4c037"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2783), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2783), "Admin", "Admin", "Size 40" },
                    { new Guid("ac526cfc-57ad-4b3a-8eb8-e7109b3e4c2e"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2786), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2786), "Admin", "Admin", "Size 42" },
                    { new Guid("e422daa6-0abd-460d-8e1a-4cc78f3c2777"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2787), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2788), "Admin", "Admin", "Size 43" },
                    { new Guid("f7dbd236-d04c-46e5-8a63-e8551e039f5b"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2784), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2785), "Admin", "Admin", "Size 41" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("12a671de-ba1c-40e4-9ba9-8aa81227b3b0"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2826), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2825), "Admin", "Admin", "Thể Thao" },
                    { new Guid("8a6d9276-c101-4958-8e6c-90477bcbce11"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2829), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2828), "Admin", "Admin", "Cổ Điển" },
                    { new Guid("cce3dadd-d91e-4308-8d13-be1e04328cf7"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2830), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2830), "Admin", "Admin", "Hiện Đại" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("023cf99b-c96c-44a9-9f90-85b7dd5f7cf6"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2880), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2880), "Admin", "Admin", "white" },
                    { new Guid("0ba205e9-619a-4976-8233-f45d219a91af"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2893), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2893), "Admin", "Admin", "fluorescents" },
                    { new Guid("10f8ec66-4acd-4ea6-a135-012c91f8ee46"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2887), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2888), "Admin", "Admin", "pink" },
                    { new Guid("200bcffd-c42d-41c8-89b6-0ae83f2679fc"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2881), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2881), "Admin", "Admin", "grey" },
                    { new Guid("2a575993-a7fa-4a8c-970b-6879bf9bc550"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2891), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2892), "Admin", "Admin", "metallics" },
                    { new Guid("389da0ad-8379-4ad3-8871-b9438b58a15a"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2878), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2879), "Admin", "Admin", "Black" },
                    { new Guid("536a706d-f14d-4931-a6a8-dac14a4ecf06"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Green" },
                    { new Guid("737a1487-8bff-4783-903a-9f5fab55ed4f"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2885), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2886), "Admin", "Admin", "Brown" },
                    { new Guid("963a352b-4e1a-4d88-969a-ea755e29b03a"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2890), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2890), "Admin", "Admin", "orange" },
                    { new Guid("d8443451-292a-459b-9f97-ec098ad5dd4a"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2883), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2883), "Admin", "Admin", "navy blue" },
                    { new Guid("db8a3dad-7f2f-45c6-aa1a-1937f3f48037"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2877), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2877), "Admin", "Admin", "Blue" },
                    { new Guid("f1078e7b-25b0-46b4-9ed4-f7f592cd7da8"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Red" }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("0fca02fc-0526-48e6-81a4-b50a05e5f6bb"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2985), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2984), "Admin", "Admin", "Biti’s" },
                    { new Guid("27ba5ac0-20d0-4081-a46a-fe6ef56612c9"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2983), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2982), "Admin", "Admin", "Shondo" },
                    { new Guid("2b395333-f192-414e-a846-1ac9c36c2829"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2939), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2938), "Admin", "Admin", "Nike" },
                    { new Guid("2fa1f25e-b61b-443f-89b9-694d1714285b"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2945), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2945), "Admin", "Admin", "Reebok" },
                    { new Guid("2fd34634-3914-4c61-9e27-5ca70c16ece9"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2964), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2964), "Admin", "Admin", "MLB" },
                    { new Guid("48029135-aacf-422b-87e2-3270a4a5030c"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2978), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2977), "Admin", "Admin", "Dior" },
                    { new Guid("9869af9a-7fe7-45fd-84b1-72b24eb1a14b"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2967), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2967), "Admin", "Admin", "Louis Vuitton" },
                    { new Guid("af2524fe-9636-4926-9610-06bdb0de46da"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2951), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2951), "Admin", "Admin", "Converse" },
                    { new Guid("bced7b63-7b48-46c4-8a20-4bb8b0279e9e"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2963), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2962), "Admin", "Admin", "Fila" },
                    { new Guid("c23b0802-5213-4159-8b2d-6c262bb7fd8d"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2966), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2965), "Admin", "Admin", "Gucci" },
                    { new Guid("c5543a5e-7ee1-4bc8-bc53-2cabdaa3cddf"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2961), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2956), "Admin", "Admin", "New Balance" },
                    { new Guid("d283881f-ddee-4493-905d-e6c41845f15c"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2973), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2972), "Admin", "Admin", "Balenciaga" },
                    { new Guid("d344c405-84d3-48b0-85a8-789360e7efdf"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2989), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2988), "Admin", "Admin", "Ananas" },
                    { new Guid("da739f8f-100d-4bf8-8ebf-7aca83ac68fd"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2944), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2943), "Admin", "Admin", "Puma" },
                    { new Guid("e5b11ee0-abc9-46ce-93d1-3ae75dd19c72"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2942), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2941), "Admin", "Admin", "Adidas" },
                    { new Guid("f263f938-43bf-4f2e-9a8f-c3803ded99d8"), 1, new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2955), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(2955), "Admin", "Admin", "Vans" }
                });

            migrationBuilder.InsertData(
                table: "vouchers",
                columns: new[] { "VoucherId", "GiaTriDonHangToiThieu", "GiaTriGiam", "LoaiGiamGia", "MaVoucher", "MoTaVoucher", "NgayBatDau", "NgayKetThuc", "NgayTao", "NgayUpdate", "NguoiTao", "NguoiUpdate", "SoTienToiDa", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("4eba98e2-02ba-4113-8577-e96e4d583a69"), 100000, 10, 1, "VOUCHER10", "Giảm 10% cho đơn hàng trên 100.000 VNĐ", new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(3031), new DateTime(2025, 1, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(3032), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(3034), null, "Admin", null, null, 2 },
                    { new Guid("897b6d6f-3982-4d6c-b6bf-168c2307fe05"), 300000, 20, 1, "VOUCHER20", "Giảm 20% cho đơn hàng trên 300.000 VNĐ", new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(3041), new DateTime(2025, 3, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(3041), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(3042), null, "Admin", null, 100000, 2 }
                });

            migrationBuilder.InsertData(
                table: "vouchers",
                columns: new[] { "VoucherId", "GiaTriDonHangToiThieu", "GiaTriGiam", "LoaiGiamGia", "MaVoucher", "MoTaVoucher", "NgayBatDau", "NgayKetThuc", "NgayTao", "NgayUpdate", "NguoiTao", "NguoiUpdate", "SoTienToiDa", "TrangThai" },
                values: new object[] { new Guid("9e4e81ef-bac7-4dd5-a6e6-baa81a9ed730"), 200000, 50000, 2, "VOUCHER50K", "Giảm 50.000 VNĐ cho đơn hàng trên 200.000 VNĐ", new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(3038), new DateTime(2025, 2, 28, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(3039), null, "Admin", null, 50000, 1 });

            migrationBuilder.InsertData(
                table: "vouchers",
                columns: new[] { "VoucherId", "GiaTriDonHangToiThieu", "GiaTriGiam", "LoaiGiamGia", "MaVoucher", "MoTaVoucher", "NgayBatDau", "NgayKetThuc", "NgayTao", "NgayUpdate", "NguoiTao", "NguoiUpdate", "SoTienToiDa", "TrangThai" },
                values: new object[] { new Guid("d7eb675c-700f-4ad6-9271-e6815f301e91"), 500000, 100000, 2, "VOUCHER100K", "Giảm 100.000 VNĐ cho đơn hàng trên 500.000 VNĐ", new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(3044), new DateTime(2025, 4, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(3045), new DateTime(2024, 12, 29, 9, 13, 57, 116, DateTimeKind.Local).AddTicks(3045), null, "Admin", null, 100000, 1 });

            migrationBuilder.InsertData(
                table: "diaChi",
                columns: new[] { "IdDiaChi", "DiaChiMacDinh", "DistrictId", "DistrictName", "HoTen", "IdKhachHang", "MoTa", "ProvinceId", "ProvinceName", "SoDienThoai", "WardId", "WardName" },
                values: new object[,]
                {
                    { new Guid("00a3ceec-ca4a-4249-9806-dde2b950508c"), true, 1001, "Huyện Tây Hòa", "Hoàng Anh J", new Guid("627ada74-33ad-4dc0-aad1-5e23a2a72cf6"), "Thôn Hồng Thái, Xã Đông Hòa", 10, "Phú Yên", "0976543210", "01001", "Xã Đông Hòa" },
                    { new Guid("1411e507-8e53-42ff-aed7-a767b1f3d48a"), false, 701, "Quận Ninh Kiều", "Hoàng Anh Gia Lai", new Guid("31e5bc2f-9a54-4483-bc03-edaf0c69f616"), "Khu dân cư Bình Minh", 7, "Cần Thơ", "0965432109", "00701", "Phường Tân An" },
                    { new Guid("1939d9da-914a-4c71-ae19-83664d648349"), true, 801, "Thành phố Nha Trang", "Phan Thị Hà", new Guid("215930e2-00f7-47da-8a20-86415634429d"), "Số 15, Đường Hoàng Diệu", 8, "Khánh Hòa", "0845678901", "00801", "Phường Phước Long" },
                    { new Guid("1b921505-8781-4733-83ba-629e0548fbea"), true, 101, "Quận Đống Đa", "Nguyễn Văn Vinh", new Guid("e697f60a-8861-463e-8db8-ded66a39420e"), "Số 10, Ngõ 15, Đường Láng", 1, "Hà Nội", "0912345678", "00101", "Phường Láng Thượng" },
                    { new Guid("3dad7361-1b65-4960-ba84-7fbb2786b0bd"), true, 201, "Quận Bình Thạnh", "Trần Thị Bé", new Guid("092126a1-e629-4297-bc64-3560b0bd6b78"), "Tòa nhà Landmark 81, Bình Thạnh", 2, "Hồ Chí Minh", "0987654321", "00201", "Phường 22" },
                    { new Guid("6008ba40-295f-47ad-a9cc-1fc81022d6ce"), false, 901, "Thành phố Hạ Long", "Vũ Văn Ich", new Guid("8bf116bc-1c1f-4267-b947-c0de79e708f7"), "Số 30, Đường Lê Lợi", 9, "Quảng Ninh", "0856781234", "00901", "Phường Bãi Cháy" },
                    { new Guid("7840a493-de99-4797-aa00-6ddf758eb3c2"), false, 301, "Quận Hải Châu", "Phạm Văn Cảnh", new Guid("733f706c-2355-42e8-9222-6bf639904092"), "Số 5, Đường Trần Phú", 3, "Đà Nẵng", "0971123456", "00301", "Phường Thạch Thang" },
                    { new Guid("bc0f97d5-82b9-4108-8dfb-0c6ea8df3ece"), false, 501, "Huyện Long Thành", "Đặng Văn Em", new Guid("e1f5327b-94b1-46ac-ba00-1c86075d5024"), "Ấp An Hòa, Xã An Bình", 5, "Đồng Nai", "0398765432", "00501", "Xã An Bình" },
                    { new Guid("de5bdcf1-cf70-4094-955b-0f04840aa24c"), true, 601, "Thành phố Huế", "Ngô Văn Phát", new Guid("8d370b91-7cf1-4e44-a290-bec2eadb645e"), "Số 20, Đường Nguyễn Huệ", 6, "Thừa Thiên Huế", "0376543210", "00601", "Phường Vĩnh Ninh" },
                    { new Guid("feaecad4-abed-4770-a05b-a0f0122280c3"), true, 401, "Thị xã Thuận An", "Lê Thị Dậu", new Guid("a8112d52-f8be-4f30-9b78-55eb4f3e3468"), "Khu phố 1, Phường Vĩnh Phú", 4, "Bình Dương", "0356789123", "00401", "Phường Vĩnh Phú" }
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
