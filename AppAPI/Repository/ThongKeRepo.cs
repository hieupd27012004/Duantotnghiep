using AppAPI.IRepository;
using AppData;
using AppData.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository
{
    public class ThongKeRepo : IThongKeRepo
    {
        private AppDbcontext _context;
        public ThongKeRepo( AppDbcontext appDbcontext)
        {
            _context = appDbcontext;
        }

        public async Task<List<ThongKeNgay>> GetStatisticsByDate(DateTime date)
        {
            var starDate = date.Date;
            var endDate = starDate.AddDays(1);

            var result = await _context.hoaDons
                .Where(hd => hd.NgayTao >= starDate && hd.NgayTao <= endDate)
                .GroupBy(hd => hd.NgayTao.Date)
                .Select(g => new ThongKeNgay
                {
                    Ngay = g.Key,
                    TongDonHang = g.Count(),
                    DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
                    DonHangThanhCong = g.Count(hd => hd.TrangThai == "Hoàn Thành"),
                    TongTien = g.Sum(hd => hd.TongTienHoaDon)
                })
                .ToListAsync();
            return result;
        }
        //Thong ke tuan
        public async Task<List<ThongKeNgay>> GetStatisticsByWeek(DateTime date)
        {
            var startOfWeek = date.Date.AddDays(-(int)date.DayOfWeek);
            var endOfWeek = startOfWeek.AddDays(7);
            var result = await _context.hoaDons
                .Where(hd => hd.NgayTao >= startOfWeek && hd.NgayTao < endOfWeek)
                .GroupBy(_ => true)
                .Select(g => new ThongKeNgay
                {
                    TongDonHang = g.Count(),
                    DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
                    DonHangThanhCong = g.Count(hd => hd.TrangThai == "Hoàn Thành"),
                    TongTien = g.Sum(hd => hd.TongTienHoaDon)
                })
                .ToListAsync();
            return result;
        }
        //Thong ke thang
        public async Task<List<ThongKeNgay>> GetStatisticsByMonth(int year, int month)
        {
            var result = await _context.hoaDons
                .Where(hd => hd.NgayTao.Year == year && hd.NgayTao.Month == month)
                .GroupBy(_ => true)
                .Select(g => new ThongKeNgay
                {
                    TongDonHang = g.Count(),
                    DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
                    DonHangThanhCong = g.Count(hd => hd.TrangThai == "Hoàn Thành"),
                    TongTien = g.Sum(hd => hd.TongTienHoaDon)
                })
                .ToListAsync();

            return result;
        }
        //THong Ke Nam
        public async Task<List<ThongKeThang>> GetStatisticsByYear(int year)
        {
            var result = await _context.hoaDons
                .Where(hd => hd.NgayTao.Year == year)
                .GroupBy(_ => true) // Nhóm theo tháng
                .Select(g => new ThongKeThang
                {
                   
                    TongDonHang = g.Count(),
                    DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
                    DonHangThanhCong = g.Count(hd => hd.TrangThai == "Hoàn Thành"),
                    TongTien = g.Sum(hd => hd.TongTienHoaDon)
                })
                .ToListAsync();

            return result;
        }
        public async Task<ThongKeTongQuan> GetTotalOrdersAndRevenue()
        {
            var result = new ThongKeTongQuan
            {
                TongDonHang = await _context.hoaDons.CountAsync(),
                TongDoanhThu = await _context.hoaDons.SumAsync(hd => hd.TongTienHoaDon)
            };
            return result;

        }
        //Lọc
        public async Task<List<ThongKeKhoangThoiGian>> GetStatisticsByTimeRange(DateTime startDate, DateTime endDate)
        {
            var result = await _context.hoaDons
                .Where(hd => hd.NgayTao.Date >= startDate.Date && hd.NgayTao.Date <= endDate.Date)
                .GroupBy(_ => true)
                .Select(g => new ThongKeKhoangThoiGian
                {                  
                    TongDonHang = g.Count(),
                    DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
                    DonHangThanhCong = g.Count(hd => hd.TrangThai == "Hoàn Thành"),
                    TongDoanhThu = g.Sum(hd => hd.TongTienHoaDon)
                })
                .ToListAsync();

            return result;
        }
        //sản phẩm bán chạy
        public async Task<List<TopSellingProductViewModel>> GetTopSellingProductsAsync(DateTime? startDate, DateTime? endDate)
        {
            var query = _context.hoaDonChiTiets
                .Include(hdct => hdct.SanPhamChiTiet)
                .ThenInclude(spct => spct.SanPham)
                .Where(hdct => hdct.HoaDon.NgayTao >= (startDate ?? DateTime.MinValue)
                            && hdct.HoaDon.NgayTao <= (endDate ?? DateTime.MaxValue))
                .GroupBy(hdct => hdct.IdSanPhamChiTiet)
                .Select(group => new TopSellingProductViewModel
                {
                    SanPhamId = group.Key,
                    TenSanPham = group.FirstOrDefault().SanPhamChiTiet.SanPham.TenSanPham,
                    SoLuongBan = group.Sum(g => g.SoLuong),
                    TongDoanhThu = group.Sum(g => g.SoLuong * g.DonGia)
                })
                .OrderByDescending(x => x.SoLuongBan)
                .Take(10);
            return await query.ToListAsync();
        }
    }
}
