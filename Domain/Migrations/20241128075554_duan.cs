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
                name: "LichSuSuDungVouchers",
                columns: table => new
                {
                    IdVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLichSuVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdOrder = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgaySuDungVoucher = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuSuDungVouchers", x => new { x.IdVoucher, x.IdKhachHang });
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
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.IdHoaDon);
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
                    SoLuong = table.Column<double>(type: "float", nullable: false),
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
                name: "PromotionSanPhamChiTiet",
                columns: table => new
                {
                    IdPromotion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPhamChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionSanPhamChiTiet", x => new { x.IdPromotion, x.IdSanPhamChiTiet });
                    table.ForeignKey(
                        name: "FK_PromotionSanPhamChiTiet_promotions_IdPromotion",
                        column: x => x.IdPromotion,
                        principalTable: "promotions",
                        principalColumn: "IdPromotion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromotionSanPhamChiTiet_sanPhamChiTiets_IdSanPhamChiTiet",
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
                    { new Guid("32961fd1-3f89-4416-93cd-2253479d0a1a"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 815, DateTimeKind.Local).AddTicks(9644), new DateTime(2024, 11, 28, 14, 55, 53, 815, DateTimeKind.Local).AddTicks(9645), "Admin", "Admin", "Da thật" },
                    { new Guid("7ec14622-f838-4100-b5e2-df2052023a8a"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 815, DateTimeKind.Local).AddTicks(9646), new DateTime(2024, 11, 28, 14, 55, 53, 815, DateTimeKind.Local).AddTicks(9647), "Admin", "Admin", "Vải Polyester" },
                    { new Guid("968afe2a-a394-4a7f-bb5e-bc75b3e42dd1"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 815, DateTimeKind.Local).AddTicks(9622), new DateTime(2024, 11, 28, 14, 55, 53, 815, DateTimeKind.Local).AddTicks(9630), "Admin", "Admin", "Vải Cotton" }
                });

            migrationBuilder.InsertData(
                table: "chuVu",
                columns: new[] { "IdChucVu", "Code", "TenChucVu" },
                values: new object[,]
                {
                    { new Guid("72f034d2-36fd-49c0-934a-8c0e6a7a7b9e"), "QL", "Quản lý" },
                    { new Guid("797acebe-fce4-468b-9212-ebda8ec48f34"), "NV", "Nhân viên" },
                    { new Guid("c275c461-69ca-4b87-b7d2-cfca40fd416c"), "KK", "Thủ kho" },
                    { new Guid("e9b040b1-d47a-4dc3-934c-5ed34d4e3dff"), "KT", "Kế toán" }
                });

            migrationBuilder.InsertData(
                table: "danhMuc",
                columns: new[] { "IdDanhMuc", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("84f9e990-c7ab-4e32-89ef-96def2f0c8db"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 816, DateTimeKind.Local).AddTicks(4748), new DateTime(2024, 11, 28, 14, 55, 53, 816, DateTimeKind.Local).AddTicks(4748), "Admin", "Admin", "Giày Cao Gót" },
                    { new Guid("a1d895f7-b0bd-41c7-8bdb-d6e47a17b1eb"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 816, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 11, 28, 14, 55, 53, 816, DateTimeKind.Local).AddTicks(4741), "Admin", "Admin", "Giày Da" },
                    { new Guid("b468e673-2a91-453d-a2dc-378044f1bf22"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 816, DateTimeKind.Local).AddTicks(4739), new DateTime(2024, 11, 28, 14, 55, 53, 816, DateTimeKind.Local).AddTicks(4735), "Admin", "Admin", "Giày Thể Thao" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("172a4372-93df-4d52-991b-2598731220fd"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" },
                    { new Guid("5d67b738-0c3e-4258-a739-426f53518e1e"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" },
                    { new Guid("daa5f216-ffe2-40e2-bd1f-ded77882fc63"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("1e6d3fee-503e-45d4-99e1-e257d1074f2c"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 822, DateTimeKind.Local).AddTicks(3868), new DateTime(2024, 11, 28, 14, 55, 53, 822, DateTimeKind.Local).AddTicks(3868), "Admin", "Admin", "Size 39" },
                    { new Guid("803b5514-ada7-45c0-8da5-887fa42f6658"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 822, DateTimeKind.Local).AddTicks(3849), new DateTime(2024, 11, 28, 14, 55, 53, 822, DateTimeKind.Local).AddTicks(3863), "Admin", "Admin", "Size 37" },
                    { new Guid("8dfabc2a-9aad-45a9-8c3e-ddd8e70743ff"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 822, DateTimeKind.Local).AddTicks(3866), new DateTime(2024, 11, 28, 14, 55, 53, 822, DateTimeKind.Local).AddTicks(3866), "Admin", "Admin", "Size 38" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("355f15e0-a584-402f-9bc9-9f251c7b7030"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 822, DateTimeKind.Local).AddTicks(7964), new DateTime(2024, 11, 28, 14, 55, 53, 822, DateTimeKind.Local).AddTicks(7964), "Admin", "Admin", "Hiện Đại" },
                    { new Guid("5d663e85-b35f-4704-8829-87f9aedc7554"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 822, DateTimeKind.Local).AddTicks(7955), new DateTime(2024, 11, 28, 14, 55, 53, 822, DateTimeKind.Local).AddTicks(7952), "Admin", "Admin", "Thể Thao" },
                    { new Guid("8d981261-0575-4bdb-9dbe-8cee72bf9d98"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 822, DateTimeKind.Local).AddTicks(7962), new DateTime(2024, 11, 28, 14, 55, 53, 822, DateTimeKind.Local).AddTicks(7961), "Admin", "Admin", "Cổ Điển" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("9938b871-727d-45ac-8b10-39f13828c1f6"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 824, DateTimeKind.Local).AddTicks(3068), new DateTime(2024, 11, 28, 14, 55, 53, 824, DateTimeKind.Local).AddTicks(3069), "Admin", "Admin", "Green" },
                    { new Guid("a9ea2a65-eca9-46a6-b79c-e06966c412e7"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 824, DateTimeKind.Local).AddTicks(3046), new DateTime(2024, 11, 28, 14, 55, 53, 824, DateTimeKind.Local).AddTicks(3051), "Admin", "Admin", "Red" },
                    { new Guid("e29450ca-1641-4c06-a393-9ac3cc78a9ed"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 824, DateTimeKind.Local).AddTicks(3071), new DateTime(2024, 11, 28, 14, 55, 53, 824, DateTimeKind.Local).AddTicks(3071), "Admin", "Admin", "Blue" }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("50fe4acc-1938-4893-9528-63f4f070a474"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 828, DateTimeKind.Local).AddTicks(8520), new DateTime(2024, 11, 28, 14, 55, 53, 828, DateTimeKind.Local).AddTicks(8517), "Admin", "Admin", "Nike" },
                    { new Guid("65bac79c-92bf-4769-807e-0d736535e87d"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 828, DateTimeKind.Local).AddTicks(8524), new DateTime(2024, 11, 28, 14, 55, 53, 828, DateTimeKind.Local).AddTicks(8523), "Admin", "Admin", "Adidas" },
                    { new Guid("e53afc75-8e9e-41d6-b452-745a0057328a"), 1, new DateTime(2024, 11, 28, 14, 55, 53, 828, DateTimeKind.Local).AddTicks(8526), new DateTime(2024, 11, 28, 14, 55, 53, 828, DateTimeKind.Local).AddTicks(8525), "Admin", "Admin", "Puma" }
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
                name: "IX_LichSuSuDungVouchers_IdKhachHang",
                table: "LichSuSuDungVouchers",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuSuDungVouchers_IdVoucher_IdKhachHang_IdOrder",
                table: "LichSuSuDungVouchers",
                columns: new[] { "IdVoucher", "IdKhachHang", "IdOrder" },
                unique: true);

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
                name: "IX_PromotionSanPhamChiTiet_IdSanPhamChiTiet",
                table: "PromotionSanPhamChiTiet",
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
                name: "PromotionSanPhamChiTiet");

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
