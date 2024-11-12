using AppData.Model;

namespace APPMVC.ViewModel
{
    public class SanPhamChiTietClientViewModel
    {
        public Guid IdSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        public double Gia { get; set; }

        public List<KichCoViewModel> AvailableSizes { get; set; }
        public List<MauSacViewModel> AvailableColors { get; set; }
    }
    public class KichCoViewModel
    {
        public Guid IdKichCo { get; set; }
        public string TenKichCo { get; set; }
    }

    public class MauSacViewModel
    {
        public Guid? IdMauSac { get; set; }
        public string TenMauSac { get; set; }
    }
}
