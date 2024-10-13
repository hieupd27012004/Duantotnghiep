using AppData.Model;

namespace AppAPI.IService
{
    public interface INhanVienService 
    {
        Task<List<NhanVien>> GetAllNhaVien();
        Task<NhanVien> GetIdNhanVien(Guid id);
        Task<NhanVien> CreateNV(NhanVien nv);
        Task<NhanVien> UpdateNV(NhanVien nv);
        //Task<NhanVien> GetByEmail(string email);
        //Task<NhanVien> GetBySDT(string sdT);
        Task<NhanVien?> Login(string email, string password);
        Task DeleteDM(Guid id);
    }
}
