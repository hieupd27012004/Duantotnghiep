using AppData.Model;

namespace APPMVC.IService
{
    public interface IKhachHangService
    {
        Task<List<KhachHang>> GetAllKhachHang();
        Task<KhachHang> GetIdKhachHang(Guid id);
        Task<KhachHang?> LoginKH(string email, string password);
        Task AddKhachHang(KhachHang kh);
        Task UpdateKhachHang(KhachHang kh);
        Task DeleteKhachHang(Guid id);
    }
}
