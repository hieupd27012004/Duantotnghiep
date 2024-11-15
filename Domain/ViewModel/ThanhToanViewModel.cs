using System.Collections.Generic;

namespace AppData.ViewModel
{
    public class ThanhToanViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<CartItemViewModel> CartItems { get; set; } = new List<CartItemViewModel>();
    }

    public class CartItemViewModel
    {
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }

        public bool Chon { get; set; }
    }
}