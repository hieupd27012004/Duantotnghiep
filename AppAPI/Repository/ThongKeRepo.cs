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

            // Lấy danh sách các hóa đơn trong ngày
            var hoaDonsTrongNgay = await _context.hoaDons
                .Where(hd => hd.NgayTao >= startDate && hd.NgayTao < endDate)
                .ToListAsync();
            
			var result = hoaDonsTrongNgay
		        .GroupBy(hd => hd.NgayTao.Date)
		        .Select(g => new ThongKeNgay
		        {
			        Ngay = g.Key,
			        TongDonHang = g.Count(hd => hd.TrangThai != "Tạo đơn hàng"),
			        DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
			        DonHangThanhCong = g.Count(hd => hd.TrangThai == "Hoàn Thành" || hd.TrangThai == "Đã Thanh Toán"),
			        TongTien = g.Where(hd => hd.TrangThai == "Hoàn Thành" || hd.TrangThai == "Đã Thanh Toán").Sum(hd => hd.TongTienHoaDon)
		        })
		        .ToList();
			return result;
        }

        //Thong ke tuan
        public async Task<List<ThongKeNgay>> GetStatisticsByWeek(DateTime date)
        {
            var startOfWeek = date.Date.AddDays(-(int)date.DayOfWeek); 
            var endOfWeek = startOfWeek.AddDays(7);


			var hoaDonsTrongTuan = await _context.hoaDons
	            .Where(hd => hd.NgayTao >= startOfWeek && hd.NgayTao < endOfWeek)
	            .ToListAsync();

			var result = hoaDonsTrongTuan
		        .GroupBy(_ => true) 
		        .Select(g => new ThongKeNgay
		        {
			        //Ngay = startOfWeek,
			        TongDonHang = g.Count(hd => hd.TrangThai != "Tạo đơn hàng"),
					DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
			        DonHangThanhCong = g.Count(hd => hd.TrangThai == "Hoàn Thành" || hd.TrangThai == "Đã Thanh Toán"),
			        TongTien = g.Where(hd => hd.TrangThai == "Hoàn Thành" || hd.TrangThai == "Đã Thanh Toán").Sum(hd => hd.TongTienHoaDon)
		        })
		        .ToList();
			return result;
        }
        //Thong ke thang
        public async Task<List<ThongKeNgay>> GetStatisticsByMonth(int year, int month)
        {
            // Xác định ngày bắt đầu và kết thúc của tháng
            var startOfMonth = new DateTime(year, month, 1);
            var endOfMonth = startOfMonth.AddMonths(1);

			// Lấy danh sách các hóa đơn trong tháng
			var hoaDonsTrongThang = await _context.hoaDons
	            .Where(hd => hd.NgayTao >= startOfMonth && hd.NgayTao < endOfMonth)
	            .ToListAsync();

			// Lấy danh sách các hóa đơn có trạng thái "Đã Thanh Toán" từ lịch sử thanh toán
			var result = hoaDonsTrongThang
		        .GroupBy(_ => true) 
		        .Select(g => new ThongKeNgay
		        {
			        
			        TongDonHang = g.Count(hd => hd.TrangThai != "Tạo đơn hàng"),
					DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
			        DonHangThanhCong = g.Count(hd => hd.TrangThai == "Hoàn Thành" || hd.TrangThai == "Đã Thanh Toán"),
			        TongTien = g.Where(hd => hd.TrangThai == "Hoàn Thành" || hd.TrangThai == "Đã Thanh Toán").Sum(hd => hd.TongTienHoaDon)
		        })
		        .ToList();
			return result;
        }

        //THong Ke Nam
        public async Task<List<ThongKeThang>> GetStatisticsByYear(int year)
        {           
            var hoaDonsTrongNam = await _context.hoaDons
                .Where(hd => hd.NgayTao.Year == year)
                .ToListAsync();

			var result = hoaDonsTrongNam
	            .GroupBy(_ => true) // Gom nhóm tất cả hóa đơn thành một nhóm duy nhất
	            .Select(g => new ThongKeThang
	            {
		            TongDonHang =  g.Count(hd => hd.TrangThai != "Tạo đơn hàng"),
		            DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
		            DonHangThanhCong = g.Count(hd => hd.TrangThai == "Hoàn Thành" || hd.TrangThai == "Đã Thanh Toán"),
		            TongTien = g.Where(hd => hd.TrangThai == "Hoàn Thành" || hd.TrangThai == "Đã Thanh Toán").Sum(hd => hd.TongTienHoaDon)
	            })
	            .ToList();
			return result;
		}
		public async Task<ThongKeTongQuan> GetTotalOrdersAndRevenue()
		{
			// Lọc và tính toán
			int totalOrders = await _context.hoaDons.CountAsync(hd => hd.TrangThai != "Tạo đơn hàng"); // Đếm tổng số đơn hàng không có trạng thái "Tạo đơn hàng"

			double totalRevenue = await _context.hoaDons
				.Where(hd => (hd.TrangThai == "Hoàn Thành" || hd.TrangThai == "Đã Thanh Toán"))
				.SumAsync(hd => hd.TongTienHoaDon); // Tổng doanh thu chỉ tính các đơn hàng đã thành công

			// Gán kết quả vào đối tượng trả về
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

			// Tính toán thống kê và trả về danh sách (một phần tử duy nhất trong danh sách)
			var result = hoaDonsTrongKhoang
				.GroupBy(_ => true) // Gom nhóm tất cả hóa đơn thành một nhóm
				.Select(g => new ThongKeKhoangThoiGian
				{
					TongDonHang = g.Count(hd => hd.TrangThai != "Tạo đơn hàng"),
					DonHangChoXacNhan = g.Count(hd => hd.TrangThai == "Chờ Xác Nhận"),
					DonHangThanhCong = g.Count(hd => hd.TrangThai == "Đã Thanh Toán" || hd.TrangThai == "Hoàn Thành"),
					TongDoanhThu = g.Where(hd => hd.TrangThai == "Đã Thanh Toán" || hd.TrangThai == "Hoàn Thành")
									.Sum(hd => hd.TongTienHoaDon)
				})
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
