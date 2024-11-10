using AppData.ViewModel;
using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;

namespace APPMVC.Areas.Client.Controllers
{
	[Area("Client")]
	public class HomeClientController : Controller
	{
        private readonly IGioHangChiTietService _gioHangChiTietService;
        private readonly IHinhAnhService _hinhAnhService;
        public HomeClientController(IGioHangChiTietService gioHangChiTietService, IHinhAnhService hinhAnhService)
        {
            _gioHangChiTietService = gioHangChiTietService;
            _hinhAnhService = hinhAnhService;
        }
        public IActionResult Index()
		{
			return View();
		}
		public IActionResult LoginRegister()
		{
			return View();
		}
        public IActionResult Card()
        {

            var gioHangChiTiets = _gioHangChiTietService.GetAllAsync().Result; 
            var viewModel = gioHangChiTiets.Select(item => new GioHangChiTietViewModel
            {
                IdGioHangChiTiet = item.IdGioHangChiTiet,
                HinhAnhs = (List<AppData.Model.HinhAnh>)item.SanPhamChiTiet.HinhAnhs,
                TenSanPham = item.SanPhamChiTiet.SanPham.TenSanPham,
                DonGia = item.TongTien / item.SoLuong,
                SoLuong = item.SoLuong,
                TongTien = item.TongTien
            }).ToList();

            return View(viewModel);
        }


    }
}
