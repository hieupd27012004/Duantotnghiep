using System.Collections.Generic;

namespace AppData.ViewModel
{
    public class ThanhToanViewModel
    {
        public string? NguoiNhan { get; set; }
        public string? Email { get; set; }
        public string? DiaChiGiaoHang { get; set; }
        public string? SoDienThoaiNguoiNhan { get; set; }
        public List<CartItemViewModel> CartItems { get; set; } = new List<CartItemViewModel>();

        public string PaymentMethod { get; set; }
    }

    public class CartItemViewModel
    {
        public Guid IdSanPhamChiTiet { get; set; }
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
    }
}