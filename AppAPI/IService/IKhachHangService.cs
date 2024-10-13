using AppData.Model;

namespace AppAPI.IService
{
    public interface IKhachHangService
    {
        Task<List<KhachHang>> GetAllKhachHang();
        Task<KhachHang> GetIdKhachHang(Guid id);
        Task<KhachHang> AddKhachHang(KhachHang kh);
        Task<KhachHang> UpdateKhachHang(KhachHang kh);
        Task<KhachHang> GetByEmail(string email);
        Task<KhachHang?> Login(string email, string password);   
        Task DeleteKhachHang(Guid id);  
    }
}
