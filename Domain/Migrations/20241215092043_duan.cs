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
                    TongSoLuongVoucher = table.Column<int>(type: "int", nullable: false),
                    SoLuongVoucherConLai = table.Column<int>(type: "int", nullable: false),
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
                    { new Guid("0364e56b-bfbc-4017-93c5-faefcc8a10e5"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 86, DateTimeKind.Local).AddTicks(1007), new DateTime(2024, 12, 15, 16, 20, 43, 86, DateTimeKind.Local).AddTicks(1017), "Admin", "Admin", "Vải Cotton" },
                    { new Guid("5f8a53ae-d804-4e8b-ab94-6c44093cc8aa"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 86, DateTimeKind.Local).AddTicks(1028), new DateTime(2024, 12, 15, 16, 20, 43, 86, DateTimeKind.Local).AddTicks(1028), "Admin", "Admin", "Vải Polyester" },
                    { new Guid("c0c599dc-322f-493d-aa24-bbbb4440eacc"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 86, DateTimeKind.Local).AddTicks(1020), new DateTime(2024, 12, 15, 16, 20, 43, 86, DateTimeKind.Local).AddTicks(1021), "Admin", "Admin", "Da thật" }
                });

            migrationBuilder.InsertData(
                table: "chuVu",
                columns: new[] { "IdChucVu", "Code", "TenChucVu" },
                values: new object[,]
                {
                    { new Guid("03addee0-42d6-4abd-a09a-268ef9195e36"), "NV", "Nhân viên" },
                    { new Guid("05b56447-5f53-42d6-bd1d-bb46a39cd33b"), "KT", "Kế toán" },
                    { new Guid("167fe3c1-4e18-458a-a0fa-d7798f9ab627"), "KK", "Thủ kho" },
                    { new Guid("48920264-4e2c-4a08-bb32-36dfa71d01fa"), "QL", "Quản lý" }
                });

            migrationBuilder.InsertData(
                table: "danhMuc",
                columns: new[] { "IdDanhMuc", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("04254ba8-f7de-4adf-a6b8-3e50ac8ef21d"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 86, DateTimeKind.Local).AddTicks(6360), new DateTime(2024, 12, 15, 16, 20, 43, 86, DateTimeKind.Local).AddTicks(6360), "Admin", "Admin", "Giày Da" },
                    { new Guid("7417636f-5d61-4c9b-8c89-dfc55c3bbefa"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 86, DateTimeKind.Local).AddTicks(6357), new DateTime(2024, 12, 15, 16, 20, 43, 86, DateTimeKind.Local).AddTicks(6354), "Admin", "Admin", "Giày Thể Thao" },
                    { new Guid("f163e73f-b7af-473a-a36f-c08e9eb42c84"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 86, DateTimeKind.Local).AddTicks(6362), new DateTime(2024, 12, 15, 16, 20, 43, 86, DateTimeKind.Local).AddTicks(6362), "Admin", "Admin", "Giày Cao Gót" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("100585b3-e75d-48a4-b44f-98a76faf3c89"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" },
                    { new Guid("454cda08-c1d1-4f91-a9de-fa39f2f62846"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" },
                    { new Guid("9a77ad6b-cc0c-4186-8821-e84769e270c0"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("1c96f7cc-d516-430f-8935-4d3e96b62768"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 91, DateTimeKind.Local).AddTicks(599), new DateTime(2024, 12, 15, 16, 20, 43, 91, DateTimeKind.Local).AddTicks(599), "Admin", "Admin", "Size 38" },
                    { new Guid("4d14511f-429a-44bd-884d-dcac1c6b6606"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 91, DateTimeKind.Local).AddTicks(594), new DateTime(2024, 12, 15, 16, 20, 43, 91, DateTimeKind.Local).AddTicks(596), "Admin", "Admin", "Size 37" },
                    { new Guid("f4af2f31-1e95-45f2-b2ca-fc96965680e7"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 91, DateTimeKind.Local).AddTicks(601), new DateTime(2024, 12, 15, 16, 20, 43, 91, DateTimeKind.Local).AddTicks(601), "Admin", "Admin", "Size 39" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("10a2a6b6-68bf-4446-a936-024b6fcf6cc4"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 91, DateTimeKind.Local).AddTicks(3321), new DateTime(2024, 12, 15, 16, 20, 43, 91, DateTimeKind.Local).AddTicks(3320), "Admin", "Admin", "Hiện Đại" },
                    { new Guid("74e26f2a-9b39-451b-aab6-270fb912c152"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 91, DateTimeKind.Local).AddTicks(3314), new DateTime(2024, 12, 15, 16, 20, 43, 91, DateTimeKind.Local).AddTicks(3314), "Admin", "Admin", "Cổ Điển" },
                    { new Guid("c310f123-8d2d-4dd4-ac45-9f04daab8e91"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 91, DateTimeKind.Local).AddTicks(3311), new DateTime(2024, 12, 15, 16, 20, 43, 91, DateTimeKind.Local).AddTicks(3309), "Admin", "Admin", "Thể Thao" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("3328a120-237d-4831-8707-7c4affdd3de2"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 92, DateTimeKind.Local).AddTicks(6451), new DateTime(2024, 12, 15, 16, 20, 43, 92, DateTimeKind.Local).AddTicks(6453), "Admin", "Admin", "Red" },
                    { new Guid("70420076-f53d-47bc-ade9-dc44fe862a68"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 92, DateTimeKind.Local).AddTicks(6458), new DateTime(2024, 12, 15, 16, 20, 43, 92, DateTimeKind.Local).AddTicks(6459), "Admin", "Admin", "Blue" },
                    { new Guid("92800e94-4b88-41fc-a406-294399cf52da"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 92, DateTimeKind.Local).AddTicks(6456), new DateTime(2024, 12, 15, 16, 20, 43, 92, DateTimeKind.Local).AddTicks(6456), "Admin", "Admin", "Green" }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("1f2e1066-4d9f-48b6-94f8-d84eddf28564"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 96, DateTimeKind.Local).AddTicks(9044), new DateTime(2024, 12, 15, 16, 20, 43, 96, DateTimeKind.Local).AddTicks(9037), "Admin", "Admin", "Nike" },
                    { new Guid("76c7f57b-2b31-49e5-8d84-4808cdb11472"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 96, DateTimeKind.Local).AddTicks(9047), new DateTime(2024, 12, 15, 16, 20, 43, 96, DateTimeKind.Local).AddTicks(9047), "Admin", "Admin", "Adidas" },
                    { new Guid("adae8ca0-71a5-411a-aa36-f223b62ec2f9"), 1, new DateTime(2024, 12, 15, 16, 20, 43, 96, DateTimeKind.Local).AddTicks(9049), new DateTime(2024, 12, 15, 16, 20, 43, 96, DateTimeKind.Local).AddTicks(9049), "Admin", "Admin", "Puma" }
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
