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
        // Thông kê ngày
        public async Task<List<ThongKeNgay>> GetStatisticsByDate(DateTime date)
        {
            var startDate = date.Date;
            var endDate = startDate.AddDays(1);

            var hoaDonsTrongNgay = await _context.hoaDons
                .Where(hd => hd.NgayTao >= startDate && hd.NgayTao < endDate)
                .ToListAsync();
			var tongtien = await _context.lichSuThanhToans
				.Where(ls => ls.NgayTao >= startDate && ls.NgayTao < endDate && ls.TrangThai == "Đã thanh toán" || ls.TrangThai == "Hoàn Thành")
				.SumAsync(ls => ls.SoTien);
            
			var result = hoaDonsTrongNgay
		        .GroupBy(hd => hd.NgayTao.Date)
		        .Select(g => new ThongKeNgay
		        {
			        Ngay = g.Key,
			        TongDonHang = g.Count(hd => hd.TrangThai != "Tạo đơn hàng"),
			        DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
                    DonHangHuy = g.Count(hd => hd.TrangThai == "Đã Hủy"),
			        DonHangThanhCong = g.Count(hd => hd.TrangThai == "Hoàn Thành" || hd.TrangThai == "Đã Thanh Toán"),
			        TongTien = tongtien
		        })
		        .ToList();
			return result;
        }

        //Thống kê tuần
        public async Task<List<ThongKeNgay>> GetStatisticsByWeek(DateTime date)
        {
            var startOfWeek = date.Date.AddDays(-(int)date.DayOfWeek); 
            var endOfWeek = startOfWeek.AddDays(7);


			var hoaDonsTrongTuan = await _context.hoaDons
	            .Where(hd => hd.NgayTao >= startOfWeek && hd.NgayTao < endOfWeek)
	            .ToListAsync();

			var tongtien = await _context.lichSuThanhToans
				.Where(ls => ls.NgayTao >= startOfWeek && ls.NgayTao < endOfWeek && ls.TrangThai == "Đã thanh toán" || ls.TrangThai == "Hoàn Thành")
				.SumAsync(ls => ls.SoTien);

			var result = hoaDonsTrongTuan
		        .GroupBy(_ => true) 
		        .Select(g => new ThongKeNgay
		        {
			        TongDonHang = g.Count(hd => hd.TrangThai != "Tạo đơn hàng"),
					DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
                    DonHangHuy = g.Count(hd => hd.TrangThai == "Đã Hủy"),
                    DonHangThanhCong = g.Count(hd => hd.TrangThai == "Hoàn Thành" || hd.TrangThai == "Đã Thanh Toán"),
			        TongTien = tongtien
				})
		        .ToList();
			return result;
        }
        //Thống kê tháng
        public async Task<List<ThongKeNgay>> GetStatisticsByMonth(int year, int month)
        {           
            var startOfMonth = new DateTime(year, month, 1);
            var endOfMonth = startOfMonth.AddMonths(1);
			
			var hoaDonsTrongThang = await _context.hoaDons
	            .Where(hd => hd.NgayTao >= startOfMonth && hd.NgayTao < endOfMonth)
	            .ToListAsync();

			var tongtien = await _context.lichSuThanhToans
				.Where(ls => ls.NgayTao >= startOfMonth && ls.NgayTao < endOfMonth && ls.TrangThai == "Đã thanh toán" || ls.TrangThai == "Hoàn Thành")
				.SumAsync(ls => ls.SoTien);

			var result = hoaDonsTrongThang
		        .GroupBy(_ => true) 
		        .Select(g => new ThongKeNgay
		        {
			        
			        TongDonHang = g.Count(hd => hd.TrangThai != "Tạo đơn hàng"),
					DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
                    DonHangHuy = g.Count(hd => hd.TrangThai == "Đã Hủy"),
                    DonHangThanhCong = g.Count(hd => hd.TrangThai == "Hoàn Thành" || hd.TrangThai == "Đã Thanh Toán"),
			        TongTien = tongtien
				})
		        .ToList();
			return result;
        }

        //Thống kê năm
        public async Task<List<ThongKeThang>> GetStatisticsByYear(int year)
        {           
            var hoaDonsTrongNam = await _context.hoaDons
                .Where(hd => hd.NgayTao.Year == year)
                .ToListAsync();

			var tongTienTheoThang = await _context.lichSuThanhToans
				.Where(ls => ls.NgayTao.Year == year && ls.TrangThai == "Đã thanh toán" || ls.TrangThai == "Hoàn Thành")
				.SumAsync(ls => ls.SoTien);

			var result = hoaDonsTrongNam
	            .GroupBy(_ => true) 
	            .Select(g => new ThongKeThang
	            {
		            TongDonHang =  g.Count(hd => hd.TrangThai != "Tạo đơn hàng"),
		            DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
                    DonHangHuy = g.Count(hd => hd.TrangThai == "Đã Hủy"),
                    DonHangThanhCong = g.Count(hd => hd.TrangThai == "Hoàn Thành" || hd.TrangThai == "Đã Thanh Toán"),
		            TongTien = tongTienTheoThang
				})
	            .ToList();
			return result;
		}

		//Thông kê tổng quan
		public async Task<ThongKeTongQuan> GetTotalOrdersAndRevenue()
		{
			int totalOrders = await _context.hoaDons.CountAsync(hd => hd.TrangThai != "Tạo đơn hàng"); 

			double totalRevenue = await _context.lichSuThanhToans
				.Where(hd => (hd.TrangThai == "Hoàn Thành" || hd.TrangThai == "Đã Thanh Toán"))
				.SumAsync(hd => hd.SoTien); 
			
			return new ThongKeTongQuan
			{
				TongDonHang = totalOrders,
				TongDoanhThu = totalRevenue
			};
		}

		//Lọc
		public async Task<List<ThongKeKhoangThoiGian>> GetStatisticsByTimeRange(DateTime startDate, DateTime endDate)
        {
			var hoaDonsTrongKhoang = await _context.hoaDons
				.Where(hd => hd.NgayTao.Date >= startDate.Date && hd.NgayTao.Date <= endDate.Date)
				.ToListAsync();

            var tongTienTrongKhoang = await _context.lichSuThanhToans
                .Where(ls => ls.NgayTao.Date >= startDate.Date && ls.NgayTao.Date <= endDate.Date && ls.TrangThai == "Đã thanh toán" || ls.TrangThai == "Hoàn Thành")
                .GroupBy(ls => ls.NgayTao.Date)
                .Select(g => new { Ngay = g.Key, TongTien = g.Sum(ls => ls.SoTien) })
                .ToListAsync();

            // Thống kê theo ngày
            var result = hoaDonsTrongKhoang
                .GroupBy(hd => hd.NgayTao.Date)
                .Select(g => new ThongKeKhoangThoiGian
                {
                    Ngay = g.Key,
                    TongDonHang = g.Count(hd => hd.TrangThai != "Tạo đơn hàng"),
                    DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
                    DonHangHuy = g.Count(hd => hd.TrangThai == "Đã Hủy"),
                    DonHangThanhCong = g.Count(hd => hd.TrangThai == "Đã Thanh Toán" || hd.TrangThai == "Hoàn Thành"),
                    TongDoanhThu = tongTienTrongKhoang.FirstOrDefault(t => t.Ngay == g.Key)?.TongTien ?? 0 // Ghép tổng tiền
                })
                .OrderBy(tk => tk.Ngay)
                .ToList();
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
