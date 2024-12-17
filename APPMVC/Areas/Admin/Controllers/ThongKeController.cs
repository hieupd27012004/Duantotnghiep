﻿using AppData.ViewModel;
using APPMVC.IService;
using APPMVC.Service;
using Microsoft.AspNetCore.Mvc;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ThongKeController : Controller
    {
        private readonly IThongKeService _service;
        public ThongKeController( IThongKeService service)
        {
            _service = service;
        }
        public async Task<IActionResult> ThongKeTongQuan(DateTime? startDate, DateTime? endDate)
        {
            var time = DateTime.Now;
            DateTime start = startDate ?? new DateTime(time.Year, time.Month, 1); // Ngày đầu tháng
            DateTime end = endDate ?? time;

            var data = await _service.GetTotalOrdersAndRevenue();
           
            var theoNgay = await _service.GetStatisticsByDate(time);

            var theoTuan = await _service.GetStatisticsByWeek(time);

            var theoThang = await _service.GetStatisticsByMonth(time.Year, time.Month);

            var theoNam = await _service.GetStatisticsByYear(time.Year);
            var theoKhoangThoiGian = await _service.GetStatisticsByTimeRange(start, end);
            var model = new ThongKeViewModel
            {

                TongDonHang = data.TongDonHang,
                TongDoanhThu = data.TongDoanhThu,
                ThongKeNgay = theoNgay,
                
                ThongKeTuan = theoTuan,
                ThongKeThang = theoThang,
                ThongKeNam = theoNam,
                ThongKeKhoangThoiGian = theoKhoangThoiGian.ToList(), // Chuyển đổi sang danh sách nếu cần
                StartDate = start,
                EndDate = end
            };

            ViewData["Date"] = time.ToString("yyyy-MM-dd");
            ViewData["StartDate"] = start.ToString("yyyy-MM-dd");
            ViewData["EndDate"] = end.ToString("yyyy-MM-dd");
            return View(model);
        }
        //public async Task<IActionResult> ThongKeTheoThoiGian(DateTime? startDate, DateTime? endDate)
        //{
        //    DateTime time = DateTime.Now;
        //    DateTime start = startDate ?? new DateTime(time.Year, time.Month, 1); // Ngày đầu tháng
        //    DateTime end = endDate ?? time;
        //    var theoKhoangThoiGian = await _service.GetStatisticsByTimeRange(start, end);
        //    var model = new ThongKeTheoThoiGianViewModel
        //    {
        //        StartDate = start,
        //        EndDate = end,
        //        ThongKeKhoangThoiGian = theoKhoangThoiGian
        //    };
        //    ViewData["StartDate"] = start.ToString("yyyy-MM-dd");
        //    ViewData["EndDate"] = end.ToString("yyyy-MM-dd");

        //    return View(model);
        //}
        public async Task<IActionResult> TopSellingProductsChart(DateTime? startDate, DateTime? endDate)
        {
            var data = await _service.GetTopSellingProductsAsync(startDate, endDate);

            // Chuyển đổi dữ liệu sang dạng biểu đồ
            var chartData = data.Select(item => new ChartDataViewModel
            {
                Label = item.TenSanPham,
                Value = item.SoLuongBan,
            }).ToList();

            ViewData["StartDate"] = startDate?.ToString("yyyy-MM-dd");
            ViewData["EndDate"] = endDate?.ToString("yyyy-MM-dd");
            return View(chartData);
        }
    }
   
}