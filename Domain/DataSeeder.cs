
using AppData.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace AppData
{
    public static class Dataseeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Định nghĩa ID cố định cho các chức vụ
            var chucVuQL = Guid.Parse("11111111-1111-1111-1111-111111111111");
            var chucVuNV = Guid.Parse("22222222-2222-2222-2222-222222222222");
            var chucVuKT = Guid.Parse("33333333-3333-3333-3333-333333333333");
            var chucVuKK = Guid.Parse("44444444-4444-4444-4444-444444444444");

            // Seed dữ liệu chức vụ
            modelBuilder.Entity<ChucVu>().HasData(
                new ChucVu() { IdChucVu = chucVuQL, Code = "QL", TenChucVu = "Quản lý" },
                new ChucVu() { IdChucVu = chucVuNV, Code = "NV", TenChucVu = "Nhân viên" },
                new ChucVu() { IdChucVu = chucVuKT, Code = "KT", TenChucVu = "Kế toán" },
                new ChucVu() { IdChucVu = chucVuKK, Code = "KK", TenChucVu = "Thủ kho" }
            );

            // Định nghĩa ID cố định cho các nhân viên
            var nhanVien1 = Guid.Parse("55555555-5555-5555-5555-555555555555");
            var nhanVien2 = Guid.Parse("66666666-6666-6666-6666-666666666666");
            var nhanVien3 = Guid.Parse("77777777-7777-7777-7777-777777777777");
            var nhanVien4 = Guid.Parse("88888888-8888-8888-8888-888888888888");

            // Seed dữ liệu nhân viên
            modelBuilder.Entity<NhanVien>().HasData(
                new NhanVien()
                {
                    IdNhanVien = nhanVien1,
                    TenNhanVien = "Phạm Đức Hiếu",
                    SoDienThoai = "0976819974",
                    Email = "hieupdph40428@fpt.edu.vn",
                    AnhNhanVien = "anh_a.jpg",
                    MatKhau = "1",
                    AuthProvider = "Local",
                    DiaChi = "Hà Nội",
                    NgayCapNhat = new DateTime(2024, 9, 4),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1,
                    TrangThai = 1,
                    IdchucVu = chucVuQL // Liên kết với ID chức vụ Quản lý
                },
                new NhanVien()
                {
                    IdNhanVien = nhanVien2,
                    TenNhanVien = "Trần Ngọc Hà",
                    SoDienThoai = "0969293263",
                    Email = "tranha10112004@gmail.com",
                    AnhNhanVien = "anh_b.jpg",
                    MatKhau = "1",
                    AuthProvider = "Local",
                    DiaChi = "Đà Nẵng",
                    NgayCapNhat = new DateTime(2024, 9, 4),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1,
                    TrangThai = 1,
                    IdchucVu = chucVuQL // Liên kết với ID chức vụ Nhân viên
                },
                new NhanVien()
                {
                    IdNhanVien = nhanVien3,
                    TenNhanVien = "Kim Hoàng Long",
                    SoDienThoai = "0377804800",
                    Email = "longkhph35837@fpt.edu.vn",
                    AnhNhanVien = "anh_b.jpg",
                    MatKhau = "1",
                    AuthProvider = "Local",
                    DiaChi = "Đà Nẵng",
                    NgayCapNhat = new DateTime(2024, 9, 4),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1,
                    TrangThai = 1,
                    IdchucVu = chucVuNV // Liên kết với ID chức vụ Kế toán
                },
                new NhanVien()
                {
                    IdNhanVien = nhanVien4,
                    TenNhanVien = "Đào Thành Nam",
                    SoDienThoai = "0855896668",
                    Email = "namdtph39830@fpt.edu.vn",
                    AnhNhanVien = "anh_b.jpg",
                    MatKhau = "1",
                    AuthProvider = "Local",
                    DiaChi = "Đà Nẵng",
                    NgayCapNhat = new DateTime(2024, 9, 4),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1,
                    TrangThai = 1,
                    IdchucVu = chucVuNV // Liên kết với ID chức vụ Thủ kho
                }
            );

            // Định nghĩa các ID cố định mới (các GUID khác)
            var chatLieuCotton = Guid.NewGuid();
            var chatLieuDaThat = Guid.NewGuid();
            var chatLieuPolyester = Guid.NewGuid();
            var chatLieuVaiDet = Guid.NewGuid();
            var chatLieuDaTuNhien = Guid.NewGuid();
            var chatLieuDaLon = Guid.NewGuid();

            // Seed dữ liệu chất liệu với các GUID mới
            modelBuilder.Entity<ChatLieu>().HasData(
                new ChatLieu
                {
                    IdChatLieu = chatLieuCotton, // ID cố định cho "Vải Cotton"
                    TenChatLieu = "Vải Cotton",
                    NgayCapNhat = new DateTime(2024, 9, 4),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1
                },
                new ChatLieu
                {
                    IdChatLieu = chatLieuDaThat, // ID cố định cho "Da thật"
                    TenChatLieu = "Da thật",
                    NgayCapNhat = new DateTime(2024, 9, 4),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1
                },
                new ChatLieu
                {
                    IdChatLieu = chatLieuPolyester, // ID cố định cho "Vải Polyester"
                    TenChatLieu = "Vải Polyester",
                    NgayCapNhat = new DateTime(2024, 9, 4),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1,
                },
                new ChatLieu
                {
                    IdChatLieu = chatLieuVaiDet, // ID cố định cho ""
                    TenChatLieu = "Vải Dệt",
                    NgayCapNhat = new DateTime(2024, 9, 4),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1,
                },
                new ChatLieu
                {
                    IdChatLieu = chatLieuDaTuNhien, // ID cố định cho "Vải Polyester"
                    TenChatLieu = "Da Tự Nhiên",
                    NgayCapNhat = new DateTime(2024, 9, 4),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1,
                },
                new ChatLieu
                {
                    IdChatLieu = chatLieuDaLon, // ID cố định cho "Vải Polyester"
                    TenChatLieu = "Da Lộn",
                    NgayCapNhat = DateTime.Now,
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1,
                }
            );


            // Định nghĩa các ID cố định ngẫu nhiên cho DanhMuc
            var danhMucGiayTheThao = Guid.NewGuid();
            var danhMucGiayDa = Guid.NewGuid();
            var danhMucLowTop = Guid.NewGuid();
            var danhMucMidTop = Guid.NewGuid();
            var danhMucHighTop = Guid.NewGuid();

            // Seed dữ liệu DanhMuc với GUID ngẫu nhiên cố định
            modelBuilder.Entity<DanhMuc>().HasData(
                new DanhMuc
                {
                    IdDanhMuc = danhMucGiayTheThao, // ID cố định ngẫu nhiên cho "Giày Thể Thao"
                    TenDanhMuc = "Giày Thể Thao",
                    NgayTao = new DateTime(2024, 9, 4),
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new DanhMuc
                {
                    IdDanhMuc = danhMucGiayDa, // ID cố định ngẫu nhiên cho "Giày Da"
                    TenDanhMuc = "Giày Da",
                    NgayTao = new DateTime(2024, 9, 4),
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new DanhMuc
                {
                    IdDanhMuc = danhMucLowTop, // ID cố định ngẫu nhiên cho "Low-top"
                    TenDanhMuc = "Low-top",
                    NgayTao = new DateTime(2024, 9, 4),
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new DanhMuc
                {
                    IdDanhMuc = danhMucMidTop, // ID cố định ngẫu nhiên cho "Mid-top"
                    TenDanhMuc = "Mid – top",
                    NgayTao = new DateTime(2024, 9, 4),
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new DanhMuc
                {
                    IdDanhMuc = danhMucHighTop, // ID cố định ngẫu nhiên cho "High-top"
                    TenDanhMuc = "High – top",
                    NgayTao = new DateTime(2024, 9, 4),
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                }
            );

            // Định nghĩa các ID cố định ngẫu nhiên cho DeGiay
            var deCaoSu = Guid.NewGuid();
            var deNhua = Guid.NewGuid();
            var deVai = Guid.NewGuid();
            var deEva = Guid.NewGuid();
            var deCaoSuLuuHoa = Guid.NewGuid();
            var dePVC = Guid.NewGuid();
            var deBPU = Guid.NewGuid();
            var deChunky = Guid.NewGuid();
            var deChisty = Guid.NewGuid();
            var deGiayLuoi = Guid.NewGuid();

            // Seed dữ liệu cho bảng DeGiay
            modelBuilder.Entity<DeGiay>().HasData(
                new DeGiay
                {
                    IdDeGiay = deCaoSu,
                    TenDeGiay = "Đế cao su",
                    NgayCapNhat = new DateTime(2024, 9, 4),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1
                },
                new DeGiay
                {
                    IdDeGiay = deNhua,
                    TenDeGiay = "Đế nhựa",
                    NgayCapNhat = new DateTime(2024, 9, 4),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1
                },
                new DeGiay
                {
                    IdDeGiay = deVai,
                    TenDeGiay = "Đế vải",
                    NgayCapNhat = new DateTime(2023, 10, 22),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1
                },
                new DeGiay
                {
                    IdDeGiay = deEva,
                    TenDeGiay = "Đế Eva",
                    NgayCapNhat = new DateTime(2023, 10, 22),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1
                },
                new DeGiay
                {
                    IdDeGiay = deCaoSuLuuHoa,
                    TenDeGiay = "Đế Cao Su Lưu Hóa",
                    NgayCapNhat = new DateTime(2023, 10, 22),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1
                },
                new DeGiay
                {
                    IdDeGiay = dePVC,
                    TenDeGiay = "Đế PVC",
                    NgayCapNhat = new DateTime(2023, 10, 22),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1
                },
                new DeGiay
                {
                    IdDeGiay = deBPU,
                    TenDeGiay = "Đế BPU",
                    NgayCapNhat = new DateTime(2023, 10, 22),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1
                },
                new DeGiay
                {
                    IdDeGiay = deChunky,
                    TenDeGiay = "Đế Chunky",
                    NgayCapNhat = new DateTime(2023, 10, 22),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1
                },
                new DeGiay
                {
                    IdDeGiay = deChisty,
                    TenDeGiay = "Đế Chisty",
                    NgayCapNhat = new DateTime(2023, 10, 22),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1
                },
                new DeGiay
                {
                    IdDeGiay = deGiayLuoi,
                    TenDeGiay = "Đế Giày Lười",
                    NgayCapNhat = new DateTime(2023, 10, 22),
                    NgayTao = new DateTime(2024, 9, 4),
                    NguoiCapNhat = "Admin",
                    NguoiTao = "Admin",
                    KichHoat = 1
                }
            );
            // định dnagj cố định id khahcs hàng
            var khachhang1 = Guid.NewGuid();
            var khachhang2 = Guid.NewGuid();
            var khachhang3 = Guid.NewGuid();
            var khachhang4 = Guid.NewGuid();
            var khachhang5 = Guid.NewGuid();
            var khachhang6 = Guid.NewGuid();
            var khachhang7 = Guid.NewGuid();
            var khachhang8 = Guid.NewGuid();
            var khachhang9 = Guid.NewGuid();
            var khachhang10 = Guid.NewGuid();
            var khachhang11 = Guid.NewGuid();
            var khachhang12 = Guid.NewGuid();
            var khachhang13 = Guid.NewGuid();
            var khachhang14 = Guid.NewGuid();
            var khachhang15 = Guid.NewGuid();
            var khachhang16 = Guid.NewGuid();
            var khachhang17 = Guid.NewGuid();
            modelBuilder.Entity<KhachHang>().HasData(
            // thêm dữ liệu khách hàng
            new KhachHang
            {
                IdKhachHang = khachhang1,
                HoTen = "Nguyễn Văn Vinh",
                SoDienThoai = "0912345678",
                Email = "nguyenvanvinh@gmail.com",
                AuthProvider = "Local",
                MatKhau = "1", // Lưu ý: Mật khẩu thực tế nên được mã hóa
                NgayTao = new DateTime(2024, 9, 4),
                NgayCapNhat = new DateTime(2024, 9, 4),
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 1
            },
            new KhachHang
            {
                IdKhachHang = khachhang2,
                HoTen = "Trần Thị Bé",
                SoDienThoai = "0987654321",
                Email = "tranthibe@gmail.com",
                AuthProvider = "Google",
                MatKhau = "1", // Mật khẩu mã hóa
                NgayTao = new DateTime(2024, 9, 4),
                NgayCapNhat = new DateTime(2024, 9, 4),
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 1
            },
            new KhachHang
            {
                IdKhachHang = khachhang3,
                HoTen = "Phạm Văn Cảnh",
                SoDienThoai = "0971123456",
                Email = "phamvancanh@gmail.com",
                AuthProvider = "Facebook",
                MatKhau = "1",
                NgayTao = DateTime.Now,
                NgayCapNhat = DateTime.Now,
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 0 // Không kích hoạt
            },
            new KhachHang
            {
                IdKhachHang = khachhang4,
                HoTen = "Lê Thị Dậu",
                SoDienThoai = "0356789123",
                Email = "lethidau@gmail.com",
                AuthProvider = "Local",
                MatKhau = "1", // Lưu ý: Mã hóa mật khẩu
                NgayTao = DateTime.Now.AddDays(-10),
                NgayCapNhat = DateTime.Now,
                NguoiTao = "System",
                NguoiCapNhat = "Admin",
                KichHoat = 1
            },
            new KhachHang
            {
                IdKhachHang = khachhang5,
                HoTen = "Đặng Văn Em",
                SoDienThoai = "0398765432",
                Email = "dangvanem@gmail.com",
                AuthProvider = "Google",
                MatKhau = "1",
                NgayTao = DateTime.Now.AddMonths(-2),
                NgayCapNhat = DateTime.Now.AddDays(-1),
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 1
            },
            new KhachHang
            {
                IdKhachHang = khachhang6,
                HoTen = "Ngô Văn Phát",
                SoDienThoai = "0376543210",
                Email = "ngovanf@gmail.com",
                AuthProvider = "Facebook",
                MatKhau = "1",
                NgayTao = DateTime.Now.AddYears(-1),
                NgayCapNhat = DateTime.Now.AddMonths(-6),
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 0
            },
            new KhachHang
            {
                IdKhachHang = khachhang7,
                HoTen = "Hoàng Anh Gia Lai",
                SoDienThoai = "0965432109",
                Email = "hoanganhgialai@gmail.com",
                AuthProvider = "Local",
                MatKhau = "1",
                NgayTao = DateTime.Now.AddMonths(-3),
                NgayCapNhat = DateTime.Now.AddMonths(-1),
                NguoiTao = "System",
                NguoiCapNhat = "System",
                KichHoat = 1
            },
            new KhachHang
            {
                IdKhachHang = khachhang8,
                HoTen = "Phan Thị Hà",
                SoDienThoai = "0845678901",
                Email = "phanthiha@gmail.com",
                AuthProvider = "Google",
                MatKhau = "1",
                NgayTao = DateTime.Now.AddMonths(-5),
                NgayCapNhat = DateTime.Now.AddMonths(-4),
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 1
            },
            new KhachHang
            {
                IdKhachHang = khachhang9,
                HoTen = "Vũ Văn Ich",
                SoDienThoai = "0856781234",
                Email = "vuvanich@gmail.com",
                AuthProvider = "Facebook",
                MatKhau = "Fb@12345",
                NgayTao = DateTime.Now.AddDays(-20),
                NgayCapNhat = DateTime.Now.AddDays(-5),
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 0
            },
            new KhachHang
            {
                IdKhachHang = khachhang10,
                HoTen = "Nguyễn Thị Khánh",
                SoDienThoai = "0834567890",
                Email = "nguyenthikhanh@gmail.com",
                AuthProvider = "Google",
                MatKhau = "1",
                NgayTao = DateTime.Now.AddDays(-15),
                NgayCapNhat = DateTime.Now.AddDays(-10),
                NguoiTao = "System",
                NguoiCapNhat = "Admin",
                KichHoat = 1
            },
            new KhachHang
            {
                IdKhachHang = khachhang11,
                HoTen = "Trần Văn Lý",
                SoDienThoai = "0901234567",
                Email = "tranvanly@yahoo.com",
                AuthProvider = "Facebook",
                MatKhau = "1",
                NgayTao = DateTime.Now.AddMonths(-8),
                NgayCapNhat = DateTime.Now.AddMonths(-2),
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 1
            },
            new KhachHang
            {
                IdKhachHang = khachhang12,
                HoTen = "Lê Thị Mai",
                SoDienThoai = "0387654321",
                Email = "lethimai@gmail.com",
                AuthProvider = "Local",
                MatKhau = "1",
                NgayTao = DateTime.Now.AddYears(-1),
                NgayCapNhat = DateTime.Now.AddMonths(-6),
                NguoiTao = "System",
                NguoiCapNhat = "Admin",
                KichHoat = 1
            },
            new KhachHang
            {
                IdKhachHang = khachhang13,
                HoTen = "Phạm Văn Nam",
                SoDienThoai = "0919876543",
                Email = "phamvannam@outlook.com",
                AuthProvider = "Facebook",
                MatKhau = "1",
                NgayTao = DateTime.Now.AddMonths(-3),
                NgayCapNhat = DateTime.Now.AddDays(-30),
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 0
            },
            new KhachHang
            {
                IdKhachHang = khachhang14,
                HoTen = "Đỗ Minh Hải",
                SoDienThoai = "0867891234",
                Email = "dminhai@gmail.com",
                AuthProvider = "Google",
                MatKhau = "1",
                NgayTao = DateTime.Now.AddDays(-100),
                NgayCapNhat = DateTime.Now.AddDays(-50),
                NguoiTao = "System",
                NguoiCapNhat = "System",
                KichHoat = 1
            },
            new KhachHang
            {
                IdKhachHang = khachhang15,
                HoTen = "Nguyễn Hoàng Phong",
                SoDienThoai = "0923456789",
                Email = "nguyenhoangp@gmail.com",
                AuthProvider = "Local",
                MatKhau = "1",
                NgayTao = DateTime.Now.AddMonths(-2),
                NgayCapNhat = DateTime.Now.AddDays(-20),
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 1
            },
            new KhachHang
            {
                IdKhachHang = khachhang16,
                HoTen = "Trịnh Thị Quyên",
                SoDienThoai = "0898765432",
                Email = "trinhthiquyen@gmail.com",
                AuthProvider = "Google",
                MatKhau = "1",
                NgayTao = DateTime.Now.AddYears(-2),
                NgayCapNhat = DateTime.Now.AddMonths(-12),
                NguoiTao = "System",
                NguoiCapNhat = "System",
                KichHoat = 1
            },
            new KhachHang
            {
                IdKhachHang = khachhang17,
                HoTen = "Lý Văn Rô",
                SoDienThoai = "0945678901",
                Email = "lyvanro@gmail.com",
                AuthProvider = "Facebook",
                MatKhau = "1",
                NgayTao = DateTime.Now.AddMonths(-5),
                NgayCapNhat = DateTime.Now.AddDays(-10),
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 0
            }
        );
            var diachi1 = Guid.NewGuid();
            var diachi2 = Guid.NewGuid();
            var diachi3 = Guid.NewGuid();
            var diachi4 = Guid.NewGuid();
            var diachi5 = Guid.NewGuid();
            var diachi6 = Guid.NewGuid();
            var diachi7 = Guid.NewGuid();
            var diachi8 = Guid.NewGuid();
            var diachi9 = Guid.NewGuid();
            var diachi10 = Guid.NewGuid();
            var diachi11 = Guid.NewGuid();
            var diachi12 = Guid.NewGuid();
            var diachi13 = Guid.NewGuid();
            var diachi14 = Guid.NewGuid();
            var diachi15 = Guid.NewGuid();
            var diachi16 = Guid.NewGuid();
            modelBuilder.Entity<DiaChi>().HasData(
            // thêm dữ liệu địa chỉ
            new DiaChi
            {

                IdDiaChi = diachi1,
                HoTen = "Nguyễn Văn Vinh",
                SoDienThoai = "0912345678",
                MoTa = "Số 10, Ngõ 15, Đường Láng",
                ProvinceName = "Hà Nội",
                ProvinceId = 1,
                DistrictName = "Quận Đống Đa",
                DistrictId = 101,
                WardName = "Phường Láng Thượng",
                WardId = "00101",
                DiaChiMacDinh = true,
                IdKhachHang = khachhang1,
            },
            new DiaChi
            {
                IdDiaChi = diachi2,
                HoTen = "Trần Thị Bé",
                SoDienThoai = "0987654321",
                MoTa = "Tòa nhà Landmark 81, Bình Thạnh",
                ProvinceName = "Hồ Chí Minh",
                ProvinceId = 2,
                DistrictName = "Quận Bình Thạnh",
                DistrictId = 201,
                WardName = "Phường 22",
                WardId = "00201",
                DiaChiMacDinh = true,
                IdKhachHang = khachhang2
            },
            new DiaChi
            {
                IdDiaChi = diachi3,
                HoTen = "Phạm Văn Cảnh",
                SoDienThoai = "0971123456",
                MoTa = "Số 5, Đường Trần Phú",
                ProvinceName = "Đà Nẵng",
                ProvinceId = 3,
                DistrictName = "Quận Hải Châu",
                DistrictId = 301,
                WardName = "Phường Thạch Thang",
                WardId = "00301",
                DiaChiMacDinh = false,
                IdKhachHang = khachhang3
            },
            new DiaChi
            {
                IdDiaChi = diachi4,
                HoTen = "Lê Thị Dậu",
                SoDienThoai = "0356789123",
                MoTa = "Khu phố 1, Phường Vĩnh Phú",
                ProvinceName = "Bình Dương",
                ProvinceId = 4,
                DistrictName = "Thị xã Thuận An",
                DistrictId = 401,
                WardName = "Phường Vĩnh Phú",
                WardId = "00401",
                DiaChiMacDinh = true,
                IdKhachHang = khachhang4
            },
            new DiaChi
            {
                IdDiaChi = diachi5,
                HoTen = "Đặng Văn Em",
                SoDienThoai = "0398765432",
                MoTa = "Ấp An Hòa, Xã An Bình",
                ProvinceName = "Đồng Nai",
                ProvinceId = 5,
                DistrictName = "Huyện Long Thành",
                DistrictId = 501,
                WardName = "Xã An Bình",
                WardId = "00501",
                DiaChiMacDinh = false,
                IdKhachHang = khachhang5
            },
            new DiaChi
            {
                IdDiaChi = diachi6,
                HoTen = "Ngô Văn Phát",
                SoDienThoai = "0376543210",
                MoTa = "Số 20, Đường Nguyễn Huệ",
                ProvinceName = "Thừa Thiên Huế",
                ProvinceId = 6,
                DistrictName = "Thành phố Huế",
                DistrictId = 601,
                WardName = "Phường Vĩnh Ninh",
                WardId = "00601",
                DiaChiMacDinh = true,
                IdKhachHang = khachhang6
            },
            new DiaChi
            {
                IdDiaChi = diachi7,
                HoTen = "Hoàng Anh Gia Lai",
                SoDienThoai = "0965432109",
                MoTa = "Khu dân cư Bình Minh",
                ProvinceName = "Cần Thơ",
                ProvinceId = 7,
                DistrictName = "Quận Ninh Kiều",
                DistrictId = 701,
                WardName = "Phường Tân An",
                WardId = "00701",
                DiaChiMacDinh = false,
                IdKhachHang = khachhang7
            },
            new DiaChi
            {
                IdDiaChi = diachi8,
                HoTen = "Phan Thị Hà",
                SoDienThoai = "0845678901",
                MoTa = "Số 15, Đường Hoàng Diệu",
                ProvinceName = "Khánh Hòa",
                ProvinceId = 8,
                DistrictName = "Thành phố Nha Trang",
                DistrictId = 801,
                WardName = "Phường Phước Long",
                WardId = "00801",
                DiaChiMacDinh = true,
                IdKhachHang = khachhang8
            },
            new DiaChi
            {
                IdDiaChi = diachi9,
                HoTen = "Vũ Văn Ich",
                SoDienThoai = "0856781234",
                MoTa = "Số 30, Đường Lê Lợi",
                ProvinceName = "Quảng Ninh",
                ProvinceId = 9,
                DistrictName = "Thành phố Hạ Long",
                DistrictId = 901,
                WardName = "Phường Bãi Cháy",
                WardId = "00901",
                DiaChiMacDinh = false,
                IdKhachHang = khachhang9
            },
            new DiaChi
            {
                IdDiaChi = diachi10,
                HoTen = "Hoàng Anh J",
                SoDienThoai = "0976543210",
                MoTa = "Thôn Hồng Thái, Xã Đông Hòa",
                ProvinceName = "Phú Yên",
                ProvinceId = 10,
                DistrictName = "Huyện Tây Hòa",
                DistrictId = 1001,
                WardName = "Xã Đông Hòa",
                WardId = "01001",
                DiaChiMacDinh = true,
                IdKhachHang = khachhang10
            }
        );
            var kichco35 = Guid.NewGuid();
            var kichco36 = Guid.NewGuid();
            var kichco37 = Guid.NewGuid();
            var kichco38 = Guid.NewGuid();
            var kichco39 = Guid.NewGuid();
            var kichco40 = Guid.NewGuid();
            var kichco41 = Guid.NewGuid();
            var kichco42 = Guid.NewGuid();
            var kichco43 = Guid.NewGuid();
            var kichco44 = Guid.NewGuid();
            var kichco45 = Guid.NewGuid();
            modelBuilder.Entity<KichCo>().HasData(
            // thêm kích cỡ
            new KichCo
            {
                IdKichCo = kichco35,
                TenKichCo = "Size 35",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new KichCo
            {
                IdKichCo = kichco36,
                TenKichCo = "Size 36",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new KichCo
            {
                IdKichCo = kichco37,
                TenKichCo = "Size 37",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new KichCo
            {
                IdKichCo = kichco38,
                TenKichCo = "Size 38",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new KichCo
            {
                IdKichCo = kichco39,
                TenKichCo = "Size 39",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new KichCo
            {
                IdKichCo = kichco40,
                TenKichCo = "Size 40",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new KichCo
            {
                IdKichCo = kichco41,
                TenKichCo = "Size 41",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new KichCo
            {
                IdKichCo = kichco42,
                TenKichCo = "Size 42",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new KichCo
            {
                IdKichCo = kichco43,
                TenKichCo = "Size 43",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new KichCo
            {
                IdKichCo = kichco44,
                TenKichCo = "Size 44",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new KichCo
            {
                IdKichCo = kichco45,
                TenKichCo = "Size 45",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            }
        );
            var kieudangTT = Guid.NewGuid();
            var kieudangCD = Guid.NewGuid();
            var kieudangHD = Guid.NewGuid();
            modelBuilder.Entity<KieuDang>().HasData(
            //thêm kiểu dáng
            new KieuDang
            {
                IdKieuDang = kieudangTT,
                TenKieuDang = "Thể Thao",
                NgayTao = DateTime.Now,
                NgayCapNhat = DateTime.Now,
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 1
            },
            new KieuDang
            {
                IdKieuDang = kieudangCD,
                TenKieuDang = "Cổ Điển",
                NgayTao = DateTime.Now,
                NgayCapNhat = DateTime.Now,
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 1
            },
             new KieuDang
             {
                 IdKieuDang = kieudangHD,
                 TenKieuDang = "Hiện Đại",
                 NgayTao = DateTime.Now,
                 NgayCapNhat = DateTime.Now,
                 NguoiTao = "Admin",
                 NguoiCapNhat = "Admin",
                 KichHoat = 1
             }
        );
            var redId = Guid.NewGuid();
            var greenId = Guid.NewGuid();
            var blueId = Guid.NewGuid();
            var blackId = Guid.NewGuid();
            var whiteId = Guid.NewGuid();
            var greyId = Guid.NewGuid();
            var navyBlueId = Guid.NewGuid();
            var brownId = Guid.NewGuid();
            var pinkId = Guid.NewGuid();
            var orangeId = Guid.NewGuid();
            var metallicsId = Guid.NewGuid();
            var fluorescentsId = Guid.NewGuid();
            modelBuilder.Entity<MauSac>().HasData(
            // thêm màu sắc
            new MauSac
            {
                IdMauSac = redId,
                TenMauSac = "Red",
                NgayCapNhat = new DateTime(2024, 9, 4),
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new MauSac
            {
                IdMauSac = greenId,
                TenMauSac = "Green",
                NgayCapNhat = new DateTime(2024, 9, 4),
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new MauSac
            {
                IdMauSac = blueId,
                TenMauSac = "Blue",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new MauSac
            {
                IdMauSac = blackId,
                TenMauSac = "Black",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new MauSac
            {
                IdMauSac = whiteId,
                TenMauSac = "white",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new MauSac
            {
                IdMauSac = greyId,
                TenMauSac = "grey",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new MauSac
            {
                IdMauSac = navyBlueId,
                TenMauSac = "navy blue",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new MauSac
            {
                IdMauSac = brownId,
                TenMauSac = "Brown",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new MauSac
            {
                IdMauSac = pinkId,
                TenMauSac = "pink",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new MauSac
            {
                IdMauSac = orangeId,
                TenMauSac = "orange",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new MauSac
            {
                IdMauSac = metallicsId,
                TenMauSac = "metallics",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new MauSac
            {
                IdMauSac = fluorescentsId,
                TenMauSac = "fluorescents",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            }
        );
            // Định nghĩa Guid cho từng thương hiệu
            var nikeId = Guid.NewGuid();
            var adidasId = Guid.NewGuid();
            var pumaId = Guid.NewGuid();
            var reebokId = Guid.NewGuid();
            var converseId = Guid.NewGuid();
            var vansId = Guid.NewGuid();
            var newBalanceId = Guid.NewGuid();
            var filaId = Guid.NewGuid();
            var mlbId = Guid.NewGuid();
            var gucciId = Guid.NewGuid();
            var louisVuittonId = Guid.NewGuid();
            var balenciagaId = Guid.NewGuid();
            var diorId = Guid.NewGuid();
            var shondoId = Guid.NewGuid();
            var bitisId = Guid.NewGuid();
            var ananasId = Guid.NewGuid();

            // Thêm dữ liệu vào bảng ThuongHieu
            modelBuilder.Entity<ThuongHieu>().HasData(
                new ThuongHieu
                {
                    IdThuongHieu = nikeId,
                    TenThuongHieu = "Nike",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = adidasId,
                    TenThuongHieu = "Adidas",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = pumaId,
                    TenThuongHieu = "Puma",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = reebokId,
                    TenThuongHieu = "Reebok",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = converseId,
                    TenThuongHieu = "Converse",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = vansId,
                    TenThuongHieu = "Vans",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = newBalanceId,
                    TenThuongHieu = "New Balance",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = filaId,
                    TenThuongHieu = "Fila",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = mlbId,
                    TenThuongHieu = "MLB",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = gucciId,
                    TenThuongHieu = "Gucci",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = louisVuittonId,
                    TenThuongHieu = "Louis Vuitton",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = balenciagaId,
                    TenThuongHieu = "Balenciaga",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = diorId,
                    TenThuongHieu = "Dior",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = shondoId,
                    TenThuongHieu = "Shondo",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = bitisId,
                    TenThuongHieu = "Biti’s",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                },
                new ThuongHieu
                {
                    IdThuongHieu = ananasId,
                    TenThuongHieu = "Ananas",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin",
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                }
            );
            var GiayTTId = Guid.NewGuid();
            var GiayDaId = Guid.NewGuid();
            var sneakerId1 = Guid.NewGuid();
            var sneakerId2 = Guid.NewGuid();
            var sneakerId3 = Guid.NewGuid();
            var sneakerId4 = Guid.NewGuid();
            var sneakerId5 = Guid.NewGuid();
            var sneakerId6 = Guid.NewGuid();
            var sneakerId7 = Guid.NewGuid();
            var sneakerId8 = Guid.NewGuid();
            var sneakerId9 = Guid.NewGuid();
            var sneakerId10 = Guid.NewGuid();
            modelBuilder.Entity<SanPham>().HasData(
            // thêm sản phẩm 
            // Tạo danh sách sản phẩm mẫu
            new SanPham
            {
                IdSanPham = GiayTTId,
                TenSanPham = "Nike Air Force 1",
                NgayCapNhat = new DateTime(2024, 9, 4),
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                MoTa = "Nike Air Force 1 là dòng giày thể thao biểu tượng của Nike, ra mắt năm 1982. Với thiết kế cổ điển, chất liệu da cao cấp, đế tích hợp công nghệ Air êm ái, và kiểu dáng đa dạng (low, mid, high), đôi giày này phù hợp cho cả thể thao lẫn thời trang đường phố. Là biểu tượng của phong cách và văn hóa sneaker toàn cầu.",
                //Sale = 10.0,
                IdChatLieu = chatLieuDaTuNhien,
                IdKieuDang = kieudangTT,
                IdThuongHieu = nikeId,
                IdDanhMuc = danhMucGiayTheThao,
                IdDeGiay = deCaoSu,

            },
            new SanPham
            {
                IdSanPham = GiayDaId,
                TenSanPham = "Adidas Ultra Boost",
                NgayCapNhat = new DateTime(2024, 9, 4),
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                MoTa = "Adidas Ultra Boost là dòng giày chạy bộ cao cấp, nổi bật với công nghệ đệm Boost mang lại độ êm ái và hoàn trả năng lượng tối ưu. Thiết kế hiện đại, phần thân Primeknit co giãn ôm sát chân, kết hợp đế ngoài Continental giúp tăng độ bám và bền bỉ. Phù hợp cho cả chạy bộ lẫn thời trang hàng ngày..",
                //Sale = 5.0,
                IdChatLieu = chatLieuPolyester,
                IdKieuDang = kieudangCD,
                IdThuongHieu = adidasId,
                IdDanhMuc = danhMucGiayTheThao,
                IdDeGiay = deEva,
            },
            new SanPham
            {
                IdSanPham = sneakerId1,
                TenSanPham = "Nike Jordan 1 (JD1)",
                NgayCapNhat = new DateTime(2024, 9, 4),
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                MoTa = "Nike Jordan 1 (JD1) là đôi giày huyền thoại ra mắt năm 1985, gắn liền với Michael Jordan. Thiết kế biểu tượng với chất liệu da cao cấp, cổ thấp/mid/cao và đế ngoài chống trượt. Phù hợp cho cả chơi bóng rổ và thời trang đường phố, JD1 là biểu tượng của văn hóa sneaker toàn cầu.",
                //Sale = 15.0,
                IdChatLieu = chatLieuPolyester, // Vải Canvas
                IdKieuDang = kieudangHD,
                IdThuongHieu = nikeId,
                IdDanhMuc = danhMucLowTop,
                IdDeGiay = deCaoSu,
            },
            new SanPham
            {
                IdSanPham = sneakerId2,
                TenSanPham = "Adidas Yeezy 350",
                NgayCapNhat = new DateTime(2024, 9, 4),
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                MoTa = "Adidas Yeezy 350 là dòng giày thời trang nổi bật, hợp tác giữa Adidas và Kanye West. Thiết kế tối giản với thân Primeknit co giãn, đế Boost êm ái, và phong cách hiện đại. Yeezy 350 được yêu thích nhờ sự thoải mái và tính biểu tượng trong làng thời trang đường phố.\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
                //Sale = 20.0,
                IdChatLieu = chatLieuDaThat, // Da thật
                IdKieuDang = kieudangHD,
                IdThuongHieu = adidasId,
                IdDanhMuc = danhMucHighTop,
                IdDeGiay = deEva,
            },
             new SanPham
             {
                 IdSanPham = sneakerId3,
                 TenSanPham = "Adidas Samba",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 MoTa = "Adidas Samba là dòng giày cổ điển ra mắt năm 1950, ban đầu thiết kế cho bóng đá trong nhà. Với chất liệu da bền bỉ, mũi giày da lộn và đế cao su chống trượt, Samba là biểu tượng vượt thời gian, phù hợp cho cả thể thao và thời trang hàng ngày.",
                 //Sale = 25.0,
                 IdChatLieu = chatLieuCotton, // Vải lưới thoáng khí
                 IdKieuDang = kieudangHD,
                 IdThuongHieu = adidasId,
                 IdDanhMuc = danhMucHighTop,
                 IdDeGiay = deBPU,
             },
             new SanPham
             {
                 IdSanPham = sneakerId4,
                 TenSanPham = "Adidas Forum 84 Low",
                 NgayCapNhat = new DateTime(2024, 9, 4),
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 MoTa = "Adidas Forum 84 Low là dòng giày retro lấy cảm hứng từ bóng rổ thập niên 80. Thiết kế thấp cổ, chất liệu da cao cấp, dây đeo đặc trưng, và đế cao su bền bỉ, mang lại phong cách cổ điển pha chút hiện đại. Phù hợp cho cả thể thao và thời trang đường phố.",
                 //Sale = 10.0,
                 IdChatLieu = chatLieuPolyester, // Vải Canvas
                 IdKieuDang = kieudangCD,
                 IdThuongHieu = adidasId,
                 IdDanhMuc = danhMucMidTop,
                 IdDeGiay = deCaoSu,
             },
             new SanPham
             {
                 IdSanPham = sneakerId5,
                 TenSanPham = "Converse Chuck Taylor All Star",
                 NgayCapNhat = new DateTime(2024, 9, 4),
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 MoTa = "Converse Chuck Taylor All Star là đôi giày huyền thoại ra mắt năm 1917, nổi bật với thiết kế vải canvas bền nhẹ, đế cao su chống trượt và logo tròn đặc trưng. Phù hợp với mọi phong cách, từ thường ngày đến thời trang đường phố, là biểu tượng vượt thời gian.\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
                 //Sale = 18.0,
                 IdChatLieu = chatLieuPolyester, // Vải Canvas
                 IdKieuDang = kieudangHD,
                 IdThuongHieu = converseId,
                 IdDanhMuc = danhMucLowTop,
                 IdDeGiay = deCaoSu,
             },
             new SanPham
             {
                 IdSanPham = sneakerId6,
                 TenSanPham = "Giày Thể Thao Biti's Hunter",
                 NgayCapNhat = new DateTime(2024, 9, 4),
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 MoTa = "Biti's Hunter là dòng giày thể thao hiện đại của Biti's, nổi bật với thiết kế năng động, chất liệu nhẹ, thoáng khí, và đế EVA êm ái, hỗ trợ vận động linh hoạt. Phù hợp cho cả tập luyện lẫn thời trang hàng ngày, mang đậm phong cách Việt trẻ trung.",
                 //Sale = 12.0,
                 IdChatLieu = chatLieuPolyester, // Vải lưới thoáng khí
                 IdKieuDang = kieudangHD,
                 IdThuongHieu = bitisId,
                 IdDanhMuc = danhMucLowTop,
                 IdDeGiay = deChisty,
             },
             new SanPham
             {
                 IdSanPham = sneakerId7,
                 TenSanPham = "Louis Vuitton Trainers",
                 NgayCapNhat = new DateTime(2024, 9, 4),
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 MoTa = "Louis Vuitton Trainers là dòng giày thể thao cao cấp của Louis Vuitton, với thiết kế sang trọng, phối hợp giữa chất liệu da, vải và cao su. Đặc trưng với logo LV nổi bật, đôi giày này mang đến sự kết hợp hoàn hảo giữa thời trang và sự thoải mái, phù hợp cho những ai yêu thích phong cách sang trọng và thể thao.",
                 //Sale = 15.0,
                 IdChatLieu = chatLieuDaThat, // Da thật
                 IdKieuDang = kieudangHD,
                 IdThuongHieu = louisVuittonId,
                 IdDanhMuc = danhMucHighTop,
                 IdDeGiay = deCaoSu,
             },
             new SanPham
             {
                 IdSanPham = sneakerId8,
                 TenSanPham = "Nike Infinity 4 Fp",
                 NgayCapNhat = DateTime.Now,
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 MoTa = "Nike Infinity 4 FP là giày chạy bộ cao cấp, thiết kế với công nghệ đệm ZoomX và Flyknit giúp tối ưu hóa sự thoải mái và hỗ trợ khi chạy. Phần đế giữa mềm mại, nhẹ và bền bỉ, mang lại trải nghiệm chạy mượt mà. Phù hợp cho người chạy dài và vận động viên.",
                 //Sale = 20.0,
                 IdChatLieu = chatLieuPolyester, // Vải Canvas
                 IdKieuDang = kieudangHD,
                 IdThuongHieu = nikeId,
                 IdDanhMuc = danhMucGiayTheThao,
                 IdDeGiay = deCaoSu,
             },
             new SanPham
             {
                 IdSanPham = sneakerId9,
                 TenSanPham = "PUMA Unisex Caven",
                 NgayCapNhat = DateTime.Now,
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 MoTa = "PUMA Unisex Caven là giày thể thao phong cách unisex với thiết kế hiện đại và thoải mái. Chất liệu da cao cấp kết hợp với đế cao su bền bỉ, tạo sự hỗ trợ và độ bám tốt. Phù hợp cho cả nam và nữ, dễ dàng phối hợp với nhiều trang phục.",
                 //Sale = 18.0,
                 IdChatLieu = chatLieuPolyester, // Vải lưới
                 IdKieuDang = kieudangTT,
                 IdThuongHieu = pumaId,
                 IdDanhMuc = danhMucGiayTheThao,
                 IdDeGiay = deCaoSuLuuHoa,
             },
             new SanPham
             {
                 IdSanPham = sneakerId10,
                 TenSanPham = "Converse Lugged 2.0 Platform Denim",
                 NgayCapNhat = new DateTime(2024, 9, 4),
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 MoTa = "Converse Lugged 2.0 Platform Denim là giày sneaker với thiết kế platform cao, kết hợp giữa vải denim bền và đế cao su dày, tạo phong cách thời trang mạnh mẽ. Đặc trưng với logo Converse và đế chống trượt, thích hợp cho cả streetwear và tạo điểm nhấn trong các bộ trang phục năng động.",
                 //Sale = 25.0,
                 IdChatLieu = chatLieuVaiDet, // Vải Canvas
                 IdKieuDang = kieudangHD,
                 IdThuongHieu = converseId,
                 IdDanhMuc = danhMucHighTop,
                 IdDeGiay = deCaoSu,
             }

        );

            var SP00001 = Guid.NewGuid();
            var SP00001_1 = Guid.NewGuid();
            var SP00001_2 = Guid.NewGuid();
            var SP00001_3 = Guid.NewGuid();
            var SP00001_4 = Guid.NewGuid();
            var SP00001_5 = Guid.NewGuid();
            var SP00001_6 = Guid.NewGuid();
            var SP00001_7 = Guid.NewGuid();
            var SP00001_0 = Guid.NewGuid();
            var SP00001_10 = Guid.NewGuid();
            var SP00001_20 = Guid.NewGuid();
            var SP00001_30 = Guid.NewGuid();
            var SP00001_40 = Guid.NewGuid();
            var SP00001_50 = Guid.NewGuid();
            var SP00001_60 = Guid.NewGuid();
            var SP00001_70 = Guid.NewGuid();
            var SP00001_01 = Guid.NewGuid();
            var SP00001_11 = Guid.NewGuid();
            var SP00001_21 = Guid.NewGuid();
            var SP00001_31 = Guid.NewGuid();
            var SP00001_41 = Guid.NewGuid();
            var SP00001_51 = Guid.NewGuid();
            var SP00001_61 = Guid.NewGuid();
            var SP00001_71 = Guid.NewGuid();
            var SP00002 = Guid.NewGuid();
            var SP00002_1 = Guid.NewGuid();
            var SP00002_2 = Guid.NewGuid();
            var SP00002_3 = Guid.NewGuid();
            var SP00002_4 = Guid.NewGuid();
            var SP00002_5 = Guid.NewGuid();
            var SP00002_0 = Guid.NewGuid();
            var SP00002_10 = Guid.NewGuid();
            var SP00002_20 = Guid.NewGuid();
            var SP00002_30 = Guid.NewGuid();
            var SP00002_40 = Guid.NewGuid();
            var SP00002_50 = Guid.NewGuid();
            var SP00002_01 = Guid.NewGuid();
            var SP00002_11 = Guid.NewGuid();
            var SP00002_21 = Guid.NewGuid();
            var SP00002_31 = Guid.NewGuid();
            var SP00002_41 = Guid.NewGuid();
            var SP00002_51 = Guid.NewGuid();
            var SP00003 = Guid.NewGuid();
            var SP00003_1 = Guid.NewGuid();
            var SP00003_2 = Guid.NewGuid();
            var SP00003_3 = Guid.NewGuid();
            var SP00003_4 = Guid.NewGuid();
            var SP00003_5 = Guid.NewGuid();
            var SP00003_0 = Guid.NewGuid();
            var SP00003_10 = Guid.NewGuid();
            var SP00003_20 = Guid.NewGuid();
            var SP00003_30 = Guid.NewGuid();
            var SP00003_40 = Guid.NewGuid();
            var SP00003_50 = Guid.NewGuid();
            var SP00003_01 = Guid.NewGuid();
            var SP00003_11 = Guid.NewGuid();
            var SP00003_21 = Guid.NewGuid();
            var SP00003_31 = Guid.NewGuid();
            var SP00003_41 = Guid.NewGuid();
            var SP00003_51 = Guid.NewGuid();
            var SP00004 = Guid.NewGuid();
            var SP00004_1 = Guid.NewGuid();
            var SP00004_2 = Guid.NewGuid();
            var SP00004_3 = Guid.NewGuid();
            var SP00004_4 = Guid.NewGuid();
            var SP00004_5 = Guid.NewGuid();
            var SP00004_0 = Guid.NewGuid();
            var SP00004_10 = Guid.NewGuid();
            var SP00004_20 = Guid.NewGuid();
            var SP00004_30 = Guid.NewGuid();
            var SP00004_40 = Guid.NewGuid();
            var SP00004_50 = Guid.NewGuid();
            var SP00004_01 = Guid.NewGuid();
            var SP00004_11 = Guid.NewGuid();
            var SP00004_21 = Guid.NewGuid();
            var SP00004_31 = Guid.NewGuid();
            var SP00004_41 = Guid.NewGuid();
            var SP00004_51 = Guid.NewGuid();
            var SP00005 = Guid.NewGuid();
            var SP00005_1 = Guid.NewGuid();
            var SP00005_2 = Guid.NewGuid();
            var SP00005_3 = Guid.NewGuid();
            var SP00005_4 = Guid.NewGuid();
            var SP00005_5 = Guid.NewGuid();
            var SP00005_0 = Guid.NewGuid();
            var SP00005_10 = Guid.NewGuid();
            var SP00005_20 = Guid.NewGuid();
            var SP00005_30 = Guid.NewGuid();
            var SP00005_40 = Guid.NewGuid();
            var SP00005_50 = Guid.NewGuid();
            var SP00005_01 = Guid.NewGuid();
            var SP00005_11 = Guid.NewGuid();
            var SP00005_21 = Guid.NewGuid();
            var SP00005_31 = Guid.NewGuid();
            var SP00005_41 = Guid.NewGuid();
            var SP00005_51 = Guid.NewGuid();
            var SP00006 = Guid.NewGuid();
            var SP00006_1 = Guid.NewGuid();
            var SP00006_2 = Guid.NewGuid();
            var SP00006_3 = Guid.NewGuid();
            var SP00006_4 = Guid.NewGuid();
            var SP00006_5 = Guid.NewGuid();
            var SP00006_0 = Guid.NewGuid();
            var SP00006_10 = Guid.NewGuid();
            var SP00006_20 = Guid.NewGuid();
            var SP00006_30 = Guid.NewGuid();
            var SP00006_40 = Guid.NewGuid();
            var SP00006_50 = Guid.NewGuid();
            var SP00006_01 = Guid.NewGuid();
            var SP00006_11 = Guid.NewGuid();
            var SP00006_21 = Guid.NewGuid();
            var SP00006_31 = Guid.NewGuid();
            var SP00006_41 = Guid.NewGuid();
            var SP00006_51 = Guid.NewGuid();
            var SP00007 = Guid.NewGuid();
            var SP00007_1 = Guid.NewGuid();
            var SP00007_2 = Guid.NewGuid();
            var SP00007_3 = Guid.NewGuid();
            var SP00007_4 = Guid.NewGuid();
            var SP00007_5 = Guid.NewGuid();
            var SP00007_0 = Guid.NewGuid();
            var SP00007_10 = Guid.NewGuid();
            var SP00007_20 = Guid.NewGuid();
            var SP00007_30 = Guid.NewGuid();
            var SP00007_40 = Guid.NewGuid();
            var SP00007_50 = Guid.NewGuid();
            var SP00007_01 = Guid.NewGuid();
            var SP00007_11 = Guid.NewGuid();
            var SP00007_21 = Guid.NewGuid();
            var SP00007_31 = Guid.NewGuid();
            var SP00007_41 = Guid.NewGuid();
            var SP00007_51 = Guid.NewGuid();
            var SP00008 = Guid.NewGuid();
            var SP00008_1 = Guid.NewGuid();
            var SP00008_2 = Guid.NewGuid();
            var SP00008_3 = Guid.NewGuid();
            var SP00008_4 = Guid.NewGuid();
            var SP00008_5 = Guid.NewGuid();
            var SP00008_0 = Guid.NewGuid();
            var SP00008_10 = Guid.NewGuid();
            var SP00008_20 = Guid.NewGuid();
            var SP00008_30 = Guid.NewGuid();
            var SP00008_40 = Guid.NewGuid();
            var SP00008_50 = Guid.NewGuid();
            var SP00008_01 = Guid.NewGuid();
            var SP00008_11 = Guid.NewGuid();
            var SP00008_21 = Guid.NewGuid();
            var SP00008_31 = Guid.NewGuid();
            var SP00008_41 = Guid.NewGuid();
            var SP00008_51 = Guid.NewGuid();
            var SP00009 = Guid.NewGuid();
            var SP00009_1 = Guid.NewGuid();
            var SP00009_2 = Guid.NewGuid();
            var SP00009_3 = Guid.NewGuid();
            var SP00009_4 = Guid.NewGuid();
            var SP00009_5 = Guid.NewGuid();
            var SP00009_0 = Guid.NewGuid();
            var SP00009_10 = Guid.NewGuid();
            var SP00009_20 = Guid.NewGuid();
            var SP00009_30 = Guid.NewGuid();
            var SP00009_40 = Guid.NewGuid();
            var SP00009_50 = Guid.NewGuid();
            var SP00009_01 = Guid.NewGuid();
            var SP00009_11 = Guid.NewGuid();
            var SP00009_21 = Guid.NewGuid();
            var SP00009_31 = Guid.NewGuid();
            var SP00009_41 = Guid.NewGuid();
            var SP00009_51 = Guid.NewGuid();
            var SP00010 = Guid.NewGuid();
            var SP00010_1 = Guid.NewGuid();
            var SP00010_2 = Guid.NewGuid();
            var SP00010_3 = Guid.NewGuid();
            var SP00010_4 = Guid.NewGuid();
            var SP00010_5 = Guid.NewGuid();
            var SP00010_0 = Guid.NewGuid();
            var SP00010_10 = Guid.NewGuid();
            var SP00010_20 = Guid.NewGuid();
            var SP00010_30 = Guid.NewGuid();
            var SP00010_40 = Guid.NewGuid();
            var SP00010_50 = Guid.NewGuid();
            var SP00010_01 = Guid.NewGuid();
            var SP00010_11 = Guid.NewGuid();
            var SP00010_21 = Guid.NewGuid();
            var SP00010_31 = Guid.NewGuid();
            var SP00010_41 = Guid.NewGuid();
            var SP00010_51 = Guid.NewGuid();
            var SP00011 = Guid.NewGuid();
            var SP00011_1 = Guid.NewGuid();
            var SP00011_2 = Guid.NewGuid();
            var SP00011_3 = Guid.NewGuid();
            var SP00011_4 = Guid.NewGuid();
            var SP00011_5 = Guid.NewGuid();
            var SP00011_0 = Guid.NewGuid();
            var SP00011_10 = Guid.NewGuid();
            var SP00011_20 = Guid.NewGuid();
            var SP00011_30 = Guid.NewGuid();
            var SP00011_40 = Guid.NewGuid();
            var SP00011_50 = Guid.NewGuid();
            var SP00011_01 = Guid.NewGuid();
            var SP00011_11 = Guid.NewGuid();
            var SP00011_21 = Guid.NewGuid();
            var SP00011_31 = Guid.NewGuid();
            var SP00011_41 = Guid.NewGuid();
            var SP00011_51 = Guid.NewGuid();
            var SP00012 = Guid.NewGuid();
            var SP00012_1 = Guid.NewGuid();
            var SP00012_2 = Guid.NewGuid();
            var SP00012_3 = Guid.NewGuid();
            var SP00012_4 = Guid.NewGuid();
            var SP00012_5 = Guid.NewGuid();
            var SP00012_0 = Guid.NewGuid();
            var SP00012_10 = Guid.NewGuid();
            var SP00012_20 = Guid.NewGuid();
            var SP00012_30 = Guid.NewGuid();
            var SP00012_40 = Guid.NewGuid();
            var SP00012_50 = Guid.NewGuid();
            var SP00012_01 = Guid.NewGuid();
            var SP00012_11 = Guid.NewGuid();
            var SP00012_21 = Guid.NewGuid();
            var SP00012_31 = Guid.NewGuid();
            var SP00012_41 = Guid.NewGuid();
            var SP00012_51 = Guid.NewGuid();
            modelBuilder.Entity<SanPhamChiTiet>().HasData(
            // Tạo danh sách chi tiết sản phẩm mẫu

            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001,
                Gia = 250000.0,
                MaSp = "SP001",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_1,
                Gia = 250000.0,
                MaSp = "SP001.1",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_2,
                Gia = 250000.0,
                MaSp = "SP001.2",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_3,
                Gia = 250000.0,
                MaSp = "SP001.3",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_4,
                Gia = 250000.0,
                MaSp = "SP001.4",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_5,
                Gia = 250000.0,
                MaSp = "SP001.5",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_6,
                Gia = 250000.0,
                MaSp = "SP001.6",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_7,
                Gia = 250000.0,
                MaSp = "SP001.7",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_0,
                Gia = 250000.0,
                MaSp = "SP001.0",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_10,
                Gia = 250000.0,
                MaSp = "SP001.10",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_20,
                Gia = 250000.0,
                MaSp = "SP001.20",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_30,
                Gia = 250000.0,
                MaSp = "SP001.30",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_40,
                Gia = 250000.0,
                MaSp = "SP001.40",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_50,
                Gia = 250000.0,
                MaSp = "SP001.50",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_60,
                Gia = 250000.0,
                MaSp = "SP001.60",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_70,
                Gia = 250000.0,
                MaSp = "SP001.70",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_01,
                Gia = 250000.0,
                MaSp = "SP001.01",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_11,
                Gia = 250000.0,
                MaSp = "SP001.11",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_21,
                Gia = 250000.0,
                MaSp = "SP001.21",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_31,
                Gia = 250000.0,
                MaSp = "SP001.31",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_41,
                Gia = 250000.0,
                MaSp = "SP001.41",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_51,
                Gia = 250000.0,
                MaSp = "SP001.51",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_61,
                Gia = 250000.0,
                MaSp = "SP001.61",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00001_71,
                Gia = 250000.0,
                MaSp = "SP001.71",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayTTId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002,
                Gia = 250000.0,
                MaSp = "SP002",
                SoLuong = 5,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_1,
                Gia = 250000.0,
                MaSp = "SP002.1",
                SoLuong = 5,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_2,
                Gia = 250000.0,
                MaSp = "SP002.2",
                SoLuong = 5,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_3,
                Gia = 250000.0,
                MaSp = "SP002.3",
                SoLuong = 10,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_4,
                Gia = 250000.0,
                MaSp = "SP002.4",
                SoLuong = 20,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_5,
                Gia = 250000.0,
                MaSp = "SP002.5",
                SoLuong = 15,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_0,
                Gia = 250000.0,
                MaSp = "SP002.0",
                SoLuong = 20,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_10,
                Gia = 250000.0,
                MaSp = "SP002.10",
                SoLuong = 5,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_20,
                Gia = 250000.0,
                MaSp = "SP002.20",
                SoLuong = 5,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_30,
                Gia = 250000.0,
                MaSp = "SP002.30",
                SoLuong = 10,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_40,
                Gia = 250000.0,
                MaSp = "SP002.40",
                SoLuong = 5,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_50,
                Gia = 250000.0,
                MaSp = "SP002.50",
                SoLuong = 5,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_01,
                Gia = 250000.0,
                MaSp = "SP002.01",
                SoLuong = 10,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_11,
                Gia = 250000.0,
                MaSp = "SP002.11",
                SoLuong = 5,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_21,
                Gia = 250000.0,
                MaSp = "SP002.21",
                SoLuong = 15,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_31,
                Gia = 250000.0,
                MaSp = "SP002.31",
                SoLuong = 10,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_41,
                Gia = 250000.0,
                MaSp = "SP002.41",
                SoLuong = 25,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00002_51,
                Gia = 250000.0,
                MaSp = "SP002.51",
                SoLuong = 5,
                //GiaGiam = 30000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nữ",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = GiayDaId
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003,
                Gia = 300000.0,
                MaSp = "SP00003",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_1,
                Gia = 300000.0,
                MaSp = "SP00003.1",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_2,
                Gia = 300000.0,
                MaSp = "SP00003.2",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_3,
                Gia = 300000.0,
                MaSp = "SP00003.3",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_4,
                Gia = 300000.0,
                MaSp = "SP00003.4",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_5,
                Gia = 300000.0,
                MaSp = "SP00003.5",
                SoLuong = 10,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00003_0,
                 Gia = 300000.0,
                 MaSp = "SP00003.0",
                 SoLuong = 20,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId1,
             },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_10,
                Gia = 300000.0,
                MaSp = "SP00003.10",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_20,
                Gia = 300000.0,
                MaSp = "SP00003.20",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_30,
                Gia = 300000.0,
                MaSp = "SP00003.30",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_40,
                Gia = 300000.0,
                MaSp = "SP00003.40",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_50,
                Gia = 300000.0,
                MaSp = "SP00003.50",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_01,
                Gia = 300000.0,
                MaSp = "SP00003.01",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_11,
                Gia = 300000.0,
                MaSp = "SP00003.11",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_21,
                Gia = 300000.0,
                MaSp = "SP00003.21",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_31,
                Gia = 300000.0,
                MaSp = "SP00003.31",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_41,
                Gia = 300000.0,
                MaSp = "SP00003.41",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00003_51,
                Gia = 300000.0,
                MaSp = "SP00003.51",
                SoLuong = 20,
                //GiaGiam = 50000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Việt Nam",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId1,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004,
                Gia = 450000.0,
                MaSp = "SP00004",
                SoLuong = 15,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_1,
                Gia = 450000.0,
                MaSp = "SP00004.1",
                SoLuong = 30,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_2,
                Gia = 450000.0,
                MaSp = "SP00004.2",
                SoLuong = 15,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_3,
                Gia = 450000.0,
                MaSp = "SP00004.3",
                SoLuong = 20,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_4,
                Gia = 450000.0,
                MaSp = "SP00004.4",
                SoLuong = 15,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_5,
                Gia = 450000.0,
                MaSp = "SP00004.5",
                SoLuong = 50,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_0,
                Gia = 450000.0,
                MaSp = "SP00004.0",
                SoLuong = 15,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_10,
                Gia = 450000.0,
                MaSp = "SP00004.10",
                SoLuong = 25,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_20,
                Gia = 450000.0,
                MaSp = "SP00004.20",
                SoLuong = 15,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_30,
                Gia = 450000.0,
                MaSp = "SP00004.30",
                SoLuong = 20,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_40,
                Gia = 450000.0,
                MaSp = "SP00004.40",
                SoLuong = 15,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_50,
                Gia = 450000.0,
                MaSp = "SP00004.50",
                SoLuong = 30,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_01,
                Gia = 450000.0,
                MaSp = "SP00004.01",
                SoLuong = 15,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_11,
                Gia = 450000.0,
                MaSp = "SP00004.11",
                SoLuong = 25,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_21,
                Gia = 450000.0,
                MaSp = "SP00004.21",
                SoLuong = 15,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_31,
                Gia = 450000.0,
                MaSp = "SP00004.31",
                SoLuong = 20,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_41,
                Gia = 450000.0,
                MaSp = "SP00004.41",
                SoLuong = 15,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
            new SanPhamChiTiet
            {
                IdSanPhamChiTiet = SP00004_51,
                Gia = 450000.0,
                MaSp = "SP00004.51",
                SoLuong = 25,
                //GiaGiam = 70000.0,
                CoHienThi = "Có",
                NgayCapNhat = DateTime.Now,
                GioiTinh = "Nam",
                XuatXu = "Trung Quốc",
                NgayTao = new DateTime(2024, 9, 4),
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1,
                IdSanPham = sneakerId2,
            },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005,
                 Gia = 600000.0,
                 MaSp = "SP00005",
                 SoLuong = 12,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_1,
                 Gia = 600000.0,
                 MaSp = "SP00005.1",
                 SoLuong = 20,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_2,
                 Gia = 600000.0,
                 MaSp = "SP00005.2",
                 SoLuong = 20,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_3,
                 Gia = 600000.0,
                 MaSp = "SP00005.3",
                 SoLuong = 12,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_4,
                 Gia = 600000.0,
                 MaSp = "SP00005.4",
                 SoLuong = 20,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_5,
                 Gia = 600000.0,
                 MaSp = "SP00005.5",
                 SoLuong = 20,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_0,
                 Gia = 600000.0,
                 MaSp = "SP00005.0",
                 SoLuong = 12,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_10,
                 Gia = 600000.0,
                 MaSp = "SP00005.10",
                 SoLuong = 20,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_20,
                 Gia = 600000.0,
                 MaSp = "SP00005.20",
                 SoLuong = 20,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_30,
                 Gia = 600000.0,
                 MaSp = "SP00005.30",
                 SoLuong = 12,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_40,
                 Gia = 600000.0,
                 MaSp = "SP00005.40",
                 SoLuong = 25,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_50,
                 Gia = 600000.0,
                 MaSp = "SP00005.50",
                 SoLuong = 20,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_01,
                 Gia = 600000.0,
                 MaSp = "SP00005.01",
                 SoLuong = 12,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_11,
                 Gia = 600000.0,
                 MaSp = "SP00005.11",
                 SoLuong = 30,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_21,
                 Gia = 600000.0,
                 MaSp = "SP00005.21",
                 SoLuong = 20,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_31,
                 Gia = 600000.0,
                 MaSp = "SP00005.3",
                 SoLuong = 25,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_41,
                 Gia = 600000.0,
                 MaSp = "SP00005.41",
                 SoLuong = 20,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00005_51,
                 Gia = 600000.0,
                 MaSp = "SP00005.51",
                 SoLuong = 20,
                 //GiaGiam = 100000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Hàn Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId3,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006,
                 Gia = 500000.0,
                 MaSp = "SP00006",
                 SoLuong = 30,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_1,
                 Gia = 500000.0,
                 MaSp = "SP00006.1",
                 SoLuong = 30,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_2,
                 Gia = 500000.0,
                 MaSp = "SP00006.2",
                 SoLuong = 30,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_3,
                 Gia = 500000.0,
                 MaSp = "SP00006.3",
                 SoLuong = 30,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_4,
                 Gia = 500000.0,
                 MaSp = "SP00006.4",
                 SoLuong = 30,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_5,
                 Gia = 500000.0,
                 MaSp = "SP00006.5",
                 SoLuong = 30,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_0,
                 Gia = 500000.0,
                 MaSp = "SP00006.0",
                 SoLuong = 30,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_10,
                 Gia = 500000.0,
                 MaSp = "SP00006.10",
                 SoLuong = 30,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_20,
                 Gia = 500000.0,
                 MaSp = "SP00006.20",
                 SoLuong = 30,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_30,
                 Gia = 500000.0,
                 MaSp = "SP00006.30",
                 SoLuong = 30,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_40,
                 Gia = 500000.0,
                 MaSp = "SP00006.40",
                 SoLuong = 20,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_50,
                 Gia = 500000.0,
                 MaSp = "SP00006.50",
                 SoLuong = 30,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_01,
                 Gia = 500000.0,
                 MaSp = "SP00006.01",
                 SoLuong = 30,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_11,
                 Gia = 500000.0,
                 MaSp = "SP00006.11",
                 SoLuong = 30,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_21,
                 Gia = 500000.0,
                 MaSp = "SP00006.21",
                 SoLuong = 20,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_31,
                 Gia = 500000.0,
                 MaSp = "SP00006.31",
                 SoLuong = 30,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_41,
                 Gia = 500000.0,
                 MaSp = "SP00006.41",
                 SoLuong = 20,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00006_51,
                 Gia = 500000.0,
                 MaSp = "SP00006.51",
                 SoLuong = 10,
                 //GiaGiam = 80000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId4,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007,
                 Gia = 700000.0,
                 MaSp = "SP00007",
                 SoLuong = 10,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_1,
                 Gia = 700000.0,
                 MaSp = "SP00007.1",
                 SoLuong = 10,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_2,
                 Gia = 700000.0,
                 MaSp = "SP00007.2",
                 SoLuong = 10,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_3,
                 Gia = 700000.0,
                 MaSp = "SP00007.3",
                 SoLuong = 10,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_4,
                 Gia = 700000.0,
                 MaSp = "SP00007.4",
                 SoLuong = 10,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_5,
                 Gia = 700000.0,
                 MaSp = "SP00007.5",
                 SoLuong = 10,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_0,
                 Gia = 700000.0,
                 MaSp = "SP00007.0",
                 SoLuong = 10,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_10,
                 Gia = 700000.0,
                 MaSp = "SP00007.10",
                 SoLuong = 20,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_20,
                 Gia = 700000.0,
                 MaSp = "SP00007.20",
                 SoLuong = 10,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_30,
                 Gia = 700000.0,
                 MaSp = "SP00007.30",
                 SoLuong = 10,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_40,
                 Gia = 700000.0,
                 MaSp = "SP00007.40",
                 SoLuong = 10,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_50,
                 Gia = 700000.0,
                 MaSp = "SP00007.50",
                 SoLuong = 20,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_01,
                 Gia = 700000.0,
                 MaSp = "SP00007.01",
                 SoLuong = 30,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_11,
                 Gia = 700000.0,
                 MaSp = "SP00007.11",
                 SoLuong = 10,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_21,
                 Gia = 700000.0,
                 MaSp = "SP00007.21",
                 SoLuong = 20,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_31,
                 Gia = 700000.0,
                 MaSp = "SP00007.31",
                 SoLuong = 20,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_41,
                 Gia = 700000.0,
                 MaSp = "SP00007.41",
                 SoLuong = 10,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00007_51,
                 Gia = 700000.0,
                 MaSp = "SP00007.51",
                 SoLuong = 15,
                 //GiaGiam = 120000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Nhật Bản",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId5,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008,
                 Gia = 350000.0,
                 MaSp = "SP00008",
                 SoLuong = 25,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_1,
                 Gia = 350000.0,
                 MaSp = "SP00008.1",
                 SoLuong = 5,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_2,
                 Gia = 350000.0,
                 MaSp = "SP00008.2",
                 SoLuong = 21,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_3,
                 Gia = 350000.0,
                 MaSp = "SP00008.3",
                 SoLuong = 10,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_4,
                 Gia = 350000.0,
                 MaSp = "SP00008.4",
                 SoLuong = 5,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_5,
                 Gia = 350000.0,
                 MaSp = "SP00008.5",
                 SoLuong = 5,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_0,
                 Gia = 350000.0,
                 MaSp = "SP00008.0",
                 SoLuong = 2,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_10,
                 Gia = 350000.0,
                 MaSp = "SP00008.10",
                 SoLuong = 5,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_20,
                 Gia = 350000.0,
                 MaSp = "SP00008.20",
                 SoLuong = 20,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_30,
                 Gia = 350000.0,
                 MaSp = "SP00008.30",
                 SoLuong = 10,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_40,
                 Gia = 350000.0,
                 MaSp = "SP00008.40",
                 SoLuong = 25,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_50,
                 Gia = 350000.0,
                 MaSp = "SP00008.50",
                 SoLuong = 10,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_01,
                 Gia = 350000.0,
                 MaSp = "SP00008.01",
                 SoLuong = 25,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_11,
                 Gia = 350000.0,
                 MaSp = "SP00008.11",
                 SoLuong = 25,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_21,
                 Gia = 350000.0,
                 MaSp = "SP00008.21",
                 SoLuong = 20,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_31,
                 Gia = 350000.0,
                 MaSp = "SP00008.31",
                 SoLuong = 25,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_41,
                 Gia = 350000.0,
                 MaSp = "SP00008.41",
                 SoLuong = 25,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00008_51,
                 Gia = 350000.0,
                 MaSp = "SP00008.51",
                 SoLuong = 10,
                 //GiaGiam = 50000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId6,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009,
                 Gia = 400000.0,
                 MaSp = "SP00009",
                 SoLuong = 18,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_1,
                 Gia = 400000.0,
                 MaSp = "SP00009.1",
                 SoLuong = 20,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_2,
                 Gia = 400000.0,
                 MaSp = "SP00009.2",
                 SoLuong = 10,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_3,
                 Gia = 400000.0,
                 MaSp = "SP00009.3",
                 SoLuong = 10,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_4,
                 Gia = 400000.0,
                 MaSp = "SP00009.4",
                 SoLuong = 10,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_5,
                 Gia = 400000.0,
                 MaSp = "SP00009.5",
                 SoLuong = 10,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_0,
                 Gia = 400000.0,
                 MaSp = "SP00009.0",
                 SoLuong = 18,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_10,
                 Gia = 400000.0,
                 MaSp = "SP00009.10",
                 SoLuong = 20,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_20,
                 Gia = 400000.0,
                 MaSp = "SP00009.20",
                 SoLuong = 10,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_30,
                 Gia = 400000.0,
                 MaSp = "SP00009.30",
                 SoLuong = 10,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_40,
                 Gia = 400000.0,
                 MaSp = "SP00009.40",
                 SoLuong = 10,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_50,
                 Gia = 400000.0,
                 MaSp = "SP00009.50",
                 SoLuong = 20,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_01,
                 Gia = 400000.0,
                 MaSp = "SP00009.01",
                 SoLuong = 18,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_11,
                 Gia = 400000.0,
                 MaSp = "SP00009.11",
                 SoLuong = 20,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_21,
                 Gia = 400000.0,
                 MaSp = "SP00009.21",
                 SoLuong = 10,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_31,
                 Gia = 400000.0,
                 MaSp = "SP00009.31",
                 SoLuong = 10,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_41,
                 Gia = 400000.0,
                 MaSp = "SP00009.41",
                 SoLuong = 20,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00009_51,
                 Gia = 400000.0,
                 MaSp = "SP00009.51",
                 SoLuong = 10,
                 //GiaGiam = 60000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Mỹ",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId7,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010,
                 Gia = 800000.0,
                 MaSp = "SP00010",
                 SoLuong = 10,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_1,
                 Gia = 800000.0,
                 MaSp = "SP00010.1",
                 SoLuong = 20,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_2,
                 Gia = 800000.0,
                 MaSp = "SP00010.2",
                 SoLuong = 20,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_3,
                 Gia = 800000.0,
                 MaSp = "SP00010.3",
                 SoLuong = 20,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_4,
                 Gia = 800000.0,
                 MaSp = "SP00010.4",
                 SoLuong = 10,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_5,
                 Gia = 800000.0,
                 MaSp = "SP00010.5",
                 SoLuong = 10,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_0,
                 Gia = 800000.0,
                 MaSp = "SP00010.0",
                 SoLuong = 10,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_10,
                 Gia = 800000.0,
                 MaSp = "SP00010.10",
                 SoLuong = 10,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_20,
                 Gia = 800000.0,
                 MaSp = "SP00010.20",
                 SoLuong = 10,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_30,
                 Gia = 800000.0,
                 MaSp = "SP00010.30",
                 SoLuong = 20,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_40,
                 Gia = 800000.0,
                 MaSp = "SP00010.40",
                 SoLuong = 10,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_50,
                 Gia = 800000.0,
                 MaSp = "SP00010.50",
                 SoLuong = 20,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_01,
                 Gia = 800000.0,
                 MaSp = "SP00010.01",
                 SoLuong = 10,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_11,
                 Gia = 800000.0,
                 MaSp = "SP00010.11",
                 SoLuong = 10,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_21,
                 Gia = 800000.0,
                 MaSp = "SP00010.21",
                 SoLuong = 10,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_31,
                 Gia = 800000.0,
                 MaSp = "SP00010.31",
                 SoLuong = 10,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_41,
                 Gia = 800000.0,
                 MaSp = "SP00010.41",
                 SoLuong = 10,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00010_51,
                 Gia = 800000.0,
                 MaSp = "SP00010.51",
                 SoLuong = 10,
                 //GiaGiam = 150000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Unisex",
                 XuatXu = "Ý",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId8,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011,
                 Gia = 550000.0,
                 MaSp = "SP00011",
                 SoLuong = 40,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_1,
                 Gia = 550000.0,
                 MaSp = "SP00011.1",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_2,
                 Gia = 550000.0,
                 MaSp = "SP00011.2",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_3,
                 Gia = 550000.0,
                 MaSp = "SP00011.3",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_4,
                 Gia = 550000.0,
                 MaSp = "SP00011.4",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_5,
                 Gia = 550000.0,
                 MaSp = "SP00011.5",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_0,
                 Gia = 550000.0,
                 MaSp = "SP00011.0",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_10,
                 Gia = 550000.0,
                 MaSp = "SP00011.10",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_20,
                 Gia = 550000.0,
                 MaSp = "SP00011.20",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_30,
                 Gia = 550000.0,
                 MaSp = "SP00011.30",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_40,
                 Gia = 550000.0,
                 MaSp = "SP00011.40",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_50,
                 Gia = 550000.0,
                 MaSp = "SP00011.50",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_01,
                 Gia = 550000.0,
                 MaSp = "SP00011.01",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_11,
                 Gia = 550000.0,
                 MaSp = "SP00011.11",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_21,
                 Gia = 550000.0,
                 MaSp = "SP00011.21",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_31,
                 Gia = 550000.0,
                 MaSp = "SP00011.31",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_41,
                 Gia = 550000.0,
                 MaSp = "SP00011.41",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00011_51,
                 Gia = 550000.0,
                 MaSp = "SP00011.51",
                 SoLuong = 10,
                 //GiaGiam = 70000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nam",
                 XuatXu = "Trung Quốc",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId9,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012,
                 Gia = 650000.0,
                 MaSp = "SP00012",
                 SoLuong = 20,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_1,
                 Gia = 650000.0,
                 MaSp = "SP00012.1",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_2,
                 Gia = 650000.0,
                 MaSp = "SP00012.2",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_3,
                 Gia = 650000.0,
                 MaSp = "SP00012.3",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_4,
                 Gia = 650000.0,
                 MaSp = "SP00012.4",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_5,
                 Gia = 650000.0,
                 MaSp = "SP00012.5",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_0,
                 Gia = 650000.0,
                 MaSp = "SP00012.0",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_10,
                 Gia = 650000.0,
                 MaSp = "SP00012.10",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_20,
                 Gia = 650000.0,
                 MaSp = "SP00012.20",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_30,
                 Gia = 650000.0,
                 MaSp = "SP00012.30",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_40,
                 Gia = 650000.0,
                 MaSp = "SP00012.40",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_50,
                 Gia = 650000.0,
                 MaSp = "SP00012.50",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_01,
                 Gia = 650000.0,
                 MaSp = "SP00012.01",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_11,
                 Gia = 650000.0,
                 MaSp = "SP00012.11",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_21,
                 Gia = 650000.0,
                 MaSp = "SP00012.21",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_31,
                 Gia = 650000.0,
                 MaSp = "SP00012.31",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_41,
                 Gia = 650000.0,
                 MaSp = "SP00012.41",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             },
             new SanPhamChiTiet
             {
                 IdSanPhamChiTiet = SP00012_51,
                 Gia = 650000.0,
                 MaSp = "SP00012.51",
                 SoLuong = 10,
                 //GiaGiam = 90000.0,
                 CoHienThi = "Có",
                 NgayCapNhat = DateTime.Now,
                 GioiTinh = "Nữ",
                 XuatXu = "Việt Nam",
                 NgayTao = new DateTime(2024, 9, 4),
                 NguoiCapNhat = "Admin",
                 NguoiTao = "Admin",
                 KichHoat = 1,
                 IdSanPham = sneakerId10,
             }


        );
            modelBuilder.Entity<SanPhamChiTietMauSac>().HasData(
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_1,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_2,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_3,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_4,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_5,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_6,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_7,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_0,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_10,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_20,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_30,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_40,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_50,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_60,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_70,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_01,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_11,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_21,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_31,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_41,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_51,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_61,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00001_71,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_1,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_2,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_3,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_4,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_5,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_0,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_10,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_20,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_30,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_40,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_50,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_1,
                    IdMauSac = orangeId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_11,
                    IdMauSac = orangeId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_21,
                    IdMauSac = orangeId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_31,
                    IdMauSac = orangeId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_41,
                    IdMauSac = orangeId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00002_51,
                    IdMauSac = orangeId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_1,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_2,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_3,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_4,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_5,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_0,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_10,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_20,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_30,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_40,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_50,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_01,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_11,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_21,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_31,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_41,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00003_51,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_1,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_2,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_3,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_4,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_5,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_0,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_10,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_20,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_30,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_40,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_50,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_1,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_11,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_21,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_31,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_41,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00004_51,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_1,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_2,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_3,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_4,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_5,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_0,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_10,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_20,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_30,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_40,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_50,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_01,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_11,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_21,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_31,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_41,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00005_51,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_1,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_2,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_3,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_4,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_5,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_0,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_10,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_20,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_30,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_40,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_50,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_01,
                    IdMauSac = pinkId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_11,
                    IdMauSac = pinkId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_21,
                    IdMauSac = pinkId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_31,
                    IdMauSac = pinkId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_41,
                    IdMauSac = pinkId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00006_51,
                    IdMauSac = pinkId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_1,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_2,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_3,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_4,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_5,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_0,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_10,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_20,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_30,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_40,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_50,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_01,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_11,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_21,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_31,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_41,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00007_51,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_1,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_2,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_3,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_4,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_5,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_0,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_10,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_20,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_30,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_40,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_50,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_01,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_11,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_21,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_31,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_41,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00008_51,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_1,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_2,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_3,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_4,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_5,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_0,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_10,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_20,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_30,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_40,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_50,
                    IdMauSac = blueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_01,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_11,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_21,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_31,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_41,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00009_51,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010,
                    IdMauSac = orangeId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_1,
                    IdMauSac = orangeId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_2,
                    IdMauSac = orangeId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_3,
                    IdMauSac = orangeId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_4,
                    IdMauSac = orangeId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_5,
                    IdMauSac = orangeId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_0,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_10,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_20,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_30,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_40,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_50,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_01,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_11,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_21,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_31,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_41,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00010_51,
                    IdMauSac = whiteId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011,
                    IdMauSac = pinkId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_1,
                    IdMauSac = pinkId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_2,
                    IdMauSac = pinkId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_3,
                    IdMauSac = pinkId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_4,
                    IdMauSac = pinkId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_5,
                    IdMauSac = pinkId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_0,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_10,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_20,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_30,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_40,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_50,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_01,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_11,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_21,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_31,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_41,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00011_51,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_1,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_2,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_3,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_4,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_5,
                    IdMauSac = blackId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_0,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_10,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_20,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_30,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_40,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_50,
                    IdMauSac = redId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_01,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_11,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_21,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_31,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_41,
                    IdMauSac = navyBlueId
                },
                new SanPhamChiTietMauSac
                {
                    IdSanPhamChiTiet = SP00012_51,
                    IdMauSac = navyBlueId
                }

                );
            modelBuilder.Entity<SanPhamChiTietKichCo>().HasData(
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_1,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_2,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_3,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_4,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_5,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_6,
                    IdKichCo = kichco41
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_7,
                    IdKichCo = kichco42
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_0,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_10,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_20,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_30,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_40,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_50,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_60,
                    IdKichCo = kichco41
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_70,
                    IdKichCo = kichco42
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_01,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_11,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_21,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_31,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_41,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_51,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_61,
                    IdKichCo = kichco41
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00001_71,
                    IdKichCo = kichco42
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_1,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_2,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_3,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_4,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_5,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_0,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_10,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_20,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_30,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_40,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_50,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_01,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_11,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_21,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_31,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_41,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00002_51,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003,
                    IdKichCo = kichco41
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_1,
                    IdKichCo = kichco42
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_2,
                    IdKichCo = kichco43
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_3,
                    IdKichCo = kichco44
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_4,
                    IdKichCo = kichco45
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_5,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_0,
                    IdKichCo = kichco41
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_10,
                    IdKichCo = kichco42
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_20,
                    IdKichCo = kichco43
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_30,
                    IdKichCo = kichco44
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_40,
                    IdKichCo = kichco45
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_50,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_01,
                    IdKichCo = kichco41
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_11,
                    IdKichCo = kichco42
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_21,
                    IdKichCo = kichco43
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_31,
                    IdKichCo = kichco44
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_41,
                    IdKichCo = kichco45
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00003_51,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_1,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_2,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_3,
                    IdKichCo = kichco41
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_4,
                    IdKichCo = kichco42
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_5,
                    IdKichCo = kichco43
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_0,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_10,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_20,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_30,
                    IdKichCo = kichco41
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_40,
                    IdKichCo = kichco42
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_50,
                    IdKichCo = kichco43
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_01,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_11,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_21,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_31,
                    IdKichCo = kichco41
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_41,
                    IdKichCo = kichco42
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00004_51,
                    IdKichCo = kichco43
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_1,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_2,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_3,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_4,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_5,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_0,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_10,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_20,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_30,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_40,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_50,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_01,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_11,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_21,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_31,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_41,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00005_51,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_1,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_2,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_3,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_4,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_5,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_0,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_10,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_20,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_30,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_40,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_50,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_01,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_11,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_21,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_31,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_41,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00006_51,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_1,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_2,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_3,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_4,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_5,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_0,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_10,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_20,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_30,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_40,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_50,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_01,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_11,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_21,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_31,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_41,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00007_51,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_1,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_2,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_3,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_4,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_5,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_0,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_10,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_20,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_30,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_40,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_50,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_01,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_11,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_21,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_31,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_41,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00008_51,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_1,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_2,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_3,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_4,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_5,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_0,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_10,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_20,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_30,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_40,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_50,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_01,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_11,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_21,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_31,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_41,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00009_51,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_1,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_2,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_3,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_4,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_5,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_0,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_10,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_20,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_30,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_40,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_50,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_01,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_11,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_21,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_31,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_41,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00010_51,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_1,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_2,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_3,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_4,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_5,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_0,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_10,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_20,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_30,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_40,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_50,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_01,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_11,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_21,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_31,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_41,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00011_51,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_1,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_2,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_3,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_4,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_5,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_0,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_10,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_20,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_30,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_40,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_50,
                    IdKichCo = kichco40
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_01,
                    IdKichCo = kichco35
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_11,
                    IdKichCo = kichco36
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_21,
                    IdKichCo = kichco37
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_31,
                    IdKichCo = kichco38
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_41,
                    IdKichCo = kichco39
                },
                new SanPhamChiTietKichCo
                {
                    IdSanPhamChiTiet = SP00012_51,
                    IdKichCo = kichco40
                }
                );
            var Voucher10 = Guid.NewGuid();
            var Voucher50k = Guid.NewGuid();
            var Voucher20 = Guid.NewGuid();
            var Voucher100k = Guid.NewGuid();
            modelBuilder.Entity<Voucher>().HasData(
            // Tạo danh sách voucher mẫu
            new Voucher
            {
                VoucherId = Voucher10,
                MaVoucher = "VOUCHER10",
                MoTaVoucher = "Giảm 10% cho đơn hàng trên 100.000 VNĐ",
                LoaiGiamGia = 1,
                GiaTriGiam = 10,
                GiaTriDonHangToiThieu = 100000,
                SoTienToiDa = null,
                NgayBatDau = DateTime.Now,
                NgayKetThuc = DateTime.Now.AddMonths(1),
                TongSoLuongVoucher = 100,
                SoLuongVoucherConLai = 100,
                TrangThai = 2, // Đang kích hoạt
                NgayTao = DateTime.Now,
                NguoiTao = "Admin",
                NgayUpdate = null,
                NguoiUpdate = null
            },
            new Voucher
            {
                VoucherId = Voucher50k,
                MaVoucher = "VOUCHER50K",
                MoTaVoucher = "Giảm 50.000 VNĐ cho đơn hàng trên 200.000 VNĐ",
                LoaiGiamGia = 2,
                GiaTriGiam = 50000,
                GiaTriDonHangToiThieu = 200000,
                SoTienToiDa = 50000,
                NgayBatDau = DateTime.Now,
                NgayKetThuc = DateTime.Now.AddMonths(2),
                TongSoLuongVoucher = 50,
                SoLuongVoucherConLai = 50,
                TrangThai = 1, // Chờ kích hoạt
                NgayTao = DateTime.Now,
                NguoiTao = "Admin",
                NgayUpdate = null,
                NguoiUpdate = null
            },
            new Voucher
            {
                VoucherId = Voucher20,
                MaVoucher = "VOUCHER20",
                MoTaVoucher = "Giảm 20% cho đơn hàng trên 300.000 VNĐ",
                LoaiGiamGia = 1, // Giảm theo phần trăm
                GiaTriGiam = 20,
                GiaTriDonHangToiThieu = 300000,
                SoTienToiDa = 100000, // Giảm tối đa 100.000 VNĐ
                NgayBatDau = DateTime.Now,
                NgayKetThuc = DateTime.Now.AddMonths(3),
                TongSoLuongVoucher = 200,
                SoLuongVoucherConLai = 200,
                TrangThai = 2, // Đang kích hoạt
                NgayTao = DateTime.Now,
                NguoiTao = "Admin",
                NgayUpdate = null,
                NguoiUpdate = null
            },
             new Voucher
             {
                 VoucherId = Voucher100k,
                 MaVoucher = "VOUCHER100K",
                 MoTaVoucher = "Giảm 100.000 VNĐ cho đơn hàng trên 500.000 VNĐ",
                 LoaiGiamGia = 2, // Giảm giá cố định
                 GiaTriGiam = 100000,
                 GiaTriDonHangToiThieu = 500000,
                 SoTienToiDa = 100000, // Không giảm quá 100.000 VNĐ
                 NgayBatDau = DateTime.Now,
                 NgayKetThuc = DateTime.Now.AddMonths(4),
                 TongSoLuongVoucher = 80,
                 SoLuongVoucherConLai = 80,
                 TrangThai = 1, // Chờ kích hoạt
                 NgayTao = DateTime.Now,
                 NguoiTao = "Admin",
                 NgayUpdate = null,
                 NguoiUpdate = null
             }


        );
            var HD1 = Guid.NewGuid();
            var HD2 = Guid.NewGuid();
            var HD3 = Guid.NewGuid();
            var HD4 = Guid.NewGuid();
            var HD5 = Guid.NewGuid();
            var HD6 = Guid.NewGuid();
            var HD7 = Guid.NewGuid();
            var HD8 = Guid.NewGuid();
            var HD9 = Guid.NewGuid();
            var HD10 = Guid.NewGuid();
            var HD11 = Guid.NewGuid();
            modelBuilder.Entity<HoaDon>().HasData(
            // Tạo danh sách hóa đơn mẫu với Ngày Tạo khác nhau
            new HoaDon
            {
                IdHoaDon = HD1,
                MaDon = "HD1",
                NguoiNhan = "Nguyễn Văn Vinh",
                SoDienThoaiNguoiNhan = null,
                DiaChiGiaoHang = null,
                LoaiHoaDon = "Tại Quầy",
                GhiChu = null,
                TienShip = 0,
                TienGiam = 0,
                TongTienDonHang = 600000,
                TongTienHoaDon = 600000,
                NgayTao = new DateTime(2024, 9, 4, 18, 30, 40),
                NguoiTao = "Phạm Đúc Hiếu",
                KichHoat = 1,
                TrangThai = "Hoàn Thành",
                IdKhachHang = khachhang1,
                IdNhanVien = nhanVien1
            },
            new HoaDon
            {
                IdHoaDon = HD2,
                MaDon = "HD2",
                NguoiNhan = "Nguyễn Văn Vinh",
                SoDienThoaiNguoiNhan = null,
                DiaChiGiaoHang = null,
                LoaiHoaDon = "Tại Quầy",
                GhiChu = null,
                TienShip = 0,
                TienGiam = 0,
                TongTienDonHang = 450000,
                TongTienHoaDon = 450000,
                NgayTao = new DateTime(2024, 10, 15, 18, 59, 10), // Khác thời gian HD1
                NguoiTao = "Phạm Đức Hiếu",
                KichHoat = 1,
                TrangThai = "Hoàn Thành",
                IdKhachHang = khachhang1,
                IdNhanVien = nhanVien1
            },
            new HoaDon
            {
                IdHoaDon = HD3,
                MaDon = "HD3",
                NguoiNhan = "Nguyễn Văn Vinh",
                SoDienThoaiNguoiNhan = null,
                DiaChiGiaoHang = null,
                LoaiHoaDon = "Tại Quầy",
                GhiChu = null,
                TienShip = 0,
                TienGiam = 0,
                TongTienDonHang = 250000,
                TongTienHoaDon = 250000,
                NgayTao = new DateTime(2024, 11, 15, 18, 53, 45), // Khác thời gian HD2
                NguoiTao = "Phạm Đức Hiếu",
                KichHoat = 1,
                TrangThai = "Hoàn Thành",
                IdKhachHang = khachhang10,
                IdNhanVien = nhanVien1
            },
            new HoaDon
            {
                IdHoaDon = HD4,
                MaDon = "HD4",
                NguoiNhan = "Nguyễn Văn Vinh",
                SoDienThoaiNguoiNhan = null,
                DiaChiGiaoHang = null,
                LoaiHoaDon = "Tại Quầy",
                GhiChu = null,
                TienShip = 0,
                TienGiam = 0,
                TongTienDonHang = 250000,
                TongTienHoaDon = 250000,
                NgayTao = new DateTime(2024, 11, 15, 19, 20, 30), // Khác thời gian HD3
                NguoiTao = "Phạm Đức Hiếu",
                KichHoat = 1,
                TrangThai = "Hoàn Thành",
                IdKhachHang = khachhang1,
                IdNhanVien = nhanVien1
            },
            new HoaDon
            {
                IdHoaDon = HD5,
                MaDon = "HD5",
                NguoiNhan = "Nguyễn Văn Vinh",
                SoDienThoaiNguoiNhan = null,
                DiaChiGiaoHang = null,
                LoaiHoaDon = "Tại Quầy",
                GhiChu = null,
                TienShip = 0,
                TienGiam = 0,
                TongTienDonHang = 250000,
                TongTienHoaDon = 250000,
                NgayTao = new DateTime(2024, 12, 15, 19, 35, 45), // Khác thời gian HD4
                NguoiTao = "Phạm Đức Hiếu",
                KichHoat = 1,
                TrangThai = "Hoàn Thành",
                IdKhachHang = khachhang1,
                IdNhanVien = nhanVien1
            },
            new HoaDon
            {
                IdHoaDon = HD6,
                MaDon = "HD6",
                NguoiNhan = "Nguyễn Văn Vinh",
                SoDienThoaiNguoiNhan = null,
                DiaChiGiaoHang = null,
                LoaiHoaDon = "Tại Quầy",
                GhiChu = null,
                TienShip = 0,
                TienGiam = 0,
                TongTienDonHang = 550000,
                TongTienHoaDon = 550000,
                NgayTao = new DateTime(2024, 11, 16, 19, 35, 45), // Khác thời gian HD5
                NguoiTao = "Phạm Đức Hiếu",
                KichHoat = 1,
                TrangThai = "Hoàn Thành",
                IdKhachHang = khachhang1,
                IdNhanVien = nhanVien1
            },
            new HoaDon
            {
                IdHoaDon = HD7,
                MaDon = "HD7",
                NguoiNhan = "Nguyễn Văn Vinh",
                SoDienThoaiNguoiNhan = null,
                DiaChiGiaoHang = null,
                LoaiHoaDon = "Tại Quầy",
                GhiChu = null,
                TienShip = 0,
                TienGiam = 0,
                TongTienDonHang = 400000,
                TongTienHoaDon = 400000,
                NgayTao = new DateTime(2024, 11, 16, 20, 05, 25), // Khác thời gian HD6
                NguoiTao = "Phạm Đức Hiếu",
                KichHoat = 1,
                TrangThai = "Hoàn Thành",
                IdKhachHang = khachhang1,
                IdNhanVien = nhanVien1
            },
            new HoaDon
            {
                IdHoaDon = HD8,
                MaDon = "HD8",
                NguoiNhan = "Nguyễn Văn Vinh",
                SoDienThoaiNguoiNhan = null,
                DiaChiGiaoHang = null,
                LoaiHoaDon = "Tại Quầy",
                GhiChu = null,
                TienShip = 0,
                TienGiam = 0,
                TongTienDonHang = 300000,
                TongTienHoaDon = 300000,
                NgayTao = new DateTime(2024, 11, 20, 20, 20, 40), // Khác thời gian HD7
                NguoiTao = "Phạm Đức Hiếu",
                KichHoat = 1,
                TrangThai = "Hoàn Thành",
                IdKhachHang = khachhang1,
                IdNhanVien = nhanVien1
            },
            new HoaDon
            {
                IdHoaDon = HD9,
                MaDon = "HD9",
                NguoiNhan = "Nguyễn Văn Vinh",
                SoDienThoaiNguoiNhan = null,
                DiaChiGiaoHang = null,
                LoaiHoaDon = "Tại Quầy",
                GhiChu = null,
                TienShip = 0,
                TienGiam = 0,
                TongTienDonHang = 500000,
                TongTienHoaDon = 500000,
                NgayTao = new DateTime(2024, 12, 15, 20, 35, 55), // Khác thời gian HD8
                NguoiTao = "Phạm Đức Hiếu",
                KichHoat = 1,
                TrangThai = "Hoàn Thành",
                IdKhachHang = khachhang1,
                IdNhanVien = nhanVien1
            },
             new HoaDon
             {
                 IdHoaDon = HD10, // Tạo GUID duy nhất
                 MaDon = "HD10",
                 NguoiNhan = "Nguyễn Văn Vinh",
                 SoDienThoaiNguoiNhan = null, // Không có trong dữ liệu mẫu
                 DiaChiGiaoHang = null,       // Không có trong dữ liệu mẫu
                 LoaiHoaDon = "Tại Quầy",
                 GhiChu = null,               // Không có trong dữ liệu mẫu
                 TienShip = 0,                // Không có trong dữ liệu mẫu
                 TienGiam = 0,                // Không có trong dữ liệu mẫu
                 TongTienDonHang = 250000,
                 TongTienHoaDon = 250000,
                 NgayTao = new DateTime(2024, 12, 15, 19, 3, 20), // Ngày Tạo từ dữ liệu mẫu
                 NguoiTao = "Phạm Đức Hiếu",                    // Giả sử người tạo là Nguyễn Văn Vinh
                 KichHoat = 1,                                    // Hoạt động
                 TrangThai = "Hoàn Thành",
                 IdKhachHang = khachhang1,                    // Id giả lập cho Khách Hàng
                 IdNhanVien = nhanVien1
             },
              new HoaDon
              {
                  IdHoaDon = HD11, // Tạo GUID duy nhất
                  MaDon = "HD11",
                  NguoiNhan = "Nguyễn Văn Vinh",
                  SoDienThoaiNguoiNhan = null, // Không có trong dữ liệu mẫu
                  DiaChiGiaoHang = null,       // Không có trong dữ liệu mẫu
                  LoaiHoaDon = "Tại Quầy",
                  GhiChu = null,               // Không có trong dữ liệu mẫu
                  TienShip = 0,                // Không có trong dữ liệu mẫu
                  TienGiam = 0,                // Không có trong dữ liệu mẫu
                  TongTienDonHang = 250000,
                  TongTienHoaDon = 250000,
                  NgayTao = new DateTime(2024, 12, 15, 19, 3, 20), // Ngày Tạo từ dữ liệu mẫu
                  NguoiTao = "Phạm Đức Hiếu",                    // Giả sử người tạo là Nguyễn Văn Vinh
                  KichHoat = 1,                                    // Hoạt động
                  TrangThai = "Hoàn Thành",
                  IdKhachHang = khachhang1,                    // Id giả lập cho Khách Hàng
                  IdNhanVien = nhanVien1                               // Không có trong dữ liệu mẫu
              }

     );

            var HDCT00001 = Guid.NewGuid();
            var HDCT00002 = Guid.NewGuid();
            var HDCT00003 = Guid.NewGuid();
            var HDCT00004 = Guid.NewGuid();
            var HDCT00005 = Guid.NewGuid();
            var HDCT00006 = Guid.NewGuid();
            var HDCT00007 = Guid.NewGuid();
            var HDCT00008 = Guid.NewGuid();
            var HDCT00009 = Guid.NewGuid();
            var HDCT000010 = Guid.NewGuid();
            var HDCT000011 = Guid.NewGuid();
            modelBuilder.Entity<HoaDonChiTiet>().HasData(
                new HoaDonChiTiet
                {
                    IdHoaDonChiTiet = HDCT00001, // GUID duy nhất cho chi tiết hóa đơn
                    DonGia = 600000,            // Giá sản phẩm
                    SoLuong = 1,                // Số lượng sản phẩm
                    TongTien = 600000,          // Tổng tiền (DonGia * SoLuong)
                    KichHoat = 1,               // Trạng thái hoạt động
                    IdHoaDon = HD1,             // Liên kết với hóa đơn HD3
                    IdSanPhamChiTiet = SP00005_1 // GUID của sản phẩm chi tiết với màu đỏ và size 37
                },
                new HoaDonChiTiet
                {
                    IdHoaDonChiTiet = HDCT00002, // GUID duy nhất cho chi tiết hóa đơn
                    DonGia = 450000,            // Giá sản phẩm
                    SoLuong = 1,                // Số lượng sản phẩm
                    TongTien = 450000,          // Tổng tiền (DonGia * SoLuong)
                    KichHoat = 1,               // Trạng thái hoạt động
                    IdHoaDon = HD2,             // Liên kết với hóa đơn HD2
                    IdSanPhamChiTiet = SP00004_5 // GUID của sản phẩm "Giày sneaker cổ cao"
                },
                new HoaDonChiTiet
                {
                    IdHoaDonChiTiet = HDCT00003, // GUID duy nhất cho chi tiết hóa đơn
                    DonGia = 250000,            // Giá sản phẩm
                    SoLuong = 1,                // Số lượng sản phẩm
                    TongTien = 250000,          // Tổng tiền (DonGia * SoLuong)
                    KichHoat = 1,               // Trạng thái hoạt động
                    IdHoaDon = HD3,             // Liên kết với hóa đơn HD2
                    IdSanPhamChiTiet = SP00004_5 // GUID của sản phẩm "Giày sneaker cổ cao"
                },
                new HoaDonChiTiet
                {
                    IdHoaDonChiTiet = HDCT00004, // GUID duy nhất cho chi tiết hóa đơn
                    DonGia = 250000,            // Giá sản phẩm
                    SoLuong = 1,                // Số lượng sản phẩm
                    TongTien = 450000,          // Tổng tiền (DonGia * SoLuong)
                    KichHoat = 1,               // Trạng thái hoạt động
                    IdHoaDon = HD4,             // Liên kết với hóa đơn HD2
                    IdSanPhamChiTiet = SP00001 // GUID của sản phẩm "Giày sneaker cổ cao"
                },
                new HoaDonChiTiet
                {
                    IdHoaDonChiTiet = HDCT00005, // GUID duy nhất cho chi tiết hóa đơn
                    DonGia = 250000,            // Giá sản phẩm
                    SoLuong = 1,                // Số lượng sản phẩm
                    TongTien = 250000,          // Tổng tiền (DonGia * SoLuong)
                    KichHoat = 1,               // Trạng thái hoạt động
                    IdHoaDon = HD5,             // Liên kết với hóa đơn HD2
                    IdSanPhamChiTiet = SP00002_5 // GUID của sản phẩm "Giày sneaker cổ cao"
                },
                new HoaDonChiTiet
                {
                    IdHoaDonChiTiet = HDCT00006, // GUID duy nhất cho chi tiết hóa đơn
                    DonGia = 550000,            // Giá sản phẩm
                    SoLuong = 1,                // Số lượng sản phẩm
                    TongTien = 550000,          // Tổng tiền (DonGia * SoLuong)
                    KichHoat = 1,               // Trạng thái hoạt động
                    IdHoaDon = HD6,             // Liên kết với hóa đơn HD2
                    IdSanPhamChiTiet = SP00011_5 // GUID của sản phẩm "Giày sneaker cổ cao"
                },
                new HoaDonChiTiet
                {
                    IdHoaDonChiTiet = HDCT00007, // GUID duy nhất cho chi tiết hóa đơn
                    DonGia = 400000,            // Giá sản phẩm
                    SoLuong = 1,                // Số lượng sản phẩm
                    TongTien = 400000,          // Tổng tiền (DonGia * SoLuong)
                    KichHoat = 1,               // Trạng thái hoạt động
                    IdHoaDon = HD7,             // Liên kết với hóa đơn HD2
                    IdSanPhamChiTiet = SP00009 // GUID của sản phẩm "Giày sneaker cổ cao"
                },
                    new HoaDonChiTiet
                    {
                        IdHoaDonChiTiet = HDCT00008, // GUID duy nhất cho chi tiết hóa đơn
                        DonGia = 300000,            // Giá sản phẩm
                        SoLuong = 1,                // Số lượng sản phẩm
                        TongTien = 300000,          // Tổng tiền (DonGia * SoLuong)
                        KichHoat = 1,               // Trạng thái hoạt động
                        IdHoaDon = HD8,             // Liên kết với hóa đơn HD2
                        IdSanPhamChiTiet = SP00003_5 // GUID của sản phẩm "Giày sneaker cổ cao"
                    },
                    new HoaDonChiTiet
                    {
                        IdHoaDonChiTiet = HDCT00009, // GUID duy nhất cho chi tiết hóa đơn
                        DonGia = 500000,            // Giá sản phẩm
                        SoLuong = 1,                // Số lượng sản phẩm
                        TongTien = 500000,          // Tổng tiền (DonGia * SoLuong)
                        KichHoat = 1,               // Trạng thái hoạt động
                        IdHoaDon = HD9,             // Liên kết với hóa đơn HD2
                        IdSanPhamChiTiet = SP00006_5 // GUID của sản phẩm "Giày sneaker cổ cao"
                    },
                    new HoaDonChiTiet
                    {
                        IdHoaDonChiTiet = HDCT000010, // GUID duy nhất cho chi tiết hóa đơn
                        DonGia = 450000,            // Giá sản phẩm
                        SoLuong = 1,                // Số lượng sản phẩm
                        TongTien = 450000,          // Tổng tiền (DonGia * SoLuong)
                        KichHoat = 1,               // Trạng thái hoạt động
                        IdHoaDon = HD10,             // Liên kết với hóa đơn HD2
                        IdSanPhamChiTiet = SP00001_2 // GUID của sản phẩm "Giày sneaker cổ cao"
                    },
                    new HoaDonChiTiet
                    {
                        IdHoaDonChiTiet = HDCT000011, // GUID duy nhất cho chi tiết hóa đơn
                        DonGia = 450000,            // Giá sản phẩm
                        SoLuong = 1,                // Số lượng sản phẩm
                        TongTien = 450000,          // Tổng tiền (DonGia * SoLuong)
                        KichHoat = 1,               // Trạng thái hoạt động
                        IdHoaDon = HD11,             // Liên kết với hóa đơn HD2
                        IdSanPhamChiTiet = SP00001_2 // GUID của sản phẩm "Giày sneaker cổ cao"
                    }

            );
            var LSHD1 = Guid.NewGuid();
            var LSHD1_1 = Guid.NewGuid();
            var LSHD2 = Guid.NewGuid();
            var LSHD2_1 = Guid.NewGuid();
            var LSHD3 = Guid.NewGuid();
            var LSHD3_1 = Guid.NewGuid();
            var LSHD4 = Guid.NewGuid();
            var LSHD4_1 = Guid.NewGuid();
            var LSHD5 = Guid.NewGuid();
            var LSHD5_1 = Guid.NewGuid();
            var LSHD6 = Guid.NewGuid();
            var LSHD6_1 = Guid.NewGuid();
            var LSHD7 = Guid.NewGuid();
            var LSHD7_1 = Guid.NewGuid();
            var LSHD8 = Guid.NewGuid();
            var LSHD8_1 = Guid.NewGuid();
            var LSHD9 = Guid.NewGuid();
            var LSHD9_1 = Guid.NewGuid();
            var LSHD10 = Guid.NewGuid();
            var LSHD10_1 = Guid.NewGuid();
            var LSHD11 = Guid.NewGuid();
            var LSHD11_1 = Guid.NewGuid();
            var LSHD12 = Guid.NewGuid();
            var LSHD12_1 = Guid.NewGuid();
            modelBuilder.Entity<LichSuHoaDon>().HasData(
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD1,
                 ThaoTac = "Tạo hóa đơn",
                 NgayTao = new DateTime(2024, 9, 4, 18, 30, 40),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD1,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD1_1,
                 ThaoTac = "Hoàn Thành",
                 NgayTao = new DateTime(2024, 9, 4, 18, 31, 40),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD1,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD2,      // GUID duy nhất cho lịch sử hóa đơn
                 ThaoTac = "Tạo hóa đơn",              // Nội dung thao tác                  
                 NgayTao = new DateTime(2024, 10, 15, 18, 59, 10), // Thời gian thao tác
                 TrangThai = "Hoàn Thành",             // Trạng thái hóa đơn
                 NguoiThaoTac = "Phạm Đức Hiếu",       // Người thực hiện thao tác
                 GhiChu = null,                        // Không có ghi chú
                 IdHoaDon = HD2,                       // Liên kết với hóa đơn HD1
                 IdNhanVien = nhanVien1                // Liên kết với nhân viên
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD2_1,      // GUID duy nhất cho lịch sử hóa đơn
                 ThaoTac = "Hoàn Thành",              // Nội dung thao tác                  
                 NgayTao = new DateTime(2024, 10, 15, 19, 00, 10), // Thời gian thao tác
                 TrangThai = "Hoàn Thành",             // Trạng thái hóa đơn
                 NguoiThaoTac = "Phạm Đức Hiếu",       // Người thực hiện thao tác
                 GhiChu = null,                        // Không có ghi chú
                 IdHoaDon = HD2,                       // Liên kết với hóa đơn HD1
                 IdNhanVien = nhanVien1                // Liên kết với nhân viên
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD3,
                 ThaoTac = "Tạo hóa đơn",
                 NgayTao = new DateTime(2024, 11, 15, 18, 53, 45),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD3,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD3_1,
                 ThaoTac = "Hoàn Thành",
                 NgayTao = new DateTime(2024, 11, 15, 18, 55, 30),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD3,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD4,
                 ThaoTac = "Tạo hóa đơn",
                 NgayTao = new DateTime(2024, 11, 15, 19, 20, 30),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD4,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD4_1,
                 ThaoTac = "Hoàn Thành",
                 NgayTao = new DateTime(2024, 11, 15, 19, 21, 30),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD4,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD5,
                 ThaoTac = "Tạo hóa đơn",
                 NgayTao = new DateTime(2024, 11, 16, 19, 35, 45),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD5,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD5_1,
                 ThaoTac = "Hoàn Thành",
                 NgayTao = new DateTime(2024, 11, 16, 19, 36, 45),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD5,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD6,
                 ThaoTac = "Tạo hóa đơn",
                 NgayTao = new DateTime(2024, 12, 15, 19, 50, 10),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD6,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD6_1,
                 ThaoTac = "Hoàn Thành",
                 NgayTao = new DateTime(2024, 12, 15, 19, 50, 10),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD6,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD7,
                 ThaoTac = "Tạo hóa đơn",
                 NgayTao = new DateTime(2024, 11, 16, 20, 05, 25),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD7,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD7_1,
                 ThaoTac = "Hoàn Thành",
                 NgayTao = new DateTime(2024, 11, 16, 20, 06, 25),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD7,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD8,
                 ThaoTac = "Tạo hóa đơn",
                 NgayTao = new DateTime(2024, 11, 20, 20, 20, 40),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD8,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD8_1,
                 ThaoTac = "Hoàn Thành",
                 NgayTao = new DateTime(2024, 11, 20, 20, 21, 40),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD8,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD9,
                 ThaoTac = "Tạo hóa đơn",
                 NgayTao = new DateTime(2024, 12, 15, 20, 35, 55),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đức Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD9,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD9_1,
                 ThaoTac = "Hoàn Thành",
                 NgayTao = new DateTime(2024, 12, 15, 20, 36, 55),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đúc Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD9,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD10,
                 ThaoTac = "Tạo hóa đơn",
                 NgayTao = new DateTime(2024, 12, 15, 19, 3, 20),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đúc Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD10,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD10_1,
                 ThaoTac = "Hoàn Thành",
                 NgayTao = new DateTime(2024, 12, 15, 19, 4, 20),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đúc Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD10,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD11,
                 ThaoTac = "Tạo hóa đơn",
                 NgayTao = new DateTime(2024, 12, 15, 19, 3, 20),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đúc Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD11,
                 IdNhanVien = nhanVien1
             },
             new LichSuHoaDon
             {
                 IdLichSuHoaDon = LSHD11_1,
                 ThaoTac = "Hoàn Thành",
                 NgayTao = new DateTime(2024, 12, 15, 19, 4, 20),
                 TrangThai = "Hoàn Thành",
                 NguoiThaoTac = "Phạm Đúc Hiếu",
                 GhiChu = null,
                 IdHoaDon = HD11,
                 IdNhanVien = nhanVien1
             }
        );
            var LSTT1 = Guid.NewGuid();
            var LSTT2 = Guid.NewGuid();
            var LSTT3 = Guid.NewGuid();
            var LSTT4 = Guid.NewGuid();
            var LSTT5 = Guid.NewGuid();
            var LSTT6 = Guid.NewGuid();
            var LSTT7 = Guid.NewGuid();
            var LSTT8 = Guid.NewGuid();
            var LSTT9 = Guid.NewGuid();
            var LSTT10 = Guid.NewGuid();
            var LSTT11 = Guid.NewGuid();

            modelBuilder.Entity<LichSuThanhToan>().HasData(
                // Lịch sử thanh toán cho HD1
                new LichSuThanhToan
                {
                    IdLichSuThanhToan = LSTT1,                  // GUID duy nhất cho lịch sử thanh toán
                    SoTien = 600000,                           // Tổng tiền thanh toán
                    TienThua = 0,                              // Không có tiền thừa
                    NgayTao = new DateTime(2024, 9, 4, 18, 30, 40), // Thời gian tạo thanh toán
                    LoaiGiaoDich = "Thanh Toán",               // Loại giao dịch
                    Pttt = "Tiền mặt",                         // Phương thức thanh toán
                    NguoiThaoTac = "Phạm Đức Hiếu",            // Người thao tác
                    TrangThai = "Hoàn Thành",                  // Trạng thái giao dịch
                    GhiChu = null,                             // Không có ghi chú
                    IdHoaDon = HD1,                            // Liên kết với HD1
                    IdNhanVien = nhanVien1                     // Nhân viên liên quan
                },
                new LichSuThanhToan
                {
                    IdLichSuThanhToan = LSTT2,                  // GUID duy nhất cho lịch sử thanh toán
                    SoTien = 450000,                           // Tổng tiền thanh toán
                    TienThua = 0,                              // Không có tiền thừa
                    NgayTao = new DateTime(2024, 10, 15, 18, 59, 10), // Thời gian tạo thanh toán
                    LoaiGiaoDich = "Thanh Toán",               // Loại giao dịch
                    Pttt = "Tiền mặt",                         // Phương thức thanh toán
                    NguoiThaoTac = "Phạm Đức Hiếu",            // Người thao tác
                    TrangThai = "Hoàn Thành",                  // Trạng thái giao dịch
                    GhiChu = null,                             // Không có ghi chú
                    IdHoaDon = HD2,                            // Liên kết với HD1
                    IdNhanVien = nhanVien1                     // Nhân viên liên quan
                },
                new LichSuThanhToan
                {
                    IdLichSuThanhToan = LSTT3,
                    SoTien = 250000,
                    TienThua = 0,
                    NgayTao = new DateTime(2024, 11, 15, 18, 53, 45),
                    LoaiGiaoDich = "Thanh Toán",
                    Pttt = "Tiền mặt",
                    NguoiThaoTac = "Phạm Đức Hiếu",
                    TrangThai = "Hoàn Thành",
                    GhiChu = null,
                    IdHoaDon = HD3,
                    IdNhanVien = nhanVien1
                },
                new LichSuThanhToan
                {
                    IdLichSuThanhToan = LSTT4,
                    SoTien = 450000,
                    TienThua = 0,
                    NgayTao = new DateTime(2024, 11, 15, 19, 20, 30),
                    LoaiGiaoDich = "Thanh Toán",
                    Pttt = "Tiền mặt",
                    NguoiThaoTac = "Phạm Đức Hiếu",
                    TrangThai = "Hoàn Thành",
                    GhiChu = null,
                    IdHoaDon = HD4,
                    IdNhanVien = nhanVien1
                },
                new LichSuThanhToan
                {
                    IdLichSuThanhToan = LSTT5,
                    SoTien = 250000,
                    TienThua = 0,
                    NgayTao = new DateTime(2024, 11, 16, 19, 35, 45),
                    LoaiGiaoDich = "Thanh Toán",
                    Pttt = "Tiền mặt",
                    NguoiThaoTac = "Phạm Đức Hiếu",
                    TrangThai = "Hoàn Thành",
                    GhiChu = null,
                    IdHoaDon = HD5,
                    IdNhanVien = nhanVien1
                },
                new LichSuThanhToan
                {
                    IdLichSuThanhToan = LSTT6,
                    SoTien = 550000,
                    TienThua = 0,
                    NgayTao = new DateTime(2024, 12, 15, 19, 50, 10),
                    LoaiGiaoDich = "Thanh Toán",
                    Pttt = "Tiền mặt",
                    NguoiThaoTac = "Phạm Đức Hiếu",
                    TrangThai = "Hoàn Thành",
                    GhiChu = null,
                    IdHoaDon = HD6,
                    IdNhanVien = nhanVien1
                },
                new LichSuThanhToan
                {
                    IdLichSuThanhToan = LSTT7,
                    SoTien = 400000,
                    TienThua = 0,
                    NgayTao = new DateTime(2024, 11, 16, 20, 05, 25),
                    LoaiGiaoDich = "Thanh Toán",
                    Pttt = "Tiền mặt",
                    NguoiThaoTac = "Phạm Đức Hiếu",
                    TrangThai = "Hoàn Thành",
                    GhiChu = null,
                    IdHoaDon = HD7,
                    IdNhanVien = nhanVien1
                },
                new LichSuThanhToan
                {
                    IdLichSuThanhToan = LSTT8,
                    SoTien = 300000,
                    TienThua = 0,
                    NgayTao = new DateTime(2024, 11, 20, 20, 20, 40),
                    LoaiGiaoDich = "Thanh Toán",
                    Pttt = "Tiền mặt",
                    NguoiThaoTac = "Phạm Đức Hiếu",
                    TrangThai = "Hoàn Thành",
                    GhiChu = null,
                    IdHoaDon = HD8,
                    IdNhanVien = nhanVien1
                },
                new LichSuThanhToan
                {
                    IdLichSuThanhToan = LSTT9,
                    SoTien = 500000,
                    TienThua = 0,
                    NgayTao = new DateTime(2024, 12, 15, 20, 35, 55),
                    LoaiGiaoDich = "Thanh Toán",
                    Pttt = "Tiền mặt",
                    NguoiThaoTac = "Phạm Đức Hiếu",
                    TrangThai = "Hoàn Thành",
                    GhiChu = null,
                    IdHoaDon = HD9,
                    IdNhanVien = nhanVien1
                },
                new LichSuThanhToan
                {
                    IdLichSuThanhToan = LSTT10,
                    SoTien = 250000,
                    TienThua = 0,
                    NgayTao = new DateTime(2024, 12, 15, 19, 03, 20),
                    LoaiGiaoDich = "Thanh Toán",
                    Pttt = "Tiền mặt",
                    NguoiThaoTac = "Phạm Đức Hiếu",
                    TrangThai = "Hoàn Thành",
                    GhiChu = null,
                    IdHoaDon = HD10,
                    IdNhanVien = nhanVien1
                },
                new LichSuThanhToan
                {
                    IdLichSuThanhToan = LSTT11,
                    SoTien = 250000,
                    TienThua = 0,
                    NgayTao = new DateTime(2024, 12, 15, 19, 03, 20),
                    LoaiGiaoDich = "Thanh Toán",
                    Pttt = "Tiền mặt",
                    NguoiThaoTac = "Phạm Đức Hiếu",
                    TrangThai = "Hoàn Thành",
                    GhiChu = null,
                    IdHoaDon = HD11,
                    IdNhanVien = nhanVien1
                }
                );
        }
    }
}