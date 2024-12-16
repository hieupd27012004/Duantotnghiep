using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    public partial class duAN : Migration
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
                    { new Guid("0beeeccf-0130-476e-a23d-12b231db393b"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Polyester" },
                    { new Guid("3f66e293-a056-4717-af62-ed769a74a759"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Dệt" },
                    { new Guid("4be17db8-3723-427b-9e5b-39ccf7bc0702"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9479), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Lộn" },
                    { new Guid("b3dbb3f1-3fbe-4884-97c2-f272745cb063"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Cotton" },
                    { new Guid("b5efcdb3-db62-4dab-af96-3d7d26574387"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Tự Nhiên" },
                    { new Guid("ec522c19-ddb2-419f-bdc4-32006d90499f"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da thật" }
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
                    { new Guid("0058656f-4ca0-4b37-a1f1-c15428df6411"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9503), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Low-top" },
                    { new Guid("aa92c77e-dcdf-43ba-bfef-a2f2ffd80ad4"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9500), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Thể Thao" },
                    { new Guid("bfcba4d6-f99c-4a44-b6c5-ece6e07aab00"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9503), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Mid – top" },
                    { new Guid("d3a5a953-47b8-49dc-bb18-68bec10135a9"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9504), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "High – top" },
                    { new Guid("ef0ab12a-3883-4773-ad00-6ee1eae32ab3"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9501), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Da" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("0ad59a5a-991a-4207-828b-de72da05cc24"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" },
                    { new Guid("81e6197b-c2b0-4304-99e5-b7c7181fd4f7"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Cao Su Lưu Hóa" },
                    { new Guid("897552ce-2cc2-4110-92fd-897b889f32f7"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chisty" },
                    { new Guid("8ef5b877-a8f9-4f66-8589-cb6687710b8a"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" },
                    { new Guid("8f91707d-f8fd-4cc3-82c5-b0243c986d2c"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế PVC" },
                    { new Guid("aa972deb-1e2e-4890-a382-765a7e245788"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chunky" },
                    { new Guid("c16598e5-0d96-431e-b4fa-fff6cbceeaa9"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Giày Lười" },
                    { new Guid("f0df2a35-7820-4c32-b4d0-1a34a118c665"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Eva" },
                    { new Guid("f2104311-2ab1-4b5f-8914-377b717dcce7"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" },
                    { new Guid("ffc5ac9c-cca4-413d-a696-7235a59c39b8"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế BPU" }
                });

            migrationBuilder.InsertData(
                table: "khachHangs",
                columns: new[] { "IdKhachHang", "AuthProvider", "Email", "HoTen", "KichHoat", "MatKhau", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoDienThoai" },
                values: new object[,]
                {
                    { new Guid("023e8cde-84ed-4d1c-a7f4-7dd44050359a"), "Google", "phanthiha@gmail.com", "Phan Thị Hà", 1, "1", new DateTime(2024, 8, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9596), new DateTime(2024, 7, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9595), "Admin", "Admin", "0845678901" },
                    { new Guid("0c90e6b3-9256-4e37-be88-6111220949cb"), "Local", "lethimai@gmail.com", "Lê Thị Mai", 1, "1", new DateTime(2024, 6, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9603), new DateTime(2023, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9603), "Admin", "System", "0387654321" },
                    { new Guid("1520cd6d-8165-47b5-9ea5-cf19f9cdd34e"), "Facebook", "tranvanly@yahoo.com", "Trần Văn Lý", 1, "1", new DateTime(2024, 10, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9601), new DateTime(2024, 4, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9601), "Admin", "Admin", "0901234567" },
                    { new Guid("18fc3c63-18b8-49b9-b738-e8f62c5989cf"), "Google", "tranthibe@gmail.com", "Trần Thị Bé", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0987654321" },
                    { new Guid("27b8e85e-c479-4b9b-8ce4-0fee74346392"), "Local", "lethidau@gmail.com", "Lê Thị Dậu", 1, "1", new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 12, 6, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9580), "Admin", "System", "0356789123" },
                    { new Guid("48a24b83-1036-4bf1-b16a-11cb96df7405"), "Local", "hoanganhgialai@gmail.com", "Hoàng Anh Gia Lai", 1, "1", new DateTime(2024, 11, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9594), new DateTime(2024, 9, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9593), "System", "System", "0965432109" },
                    { new Guid("7f801e12-6bcd-4787-8982-b4881fc3c785"), "Facebook", "phamvancanh@gmail.com", "Phạm Văn Cảnh", 0, "1", new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9579), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9578), "Admin", "Admin", "0971123456" },
                    { new Guid("9149fb03-382c-4ae3-97e9-bf935d36bd06"), "Facebook", "phamvannam@outlook.com", "Phạm Văn Nam", 0, "1", new DateTime(2024, 11, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9605), new DateTime(2024, 9, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9604), "Admin", "Admin", "0919876543" },
                    { new Guid("9336366b-30a1-4fc1-a4d7-58e5c8b7ba2a"), "Google", "dangvanem@gmail.com", "Đặng Văn Em", 1, "1", new DateTime(2024, 12, 15, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9588), new DateTime(2024, 10, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9585), "Admin", "Admin", "0398765432" },
                    { new Guid("9c7f331c-0ed5-4301-8e96-e75d66e6425a"), "Google", "trinhthiquyen@gmail.com", "Trịnh Thị Quyên", 1, "1", new DateTime(2023, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9610), new DateTime(2022, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9610), "System", "System", "0898765432" },
                    { new Guid("a4668485-dd2a-4a51-9a78-fe5b3942c20a"), "Google", "nguyenthikhanh@gmail.com", "Nguyễn Thị Khánh", 1, "1", new DateTime(2024, 12, 6, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9599), new DateTime(2024, 12, 1, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9599), "Admin", "System", "0834567890" },
                    { new Guid("acf24ce2-6c8d-45dd-8c02-00afaf3f228f"), "Local", "nguyenhoangp@gmail.com", "Nguyễn Hoàng Phong", 1, "1", new DateTime(2024, 11, 26, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9608), new DateTime(2024, 10, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9608), "Admin", "Admin", "0923456789" },
                    { new Guid("ae30ca33-5ed8-4859-8785-c4b9b460de61"), "Facebook", "lyvanro@gmail.com", "Lý Văn Rô", 0, "1", new DateTime(2024, 12, 6, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9612), new DateTime(2024, 7, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9612), "Admin", "Admin", "0945678901" },
                    { new Guid("b3458919-6c14-40aa-aa57-9a2c533c717a"), "Google", "dminhai@gmail.com", "Đỗ Minh Hải", 1, "1", new DateTime(2024, 10, 27, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9606), new DateTime(2024, 9, 7, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9606), "System", "System", "0867891234" },
                    { new Guid("c1788f1b-cd73-4123-9772-4a6a0f3dcf3a"), "Facebook", "ngovanf@gmail.com", "Ngô Văn Phát", 0, "1", new DateTime(2024, 6, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9592), new DateTime(2023, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9591), "Admin", "Admin", "0376543210" },
                    { new Guid("f25883d1-32e7-4744-9c6b-4761ed43e920"), "Local", "nguyenvanvinh@gmail.com", "Nguyễn Văn Vinh", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0912345678" },
                    { new Guid("fccbf7c7-3ee2-4900-b798-f39e572f85fd"), "Facebook", "vuvanich@gmail.com", "Vũ Văn Ich", 0, "Fb@12345", new DateTime(2024, 12, 11, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9597), new DateTime(2024, 11, 26, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9597), "Admin", "Admin", "0856781234" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("1c9fc5fc-314d-4982-b760-76daed7f0bbf"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9707), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9707), "Admin", "Admin", "Size 43" },
                    { new Guid("3a3247fc-88c9-4201-9fb9-ae5dfb75740c"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9702), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9703), "Admin", "Admin", "Size 41" },
                    { new Guid("4e9f9a36-8e41-4ac4-85bf-415254ca51f7"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 989, DateTimeKind.Local).AddTicks(8123), new DateTime(2024, 12, 16, 21, 58, 3, 989, DateTimeKind.Local).AddTicks(8124), "Admin", "Admin", "Size 38" },
                    { new Guid("8426438b-386a-4fe4-bf72-2a5971e34b9c"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9706), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9706), "Admin", "Admin", "Size 42" },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9695), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9695), "Admin", "Admin", "Size 37" },
                    { new Guid("983e3b8d-7e7f-44f0-be69-724219282a50"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 989, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 12, 16, 21, 58, 3, 989, DateTimeKind.Local).AddTicks(8120), "Admin", "Admin", "Size 37" },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9699), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9700), "Admin", "Admin", "Size 39" },
                    { new Guid("bcee6651-a03f-43d0-b993-e3e0c441a588"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 989, DateTimeKind.Local).AddTicks(8125), new DateTime(2024, 12, 16, 21, 58, 3, 989, DateTimeKind.Local).AddTicks(8125), "Admin", "Admin", "Size 39" },
                    { new Guid("c10a1f1a-4b43-4663-8b54-746e0f79985b"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9709), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9709), "Admin", "Admin", "Size 45" },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9693), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9694), "Admin", "Admin", "Size 36" },
                    { new Guid("d11ac410-25b5-48fd-88f4-76ef76321b16"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9708), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9708), "Admin", "Admin", "Size 44" },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9701), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9702), "Admin", "Admin", "Size 40" },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9697), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9698), "Admin", "Admin", "Size 38" },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9691), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9691), "Admin", "Admin", "Size 35" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("433844b1-28ec-46b6-884e-9be14e4a85ad"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9733), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9733), "Admin", "Admin", "Hiện Đại" },
                    { new Guid("49de77e9-5f2f-4624-aa2b-00050fe348ec"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9732), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9732), "Admin", "Admin", "Cổ Điển" },
                    { new Guid("58932e70-dd12-4b97-883d-8f7ac9c86708"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 991, DateTimeKind.Local).AddTicks(8249), new DateTime(2024, 12, 16, 21, 58, 3, 991, DateTimeKind.Local).AddTicks(8248), "Admin", "Admin", "Hiện Đại" },
                    { new Guid("b55eb401-3a3d-41c1-8825-ed4ee304e31a"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 991, DateTimeKind.Local).AddTicks(8228), new DateTime(2024, 12, 16, 21, 58, 3, 991, DateTimeKind.Local).AddTicks(8208), "Admin", "Admin", "Thể Thao" },
                    { new Guid("e1fbd05f-2085-4e5b-9ff0-ade4f66bd03a"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 991, DateTimeKind.Local).AddTicks(8233), new DateTime(2024, 12, 16, 21, 58, 3, 991, DateTimeKind.Local).AddTicks(8233), "Admin", "Admin", "Cổ Điển" },
                    { new Guid("ebd28ce8-fe8b-4ff2-aff1-610d40ba6835"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9730), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9729), "Admin", "Admin", "Thể Thao" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9765), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9766), "Admin", "Admin", "Black" },
                    { new Guid("09383418-56d6-45fb-bddd-20426ae2f3cc"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9775), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9775), "Admin", "Admin", "fluorescents" },
                    { new Guid("2f511983-dcda-4755-bce0-0ec73195d81a"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9774), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9774), "Admin", "Admin", "metallics" },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9767), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9767), "Admin", "Admin", "white" },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9769), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9770), "Admin", "Admin", "navy blue" },
                    { new Guid("58ab02f1-91fd-44e4-a75c-740d548c2eae"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 993, DateTimeKind.Local).AddTicks(6283), new DateTime(2024, 12, 16, 21, 58, 3, 993, DateTimeKind.Local).AddTicks(6290), "Admin", "Admin", "Red" },
                    { new Guid("78137743-5508-4e8a-8bb9-62bafd5853f7"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9770), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9771), "Admin", "Admin", "Brown" },
                    { new Guid("79c1c846-34e4-4bcb-9372-b440bc92404d"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Green" },
                    { new Guid("8af3f85a-b441-46d4-87a9-961e5f70c9e0"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 993, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 12, 16, 21, 58, 3, 993, DateTimeKind.Local).AddTicks(6298), "Admin", "Admin", "Blue" },
                    { new Guid("92a80258-d5ff-468a-82ac-ea1e93b6aad0"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9768), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9768), "Admin", "Admin", "grey" },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9764), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9765), "Admin", "Admin", "Blue" },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Red" },
                    { new Guid("c4e5d4f4-7112-42e8-9408-1b2e1e0af4d7"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9771), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9772), "Admin", "Admin", "pink" },
                    { new Guid("d8c2f720-c546-4f75-b5c3-764286188e85"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 993, DateTimeKind.Local).AddTicks(6294), new DateTime(2024, 12, 16, 21, 58, 3, 993, DateTimeKind.Local).AddTicks(6294), "Admin", "Admin", "Green" },
                    { new Guid("fb085ebb-cb2c-4578-bcfd-fbe0565ff241"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9773), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9773), "Admin", "Admin", "orange" }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("41236d00-615b-46ea-9dca-d828a4844bba"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9807), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9806), "Admin", "Admin", "Reebok" },
                    { new Guid("4d91883b-d5e7-4bd7-ae09-c5b32d909f91"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9817), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9816), "Admin", "Admin", "Dior" },
                    { new Guid("531d1439-e73a-415b-80e0-32664d5fd97f"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9812), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9812), "Admin", "Admin", "MLB" },
                    { new Guid("53b98574-362c-4b0c-8a41-6263b90ba7f6"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9809), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9809), "Admin", "Admin", "Vans" },
                    { new Guid("6d8db4d6-d457-41ca-a67d-fbee3f46db92"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9799), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9799), "Admin", "Admin", "Nike" },
                    { new Guid("71529ec4-1d43-449c-930b-eef8fee30589"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9808), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9808), "Admin", "Admin", "Converse" },
                    { new Guid("7654251e-7110-43ef-9bea-e6a377a30b7c"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9818), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9818), "Admin", "Admin", "Shondo" }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("7e2fb962-f7db-4b3b-bce0-923f6f8c703a"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9819), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9819), "Admin", "Admin", "Biti’s" },
                    { new Guid("81fa3c6c-a8d0-4d97-aa39-7ec13190d43a"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9813), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9813), "Admin", "Admin", "Gucci" },
                    { new Guid("97add0ea-ffa8-49cd-b299-bc0fb36326c7"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(7663), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(7663), "Admin", "Admin", "Adidas" },
                    { new Guid("b08ba324-9016-4dbe-9fe8-306c317f18c5"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9811), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9811), "Admin", "Admin", "Fila" },
                    { new Guid("b5a1473f-47fc-4bdf-b0dc-071eb416600f"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9810), "Admin", "Admin", "New Balance" },
                    { new Guid("b68d7108-05e3-4e0b-a5c1-ec614fa83f64"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(7665), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(7665), "Admin", "Admin", "Puma" },
                    { new Guid("bb46788b-3be7-4955-b914-9cbcb633478b"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9805), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9804), "Admin", "Admin", "Adidas" },
                    { new Guid("d93c7ccc-9038-4b87-9354-4ed3ab6e9ea9"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9820), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9820), "Admin", "Admin", "Ananas" },
                    { new Guid("da3f0073-645a-4474-b890-a451bcd239ad"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(7660), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(7647), "Admin", "Admin", "Nike" },
                    { new Guid("e946d111-bc58-47cb-83d9-230abdf03c5a"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9806), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9805), "Admin", "Admin", "Puma" },
                    { new Guid("e9a31962-c604-428a-aa38-8d747c930567"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9816), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9815), "Admin", "Admin", "Balenciaga" },
                    { new Guid("f3b23688-9deb-441d-8706-e0c68142502e"), 1, new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9815), new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9814), "Admin", "Admin", "Louis Vuitton" }
                });

            migrationBuilder.InsertData(
                table: "vouchers",
                columns: new[] { "VoucherId", "GiaTriDonHangToiThieu", "GiaTriGiam", "LoaiGiamGia", "MaVoucher", "MoTaVoucher", "NgayBatDau", "NgayKetThuc", "NgayTao", "NgayUpdate", "NguoiTao", "NguoiUpdate", "SoLuongVoucherConLai", "SoTienToiDa", "TongSoLuongVoucher", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("64776d61-dbe7-4261-a3f8-22aa55f0e2bf"), 500000, 100000, 2, "VOUCHER100K", "Giảm 100.000 VNĐ cho đơn hàng trên 500.000 VNĐ", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(712), new DateTime(2025, 4, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(712), new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(713), null, "Admin", null, 80, 100000, 80, 1 },
                    { new Guid("ea6d5451-0ca3-4357-a1ea-257a72016b72"), 200000, 50000, 2, "VOUCHER50K", "Giảm 50.000 VNĐ cho đơn hàng trên 200.000 VNĐ", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(707), new DateTime(2025, 2, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(707), new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(708), null, "Admin", null, 50, 50000, 50, 1 },
                    { new Guid("ed737237-c242-4df4-8a26-d8cf570b1a50"), 300000, 20, 1, "VOUCHER20", "Giảm 20% cho đơn hàng trên 300.000 VNĐ", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(710), new DateTime(2025, 3, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(710), new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(711), null, "Admin", null, 200, 100000, 200, 2 },
                    { new Guid("f042b181-2d95-4c04-9a1b-eed86936020e"), 100000, 10, 1, "VOUCHER10", "Giảm 10% cho đơn hàng trên 100.000 VNĐ", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(702), new DateTime(2025, 1, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(703), new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(705), null, "Admin", null, 100, null, 100, 2 }
                });

            migrationBuilder.InsertData(
                table: "diaChi",
                columns: new[] { "IdDiaChi", "DiaChiMacDinh", "DistrictId", "DistrictName", "HoTen", "IdKhachHang", "MoTa", "ProvinceId", "ProvinceName", "SoDienThoai", "WardId", "WardName" },
                values: new object[,]
                {
                    { new Guid("0a13676b-cafb-4229-91ae-b443c03dab1c"), true, 401, "Thị xã Thuận An", "Lê Thị Dậu", new Guid("27b8e85e-c479-4b9b-8ce4-0fee74346392"), "Khu phố 1, Phường Vĩnh Phú", 4, "Bình Dương", "0356789123", "00401", "Phường Vĩnh Phú" },
                    { new Guid("127350a1-22f7-434a-989f-d3fc49db8146"), true, 201, "Quận Bình Thạnh", "Trần Thị Bé", new Guid("18fc3c63-18b8-49b9-b738-e8f62c5989cf"), "Tòa nhà Landmark 81, Bình Thạnh", 2, "Hồ Chí Minh", "0987654321", "00201", "Phường 22" },
                    { new Guid("3ba40088-a6df-4dbf-ab57-54ae5677c332"), true, 801, "Thành phố Nha Trang", "Phan Thị Hà", new Guid("023e8cde-84ed-4d1c-a7f4-7dd44050359a"), "Số 15, Đường Hoàng Diệu", 8, "Khánh Hòa", "0845678901", "00801", "Phường Phước Long" },
                    { new Guid("3ec1f1e7-2930-4f2a-b527-c39809a49779"), false, 701, "Quận Ninh Kiều", "Hoàng Anh Gia Lai", new Guid("48a24b83-1036-4bf1-b16a-11cb96df7405"), "Khu dân cư Bình Minh", 7, "Cần Thơ", "0965432109", "00701", "Phường Tân An" },
                    { new Guid("581f66c6-4809-4086-b4f0-1f053cec194b"), false, 901, "Thành phố Hạ Long", "Vũ Văn Ich", new Guid("fccbf7c7-3ee2-4900-b798-f39e572f85fd"), "Số 30, Đường Lê Lợi", 9, "Quảng Ninh", "0856781234", "00901", "Phường Bãi Cháy" },
                    { new Guid("5f9b3f6a-5715-422a-990f-e0ca29b8982c"), false, 501, "Huyện Long Thành", "Đặng Văn Em", new Guid("9336366b-30a1-4fc1-a4d7-58e5c8b7ba2a"), "Ấp An Hòa, Xã An Bình", 5, "Đồng Nai", "0398765432", "00501", "Xã An Bình" },
                    { new Guid("66e8bc18-a8a4-4928-9076-b221ea2a2c16"), false, 301, "Quận Hải Châu", "Phạm Văn Cảnh", new Guid("7f801e12-6bcd-4787-8982-b4881fc3c785"), "Số 5, Đường Trần Phú", 3, "Đà Nẵng", "0971123456", "00301", "Phường Thạch Thang" },
                    { new Guid("97369f7b-76fd-4e68-b6f5-d571747aaeb0"), true, 101, "Quận Đống Đa", "Nguyễn Văn Vinh", new Guid("f25883d1-32e7-4744-9c6b-4761ed43e920"), "Số 10, Ngõ 15, Đường Láng", 1, "Hà Nội", "0912345678", "00101", "Phường Láng Thượng" },
                    { new Guid("ac262858-b6a0-42a5-b60a-ab435ea76ce3"), true, 1001, "Huyện Tây Hòa", "Hoàng Anh J", new Guid("a4668485-dd2a-4a51-9a78-fe5b3942c20a"), "Thôn Hồng Thái, Xã Đông Hòa", 10, "Phú Yên", "0976543210", "01001", "Xã Đông Hòa" },
                    { new Guid("e26b3080-39a2-4ec7-9853-e318a9b63c20"), true, 601, "Thành phố Huế", "Ngô Văn Phát", new Guid("c1788f1b-cd73-4123-9772-4a6a0f3dcf3a"), "Số 20, Đường Nguyễn Huệ", 6, "Thừa Thiên Huế", "0376543210", "00601", "Phường Vĩnh Ninh" }
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

            migrationBuilder.InsertData(
                table: "sanPhams",
                columns: new[] { "IdSanPham", "IdChatLieu", "IdDanhMuc", "IdDeGiay", "IdKieuDang", "IdThuongHieu", "KichHoat", "MoTa", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "Sale", "TenSanPham" },
                values: new object[,]
                {
                    { new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), new Guid("3f66e293-a056-4717-af62-ed769a74a759"), new Guid("d3a5a953-47b8-49dc-bb18-68bec10135a9"), new Guid("8ef5b877-a8f9-4f66-8589-cb6687710b8a"), new Guid("433844b1-28ec-46b6-884e-9be14e4a85ad"), new Guid("71529ec4-1d43-449c-930b-eef8fee30589"), 1, "Converse Lugged 2.0 Platform Denim là giày sneaker với thiết kế platform cao, kết hợp giữa vải denim bền và đế cao su dày, tạo phong cách thời trang mạnh mẽ. Đặc trưng với logo Converse và đế chống trượt, thích hợp cho cả streetwear và tạo điểm nhấn trong các bộ trang phục năng động.", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 0.0, "Converse Lugged 2.0 Platform Denim" },
                    { new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), new Guid("0beeeccf-0130-476e-a23d-12b231db393b"), new Guid("0058656f-4ca0-4b37-a1f1-c15428df6411"), new Guid("8ef5b877-a8f9-4f66-8589-cb6687710b8a"), new Guid("433844b1-28ec-46b6-884e-9be14e4a85ad"), new Guid("6d8db4d6-d457-41ca-a67d-fbee3f46db92"), 1, "Nike Jordan 1 (JD1) là đôi giày huyền thoại ra mắt năm 1985, gắn liền với Michael Jordan. Thiết kế biểu tượng với chất liệu da cao cấp, cổ thấp/mid/cao và đế ngoài chống trượt. Phù hợp cho cả chơi bóng rổ và thời trang đường phố, JD1 là biểu tượng của văn hóa sneaker toàn cầu.", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 0.0, "Nike Jordan 1 (JD1)" },
                    { new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), new Guid("0beeeccf-0130-476e-a23d-12b231db393b"), new Guid("0058656f-4ca0-4b37-a1f1-c15428df6411"), new Guid("8ef5b877-a8f9-4f66-8589-cb6687710b8a"), new Guid("433844b1-28ec-46b6-884e-9be14e4a85ad"), new Guid("71529ec4-1d43-449c-930b-eef8fee30589"), 1, "Converse Chuck Taylor All Star là đôi giày huyền thoại ra mắt năm 1917, nổi bật với thiết kế vải canvas bền nhẹ, đế cao su chống trượt và logo tròn đặc trưng. Phù hợp với mọi phong cách, từ thường ngày đến thời trang đường phố, là biểu tượng vượt thời gian.\r\n\r\n\r\n\r\n\r\n\r\n\r\n", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 0.0, "Converse Chuck Taylor All Star" },
                    { new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), new Guid("b5efcdb3-db62-4dab-af96-3d7d26574387"), new Guid("aa92c77e-dcdf-43ba-bfef-a2f2ffd80ad4"), new Guid("8ef5b877-a8f9-4f66-8589-cb6687710b8a"), new Guid("ebd28ce8-fe8b-4ff2-aff1-610d40ba6835"), new Guid("6d8db4d6-d457-41ca-a67d-fbee3f46db92"), 1, "Nike Air Force 1 là dòng giày thể thao biểu tượng của Nike, ra mắt năm 1982. Với thiết kế cổ điển, chất liệu da cao cấp, đế tích hợp công nghệ Air êm ái, và kiểu dáng đa dạng (low, mid, high), đôi giày này phù hợp cho cả thể thao lẫn thời trang đường phố. Là biểu tượng của phong cách và văn hóa sneaker toàn cầu.", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 0.0, "Nike Air Force 1" },
                    { new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), new Guid("0beeeccf-0130-476e-a23d-12b231db393b"), new Guid("aa92c77e-dcdf-43ba-bfef-a2f2ffd80ad4"), new Guid("f0df2a35-7820-4c32-b4d0-1a34a118c665"), new Guid("49de77e9-5f2f-4624-aa2b-00050fe348ec"), new Guid("bb46788b-3be7-4955-b914-9cbcb633478b"), 1, "Adidas Ultra Boost là dòng giày chạy bộ cao cấp, nổi bật với công nghệ đệm Boost mang lại độ êm ái và hoàn trả năng lượng tối ưu. Thiết kế hiện đại, phần thân Primeknit co giãn ôm sát chân, kết hợp đế ngoài Continental giúp tăng độ bám và bền bỉ. Phù hợp cho cả chạy bộ lẫn thời trang hàng ngày..", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 0.0, "Adidas Ultra Boost" },
                    { new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), new Guid("ec522c19-ddb2-419f-bdc4-32006d90499f"), new Guid("d3a5a953-47b8-49dc-bb18-68bec10135a9"), new Guid("f0df2a35-7820-4c32-b4d0-1a34a118c665"), new Guid("433844b1-28ec-46b6-884e-9be14e4a85ad"), new Guid("bb46788b-3be7-4955-b914-9cbcb633478b"), 1, "Adidas Yeezy 350 là dòng giày thời trang nổi bật, hợp tác giữa Adidas và Kanye West. Thiết kế tối giản với thân Primeknit co giãn, đế Boost êm ái, và phong cách hiện đại. Yeezy 350 được yêu thích nhờ sự thoải mái và tính biểu tượng trong làng thời trang đường phố.\r\n\r\n\r\n\r\n\r\n\r\n\r\n", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 0.0, "Adidas Yeezy 350" },
                    { new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), new Guid("0beeeccf-0130-476e-a23d-12b231db393b"), new Guid("aa92c77e-dcdf-43ba-bfef-a2f2ffd80ad4"), new Guid("8ef5b877-a8f9-4f66-8589-cb6687710b8a"), new Guid("433844b1-28ec-46b6-884e-9be14e4a85ad"), new Guid("6d8db4d6-d457-41ca-a67d-fbee3f46db92"), 1, "Nike Infinity 4 FP là giày chạy bộ cao cấp, thiết kế với công nghệ đệm ZoomX và Flyknit giúp tối ưu hóa sự thoải mái và hỗ trợ khi chạy. Phần đế giữa mềm mại, nhẹ và bền bỉ, mang lại trải nghiệm chạy mượt mà. Phù hợp cho người chạy dài và vận động viên.", new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9862), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 0.0, "Nike Infinity 4 Fp" },
                    { new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), new Guid("0beeeccf-0130-476e-a23d-12b231db393b"), new Guid("0058656f-4ca0-4b37-a1f1-c15428df6411"), new Guid("897552ce-2cc2-4110-92fd-897b889f32f7"), new Guid("433844b1-28ec-46b6-884e-9be14e4a85ad"), new Guid("7e2fb962-f7db-4b3b-bce0-923f6f8c703a"), 1, "Biti's Hunter là dòng giày thể thao hiện đại của Biti's, nổi bật với thiết kế năng động, chất liệu nhẹ, thoáng khí, và đế EVA êm ái, hỗ trợ vận động linh hoạt. Phù hợp cho cả tập luyện lẫn thời trang hàng ngày, mang đậm phong cách Việt trẻ trung.", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 0.0, "Giày Thể Thao Biti's Hunter" },
                    { new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), new Guid("b3dbb3f1-3fbe-4884-97c2-f272745cb063"), new Guid("d3a5a953-47b8-49dc-bb18-68bec10135a9"), new Guid("ffc5ac9c-cca4-413d-a696-7235a59c39b8"), new Guid("433844b1-28ec-46b6-884e-9be14e4a85ad"), new Guid("bb46788b-3be7-4955-b914-9cbcb633478b"), 1, "Adidas Samba là dòng giày cổ điển ra mắt năm 1950, ban đầu thiết kế cho bóng đá trong nhà. Với chất liệu da bền bỉ, mũi giày da lộn và đế cao su chống trượt, Samba là biểu tượng vượt thời gian, phù hợp cho cả thể thao và thời trang hàng ngày.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 0.0, "Adidas Samba" },
                    { new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), new Guid("0beeeccf-0130-476e-a23d-12b231db393b"), new Guid("bfcba4d6-f99c-4a44-b6c5-ece6e07aab00"), new Guid("8ef5b877-a8f9-4f66-8589-cb6687710b8a"), new Guid("49de77e9-5f2f-4624-aa2b-00050fe348ec"), new Guid("bb46788b-3be7-4955-b914-9cbcb633478b"), 1, "Adidas Forum 84 Low là dòng giày retro lấy cảm hứng từ bóng rổ thập niên 80. Thiết kế thấp cổ, chất liệu da cao cấp, dây đeo đặc trưng, và đế cao su bền bỉ, mang lại phong cách cổ điển pha chút hiện đại. Phù hợp cho cả thể thao và thời trang đường phố.", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 0.0, "Adidas Forum 84 Low" },
                    { new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), new Guid("ec522c19-ddb2-419f-bdc4-32006d90499f"), new Guid("d3a5a953-47b8-49dc-bb18-68bec10135a9"), new Guid("8ef5b877-a8f9-4f66-8589-cb6687710b8a"), new Guid("433844b1-28ec-46b6-884e-9be14e4a85ad"), new Guid("f3b23688-9deb-441d-8706-e0c68142502e"), 1, "Louis Vuitton Trainers là dòng giày thể thao cao cấp của Louis Vuitton, với thiết kế sang trọng, phối hợp giữa chất liệu da, vải và cao su. Đặc trưng với logo LV nổi bật, đôi giày này mang đến sự kết hợp hoàn hảo giữa thời trang và sự thoải mái, phù hợp cho những ai yêu thích phong cách sang trọng và thể thao.", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 0.0, "Louis Vuitton Trainers" },
                    { new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), new Guid("0beeeccf-0130-476e-a23d-12b231db393b"), new Guid("aa92c77e-dcdf-43ba-bfef-a2f2ffd80ad4"), new Guid("81e6197b-c2b0-4304-99e5-b7c7181fd4f7"), new Guid("ebd28ce8-fe8b-4ff2-aff1-610d40ba6835"), new Guid("e946d111-bc58-47cb-83d9-230abdf03c5a"), 1, "PUMA Unisex Caven là giày thể thao phong cách unisex với thiết kế hiện đại và thoải mái. Chất liệu da cao cấp kết hợp với đế cao su bền bỉ, tạo sự hỗ trợ và độ bám tốt. Phù hợp cho cả nam và nữ, dễ dàng phối hợp với nhiều trang phục.", new DateTime(2024, 12, 16, 21, 58, 3, 999, DateTimeKind.Local).AddTicks(9864), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 0.0, "PUMA Unisex Caven" }
                });

            migrationBuilder.InsertData(
                table: "hoaDons",
                columns: new[] { "IdHoaDon", "DiaChiGiaoHang", "GhiChu", "IdDiaChiHoaDon", "IdKhachHang", "IdNhanVien", "KichHoat", "LoaiHoaDon", "MaDon", "NgayTao", "NguoiNhan", "NguoiTao", "SoDienThoaiNguoiNhan", "TienGiam", "TienShip", "TongTienDonHang", "TongTienHoaDon", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("167fe6a1-35e4-4e72-b503-9bf35b0b189f"), null, null, null, new Guid("f25883d1-32e7-4744-9c6b-4761ed43e920"), new Guid("55555555-5555-5555-5555-555555555555"), 1, "Tại Quầy", "HD5", new DateTime(2024, 12, 15, 19, 35, 45, 0, DateTimeKind.Unspecified), "Nguyễn Văn Vinh", "Phạm Đức Hiếu", null, 0.0, 0.0, 250000.0, 250000.0, "Hoàn Thành" },
                    { new Guid("4046f331-9561-4812-9334-e15667c2997b"), null, null, null, new Guid("f25883d1-32e7-4744-9c6b-4761ed43e920"), new Guid("55555555-5555-5555-5555-555555555555"), 1, "Tại Quầy", "HD9", new DateTime(2024, 12, 15, 20, 35, 55, 0, DateTimeKind.Unspecified), "Nguyễn Văn Vinh", "Phạm Đức Hiếu", null, 0.0, 0.0, 500000.0, 500000.0, "Hoàn Thành" },
                    { new Guid("46b39a37-fdc3-4ffa-8439-42af244d3738"), null, null, null, new Guid("f25883d1-32e7-4744-9c6b-4761ed43e920"), new Guid("55555555-5555-5555-5555-555555555555"), 1, "Tại Quầy", "HD10", new DateTime(2024, 12, 15, 19, 3, 20, 0, DateTimeKind.Unspecified), "Nguyễn Văn Vinh", "Phạm Đức Hiếu", null, 0.0, 0.0, 250000.0, 250000.0, "Hoàn Thành" },
                    { new Guid("5a6f7faf-9ffd-4281-a07a-c6c2777df197"), null, null, null, new Guid("f25883d1-32e7-4744-9c6b-4761ed43e920"), new Guid("55555555-5555-5555-5555-555555555555"), 1, "Tại Quầy", "HD1", new DateTime(2024, 9, 4, 18, 30, 40, 0, DateTimeKind.Unspecified), "Nguyễn Văn Vinh", "Phạm Đúc Hiếu", null, 0.0, 0.0, 600000.0, 600000.0, "Hoàn Thành" },
                    { new Guid("61c4a48a-7639-4130-98e3-675851b162f5"), null, null, null, new Guid("f25883d1-32e7-4744-9c6b-4761ed43e920"), new Guid("55555555-5555-5555-5555-555555555555"), 1, "Tại Quầy", "HD6", new DateTime(2024, 11, 16, 19, 35, 45, 0, DateTimeKind.Unspecified), "Nguyễn Văn Vinh", "Phạm Đức Hiếu", null, 0.0, 0.0, 550000.0, 550000.0, "Hoàn Thành" },
                    { new Guid("7e33ace5-0a1b-407f-882b-110cb7ec6673"), null, null, null, new Guid("f25883d1-32e7-4744-9c6b-4761ed43e920"), new Guid("55555555-5555-5555-5555-555555555555"), 1, "Tại Quầy", "HD7", new DateTime(2024, 11, 16, 20, 5, 25, 0, DateTimeKind.Unspecified), "Nguyễn Văn Vinh", "Phạm Đức Hiếu", null, 0.0, 0.0, 400000.0, 400000.0, "Hoàn Thành" },
                    { new Guid("84f0335c-8acc-4b12-a112-84041567e0d6"), null, null, null, new Guid("f25883d1-32e7-4744-9c6b-4761ed43e920"), new Guid("55555555-5555-5555-5555-555555555555"), 1, "Tại Quầy", "HD8", new DateTime(2024, 11, 20, 20, 20, 40, 0, DateTimeKind.Unspecified), "Nguyễn Văn Vinh", "Phạm Đức Hiếu", null, 0.0, 0.0, 300000.0, 300000.0, "Hoàn Thành" },
                    { new Guid("9ae700b4-f0ab-4699-a026-1bd7cf1ff63d"), null, null, null, new Guid("f25883d1-32e7-4744-9c6b-4761ed43e920"), new Guid("55555555-5555-5555-5555-555555555555"), 1, "Tại Quầy", "HD2", new DateTime(2024, 10, 15, 18, 59, 10, 0, DateTimeKind.Unspecified), "Nguyễn Văn Vinh", "Phạm Đức Hiếu", null, 0.0, 0.0, 450000.0, 450000.0, "Hoàn Thành" },
                    { new Guid("bf4308e8-23b9-46a8-ad78-0bd72734696a"), null, null, null, new Guid("f25883d1-32e7-4744-9c6b-4761ed43e920"), new Guid("55555555-5555-5555-5555-555555555555"), 1, "Tại Quầy", "HD4", new DateTime(2024, 11, 15, 19, 20, 30, 0, DateTimeKind.Unspecified), "Nguyễn Văn Vinh", "Phạm Đức Hiếu", null, 0.0, 0.0, 250000.0, 250000.0, "Hoàn Thành" },
                    { new Guid("f8f6c385-d254-4d6c-aea3-528502a65221"), null, null, null, new Guid("a4668485-dd2a-4a51-9a78-fe5b3942c20a"), new Guid("55555555-5555-5555-5555-555555555555"), 1, "Tại Quầy", "HD3", new DateTime(2024, 11, 15, 18, 53, 45, 0, DateTimeKind.Unspecified), "Nguyễn Văn Vinh", "Phạm Đức Hiếu", null, 0.0, 0.0, 250000.0, 250000.0, "Hoàn Thành" },
                    { new Guid("f909806b-0a16-46f5-bb5a-250b0ede383d"), null, null, null, new Guid("f25883d1-32e7-4744-9c6b-4761ed43e920"), new Guid("55555555-5555-5555-5555-555555555555"), 1, "Tại Quầy", "HD11", new DateTime(2024, 12, 15, 19, 3, 20, 0, DateTimeKind.Unspecified), "Nguyễn Văn Vinh", "Phạm Đức Hiếu", null, 0.0, 0.0, 250000.0, 250000.0, "Hoàn Thành" }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTiets",
                columns: new[] { "IdSanPhamChiTiet", "CoHienThi", "Gia", "GiaGiam", "GioiTinh", "IdSanPham", "KichHoat", "MaSp", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoLuong", "XuatXu" },
                values: new object[,]
                {
                    { new Guid("00f044d5-9224-4e28-950e-5277b0ad2426"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.21", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(310), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Ý" },
                    { new Guid("023b4fcc-c073-46cf-9511-40e2e85b29e4"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.21", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(339), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("02f99364-e1b1-428a-abfa-b2dee83f377f"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.0", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(266), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 18.0, "Mỹ" },
                    { new Guid("0325c437-2a7f-4def-88da-31f6fbb0549d"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(256), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 18.0, "Mỹ" },
                    { new Guid("04447561-833b-43c4-a582-c4522b370486"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.60", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(28), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("058ad06a-797b-4460-ad15-6bcc6a3cdc12"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.21", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(129), new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(129), "Admin", "Admin", 15.0, "Trung Quốc" },
                    { new Guid("07f75ab5-2071-432e-939a-f3e15421c61e"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.11", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(366), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("08acc569-a287-4812-859a-f758db4b35ab"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.41", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(194), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("0a2daae5-4c4d-42d9-8b81-a9f66a3adcf1"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.5", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(86), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("0ced90f6-2bd9-4c77-8afe-20786319b29f"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.11", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(308), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Ý" },
                    { new Guid("0df3b16c-a410-4003-9964-dbd2f4f7a355"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.3", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(290), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Ý" },
                    { new Guid("1491e7bc-6258-449c-b0ca-357e4b3dfd32"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.50", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(187), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Việt Nam" },
                    { new Guid("14c5f9bc-3adb-4246-8631-668d414a7f95"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.21", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(161), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Hàn Quốc" },
                    { new Guid("1648636e-d85b-4e22-9775-2618c715824b"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.2", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(288), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Ý" },
                    { new Guid("16b10c0a-9742-421a-891f-b0f9d79a735c"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.51", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(284), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Mỹ" },
                    { new Guid("19e9d5a9-27a9-4b3e-8f47-f95de29ac056"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.1", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(142), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Hàn Quốc" },
                    { new Guid("1b945892-5efb-476d-beab-328dd6ca7134"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.21", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(37), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("1cd2476f-fa06-4837-a3bf-8774abdea482"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.11", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(190), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Việt Nam" },
                    { new Guid("1ce4006b-d05d-4e50-abe5-3cf5c3afdbdf"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.30", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(210), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Nhật Bản" },
                    { new Guid("1d4b202e-ab0b-4cb5-84e8-a6050dbb69aa"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.1", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(199), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Nhật Bản" },
                    { new Guid("1f51c892-33c2-44bf-b370-12653e940d2d"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.21", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(72), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 15.0, "Việt Nam" },
                    { new Guid("215fe3a0-2338-4082-97f2-288f9f21738b"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.2", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(348), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("222f19ad-2e39-4a4f-8caf-d46a6f0a6da1"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.40", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(303), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Ý" },
                    { new Guid("23592687-3bab-4be1-90d1-f4e6644a0199"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(315), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 40.0, "Trung Quốc" },
                    { new Guid("23d254c1-425e-45a9-a5fd-6e8689262b7c"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(78), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("23e4c698-085c-4972-accd-4e395c0d630e"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.10", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Việt Nam" },
                    { new Guid("248776df-7270-480a-9a04-24ea1d8ce745"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.11", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(160), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Hàn Quốc" },
                    { new Guid("26bbe4c6-5430-46f9-982e-210393d2d504"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.31", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(73), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("270d4d21-295e-45ca-9666-dbb4bd4db648"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.51", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(196), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("28fa74fc-2183-4500-9398-15484f62dc80"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.1", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(110), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Trung Quốc" },
                    { new Guid("299e463a-f9a2-4168-9656-83af49c50b96"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.0", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(18), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTiets",
                columns: new[] { "IdSanPhamChiTiet", "CoHienThi", "Gia", "GiaGiam", "GioiTinh", "IdSanPham", "KichHoat", "MaSp", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoLuong", "XuatXu" },
                values: new object[,]
                {
                    { new Guid("29e31bb9-21aa-43d0-a91c-a0f4b6d85852"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.40", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(24), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("2a18e9ab-c59c-4b88-a9ac-4a5b08dfe0fb"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.01", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(96), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("2a3254fa-622e-4d6f-8eb1-e41e1b1b11f9"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.2", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(111), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 15.0, "Trung Quốc" },
                    { new Guid("2e18de94-514a-43d8-9964-8469f6a8f21c"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.41", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(219), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Nhật Bản" },
                    { new Guid("2f5bd6cd-e4d6-48fc-a4cf-49ba664ab767"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.50", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(124), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Trung Quốc" },
                    { new Guid("2f9d3c79-b7b0-4478-a72d-1c045cd0a0d4"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.50", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(155), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Hàn Quốc" },
                    { new Guid("2ff5ba83-d002-42e5-867e-c97a4b6b2524"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.41", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(132), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 15.0, "Trung Quốc" },
                    { new Guid("3439ca3d-c3c8-4201-bac9-d5500cd9bdb4"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.50", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(334), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("38d251bd-62da-4dc3-b7ef-5cafbb97e7e8"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.3", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(112), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Trung Quốc" },
                    { new Guid("398e071c-c1f3-43dc-a097-1dde8b1b326f"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.3", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(201), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Nhật Bản" },
                    { new Guid("3d0929e1-a3e5-4829-8844-0237535b895e"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.01", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(275), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 18.0, "Mỹ" },
                    { new Guid("3dcbf7ad-bfd7-4c7b-bef8-4d052f1e9ed4"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.2", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(200), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Nhật Bản" },
                    { new Guid("3dd2395f-71d1-4edc-a57b-21640afd9cd3"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.3", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(349), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("3e9ed909-5b48-41fb-b420-86b2e89cc9ad"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.30", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(331), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("3f26d222-ef41-44c2-b78c-7913369ef2bd"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.20", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(268), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Mỹ" },
                    { new Guid("3f4ba479-1c23-4ac6-a50a-1d439abefce7"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.50", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(305), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Ý" },
                    { new Guid("3f56dbd3-9c42-492b-977f-7669ded8cad0"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.1", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(48), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 5.0, "Việt Nam" },
                    { new Guid("3fb618c1-9735-4d20-a14d-170dbb2d2d5f"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.10", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(118), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 25.0, "Trung Quốc" },
                    { new Guid("41dcdcca-a9b2-496a-b502-cc63f43ee5cc"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.20", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("425c619e-9589-4cde-8857-d106c6da6385"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.01", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(34), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("43603eba-c2da-45bb-acbe-6a048350a4b9"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(197), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Nhật Bản" },
                    { new Guid("44304c0e-8c1f-439e-b57e-69e36bbec1f5"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.0", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(148), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 12.0, "Hàn Quốc" },
                    { new Guid("445ccf5c-996e-43fe-8f31-f3a4a23c2ad0"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.01", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(158), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 12.0, "Hàn Quốc" },
                    { new Guid("448d3ece-3e8f-4985-93a6-6e2a21604b45"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.3", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(174), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Việt Nam" },
                    { new Guid("4573ca3c-9a30-4f19-9071-8686e63c3c85"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.40", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(271), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Mỹ" },
                    { new Guid("47db7e29-2296-434d-9706-885c2626099e"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.70", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(29), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("48c24ac7-e80e-4880-916c-c26751057e7c"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.2", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(173), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Việt Nam" },
                    { new Guid("49ccd28f-86e6-4f0d-a77d-5a7a9a698589"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.51", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(255), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("4a133de7-2840-4f2f-ba07-c2508b4beb57"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.10", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(298), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Ý" },
                    { new Guid("4aa6776d-8f44-40c4-857b-8cab413d92bf"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.31", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(369), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("4abe567d-cee3-4e1a-aee2-6e41eeabf927"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.2", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(229), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 21.0, "Việt Nam" },
                    { new Guid("4bef1079-25d6-4b00-bcc1-04d6a5c4a1dd"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.30", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(183), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Việt Nam" },
                    { new Guid("4bfafd4e-95c4-4ec6-9231-c138e13ed9c7"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.1", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(8), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("4c21cd31-1c82-47d8-8cdd-d44683ad4f5e"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.0", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(205), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Nhật Bản" },
                    { new Guid("4c25e9d9-f2ae-4e68-afdc-14698d6818e0"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(170), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Việt Nam" },
                    { new Guid("4d818439-0a02-401d-8b9d-ac3dc7008d65"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.41", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(342), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("4e373a0b-165d-4caa-a582-f8392cc24498"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.11", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(35), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("4e4021fc-eae7-41fc-99df-1df038c80e14"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.2", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(82), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("501dc9c9-ca40-4d45-95d2-e206f3a9f52c"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.11", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(128), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 25.0, "Trung Quốc" },
                    { new Guid("5115f516-f864-4f9b-823f-b52a80c42b17"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.5", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Việt Nam" },
                    { new Guid("51425614-9376-47bc-80f0-a3c9bfd9f65e"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.4", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(175), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Việt Nam" },
                    { new Guid("51c38dab-66ee-4189-8980-4f716ec50ada"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.10", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(267), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Mỹ" }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTiets",
                columns: new[] { "IdSanPhamChiTiet", "CoHienThi", "Gia", "GiaGiam", "GioiTinh", "IdSanPham", "KichHoat", "MaSp", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoLuong", "XuatXu" },
                values: new object[,]
                {
                    { new Guid("51ef93f2-3f07-42c5-b33e-2aa04ff20859"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.71", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(44), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("528e6a14-e7cf-4865-9956-1987a870b9c8"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.31", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(341), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("52f8c9a4-5742-4879-9789-983c22af71ac"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.0", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(238), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 2.0, "Việt Nam" },
                    { new Guid("53482826-3516-4770-8094-3ec8a592cf79"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.01", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(365), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("5375137d-d183-4de1-b6a2-cd565225b517"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.30", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(59), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("53775124-ee46-4f20-ba63-f66548986244"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.41", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(75), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 25.0, "Việt Nam" },
                    { new Guid("54747aad-befc-49c3-b1f6-65eca4a26660"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.21", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(368), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("554c894c-65b3-4323-88ac-a5d440bd7c61"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.51", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(136), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 25.0, "Trung Quốc" },
                    { new Guid("558b70e1-5e82-4e32-aa3f-5f2cd127b46f"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.30", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(153), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 12.0, "Hàn Quốc" },
                    { new Guid("55a5ffc6-097a-4bf8-a798-50a1e324fc6a"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.20", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(151), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Hàn Quốc" },
                    { new Guid("55f9804a-cda1-4aa7-95e9-8ffbe2443520"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.10", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(149), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Hàn Quốc" },
                    { new Guid("56737a32-0d20-427c-a5a1-3bff1f94e0d7"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.5", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(14), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("567be2a6-7421-46a3-a20c-0827e3170c64"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.30", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(92), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("5a007dc4-d1df-4ac5-81e0-823d702db695"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.31", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(280), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Mỹ" },
                    { new Guid("5a155841-560f-4383-92c1-497d8a297260"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.3", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(319), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("5a72f800-0f95-41b4-9bf7-d64e618c69ce"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.21", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(217), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Nhật Bản" },
                    { new Guid("5dc05c9b-2098-4d67-97d2-cc4d7be4e549"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.11", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(277), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Mỹ" },
                    { new Guid("5e355c97-e31d-4eff-831f-2cc41fbda1de"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.50", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Nhật Bản" },
                    { new Guid("60116fbd-641a-42b4-92ca-1da41ab3c70a"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.01", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(248), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 25.0, "Việt Nam" },
                    { new Guid("60afc7a5-845f-4c9e-8b8e-3c01a5cdbd0f"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.1", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(287), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Ý" },
                    { new Guid("63239d55-4ab2-42ad-af6b-337cadcb1d08"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.1", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(317), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("64b07d62-126a-44a0-b80c-a2fda7d59bb5"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.20", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(330), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("64f39ec3-1690-4449-9002-91fc9d9fcf8c"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.01", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(214), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Nhật Bản" },
                    { new Guid("65badccc-781f-478b-ba82-d268bdf463a5"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.51", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(41), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("65f71b92-9283-46e8-94ae-41462b48435a"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.41", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(370), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("6942032b-d386-4b20-a4cd-96c0dadc0b16"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.20", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(21), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("694efdef-5bc5-4a73-88a5-8e5284e50fb4"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.01", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(125), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 15.0, "Trung Quốc" },
                    { new Guid("6a3f7de9-c2c8-4763-99d3-ad7f42844250"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.20", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(182), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Việt Nam" },
                    { new Guid("6d9f59d5-9705-414e-965d-dab40b7c6ebe"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.41", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(40), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("6db7d816-d9e9-4447-8b38-7598e206b9ca"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.4", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(320), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("6e4a6e31-e2cc-4311-886e-7b81659f28a6"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.50", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(26), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("7386e6a1-f603-48bc-b271-b9f0b31a3c07"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.2", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(318), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("74cca36f-1bbc-4e6e-8afd-31882214b70a"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.30", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(23), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("76d53d2d-fa90-4193-ac37-0caab494fa34"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.40", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(362), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("775571ff-7142-4a7b-8ebc-ea3f171368f4"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.1", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(172), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Việt Nam" },
                    { new Guid("7755752b-20ce-4699-b909-1bbae5735f0a"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.50", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(65), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 5.0, "Việt Nam" },
                    { new Guid("776ac667-2560-4589-b44e-11234076d1eb"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(345), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("7804cccb-5d9b-4236-b04d-e8b4831efb0b"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.50", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(364), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("785dd673-b96a-4779-ac6b-5fa40827bd57"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.5", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(233), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 5.0, "Việt Nam" },
                    { new Guid("790aca04-56c9-4149-9b06-c8c3e5575dfe"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.51", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(169), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Hàn Quốc" },
                    { new Guid("79283b68-ab08-45fa-8ef5-a01129ceebd3"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.0", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(116), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 15.0, "Trung Quốc" },
                    { new Guid("79d9806a-b19b-4dc6-8b28-dc9d52dfa930"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.20", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(58), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 5.0, "Việt Nam" }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTiets",
                columns: new[] { "IdSanPhamChiTiet", "CoHienThi", "Gia", "GiaGiam", "GioiTinh", "IdSanPham", "KichHoat", "MaSp", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoLuong", "XuatXu" },
                values: new object[,]
                {
                    { new Guid("79db4a88-7d04-4d68-bc3e-73e25aad32dd"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.4", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(263), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Mỹ" },
                    { new Guid("79fbade8-21d1-4ba6-85f5-07d64e9dd797"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.11", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(337), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("7a06f3f2-fe55-4b74-9a16-4d0d9c20cbae"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.10", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(20), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("7d776dff-494b-4cc5-b819-ea1f65c1a33a"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.41", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(313), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Ý" },
                    { new Guid("7f54e513-9be3-47ba-89ff-eb274757cb87"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.01", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(189), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Việt Nam" },
                    { new Guid("822de950-cc64-4705-a8dc-e70e3d3dbaeb"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.40", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(94), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("826773e4-4782-446e-8d60-0b89bdf4b5e4"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.51", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(314), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Ý" },
                    { new Guid("82f21608-a636-44b5-91db-77d7550c3dca"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.4", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(350), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("837f680b-0435-42ed-bf17-009c0baab9d7"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.10", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(56), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 5.0, "Việt Nam" },
                    { new Guid("83f676cf-08c0-4d06-adfe-258c856a3263"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.50", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(274), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Mỹ" },
                    { new Guid("87d2591c-fc28-41fd-91dc-afd7e2b0bc32"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.1", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Mỹ" },
                    { new Guid("883330dd-d471-4470-8bcc-55bb4d2ecca7"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.6", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(16), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("8854468a-bcb8-421a-bf3d-d22e027f14c6"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.7", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(17), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("88c754b7-32db-477e-b72b-a45d25f85a6a"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.3", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(11), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("8a80efdf-97ea-4cbb-b80f-d2ee64f76ea8"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.40", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(154), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 25.0, "Hàn Quốc" },
                    { new Guid("8c30caa7-7c81-4c88-9235-c2ad230a48f4"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.21", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(251), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("8db7f7a9-45bb-4644-ac9b-3691d9e3b77d"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.5", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(322), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("8ea80907-1a6c-4d6b-906a-d2e4a26f0ed5"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.31", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(311), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Ý" },
                    { new Guid("8f5226e7-b14b-43da-88b4-e1b81019f324"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.50", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(247), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("8fb05196-c04e-4146-b843-7435683c4b91"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.0", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(87), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("90c43059-fba4-4d18-b9d5-bcfb1efdca0e"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.51", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(77), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 5.0, "Việt Nam" },
                    { new Guid("9197695c-181a-42ad-b003-9a63ce9b6eac"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.5", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(264), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Mỹ" },
                    { new Guid("924bac05-8a68-4855-afc8-cd5129207b6f"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.30", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(302), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Ý" },
                    { new Guid("94038418-592a-44ff-b296-423c79850669"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.2", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(10), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("950fa338-d988-473c-a505-37d5aa5b588e"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.61", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(43), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("9679011e-2f4c-4848-bae8-2c2dbbfd0bd0"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.0", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(55), new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(55), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("975fb191-fe0a-4637-8ec3-de026b1c39e8"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.4", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(114), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 15.0, "Trung Quốc" },
                    { new Guid("9805444a-8c4f-4de6-9690-8c5938d1b9d7"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.0", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(353), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("9975d99b-ebd6-4de8-9519-168a65b85370"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.30", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(361), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("9c7c6fac-2b9b-495d-a149-353a9bd4d13e"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.3", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(83), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("a37af730-9db9-4a44-a9fe-ecb0b4f7bea1"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.20", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(120), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 15.0, "Trung Quốc" },
                    { new Guid("a5c34da3-7764-44ea-82dd-616126d2bf0e"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.4", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(291), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Ý" },
                    { new Guid("a7746e69-addd-4eb8-8586-25101784edff"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.3", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(144), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 12.0, "Hàn Quốc" },
                    { new Guid("a790d2f4-c0c9-4fa4-a326-4e39284021dc"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.0", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(297), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Ý" },
                    { new Guid("a8101fbe-f1e8-4a87-996e-cdd7a04909bc"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.20", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(243), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("a8c22ce5-7944-476d-b6b9-e4356b773ad2"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.10", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(241), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 5.0, "Việt Nam" },
                    { new Guid("a97e4a39-c35b-41cb-8c98-42d35d5b4433"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(285), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Ý" },
                    { new Guid("aa3d6425-301e-47fb-8dca-5b96dfaf9024"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.51", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(344), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("abd3500d-a6f7-4459-833f-235338c51770"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(140), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 12.0, "Hàn Quốc" },
                    { new Guid("ac72d438-21c4-403e-a05d-17fa0b9f5d01"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.41", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(281), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Mỹ" },
                    { new Guid("ac9f4cf1-de9c-4abb-80e9-b8a97d487c40"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.30", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(121), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Trung Quốc" },
                    { new Guid("ad08a33b-2016-4d96-b898-73e3037fc920"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.40", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(184), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTiets",
                columns: new[] { "IdSanPhamChiTiet", "CoHienThi", "Gia", "GiaGiam", "GioiTinh", "IdSanPham", "KichHoat", "MaSp", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoLuong", "XuatXu" },
                values: new object[,]
                {
                    { new Guid("aecba6e3-f9a9-4294-9fd2-07f34fc13c21"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.41", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(106), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("afa1ef2f-3edc-4f08-8b20-9d4dacd54386"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.31", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(104), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("aff961bd-fcaa-4f9e-af73-fbc2f636279e"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.5", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(351), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("b4ac6de2-ddbc-4c46-a839-50db1d0e39d5"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(4), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("b5be1f86-93e6-452e-a786-6c6df0cb1ac3"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.01", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Ý" },
                    { new Guid("b8c3f587-5459-48f6-9a4a-746c4c895e0a"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.4", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(203), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Nhật Bản" },
                    { new Guid("bacc65d0-3647-45fe-ac6a-7c4abef10eaf"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.5", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(115), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 50.0, "Trung Quốc" },
                    { new Guid("bb9b6c81-b3c4-4675-9227-2060d1a16bf4"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.0", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(179), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Việt Nam" },
                    { new Guid("bbd8738f-c948-488e-bff3-a95200fe4d43"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.3", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(261), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Mỹ" },
                    { new Guid("bd4a3e6d-5d0e-459c-ba5a-abff1984fb5e"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.40", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(60), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 5.0, "Việt Nam" },
                    { new Guid("bee65a90-50bf-49db-aee1-61c205b8dc0e"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.1", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(227), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 5.0, "Việt Nam" },
                    { new Guid("c034b7e2-6084-4a97-92fa-3c4dc38a4967"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.21", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(191), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("c1252891-249f-48ce-81dc-1e16bab7342d"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.1", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(80), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("c19221a5-5686-42c6-b3f6-715f8ed406b0"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.10", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(89), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("c1c3b372-1dae-45ba-84b6-a377b222ae9c"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.51", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(107), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("c308a48f-a7ed-438e-ad28-6fb543c24da5"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.11", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(101), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("c430afb1-b734-45fe-b966-d3884b4fe8f4"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.51", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(371), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("c45666bd-e3ca-4c6e-b37c-0ae6dad9c071"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.4", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(52), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("c4b246ba-dd19-4493-b2a3-4b287933f1df"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.10", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(354), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("cb865a00-7b61-429e-94a6-e179127a95ad"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.01", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(69), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("ccc33371-d3a1-4803-91bf-2d670ef44acf"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.3", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(51), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("ce60379b-5a91-4177-8b92-6a0cc5bc40c0"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.20", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(359), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("d09b806a-9e5d-40ae-9c61-cda6ba38c053"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.40", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(122), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 15.0, "Trung Quốc" },
                    { new Guid("d0ca4381-df33-47fc-9c7f-c6b11884d312"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.5", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(147), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Hàn Quốc" },
                    { new Guid("d1a5114b-315c-4822-80aa-b6cf28f072f9"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.51", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(221), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 15.0, "Nhật Bản" },
                    { new Guid("d2fb74ce-0d88-4319-9e8f-24a975ea92ad"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.11", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(70), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 5.0, "Việt Nam" },
                    { new Guid("d333abf3-6a85-4722-a60c-e2050786af35"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.5", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(296), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Ý" },
                    { new Guid("d38694f5-eafb-4c3b-92d4-718ed6e47caf"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.10", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(207), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Nhật Bản" },
                    { new Guid("d5b90d92-3cbb-4ad2-868e-9b2b792907a0"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(108), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 15.0, "Trung Quốc" },
                    { new Guid("d84c1392-7bb1-4910-a834-5d407cb8fe60"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.40", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(211), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Nhật Bản" },
                    { new Guid("da9785a7-d3ef-4359-839c-6a48a481555b"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.31", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(218), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Nhật Bản" },
                    { new Guid("dba08f68-1eb1-4497-aa40-c46055451645"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.30", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(270), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Mỹ" },
                    { new Guid("dce8ccf9-e88e-4316-87a5-89f31825edb5"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.41", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(254), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 25.0, "Việt Nam" },
                    { new Guid("dd089dd6-0b59-4852-885f-1d1ebe810da6"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(222), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 25.0, "Việt Nam" },
                    { new Guid("ddafaad7-bd62-4df5-b2b2-7fae57b57516"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.3", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(163), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 25.0, "Hàn Quốc" },
                    { new Guid("ddc21c54-d8c0-4366-9361-24b9fb5ee630"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.30", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(244), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("ddf406f0-988f-4417-8476-02b0b975bcc2"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.31", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(38), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("deca944a-57dc-436a-9a6d-73b1644427b2"), "Có", 450000.0, null, "Nam", new Guid("700350fe-b88f-4dd6-8d62-adefb2988de7"), 1, "SP00004.31", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(130), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Trung Quốc" },
                    { new Guid("df46b06a-7ffa-4de9-88c8-474c6fefd16e"), "Có", 250000.0, null, "Nam", new Guid("44031389-6b83-4f6d-a909-4a69c7f54302"), 1, "SP001.4", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(13), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("e03572ac-6e4c-42af-a7c6-b2bbae483fad"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.2", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(260), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Mỹ" },
                    { new Guid("e16a5336-533e-4bfe-880d-cf8504ab0145"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.3", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(230), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("e333588e-4a51-4368-9f0e-d18f4b8c7d4a"), "Có", 400000.0, null, "Nữ", new Guid("ba93a7a8-701a-4ad3-9556-98d139ff2a2e"), 1, "SP00009.21", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(278), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Mỹ" }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTiets",
                columns: new[] { "IdSanPhamChiTiet", "CoHienThi", "Gia", "GiaGiam", "GioiTinh", "IdSanPham", "KichHoat", "MaSp", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoLuong", "XuatXu" },
                values: new object[,]
                {
                    { new Guid("e6330c1a-886e-45f3-b26d-1f23a8d14e5a"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.5", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(54), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 15.0, "Việt Nam" },
                    { new Guid("e6b97675-b70a-49cb-a230-c6cf12dfe286"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.11", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(215), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Nhật Bản" },
                    { new Guid("e7158ef5-d2e5-4dbc-ae54-95ad9d3d02ec"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.4", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 5.0, "Việt Nam" },
                    { new Guid("e8061f40-d55c-4945-8219-78a107e129cf"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.0", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(323), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("e83f4468-13df-49ca-ad0b-409f1a1e01a9"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.2", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(143), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Hàn Quốc" },
                    { new Guid("eaaa11aa-5908-404b-9d0c-e062763e339c"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(46), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 5.0, "Việt Nam" },
                    { new Guid("ed422156-d7ea-4c68-a9b1-4d26761ead8a"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.11", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(250), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 25.0, "Việt Nam" },
                    { new Guid("ef809ed2-6203-4656-bab9-0acd7c8912a4"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.41", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(168), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Hàn Quốc" },
                    { new Guid("efd574ad-f93e-443e-afd5-9e3f366f0032"), "Có", 600000.0, null, "Unisex", new Guid("aff56961-6cba-4e16-976e-930b3444a1e6"), 1, "SP00005.4", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(145), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Hàn Quốc" },
                    { new Guid("f052f971-8e8f-4bee-97cf-80f5333eb3ce"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.31", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(252), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 25.0, "Việt Nam" },
                    { new Guid("f104aba8-24d0-4b6e-802e-b505d6612c8f"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.10", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(324), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("f153e1ce-d2fa-4961-a33b-acb1637ed8e2"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.21", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(103), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("f388579c-28e5-4ffd-8d6e-9a067467a05f"), "Có", 800000.0, null, "Unisex", new Guid("76f5b930-ea0a-4941-ba52-32c02a61a1ba"), 1, "SP00010.20", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Ý" },
                    { new Guid("f3be26b7-b353-49ef-a93a-56dc23739c2a"), "Có", 350000.0, null, "Nam", new Guid("87974da2-a685-4ede-ae5e-0a6e498e9105"), 1, "SP00008.40", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(245), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 25.0, "Việt Nam" },
                    { new Guid("f625ec33-e3f9-44d4-af77-bf4100371ccb"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.40", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(333), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("f748bb14-ce01-4d59-b062-1f50c61c0fd9"), "Có", 550000.0, null, "Nam", new Guid("f8a2dd2e-cb75-45c1-9093-be08e6bca17a"), 1, "SP00011.01", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(336), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Trung Quốc" },
                    { new Guid("f8341911-40c9-44ed-86eb-ce8b6625dd19"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.50", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(95), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 20.0, "Việt Nam" },
                    { new Guid("f858206d-493d-4179-8e8c-7e56f49b6f5b"), "Có", 300000.0, null, "Nam", new Guid("3d158fda-1d31-4d51-828f-2023f0ca4ff2"), 1, "SP00003.4", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(85), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("fa87ff71-9456-4aeb-becd-7f71733717a6"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.5", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(204), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Nhật Bản" },
                    { new Guid("fbe9b897-6da9-40b9-88ec-d50466b79d73"), "Có", 700000.0, null, "Nam", new Guid("3f530a8a-0aaa-4111-b45e-62bcd8381951"), 1, "SP00007.20", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(208), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Nhật Bản" },
                    { new Guid("fcf9bd25-2862-4443-92c0-bfec01e09200"), "Có", 650000.0, null, "Nữ", new Guid("145d3f7d-9a75-4989-a409-ee2305d9f062"), 1, "SP00012.1", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(347), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 10.0, "Việt Nam" },
                    { new Guid("fef42c8d-c16d-48e8-b6e2-770db112c199"), "Có", 250000.0, null, "Nữ", new Guid("58cc797f-36d6-4a17-ab29-308590a65803"), 1, "SP002.2", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(49), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 5.0, "Việt Nam" },
                    { new Guid("ff720eea-f5f6-4130-af01-995b5317c0e9"), "Có", 500000.0, null, "Nữ", new Guid("b186219b-8383-459b-83d5-8d2045e2aa24"), 1, "SP00006.31", new DateTime(2024, 12, 16, 21, 58, 4, 0, DateTimeKind.Local).AddTicks(193), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", 30.0, "Việt Nam" }
                });

            migrationBuilder.InsertData(
                table: "hoaDonChiTiets",
                columns: new[] { "IdHoaDonChiTiet", "DonGia", "IdHoaDon", "IdSanPhamChiTiet", "KichHoat", "SoLuong", "TienGiam", "TongTien" },
                values: new object[,]
                {
                    { new Guid("0984be82-03c4-4deb-bd82-f24e4cd6893d"), 400000.0, new Guid("7e33ace5-0a1b-407f-882b-110cb7ec6673"), new Guid("0325c437-2a7f-4def-88da-31f6fbb0549d"), 1.0, 1.0, 0.0, 400000.0 },
                    { new Guid("213164aa-3647-4fb0-8195-476d12f79756"), 250000.0, new Guid("167fe6a1-35e4-4e72-b503-9bf35b0b189f"), new Guid("e6330c1a-886e-45f3-b26d-1f23a8d14e5a"), 1.0, 1.0, 0.0, 250000.0 },
                    { new Guid("68f5f491-3632-44c7-9327-bbfa2fe1e9aa"), 450000.0, new Guid("46b39a37-fdc3-4ffa-8439-42af244d3738"), new Guid("94038418-592a-44ff-b296-423c79850669"), 1.0, 1.0, 0.0, 450000.0 },
                    { new Guid("6f1c7fc5-d6d0-432f-8ceb-f12194d99d55"), 500000.0, new Guid("4046f331-9561-4812-9334-e15667c2997b"), new Guid("5115f516-f864-4f9b-823f-b52a80c42b17"), 1.0, 1.0, 0.0, 500000.0 },
                    { new Guid("74899f1a-0c6d-4b30-9c32-99fea4a9e2ae"), 450000.0, new Guid("9ae700b4-f0ab-4699-a026-1bd7cf1ff63d"), new Guid("bacc65d0-3647-45fe-ac6a-7c4abef10eaf"), 1.0, 1.0, 0.0, 450000.0 },
                    { new Guid("7def606d-6cc9-4c5d-a593-f50ec772002a"), 250000.0, new Guid("bf4308e8-23b9-46a8-ad78-0bd72734696a"), new Guid("b4ac6de2-ddbc-4c46-a839-50db1d0e39d5"), 1.0, 1.0, 0.0, 450000.0 },
                    { new Guid("9579673e-d5da-4113-9dd7-4bd68a828170"), 550000.0, new Guid("61c4a48a-7639-4130-98e3-675851b162f5"), new Guid("8db7f7a9-45bb-4644-ac9b-3691d9e3b77d"), 1.0, 1.0, 0.0, 550000.0 },
                    { new Guid("a9fce970-94a5-495d-a297-675f988c7400"), 250000.0, new Guid("f8f6c385-d254-4d6c-aea3-528502a65221"), new Guid("bacc65d0-3647-45fe-ac6a-7c4abef10eaf"), 1.0, 1.0, 0.0, 250000.0 },
                    { new Guid("aabdbadc-f58b-4afe-a581-66d9428ec954"), 450000.0, new Guid("f909806b-0a16-46f5-bb5a-250b0ede383d"), new Guid("94038418-592a-44ff-b296-423c79850669"), 1.0, 1.0, 0.0, 450000.0 },
                    { new Guid("df15ed6c-cd77-488b-a65c-5bbbeddf7c8f"), 600000.0, new Guid("5a6f7faf-9ffd-4281-a07a-c6c2777df197"), new Guid("19e9d5a9-27a9-4b3e-8f47-f95de29ac056"), 1.0, 1.0, 0.0, 600000.0 },
                    { new Guid("f69c810d-dadb-4f71-8035-a7974ee95263"), 300000.0, new Guid("84f0335c-8acc-4b12-a112-84041567e0d6"), new Guid("0a2daae5-4c4d-42d9-8b81-a9f66a3adcf1"), 1.0, 1.0, 0.0, 300000.0 }
                });

            migrationBuilder.InsertData(
                table: "lichSuHoaDons",
                columns: new[] { "IdLichSuHoaDon", "GhiChu", "IdHoaDon", "IdNhanVien", "NgayTao", "NguoiThaoTac", "ThaoTac", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("0a3f92ad-1bc7-4e18-a33a-3dbd91fdc990"), null, new Guid("f909806b-0a16-46f5-bb5a-250b0ede383d"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 12, 15, 19, 3, 20, 0, DateTimeKind.Unspecified), "Phạm Đúc Hiếu", "Tạo hóa đơn", "Hoàn Thành" },
                    { new Guid("156b9e9e-a7b6-4fac-ada2-efa680ea6a76"), null, new Guid("46b39a37-fdc3-4ffa-8439-42af244d3738"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 12, 15, 19, 3, 20, 0, DateTimeKind.Unspecified), "Phạm Đúc Hiếu", "Tạo hóa đơn", "Hoàn Thành" },
                    { new Guid("269ca514-3945-42e4-9bc7-2363fd801786"), null, new Guid("4046f331-9561-4812-9334-e15667c2997b"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 12, 15, 20, 35, 55, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tạo hóa đơn", "Hoàn Thành" },
                    { new Guid("4d33184c-d869-4751-8522-e8a99db568f8"), null, new Guid("f8f6c385-d254-4d6c-aea3-528502a65221"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 11, 15, 18, 53, 45, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tạo hóa đơn", "Hoàn Thành" },
                    { new Guid("5545e039-3285-4dbe-bf1d-aea6c458b2a8"), null, new Guid("9ae700b4-f0ab-4699-a026-1bd7cf1ff63d"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 10, 15, 19, 0, 10, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Hoàn Thành", "Hoàn Thành" },
                    { new Guid("593d4973-299a-4ac6-b0bf-734e5c213483"), null, new Guid("9ae700b4-f0ab-4699-a026-1bd7cf1ff63d"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 10, 15, 18, 59, 10, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tạo hóa đơn", "Hoàn Thành" },
                    { new Guid("5e3e2d11-8a84-4180-9837-d5b947299d0f"), null, new Guid("61c4a48a-7639-4130-98e3-675851b162f5"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 12, 15, 19, 50, 10, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Hoàn Thành", "Hoàn Thành" },
                    { new Guid("6cc06dc2-8d7c-48fa-b69b-83347964076d"), null, new Guid("84f0335c-8acc-4b12-a112-84041567e0d6"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 11, 20, 20, 21, 40, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Hoàn Thành", "Hoàn Thành" },
                    { new Guid("6d581bc1-b24c-4a6d-b28c-219495d11cbd"), null, new Guid("167fe6a1-35e4-4e72-b503-9bf35b0b189f"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 11, 16, 19, 35, 45, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tạo hóa đơn", "Hoàn Thành" },
                    { new Guid("7f06c65c-430d-408e-898c-f531d1c91493"), null, new Guid("7e33ace5-0a1b-407f-882b-110cb7ec6673"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 11, 16, 20, 5, 25, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tạo hóa đơn", "Hoàn Thành" },
                    { new Guid("8139e638-34bb-49cd-9b88-f8c26ea975f8"), null, new Guid("4046f331-9561-4812-9334-e15667c2997b"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 12, 15, 20, 36, 55, 0, DateTimeKind.Unspecified), "Phạm Đúc Hiếu", "Hoàn Thành", "Hoàn Thành" },
                    { new Guid("88a9eec7-1fb4-4334-ad8f-967dc8b8934e"), null, new Guid("167fe6a1-35e4-4e72-b503-9bf35b0b189f"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 11, 16, 19, 36, 45, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Hoàn Thành", "Hoàn Thành" },
                    { new Guid("89439ca7-e768-4361-8c27-f415925f197b"), null, new Guid("84f0335c-8acc-4b12-a112-84041567e0d6"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 11, 20, 20, 20, 40, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tạo hóa đơn", "Hoàn Thành" },
                    { new Guid("ad32736e-9843-4faf-b9cb-690a73e316c3"), null, new Guid("f909806b-0a16-46f5-bb5a-250b0ede383d"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 12, 15, 19, 4, 20, 0, DateTimeKind.Unspecified), "Phạm Đúc Hiếu", "Hoàn Thành", "Hoàn Thành" },
                    { new Guid("aec72c24-23ad-4613-844b-ff9e595847be"), null, new Guid("61c4a48a-7639-4130-98e3-675851b162f5"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 12, 15, 19, 50, 10, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tạo hóa đơn", "Hoàn Thành" },
                    { new Guid("af55b517-4d98-4739-b6a8-bf385814e332"), null, new Guid("5a6f7faf-9ffd-4281-a07a-c6c2777df197"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 9, 4, 18, 31, 40, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Hoàn Thành", "Hoàn Thành" },
                    { new Guid("bc12f3e6-b2e3-4f65-b2f6-0ccccfd763b4"), null, new Guid("5a6f7faf-9ffd-4281-a07a-c6c2777df197"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 9, 4, 18, 30, 40, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tạo hóa đơn", "Hoàn Thành" },
                    { new Guid("bd9c7a9d-b258-46d0-a731-f3ca310abbe8"), null, new Guid("bf4308e8-23b9-46a8-ad78-0bd72734696a"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 11, 15, 19, 21, 30, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Hoàn Thành", "Hoàn Thành" },
                    { new Guid("be27b4fe-1c9b-412d-bb66-809baaa9b4c5"), null, new Guid("7e33ace5-0a1b-407f-882b-110cb7ec6673"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 11, 16, 20, 6, 25, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Hoàn Thành", "Hoàn Thành" },
                    { new Guid("c45b1070-6992-4401-acdc-8acc1a4fabb5"), null, new Guid("bf4308e8-23b9-46a8-ad78-0bd72734696a"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 11, 15, 19, 20, 30, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tạo hóa đơn", "Hoàn Thành" },
                    { new Guid("d323c231-a537-413f-a8d3-b1baa25aec65"), null, new Guid("f8f6c385-d254-4d6c-aea3-528502a65221"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 11, 15, 18, 55, 30, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Hoàn Thành", "Hoàn Thành" },
                    { new Guid("e1a737d6-47b4-487b-b785-550be696573b"), null, new Guid("46b39a37-fdc3-4ffa-8439-42af244d3738"), new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 12, 15, 19, 4, 20, 0, DateTimeKind.Unspecified), "Phạm Đúc Hiếu", "Hoàn Thành", "Hoàn Thành" }
                });

            migrationBuilder.InsertData(
                table: "lichSuThanhToans",
                columns: new[] { "IdLichSuThanhToan", "GhiChu", "IdHoaDon", "IdNhanVien", "LoaiGiaoDich", "NgayTao", "NguoiThaoTac", "Pttt", "SoTien", "TienThua", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("0bd40e2e-13bf-4150-b927-386e9c05870e"), null, new Guid("f8f6c385-d254-4d6c-aea3-528502a65221"), new Guid("55555555-5555-5555-5555-555555555555"), "Thanh Toán", new DateTime(2024, 11, 15, 18, 53, 45, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tiền mặt", 250000.0, 0.0, "Hoàn Thành" },
                    { new Guid("0ca134ef-926d-4c90-86ac-48143a71aa74"), null, new Guid("4046f331-9561-4812-9334-e15667c2997b"), new Guid("55555555-5555-5555-5555-555555555555"), "Thanh Toán", new DateTime(2024, 12, 15, 20, 35, 55, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tiền mặt", 500000.0, 0.0, "Hoàn Thành" },
                    { new Guid("306c6b1e-bbc7-4303-8486-fc9e20602a29"), null, new Guid("bf4308e8-23b9-46a8-ad78-0bd72734696a"), new Guid("55555555-5555-5555-5555-555555555555"), "Thanh Toán", new DateTime(2024, 11, 15, 19, 20, 30, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tiền mặt", 450000.0, 0.0, "Hoàn Thành" },
                    { new Guid("660f34ef-bb7d-4114-963e-6e6d3d3bbf06"), null, new Guid("61c4a48a-7639-4130-98e3-675851b162f5"), new Guid("55555555-5555-5555-5555-555555555555"), "Thanh Toán", new DateTime(2024, 12, 15, 19, 50, 10, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tiền mặt", 550000.0, 0.0, "Hoàn Thành" },
                    { new Guid("6daf3bcb-c25c-41d8-8228-abf8085a31f2"), null, new Guid("9ae700b4-f0ab-4699-a026-1bd7cf1ff63d"), new Guid("55555555-5555-5555-5555-555555555555"), "Thanh Toán", new DateTime(2024, 10, 15, 18, 59, 10, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tiền mặt", 450000.0, 0.0, "Hoàn Thành" },
                    { new Guid("84ecfcf8-b530-4dd5-84c3-adc2948cd228"), null, new Guid("46b39a37-fdc3-4ffa-8439-42af244d3738"), new Guid("55555555-5555-5555-5555-555555555555"), "Thanh Toán", new DateTime(2024, 12, 15, 19, 3, 20, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tiền mặt", 250000.0, 0.0, "Hoàn Thành" },
                    { new Guid("8679b09f-bf8a-4ff3-a0b0-5ddea7502316"), null, new Guid("167fe6a1-35e4-4e72-b503-9bf35b0b189f"), new Guid("55555555-5555-5555-5555-555555555555"), "Thanh Toán", new DateTime(2024, 11, 16, 19, 35, 45, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tiền mặt", 250000.0, 0.0, "Hoàn Thành" },
                    { new Guid("a4878af6-b93b-4559-b601-76ba31af00c1"), null, new Guid("5a6f7faf-9ffd-4281-a07a-c6c2777df197"), new Guid("55555555-5555-5555-5555-555555555555"), "Thanh Toán", new DateTime(2024, 9, 4, 18, 30, 40, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tiền mặt", 600000.0, 0.0, "Hoàn Thành" },
                    { new Guid("b10737dd-4908-40c7-8637-1b62d0c72c4b"), null, new Guid("84f0335c-8acc-4b12-a112-84041567e0d6"), new Guid("55555555-5555-5555-5555-555555555555"), "Thanh Toán", new DateTime(2024, 11, 20, 20, 20, 40, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tiền mặt", 300000.0, 0.0, "Hoàn Thành" }
                });

            migrationBuilder.InsertData(
                table: "lichSuThanhToans",
                columns: new[] { "IdLichSuThanhToan", "GhiChu", "IdHoaDon", "IdNhanVien", "LoaiGiaoDich", "NgayTao", "NguoiThaoTac", "Pttt", "SoTien", "TienThua", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("cc91b601-1e99-4736-b462-217951f918cb"), null, new Guid("f909806b-0a16-46f5-bb5a-250b0ede383d"), new Guid("55555555-5555-5555-5555-555555555555"), "Thanh Toán", new DateTime(2024, 12, 15, 19, 3, 20, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tiền mặt", 250000.0, 0.0, "Hoàn Thành" },
                    { new Guid("e24a25a9-1e8d-4dad-9132-bfd384fe93c3"), null, new Guid("7e33ace5-0a1b-407f-882b-110cb7ec6673"), new Guid("55555555-5555-5555-5555-555555555555"), "Thanh Toán", new DateTime(2024, 11, 16, 20, 5, 25, 0, DateTimeKind.Unspecified), "Phạm Đức Hiếu", "Tiền mặt", 400000.0, 0.0, "Hoàn Thành" }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTietKichCos",
                columns: new[] { "IdKichCo", "IdSanPhamChiTiet" },
                values: new object[,]
                {
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("00f044d5-9224-4e28-950e-5277b0ad2426") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("023b4fcc-c073-46cf-9511-40e2e85b29e4") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("02f99364-e1b1-428a-abfa-b2dee83f377f") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("0325c437-2a7f-4def-88da-31f6fbb0549d") },
                    { new Guid("3a3247fc-88c9-4201-9fb9-ae5dfb75740c"), new Guid("04447561-833b-43c4-a582-c4522b370486") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("058ad06a-797b-4460-ad15-6bcc6a3cdc12") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("07f75ab5-2071-432e-939a-f3e15421c61e") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("08acc569-a287-4812-859a-f758db4b35ab") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("0a2daae5-4c4d-42d9-8b81-a9f66a3adcf1") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("0ced90f6-2bd9-4c77-8afe-20786319b29f") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("0df3b16c-a410-4003-9964-dbd2f4f7a355") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("1491e7bc-6258-449c-b0ca-357e4b3dfd32") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("14c5f9bc-3adb-4246-8631-668d414a7f95") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("1648636e-d85b-4e22-9775-2618c715824b") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("16b10c0a-9742-421a-891f-b0f9d79a735c") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("19e9d5a9-27a9-4b3e-8f47-f95de29ac056") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("1b945892-5efb-476d-beab-328dd6ca7134") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("1cd2476f-fa06-4837-a3bf-8774abdea482") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("1ce4006b-d05d-4e50-abe5-3cf5c3afdbdf") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("1d4b202e-ab0b-4cb5-84e8-a6050dbb69aa") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("1f51c892-33c2-44bf-b370-12653e940d2d") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("215fe3a0-2338-4082-97f2-288f9f21738b") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("222f19ad-2e39-4a4f-8caf-d46a6f0a6da1") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("23592687-3bab-4be1-90d1-f4e6644a0199") },
                    { new Guid("3a3247fc-88c9-4201-9fb9-ae5dfb75740c"), new Guid("23d254c1-425e-45a9-a5fd-6e8689262b7c") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("23e4c698-085c-4972-accd-4e395c0d630e") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("248776df-7270-480a-9a04-24ea1d8ce745") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("26bbe4c6-5430-46f9-982e-210393d2d504") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("270d4d21-295e-45ca-9666-dbb4bd4db648") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("28fa74fc-2183-4500-9398-15484f62dc80") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("299e463a-f9a2-4168-9656-83af49c50b96") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("29e31bb9-21aa-43d0-a91c-a0f4b6d85852") },
                    { new Guid("3a3247fc-88c9-4201-9fb9-ae5dfb75740c"), new Guid("2a18e9ab-c59c-4b88-a9ac-4a5b08dfe0fb") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("2a3254fa-622e-4d6f-8eb1-e41e1b1b11f9") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("2e18de94-514a-43d8-9964-8469f6a8f21c") },
                    { new Guid("1c9fc5fc-314d-4982-b760-76daed7f0bbf"), new Guid("2f5bd6cd-e4d6-48fc-a4cf-49ba664ab767") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("2f9d3c79-b7b0-4478-a72d-1c045cd0a0d4") },
                    { new Guid("8426438b-386a-4fe4-bf72-2a5971e34b9c"), new Guid("2ff5ba83-d002-42e5-867e-c97a4b6b2524") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("3439ca3d-c3c8-4201-bac9-d5500cd9bdb4") },
                    { new Guid("3a3247fc-88c9-4201-9fb9-ae5dfb75740c"), new Guid("38d251bd-62da-4dc3-b7ef-5cafbb97e7e8") }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTietKichCos",
                columns: new[] { "IdKichCo", "IdSanPhamChiTiet" },
                values: new object[,]
                {
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("398e071c-c1f3-43dc-a097-1dde8b1b326f") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("3d0929e1-a3e5-4829-8844-0237535b895e") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("3dcbf7ad-bfd7-4c7b-bef8-4d052f1e9ed4") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("3dd2395f-71d1-4edc-a57b-21640afd9cd3") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("3e9ed909-5b48-41fb-b420-86b2e89cc9ad") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("3f26d222-ef41-44c2-b78c-7913369ef2bd") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("3f4ba479-1c23-4ac6-a50a-1d439abefce7") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("3f56dbd3-9c42-492b-977f-7669ded8cad0") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("3fb618c1-9735-4d20-a14d-170dbb2d2d5f") },
                    { new Guid("1c9fc5fc-314d-4982-b760-76daed7f0bbf"), new Guid("41dcdcca-a9b2-496a-b502-cc63f43ee5cc") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("425c619e-9589-4cde-8857-d106c6da6385") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("43603eba-c2da-45bb-acbe-6a048350a4b9") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("44304c0e-8c1f-439e-b57e-69e36bbec1f5") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("445ccf5c-996e-43fe-8f31-f3a4a23c2ad0") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("448d3ece-3e8f-4985-93a6-6e2a21604b45") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("4573ca3c-9a30-4f19-9071-8686e63c3c85") },
                    { new Guid("8426438b-386a-4fe4-bf72-2a5971e34b9c"), new Guid("47db7e29-2296-434d-9706-885c2626099e") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("48c24ac7-e80e-4880-916c-c26751057e7c") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("49ccd28f-86e6-4f0d-a77d-5a7a9a698589") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("4a133de7-2840-4f2f-ba07-c2508b4beb57") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("4aa6776d-8f44-40c4-857b-8cab413d92bf") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("4abe567d-cee3-4e1a-aee2-6e41eeabf927") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("4bef1079-25d6-4b00-bcc1-04d6a5c4a1dd") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("4bfafd4e-95c4-4ec6-9231-c138e13ed9c7") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("4c21cd31-1c82-47d8-8cdd-d44683ad4f5e") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("4c25e9d9-f2ae-4e68-afdc-14698d6818e0") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("4d818439-0a02-401d-8b9d-ac3dc7008d65") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("4e373a0b-165d-4caa-a582-f8392cc24498") },
                    { new Guid("1c9fc5fc-314d-4982-b760-76daed7f0bbf"), new Guid("4e4021fc-eae7-41fc-99df-1df038c80e14") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("501dc9c9-ca40-4d45-95d2-e206f3a9f52c") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("5115f516-f864-4f9b-823f-b52a80c42b17") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("51425614-9376-47bc-80f0-a3c9bfd9f65e") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("51c38dab-66ee-4189-8980-4f716ec50ada") },
                    { new Guid("8426438b-386a-4fe4-bf72-2a5971e34b9c"), new Guid("51ef93f2-3f07-42c5-b33e-2aa04ff20859") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("528e6a14-e7cf-4865-9956-1987a870b9c8") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("52f8c9a4-5742-4879-9789-983c22af71ac") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("53482826-3516-4770-8094-3ec8a592cf79") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("5375137d-d183-4de1-b6a2-cd565225b517") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("53775124-ee46-4f20-ba63-f66548986244") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("54747aad-befc-49c3-b1f6-65eca4a26660") },
                    { new Guid("1c9fc5fc-314d-4982-b760-76daed7f0bbf"), new Guid("554c894c-65b3-4323-88ac-a5d440bd7c61") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("558b70e1-5e82-4e32-aa3f-5f2cd127b46f") }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTietKichCos",
                columns: new[] { "IdKichCo", "IdSanPhamChiTiet" },
                values: new object[,]
                {
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("55a5ffc6-097a-4bf8-a798-50a1e324fc6a") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("55f9804a-cda1-4aa7-95e9-8ffbe2443520") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("56737a32-0d20-427c-a5a1-3bff1f94e0d7") },
                    { new Guid("d11ac410-25b5-48fd-88f4-76ef76321b16"), new Guid("567be2a6-7421-46a3-a20c-0827e3170c64") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("5a007dc4-d1df-4ac5-81e0-823d702db695") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("5a155841-560f-4383-92c1-497d8a297260") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("5a72f800-0f95-41b4-9bf7-d64e618c69ce") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("5dc05c9b-2098-4d67-97d2-cc4d7be4e549") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("5e355c97-e31d-4eff-831f-2cc41fbda1de") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("60116fbd-641a-42b4-92ca-1da41ab3c70a") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("60afc7a5-845f-4c9e-8b8e-3c01a5cdbd0f") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("63239d55-4ab2-42ad-af6b-337cadcb1d08") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("64b07d62-126a-44a0-b80c-a2fda7d59bb5") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("64f39ec3-1690-4449-9002-91fc9d9fcf8c") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("65badccc-781f-478b-ba82-d268bdf463a5") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("65f71b92-9283-46e8-94ae-41462b48435a") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("6942032b-d386-4b20-a4cd-96c0dadc0b16") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("694efdef-5bc5-4a73-88a5-8e5284e50fb4") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("6a3f7de9-c2c8-4763-99d3-ad7f42844250") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("6d9f59d5-9705-414e-965d-dab40b7c6ebe") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("6db7d816-d9e9-4447-8b38-7598e206b9ca") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("6e4a6e31-e2cc-4311-886e-7b81659f28a6") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("7386e6a1-f603-48bc-b271-b9f0b31a3c07") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("74cca36f-1bbc-4e6e-8afd-31882214b70a") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("76d53d2d-fa90-4193-ac37-0caab494fa34") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("775571ff-7142-4a7b-8ebc-ea3f171368f4") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("7755752b-20ce-4699-b909-1bbae5735f0a") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("776ac667-2560-4589-b44e-11234076d1eb") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("7804cccb-5d9b-4236-b04d-e8b4831efb0b") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("785dd673-b96a-4779-ac6b-5fa40827bd57") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("790aca04-56c9-4149-9b06-c8c3e5575dfe") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("79283b68-ab08-45fa-8ef5-a01129ceebd3") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("79d9806a-b19b-4dc6-8b28-dc9d52dfa930") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("79db4a88-7d04-4d68-bc3e-73e25aad32dd") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("79fbade8-21d1-4ba6-85f5-07d64e9dd797") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("7a06f3f2-fe55-4b74-9a16-4d0d9c20cbae") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("7d776dff-494b-4cc5-b819-ea1f65c1a33a") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("7f54e513-9be3-47ba-89ff-eb274757cb87") },
                    { new Guid("c10a1f1a-4b43-4663-8b54-746e0f79985b"), new Guid("822de950-cc64-4705-a8dc-e70e3d3dbaeb") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("826773e4-4782-446e-8d60-0b89bdf4b5e4") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("82f21608-a636-44b5-91db-77d7550c3dca") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("837f680b-0435-42ed-bf17-009c0baab9d7") }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTietKichCos",
                columns: new[] { "IdKichCo", "IdSanPhamChiTiet" },
                values: new object[,]
                {
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("83f676cf-08c0-4d06-adfe-258c856a3263") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("87d2591c-fc28-41fd-91dc-afd7e2b0bc32") },
                    { new Guid("3a3247fc-88c9-4201-9fb9-ae5dfb75740c"), new Guid("883330dd-d471-4470-8bcc-55bb4d2ecca7") },
                    { new Guid("8426438b-386a-4fe4-bf72-2a5971e34b9c"), new Guid("8854468a-bcb8-421a-bf3d-d22e027f14c6") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("88c754b7-32db-477e-b72b-a45d25f85a6a") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("8a80efdf-97ea-4cbb-b80f-d2ee64f76ea8") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("8c30caa7-7c81-4c88-9235-c2ad230a48f4") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("8db7f7a9-45bb-4644-ac9b-3691d9e3b77d") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("8ea80907-1a6c-4d6b-906a-d2e4a26f0ed5") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("8f5226e7-b14b-43da-88b4-e1b81019f324") },
                    { new Guid("3a3247fc-88c9-4201-9fb9-ae5dfb75740c"), new Guid("8fb05196-c04e-4146-b843-7435683c4b91") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("90c43059-fba4-4d18-b9d5-bcfb1efdca0e") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("9197695c-181a-42ad-b003-9a63ce9b6eac") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("924bac05-8a68-4855-afc8-cd5129207b6f") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("94038418-592a-44ff-b296-423c79850669") },
                    { new Guid("3a3247fc-88c9-4201-9fb9-ae5dfb75740c"), new Guid("950fa338-d988-473c-a505-37d5aa5b588e") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("9679011e-2f4c-4848-bae8-2c2dbbfd0bd0") },
                    { new Guid("8426438b-386a-4fe4-bf72-2a5971e34b9c"), new Guid("975fb191-fe0a-4637-8ec3-de026b1c39e8") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("9805444a-8c4f-4de6-9690-8c5938d1b9d7") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("9975d99b-ebd6-4de8-9519-168a65b85370") },
                    { new Guid("d11ac410-25b5-48fd-88f4-76ef76321b16"), new Guid("9c7c6fac-2b9b-495d-a149-353a9bd4d13e") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("a37af730-9db9-4a44-a9fe-ecb0b4f7bea1") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("a5c34da3-7764-44ea-82dd-616126d2bf0e") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("a7746e69-addd-4eb8-8586-25101784edff") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("a790d2f4-c0c9-4fa4-a326-4e39284021dc") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("a8101fbe-f1e8-4a87-996e-cdd7a04909bc") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("a8c22ce5-7944-476d-b6b9-e4356b773ad2") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("a97e4a39-c35b-41cb-8c98-42d35d5b4433") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("aa3d6425-301e-47fb-8dca-5b96dfaf9024") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("abd3500d-a6f7-4459-833f-235338c51770") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("ac72d438-21c4-403e-a05d-17fa0b9f5d01") },
                    { new Guid("3a3247fc-88c9-4201-9fb9-ae5dfb75740c"), new Guid("ac9f4cf1-de9c-4abb-80e9-b8a97d487c40") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("ad08a33b-2016-4d96-b898-73e3037fc920") },
                    { new Guid("c10a1f1a-4b43-4663-8b54-746e0f79985b"), new Guid("aecba6e3-f9a9-4294-9fd2-07f34fc13c21") },
                    { new Guid("d11ac410-25b5-48fd-88f4-76ef76321b16"), new Guid("afa1ef2f-3edc-4f08-8b20-9d4dacd54386") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("aff961bd-fcaa-4f9e-af73-fbc2f636279e") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("b4ac6de2-ddbc-4c46-a839-50db1d0e39d5") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("b5be1f86-93e6-452e-a786-6c6df0cb1ac3") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("b8c3f587-5459-48f6-9a4a-746c4c895e0a") },
                    { new Guid("1c9fc5fc-314d-4982-b760-76daed7f0bbf"), new Guid("bacc65d0-3647-45fe-ac6a-7c4abef10eaf") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("bb9b6c81-b3c4-4675-9227-2060d1a16bf4") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("bbd8738f-c948-488e-bff3-a95200fe4d43") }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTietKichCos",
                columns: new[] { "IdKichCo", "IdSanPhamChiTiet" },
                values: new object[,]
                {
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("bd4a3e6d-5d0e-459c-ba5a-abff1984fb5e") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("bee65a90-50bf-49db-aee1-61c205b8dc0e") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("c034b7e2-6084-4a97-92fa-3c4dc38a4967") },
                    { new Guid("8426438b-386a-4fe4-bf72-2a5971e34b9c"), new Guid("c1252891-249f-48ce-81dc-1e16bab7342d") },
                    { new Guid("8426438b-386a-4fe4-bf72-2a5971e34b9c"), new Guid("c19221a5-5686-42c6-b3f6-715f8ed406b0") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("c1c3b372-1dae-45ba-84b6-a377b222ae9c") },
                    { new Guid("8426438b-386a-4fe4-bf72-2a5971e34b9c"), new Guid("c308a48f-a7ed-438e-ad28-6fb543c24da5") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("c430afb1-b734-45fe-b966-d3884b4fe8f4") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("c45666bd-e3ca-4c6e-b37c-0ae6dad9c071") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("c4b246ba-dd19-4493-b2a3-4b287933f1df") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("cb865a00-7b61-429e-94a6-e179127a95ad") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("ccc33371-d3a1-4803-91bf-2d670ef44acf") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("ce60379b-5a91-4177-8b92-6a0cc5bc40c0") },
                    { new Guid("8426438b-386a-4fe4-bf72-2a5971e34b9c"), new Guid("d09b806a-9e5d-40ae-9c61-cda6ba38c053") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("d0ca4381-df33-47fc-9c7f-c6b11884d312") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("d1a5114b-315c-4822-80aa-b6cf28f072f9") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("d2fb74ce-0d88-4319-9e8f-24a975ea92ad") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("d333abf3-6a85-4722-a60c-e2050786af35") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("d38694f5-eafb-4c3b-92d4-718ed6e47caf") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("d5b90d92-3cbb-4ad2-868e-9b2b792907a0") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("d84c1392-7bb1-4910-a834-5d407cb8fe60") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("da9785a7-d3ef-4359-839c-6a48a481555b") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("dba08f68-1eb1-4497-aa40-c46055451645") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("dce8ccf9-e88e-4316-87a5-89f31825edb5") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("dd089dd6-0b59-4852-885f-1d1ebe810da6") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("ddafaad7-bd62-4df5-b2b2-7fae57b57516") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("ddc21c54-d8c0-4366-9361-24b9fb5ee630") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("ddf406f0-988f-4417-8476-02b0b975bcc2") },
                    { new Guid("3a3247fc-88c9-4201-9fb9-ae5dfb75740c"), new Guid("deca944a-57dc-436a-9a6d-73b1644427b2") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("df46b06a-7ffa-4de9-88c8-474c6fefd16e") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("e03572ac-6e4c-42af-a7c6-b2bbae483fad") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("e16a5336-533e-4bfe-880d-cf8504ab0145") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("e333588e-4a51-4368-9f0e-d18f4b8c7d4a") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("e6330c1a-886e-45f3-b26d-1f23a8d14e5a") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("e6b97675-b70a-49cb-a230-c6cf12dfe286") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("e7158ef5-d2e5-4dbc-ae54-95ad9d3d02ec") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("e8061f40-d55c-4945-8219-78a107e129cf") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("e83f4468-13df-49ca-ad0b-409f1a1e01a9") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("eaaa11aa-5908-404b-9d0c-e062763e339c") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("ed422156-d7ea-4c68-a9b1-4d26761ead8a") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("ef809ed2-6203-4656-bab9-0acd7c8912a4") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("efd574ad-f93e-443e-afd5-9e3f366f0032") }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTietKichCos",
                columns: new[] { "IdKichCo", "IdSanPhamChiTiet" },
                values: new object[,]
                {
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("f052f971-8e8f-4bee-97cf-80f5333eb3ce") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("f104aba8-24d0-4b6e-802e-b505d6612c8f") },
                    { new Guid("1c9fc5fc-314d-4982-b760-76daed7f0bbf"), new Guid("f153e1ce-d2fa-4961-a33b-acb1637ed8e2") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("f388579c-28e5-4ffd-8d6e-9a067467a05f") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("f3be26b7-b353-49ef-a93a-56dc23739c2a") },
                    { new Guid("ac17a38b-de3f-4737-ae7c-b8a4c64760ad"), new Guid("f625ec33-e3f9-44d4-af77-bf4100371ccb") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("f748bb14-ce01-4d59-b062-1f50c61c0fd9") },
                    { new Guid("effa96d4-c158-4196-94e4-dccb0871ee02"), new Guid("f8341911-40c9-44ed-86eb-ce8b6625dd19") },
                    { new Guid("c10a1f1a-4b43-4663-8b54-746e0f79985b"), new Guid("f858206d-493d-4179-8e8c-7e56f49b6f5b") },
                    { new Guid("d9394e04-5371-4579-9087-5c0ba4184d90"), new Guid("fa87ff71-9456-4aeb-becd-7f71733717a6") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("fbe9b897-6da9-40b9-88ec-d50466b79d73") },
                    { new Guid("cc58687e-6bff-4073-9f68-23d15035377c"), new Guid("fcf9bd25-2862-4443-92c0-bfec01e09200") },
                    { new Guid("881ffc2b-c844-4707-8920-00fd210557b1"), new Guid("fef42c8d-c16d-48e8-b6e2-770db112c199") },
                    { new Guid("ec972b63-7846-4479-b67a-bc9f57d0dcd0"), new Guid("ff720eea-f5f6-4130-af01-995b5317c0e9") }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTietMausacs",
                columns: new[] { "IdMauSac", "IdSanPhamChiTiet" },
                values: new object[,]
                {
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("00f044d5-9224-4e28-950e-5277b0ad2426") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("023b4fcc-c073-46cf-9511-40e2e85b29e4") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("02f99364-e1b1-428a-abfa-b2dee83f377f") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("0325c437-2a7f-4def-88da-31f6fbb0549d") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("04447561-833b-43c4-a582-c4522b370486") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("058ad06a-797b-4460-ad15-6bcc6a3cdc12") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("07f75ab5-2071-432e-939a-f3e15421c61e") },
                    { new Guid("c4e5d4f4-7112-42e8-9408-1b2e1e0af4d7"), new Guid("08acc569-a287-4812-859a-f758db4b35ab") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("0a2daae5-4c4d-42d9-8b81-a9f66a3adcf1") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("0ced90f6-2bd9-4c77-8afe-20786319b29f") },
                    { new Guid("fb085ebb-cb2c-4578-bcfd-fbe0565ff241"), new Guid("0df3b16c-a410-4003-9964-dbd2f4f7a355") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("1491e7bc-6258-449c-b0ca-357e4b3dfd32") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("14c5f9bc-3adb-4246-8631-668d414a7f95") },
                    { new Guid("fb085ebb-cb2c-4578-bcfd-fbe0565ff241"), new Guid("1648636e-d85b-4e22-9775-2618c715824b") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("16b10c0a-9742-421a-891f-b0f9d79a735c") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("19e9d5a9-27a9-4b3e-8f47-f95de29ac056") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("1b945892-5efb-476d-beab-328dd6ca7134") },
                    { new Guid("c4e5d4f4-7112-42e8-9408-1b2e1e0af4d7"), new Guid("1cd2476f-fa06-4837-a3bf-8774abdea482") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("1ce4006b-d05d-4e50-abe5-3cf5c3afdbdf") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("1d4b202e-ab0b-4cb5-84e8-a6050dbb69aa") },
                    { new Guid("fb085ebb-cb2c-4578-bcfd-fbe0565ff241"), new Guid("1f51c892-33c2-44bf-b370-12653e940d2d") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("215fe3a0-2338-4082-97f2-288f9f21738b") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("222f19ad-2e39-4a4f-8caf-d46a6f0a6da1") },
                    { new Guid("c4e5d4f4-7112-42e8-9408-1b2e1e0af4d7"), new Guid("23592687-3bab-4be1-90d1-f4e6644a0199") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("23d254c1-425e-45a9-a5fd-6e8689262b7c") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("23e4c698-085c-4972-accd-4e395c0d630e") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("248776df-7270-480a-9a04-24ea1d8ce745") },
                    { new Guid("fb085ebb-cb2c-4578-bcfd-fbe0565ff241"), new Guid("26bbe4c6-5430-46f9-982e-210393d2d504") }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTietMausacs",
                columns: new[] { "IdMauSac", "IdSanPhamChiTiet" },
                values: new object[,]
                {
                    { new Guid("c4e5d4f4-7112-42e8-9408-1b2e1e0af4d7"), new Guid("270d4d21-295e-45ca-9666-dbb4bd4db648") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("28fa74fc-2183-4500-9398-15484f62dc80") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("28fa74fc-2183-4500-9398-15484f62dc80") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("299e463a-f9a2-4168-9656-83af49c50b96") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("29e31bb9-21aa-43d0-a91c-a0f4b6d85852") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("2a18e9ab-c59c-4b88-a9ac-4a5b08dfe0fb") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("2a3254fa-622e-4d6f-8eb1-e41e1b1b11f9") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("2e18de94-514a-43d8-9964-8469f6a8f21c") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("2f5bd6cd-e4d6-48fc-a4cf-49ba664ab767") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("2f9d3c79-b7b0-4478-a72d-1c045cd0a0d4") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("2ff5ba83-d002-42e5-867e-c97a4b6b2524") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("3439ca3d-c3c8-4201-bac9-d5500cd9bdb4") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("38d251bd-62da-4dc3-b7ef-5cafbb97e7e8") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("398e071c-c1f3-43dc-a097-1dde8b1b326f") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("3d0929e1-a3e5-4829-8844-0237535b895e") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("3dcbf7ad-bfd7-4c7b-bef8-4d052f1e9ed4") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("3dd2395f-71d1-4edc-a57b-21640afd9cd3") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("3e9ed909-5b48-41fb-b420-86b2e89cc9ad") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("3f26d222-ef41-44c2-b78c-7913369ef2bd") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("3f4ba479-1c23-4ac6-a50a-1d439abefce7") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("3f56dbd3-9c42-492b-977f-7669ded8cad0") },
                    { new Guid("fb085ebb-cb2c-4578-bcfd-fbe0565ff241"), new Guid("3f56dbd3-9c42-492b-977f-7669ded8cad0") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("3fb618c1-9735-4d20-a14d-170dbb2d2d5f") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("41dcdcca-a9b2-496a-b502-cc63f43ee5cc") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("425c619e-9589-4cde-8857-d106c6da6385") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("43603eba-c2da-45bb-acbe-6a048350a4b9") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("44304c0e-8c1f-439e-b57e-69e36bbec1f5") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("445ccf5c-996e-43fe-8f31-f3a4a23c2ad0") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("448d3ece-3e8f-4985-93a6-6e2a21604b45") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("4573ca3c-9a30-4f19-9071-8686e63c3c85") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("47db7e29-2296-434d-9706-885c2626099e") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("48c24ac7-e80e-4880-916c-c26751057e7c") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("49ccd28f-86e6-4f0d-a77d-5a7a9a698589") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("4a133de7-2840-4f2f-ba07-c2508b4beb57") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("4aa6776d-8f44-40c4-857b-8cab413d92bf") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("4abe567d-cee3-4e1a-aee2-6e41eeabf927") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("4bef1079-25d6-4b00-bcc1-04d6a5c4a1dd") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("4bfafd4e-95c4-4ec6-9231-c138e13ed9c7") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("4c21cd31-1c82-47d8-8cdd-d44683ad4f5e") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("4c25e9d9-f2ae-4e68-afdc-14698d6818e0") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("4d818439-0a02-401d-8b9d-ac3dc7008d65") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("4e373a0b-165d-4caa-a582-f8392cc24498") }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTietMausacs",
                columns: new[] { "IdMauSac", "IdSanPhamChiTiet" },
                values: new object[,]
                {
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("4e4021fc-eae7-41fc-99df-1df038c80e14") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("501dc9c9-ca40-4d45-95d2-e206f3a9f52c") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("5115f516-f864-4f9b-823f-b52a80c42b17") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("51425614-9376-47bc-80f0-a3c9bfd9f65e") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("51c38dab-66ee-4189-8980-4f716ec50ada") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("51ef93f2-3f07-42c5-b33e-2aa04ff20859") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("528e6a14-e7cf-4865-9956-1987a870b9c8") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("52f8c9a4-5742-4879-9789-983c22af71ac") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("53482826-3516-4770-8094-3ec8a592cf79") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("5375137d-d183-4de1-b6a2-cd565225b517") },
                    { new Guid("fb085ebb-cb2c-4578-bcfd-fbe0565ff241"), new Guid("53775124-ee46-4f20-ba63-f66548986244") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("54747aad-befc-49c3-b1f6-65eca4a26660") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("554c894c-65b3-4323-88ac-a5d440bd7c61") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("558b70e1-5e82-4e32-aa3f-5f2cd127b46f") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("55a5ffc6-097a-4bf8-a798-50a1e324fc6a") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("55f9804a-cda1-4aa7-95e9-8ffbe2443520") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("56737a32-0d20-427c-a5a1-3bff1f94e0d7") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("567be2a6-7421-46a3-a20c-0827e3170c64") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("5a007dc4-d1df-4ac5-81e0-823d702db695") },
                    { new Guid("c4e5d4f4-7112-42e8-9408-1b2e1e0af4d7"), new Guid("5a155841-560f-4383-92c1-497d8a297260") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("5a72f800-0f95-41b4-9bf7-d64e618c69ce") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("5dc05c9b-2098-4d67-97d2-cc4d7be4e549") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("5e355c97-e31d-4eff-831f-2cc41fbda1de") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("60116fbd-641a-42b4-92ca-1da41ab3c70a") },
                    { new Guid("fb085ebb-cb2c-4578-bcfd-fbe0565ff241"), new Guid("60afc7a5-845f-4c9e-8b8e-3c01a5cdbd0f") },
                    { new Guid("c4e5d4f4-7112-42e8-9408-1b2e1e0af4d7"), new Guid("63239d55-4ab2-42ad-af6b-337cadcb1d08") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("64b07d62-126a-44a0-b80c-a2fda7d59bb5") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("64f39ec3-1690-4449-9002-91fc9d9fcf8c") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("65badccc-781f-478b-ba82-d268bdf463a5") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("65f71b92-9283-46e8-94ae-41462b48435a") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("6942032b-d386-4b20-a4cd-96c0dadc0b16") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("6a3f7de9-c2c8-4763-99d3-ad7f42844250") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("6d9f59d5-9705-414e-965d-dab40b7c6ebe") },
                    { new Guid("c4e5d4f4-7112-42e8-9408-1b2e1e0af4d7"), new Guid("6db7d816-d9e9-4447-8b38-7598e206b9ca") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("6e4a6e31-e2cc-4311-886e-7b81659f28a6") },
                    { new Guid("c4e5d4f4-7112-42e8-9408-1b2e1e0af4d7"), new Guid("7386e6a1-f603-48bc-b271-b9f0b31a3c07") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("74cca36f-1bbc-4e6e-8afd-31882214b70a") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("76d53d2d-fa90-4193-ac37-0caab494fa34") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("775571ff-7142-4a7b-8ebc-ea3f171368f4") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("7755752b-20ce-4699-b909-1bbae5735f0a") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("776ac667-2560-4589-b44e-11234076d1eb") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("7804cccb-5d9b-4236-b04d-e8b4831efb0b") }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTietMausacs",
                columns: new[] { "IdMauSac", "IdSanPhamChiTiet" },
                values: new object[,]
                {
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("785dd673-b96a-4779-ac6b-5fa40827bd57") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("790aca04-56c9-4149-9b06-c8c3e5575dfe") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("79283b68-ab08-45fa-8ef5-a01129ceebd3") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("79d9806a-b19b-4dc6-8b28-dc9d52dfa930") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("79db4a88-7d04-4d68-bc3e-73e25aad32dd") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("79fbade8-21d1-4ba6-85f5-07d64e9dd797") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("7a06f3f2-fe55-4b74-9a16-4d0d9c20cbae") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("7d776dff-494b-4cc5-b819-ea1f65c1a33a") },
                    { new Guid("c4e5d4f4-7112-42e8-9408-1b2e1e0af4d7"), new Guid("7f54e513-9be3-47ba-89ff-eb274757cb87") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("822de950-cc64-4705-a8dc-e70e3d3dbaeb") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("826773e4-4782-446e-8d60-0b89bdf4b5e4") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("82f21608-a636-44b5-91db-77d7550c3dca") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("837f680b-0435-42ed-bf17-009c0baab9d7") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("83f676cf-08c0-4d06-adfe-258c856a3263") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("87d2591c-fc28-41fd-91dc-afd7e2b0bc32") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("883330dd-d471-4470-8bcc-55bb4d2ecca7") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("8854468a-bcb8-421a-bf3d-d22e027f14c6") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("88c754b7-32db-477e-b72b-a45d25f85a6a") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("8a80efdf-97ea-4cbb-b80f-d2ee64f76ea8") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("8c30caa7-7c81-4c88-9235-c2ad230a48f4") },
                    { new Guid("c4e5d4f4-7112-42e8-9408-1b2e1e0af4d7"), new Guid("8db7f7a9-45bb-4644-ac9b-3691d9e3b77d") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("8ea80907-1a6c-4d6b-906a-d2e4a26f0ed5") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("8f5226e7-b14b-43da-88b4-e1b81019f324") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("8fb05196-c04e-4146-b843-7435683c4b91") },
                    { new Guid("fb085ebb-cb2c-4578-bcfd-fbe0565ff241"), new Guid("90c43059-fba4-4d18-b9d5-bcfb1efdca0e") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("9197695c-181a-42ad-b003-9a63ce9b6eac") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("924bac05-8a68-4855-afc8-cd5129207b6f") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("94038418-592a-44ff-b296-423c79850669") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("950fa338-d988-473c-a505-37d5aa5b588e") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("9679011e-2f4c-4848-bae8-2c2dbbfd0bd0") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("975fb191-fe0a-4637-8ec3-de026b1c39e8") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("9805444a-8c4f-4de6-9690-8c5938d1b9d7") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("9975d99b-ebd6-4de8-9519-168a65b85370") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("9c7c6fac-2b9b-495d-a149-353a9bd4d13e") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("a37af730-9db9-4a44-a9fe-ecb0b4f7bea1") },
                    { new Guid("fb085ebb-cb2c-4578-bcfd-fbe0565ff241"), new Guid("a5c34da3-7764-44ea-82dd-616126d2bf0e") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("a7746e69-addd-4eb8-8586-25101784edff") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("a790d2f4-c0c9-4fa4-a326-4e39284021dc") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("a8101fbe-f1e8-4a87-996e-cdd7a04909bc") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("a8c22ce5-7944-476d-b6b9-e4356b773ad2") },
                    { new Guid("fb085ebb-cb2c-4578-bcfd-fbe0565ff241"), new Guid("a97e4a39-c35b-41cb-8c98-42d35d5b4433") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("aa3d6425-301e-47fb-8dca-5b96dfaf9024") }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTietMausacs",
                columns: new[] { "IdMauSac", "IdSanPhamChiTiet" },
                values: new object[,]
                {
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("abd3500d-a6f7-4459-833f-235338c51770") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("ac72d438-21c4-403e-a05d-17fa0b9f5d01") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("ac9f4cf1-de9c-4abb-80e9-b8a97d487c40") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("ad08a33b-2016-4d96-b898-73e3037fc920") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("aecba6e3-f9a9-4294-9fd2-07f34fc13c21") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("afa1ef2f-3edc-4f08-8b20-9d4dacd54386") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("aff961bd-fcaa-4f9e-af73-fbc2f636279e") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("b4ac6de2-ddbc-4c46-a839-50db1d0e39d5") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("b5be1f86-93e6-452e-a786-6c6df0cb1ac3") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("b8c3f587-5459-48f6-9a4a-746c4c895e0a") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("bacc65d0-3647-45fe-ac6a-7c4abef10eaf") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("bb9b6c81-b3c4-4675-9227-2060d1a16bf4") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("bbd8738f-c948-488e-bff3-a95200fe4d43") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("bd4a3e6d-5d0e-459c-ba5a-abff1984fb5e") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("bee65a90-50bf-49db-aee1-61c205b8dc0e") },
                    { new Guid("c4e5d4f4-7112-42e8-9408-1b2e1e0af4d7"), new Guid("c034b7e2-6084-4a97-92fa-3c4dc38a4967") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("c1252891-249f-48ce-81dc-1e16bab7342d") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("c19221a5-5686-42c6-b3f6-715f8ed406b0") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("c1c3b372-1dae-45ba-84b6-a377b222ae9c") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("c308a48f-a7ed-438e-ad28-6fb543c24da5") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("c430afb1-b734-45fe-b966-d3884b4fe8f4") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("c45666bd-e3ca-4c6e-b37c-0ae6dad9c071") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("c4b246ba-dd19-4493-b2a3-4b287933f1df") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("ccc33371-d3a1-4803-91bf-2d670ef44acf") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("ce60379b-5a91-4177-8b92-6a0cc5bc40c0") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("d09b806a-9e5d-40ae-9c61-cda6ba38c053") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("d0ca4381-df33-47fc-9c7f-c6b11884d312") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("d1a5114b-315c-4822-80aa-b6cf28f072f9") },
                    { new Guid("fb085ebb-cb2c-4578-bcfd-fbe0565ff241"), new Guid("d2fb74ce-0d88-4319-9e8f-24a975ea92ad") },
                    { new Guid("fb085ebb-cb2c-4578-bcfd-fbe0565ff241"), new Guid("d333abf3-6a85-4722-a60c-e2050786af35") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("d38694f5-eafb-4c3b-92d4-718ed6e47caf") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("d5b90d92-3cbb-4ad2-868e-9b2b792907a0") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("d84c1392-7bb1-4910-a834-5d407cb8fe60") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("da9785a7-d3ef-4359-839c-6a48a481555b") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("dba08f68-1eb1-4497-aa40-c46055451645") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("dce8ccf9-e88e-4316-87a5-89f31825edb5") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("dd089dd6-0b59-4852-885f-1d1ebe810da6") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("ddafaad7-bd62-4df5-b2b2-7fae57b57516") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("ddc21c54-d8c0-4366-9361-24b9fb5ee630") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("ddf406f0-988f-4417-8476-02b0b975bcc2") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("deca944a-57dc-436a-9a6d-73b1644427b2") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("df46b06a-7ffa-4de9-88c8-474c6fefd16e") }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTietMausacs",
                columns: new[] { "IdMauSac", "IdSanPhamChiTiet" },
                values: new object[,]
                {
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("e03572ac-6e4c-42af-a7c6-b2bbae483fad") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("e16a5336-533e-4bfe-880d-cf8504ab0145") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("e333588e-4a51-4368-9f0e-d18f4b8c7d4a") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("e6330c1a-886e-45f3-b26d-1f23a8d14e5a") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("e6b97675-b70a-49cb-a230-c6cf12dfe286") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("e7158ef5-d2e5-4dbc-ae54-95ad9d3d02ec") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("e8061f40-d55c-4945-8219-78a107e129cf") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("e83f4468-13df-49ca-ad0b-409f1a1e01a9") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("eaaa11aa-5908-404b-9d0c-e062763e339c") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("ed422156-d7ea-4c68-a9b1-4d26761ead8a") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("ef809ed2-6203-4656-bab9-0acd7c8912a4") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("efd574ad-f93e-443e-afd5-9e3f366f0032") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("f052f971-8e8f-4bee-97cf-80f5333eb3ce") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("f104aba8-24d0-4b6e-802e-b505d6612c8f") },
                    { new Guid("38791fed-9993-48f4-92ef-0ece08e6fd96"), new Guid("f153e1ce-d2fa-4961-a33b-acb1637ed8e2") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("f388579c-28e5-4ffd-8d6e-9a067467a05f") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("f3be26b7-b353-49ef-a93a-56dc23739c2a") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("f625ec33-e3f9-44d4-af77-bf4100371ccb") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("f748bb14-ce01-4d59-b062-1f50c61c0fd9") },
                    { new Guid("2f5a96e8-fb22-45ed-8863-4a879e3dbe7d"), new Guid("f8341911-40c9-44ed-86eb-ce8b6625dd19") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("f858206d-493d-4179-8e8c-7e56f49b6f5b") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("fa87ff71-9456-4aeb-becd-7f71733717a6") },
                    { new Guid("ab3770f2-8278-4266-8533-1a142713ff11"), new Guid("fbe9b897-6da9-40b9-88ec-d50466b79d73") },
                    { new Guid("0757e6cd-9315-492e-a817-a6c7c795343a"), new Guid("fcf9bd25-2862-4443-92c0-bfec01e09200") },
                    { new Guid("947d2de1-a5bd-4aaa-9369-c57f01959ca0"), new Guid("fef42c8d-c16d-48e8-b6e2-770db112c199") },
                    { new Guid("c4e5d4f4-7112-42e8-9408-1b2e1e0af4d7"), new Guid("ff720eea-f5f6-4130-af01-995b5317c0e9") }
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
