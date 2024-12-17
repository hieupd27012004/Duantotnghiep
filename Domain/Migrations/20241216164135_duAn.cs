using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    public partial class duAn : Migration
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
                    { new Guid("29b30788-0e21-4fc5-9e05-ad0036e1a953"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Tự Nhiên" },
                    { new Guid("659522f0-724d-4a15-a9a0-905c4e969717"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Polyester" },
                    { new Guid("7465ae45-deb0-4340-9065-64121faf42c0"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Dệt" },
                    { new Guid("7520defc-232b-453b-a9f2-1eea5c30b6db"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4475), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Lộn" },
                    { new Guid("83e026b3-42ea-4575-8608-5eb00a0b3449"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da thật" },
                    { new Guid("d0c38b87-ff81-4192-8473-cfe9761c4b4f"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Cotton" }
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
                    { new Guid("7ec3adea-02dc-4d5d-b75e-e5e81bb7ea94"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4509), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Thể Thao" },
                    { new Guid("83117123-561d-41d6-9d0b-eaca386d1d7c"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4512), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Mid – top" },
                    { new Guid("c4ad9254-28eb-4a04-9e54-60cf71f1b029"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4513), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "High – top" },
                    { new Guid("cebca42d-e6ab-4cf6-94e0-a20507d824be"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4511), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Low-top" },
                    { new Guid("e97dad11-e37b-407c-8fec-1c499d6cfca1"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4510), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Da" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("01e5c145-d7af-46f4-8b31-18096a9ddd76"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Cao Su Lưu Hóa" },
                    { new Guid("07b95b9e-7c12-4171-946f-f0109bbee3e4"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế PVC" },
                    { new Guid("1182863c-82bb-43a1-b17f-4bbbaa76cb2e"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế BPU" },
                    { new Guid("12e32759-e909-43ce-b1c0-9174af4f68fc"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" },
                    { new Guid("8c3cbee7-e7bc-4c3f-890c-d19792658cc6"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Giày Lười" },
                    { new Guid("9caf6ac1-e3e1-4d1e-9691-ecbd031e3510"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chunky" },
                    { new Guid("c8210707-5af0-42d9-969e-ecc8b998bcf0"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" },
                    { new Guid("d6e4ddab-c6a4-4659-ae5f-13c1ad18c90e"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Eva" },
                    { new Guid("decb8b89-e581-44fa-a3e8-f9e579153378"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" },
                    { new Guid("fccc2e91-6b25-4db5-b673-580930ed952e"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chisty" }
                });

            migrationBuilder.InsertData(
                table: "khachHangs",
                columns: new[] { "IdKhachHang", "AuthProvider", "Email", "HoTen", "KichHoat", "MatKhau", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoDienThoai" },
                values: new object[,]
                {
                    { new Guid("051202aa-9cbb-4487-a620-e7a13bf6866a"), "Local", "lethimai@gmail.com", "Lê Thị Mai", 1, "1", new DateTime(2024, 6, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4604), new DateTime(2023, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4603), "Admin", "System", "0387654321" },
                    { new Guid("053ff3ee-38ed-4deb-bcb6-fcdf1ea367ee"), "Local", "nguyenvanvinh@gmail.com", "Nguyễn Văn Vinh", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0912345678" },
                    { new Guid("08a248ef-9ebc-42b4-8709-272026ae5713"), "Local", "hoanganhgialai@gmail.com", "Hoàng Anh Gia Lai", 1, "1", new DateTime(2024, 11, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4595), new DateTime(2024, 9, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4594), "System", "System", "0965432109" },
                    { new Guid("1b8e10e6-b00c-42cc-8501-b2126d2b5880"), "Google", "trinhthiquyen@gmail.com", "Trịnh Thị Quyên", 1, "1", new DateTime(2023, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4616), new DateTime(2022, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4616), "System", "System", "0898765432" },
                    { new Guid("1d030681-97ba-4f5c-9ed6-9f5bb070011f"), "Facebook", "ngovanf@gmail.com", "Ngô Văn Phát", 0, "1", new DateTime(2024, 6, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4593), new DateTime(2023, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4592), "Admin", "Admin", "0376543210" },
                    { new Guid("27b3e336-b934-4438-a4c4-92b296c5a1e6"), "Google", "tranthibe@gmail.com", "Trần Thị Bé", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0987654321" },
                    { new Guid("467ff437-478c-4c19-8328-cbf30c7c1e18"), "Facebook", "lyvanro@gmail.com", "Lý Văn Rô", 0, "1", new DateTime(2024, 12, 6, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4618), new DateTime(2024, 7, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4618), "Admin", "Admin", "0945678901" },
                    { new Guid("6c0bd1d1-7973-4480-8bdc-85110175a775"), "Local", "lethidau@gmail.com", "Lê Thị Dậu", 1, "1", new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4589), new DateTime(2024, 12, 6, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4584), "Admin", "System", "0356789123" },
                    { new Guid("93c8afe5-03d2-4905-b1a6-537422638a4c"), "Google", "nguyenthikhanh@gmail.com", "Nguyễn Thị Khánh", 1, "1", new DateTime(2024, 12, 6, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4599), new DateTime(2024, 12, 1, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4599), "Admin", "System", "0834567890" },
                    { new Guid("a2405976-4e76-4918-ac32-ee555c4e3f11"), "Google", "dangvanem@gmail.com", "Đặng Văn Em", 1, "1", new DateTime(2024, 12, 15, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4591), new DateTime(2024, 10, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4590), "Admin", "Admin", "0398765432" },
                    { new Guid("a6a41c44-bf3e-466d-aab8-7a4395dad679"), "Google", "dminhai@gmail.com", "Đỗ Minh Hải", 1, "1", new DateTime(2024, 10, 27, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4610), new DateTime(2024, 9, 7, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4609), "System", "System", "0867891234" },
                    { new Guid("b6eadee1-1746-4907-8a10-53d2a722699b"), "Local", "nguyenhoangp@gmail.com", "Nguyễn Hoàng Phong", 1, "1", new DateTime(2024, 11, 26, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4611), new DateTime(2024, 10, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4611), "Admin", "Admin", "0923456789" },
                    { new Guid("c0ef0c87-1302-4f90-b01f-7bd53cdba112"), "Google", "phanthiha@gmail.com", "Phan Thị Hà", 1, "1", new DateTime(2024, 8, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4596), new DateTime(2024, 7, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4596), "Admin", "Admin", "0845678901" },
                    { new Guid("cd934ae6-b215-42eb-9b8b-7b7809c3f65d"), "Facebook", "tranvanly@yahoo.com", "Trần Văn Lý", 1, "1", new DateTime(2024, 10, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4602), new DateTime(2024, 4, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4601), "Admin", "Admin", "0901234567" },
                    { new Guid("d5d94902-8404-42cd-a4a6-f6da5b7c0664"), "Facebook", "vuvanich@gmail.com", "Vũ Văn Ich", 0, "Fb@12345", new DateTime(2024, 12, 11, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4598), new DateTime(2024, 11, 26, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4598), "Admin", "Admin", "0856781234" },
                    { new Guid("ddb769e6-1f24-40cd-987e-9371cf2d9642"), "Facebook", "phamvannam@outlook.com", "Phạm Văn Nam", 0, "1", new DateTime(2024, 11, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4605), new DateTime(2024, 9, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4605), "Admin", "Admin", "0919876543" },
                    { new Guid("eb21cc6a-d844-4f00-adac-c9d907a4ea44"), "Facebook", "phamvancanh@gmail.com", "Phạm Văn Cảnh", 0, "1", new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4583), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4582), "Admin", "Admin", "0971123456" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("0a597670-7a01-4547-866c-284efc90628b"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4683), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4683), "Admin", "Admin", "Size 36" },
                    { new Guid("3b25e563-6889-4f0a-9932-8b086e2c77e4"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4685), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4686), "Admin", "Admin", "Size 38" },
                    { new Guid("429e7bc8-ba6f-44db-b876-d3358b7cb37c"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4694), "Admin", "Admin", "Size 44" },
                    { new Guid("5fb9110f-541e-422b-84f8-54dc25207e60"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4685), "Admin", "Admin", "Size 37" },
                    { new Guid("64de23a0-4d43-44e5-bd03-d023e87dd445"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4693), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4693), "Admin", "Admin", "Size 43" },
                    { new Guid("712fc16f-a96b-48e1-9b2f-62bba78d4671"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4686), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4687), "Admin", "Admin", "Size 39" },
                    { new Guid("a81d8efc-160d-4516-a9ae-fc1fcd693428"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4689), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4690), "Admin", "Admin", "Size 40" },
                    { new Guid("c0523c43-05b4-4def-bade-ce8e42906f12"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4691), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4691), "Admin", "Admin", "Size 41" },
                    { new Guid("cb3611c4-3352-44d3-ae12-14ed1e2b9cbd"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4681), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4682), "Admin", "Admin", "Size 35" },
                    { new Guid("e5295219-f10e-41a5-b06b-0c58ba4c772e"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4692), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4692), "Admin", "Admin", "Size 42" },
                    { new Guid("e9be274a-89ad-4685-9874-6ab77f264677"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4695), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4695), "Admin", "Admin", "Size 45" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("0e82151c-245d-455a-af74-de9c39c0faaa"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4717), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4717), "Admin", "Admin", "Hiện Đại" },
                    { new Guid("aab5872d-91df-40b5-8341-927040c174ae"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4715), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4714), "Admin", "Admin", "Thể Thao" },
                    { new Guid("df334be0-3395-49c5-b33c-3b451f750bae"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4716), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4716), "Admin", "Admin", "Cổ Điển" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("1e766016-2f0f-464c-b3d4-942cadd5b277"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4743), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4743), "Admin", "Admin", "grey" },
                    { new Guid("3ee9e345-8690-4fbd-8e98-d903262e630d"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4748), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4749), "Admin", "Admin", "metallics" },
                    { new Guid("6b3d4025-f8f0-4277-aef5-aa8199182047"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Red" },
                    { new Guid("8027fbe8-c17c-439c-80cd-2ce97560b01d"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4749), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4750), "Admin", "Admin", "fluorescents" },
                    { new Guid("935e3b2d-a59c-4fba-b1fd-23e0f1eda5be"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4742), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4742), "Admin", "Admin", "white" },
                    { new Guid("9b6402d0-96a0-4796-9ad8-c2cef9b03347"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Green" },
                    { new Guid("9c610e40-5fc4-4dee-add9-7eff00694225"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4746), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4747), "Admin", "Admin", "pink" },
                    { new Guid("a3c3e7cd-dcda-4e28-b6f6-ca54ba31420f"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4746), "Admin", "Admin", "Brown" },
                    { new Guid("a62e53fc-e8e8-4d89-ae82-84c5a1030cf8"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4740), "Admin", "Admin", "Blue" },
                    { new Guid("c3df216e-b261-43e3-a8af-5df486278239"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4744), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4744), "Admin", "Admin", "navy blue" },
                    { new Guid("ccff01c3-dc4a-4dee-b574-639cbd411605"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4747), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4748), "Admin", "Admin", "orange" },
                    { new Guid("ed16e487-26e7-4214-8429-286f707efbe8"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4741), "Admin", "Admin", "Black" }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("080412e0-38db-4285-b1bd-fd38ed6b740e"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4786), "Admin", "Admin", "Louis Vuitton" },
                    { new Guid("0d6d3f1c-c8db-4fcc-9895-6ae49d587cfe"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4783), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4783), "Admin", "Admin", "MLB" },
                    { new Guid("36cec917-890d-4661-929e-ad51f7f857c8"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4780), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4780), "Admin", "Admin", "Vans" },
                    { new Guid("4b089ed0-ec4e-4f20-a591-03e71e05b9fe"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4790), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4790), "Admin", "Admin", "Biti’s" },
                    { new Guid("4bf3a47b-8b2e-4fee-9e27-227be81ab7d8"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4787), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4787), "Admin", "Admin", "Balenciaga" },
                    { new Guid("4d44b139-49b5-4b77-b3da-2759ce41fe50"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4774), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4774), "Admin", "Admin", "Nike" },
                    { new Guid("4dad6de8-b49a-415d-a452-4bce70cf4456"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4794), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4794), "Admin", "Admin", "Ananas" },
                    { new Guid("6121dad5-6d0b-4780-aca2-8c4012bdc150"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4785), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4785), "Admin", "Admin", "Gucci" },
                    { new Guid("69c0bf61-8938-4498-b53f-f61b08a05f51"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4788), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4788), "Admin", "Admin", "Dior" },
                    { new Guid("69dd1aad-7272-4b37-a606-3069bf20333d"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4781), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4781), "Admin", "Admin", "New Balance" },
                    { new Guid("846cf1a0-05bf-4b67-8090-7a83be0606b7"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4777), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4777), "Admin", "Admin", "Puma" },
                    { new Guid("87bb60f0-bf82-4881-b6e9-f58e27b3e553"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4782), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4782), "Admin", "Admin", "Fila" },
                    { new Guid("a5dc10e8-0ef5-4b55-adf3-3788a0c8673d"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4776), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4776), "Admin", "Admin", "Adidas" },
                    { new Guid("afc58f39-8544-435e-9e39-95024c39de20"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4778), "Admin", "Admin", "Reebok" },
                    { new Guid("bc067f17-0cab-402c-bbe6-ebef6807e661"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4779), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4779), "Admin", "Admin", "Converse" },
                    { new Guid("cb6b4903-d4f8-493e-9545-9de3e11fa856"), 1, new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4789), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4789), "Admin", "Admin", "Shondo" }
                });

            migrationBuilder.InsertData(
                table: "vouchers",
                columns: new[] { "VoucherId", "GiaTriDonHangToiThieu", "GiaTriGiam", "LoaiGiamGia", "MaVoucher", "MoTaVoucher", "NgayBatDau", "NgayKetThuc", "NgayTao", "NgayUpdate", "NguoiTao", "NguoiUpdate", "SoLuongVoucherConLai", "SoTienToiDa", "TongSoLuongVoucher", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("48f4d936-99be-46dd-8324-13c83e8c4048"), 100000, 10, 1, "VOUCHER10", "Giảm 10% cho đơn hàng trên 100.000 VNĐ", new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4817), new DateTime(2025, 1, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4817), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4818), null, "Admin", null, 100, null, 100, 2 },
                    { new Guid("c2416a29-ee13-4646-9aaf-0f56bd8aaed1"), 300000, 20, 1, "VOUCHER20", "Giảm 20% cho đơn hàng trên 300.000 VNĐ", new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4823), new DateTime(2025, 3, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4823), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4824), null, "Admin", null, 200, 100000, 200, 2 },
                    { new Guid("d7d888e1-6b7c-41c2-a7bc-4d6cc920a44d"), 500000, 100000, 2, "VOUCHER100K", "Giảm 100.000 VNĐ cho đơn hàng trên 500.000 VNĐ", new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4825), new DateTime(2025, 4, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4825), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4825), null, "Admin", null, 80, 100000, 80, 1 },
                    { new Guid("f97ed11b-0b8b-4c9f-9c62-8f6a6b28e1ea"), 200000, 50000, 2, "VOUCHER50K", "Giảm 50.000 VNĐ cho đơn hàng trên 200.000 VNĐ", new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4820), new DateTime(2025, 2, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4820), new DateTime(2024, 12, 16, 23, 41, 34, 731, DateTimeKind.Local).AddTicks(4821), null, "Admin", null, 50, 50000, 50, 1 }
                });

            migrationBuilder.InsertData(
                table: "diaChi",
                columns: new[] { "IdDiaChi", "DiaChiMacDinh", "DistrictId", "DistrictName", "HoTen", "IdKhachHang", "MoTa", "ProvinceId", "ProvinceName", "SoDienThoai", "WardId", "WardName" },
                values: new object[,]
                {
                    { new Guid("0ad999a0-979f-4152-b81f-b8d23d9b949a"), false, 701, "Quận Ninh Kiều", "Hoàng Anh Gia Lai", new Guid("08a248ef-9ebc-42b4-8709-272026ae5713"), "Khu dân cư Bình Minh", 7, "Cần Thơ", "0965432109", "00701", "Phường Tân An" },
                    { new Guid("27e2b4cf-aef0-466c-9268-5fe39390a9eb"), true, 601, "Thành phố Huế", "Ngô Văn Phát", new Guid("1d030681-97ba-4f5c-9ed6-9f5bb070011f"), "Số 20, Đường Nguyễn Huệ", 6, "Thừa Thiên Huế", "0376543210", "00601", "Phường Vĩnh Ninh" },
                    { new Guid("2a4f594f-bb30-48b7-b982-a2d2de99383f"), false, 901, "Thành phố Hạ Long", "Vũ Văn Ich", new Guid("d5d94902-8404-42cd-a4a6-f6da5b7c0664"), "Số 30, Đường Lê Lợi", 9, "Quảng Ninh", "0856781234", "00901", "Phường Bãi Cháy" },
                    { new Guid("2c805731-732f-425a-8790-d6f59fab76b7"), false, 301, "Quận Hải Châu", "Phạm Văn Cảnh", new Guid("eb21cc6a-d844-4f00-adac-c9d907a4ea44"), "Số 5, Đường Trần Phú", 3, "Đà Nẵng", "0971123456", "00301", "Phường Thạch Thang" },
                    { new Guid("57240e3d-7b59-48d2-af07-c8abdf72153c"), true, 101, "Quận Đống Đa", "Nguyễn Văn Vinh", new Guid("053ff3ee-38ed-4deb-bcb6-fcdf1ea367ee"), "Số 10, Ngõ 15, Đường Láng", 1, "Hà Nội", "0912345678", "00101", "Phường Láng Thượng" },
                    { new Guid("68136fb6-9088-464c-b0b3-2d07ccf0847a"), true, 1001, "Huyện Tây Hòa", "Hoàng Anh J", new Guid("93c8afe5-03d2-4905-b1a6-537422638a4c"), "Thôn Hồng Thái, Xã Đông Hòa", 10, "Phú Yên", "0976543210", "01001", "Xã Đông Hòa" },
                    { new Guid("9360c744-3069-472a-b279-4476707a8b77"), true, 801, "Thành phố Nha Trang", "Phan Thị Hà", new Guid("c0ef0c87-1302-4f90-b01f-7bd53cdba112"), "Số 15, Đường Hoàng Diệu", 8, "Khánh Hòa", "0845678901", "00801", "Phường Phước Long" },
                    { new Guid("980829ac-1054-460a-8be9-d36a287d6c60"), true, 201, "Quận Bình Thạnh", "Trần Thị Bé", new Guid("27b3e336-b934-4438-a4c4-92b296c5a1e6"), "Tòa nhà Landmark 81, Bình Thạnh", 2, "Hồ Chí Minh", "0987654321", "00201", "Phường 22" },
                    { new Guid("ea15d741-a41c-4108-8c2e-967d4d1f185c"), false, 501, "Huyện Long Thành", "Đặng Văn Em", new Guid("a2405976-4e76-4918-ac32-ee555c4e3f11"), "Ấp An Hòa, Xã An Bình", 5, "Đồng Nai", "0398765432", "00501", "Xã An Bình" },
                    { new Guid("eab2ec15-c311-4766-ae19-47c23d451c70"), true, 401, "Thị xã Thuận An", "Lê Thị Dậu", new Guid("6c0bd1d1-7973-4480-8bdc-85110175a775"), "Khu phố 1, Phường Vĩnh Phú", 4, "Bình Dương", "0356789123", "00401", "Phường Vĩnh Phú" }
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
