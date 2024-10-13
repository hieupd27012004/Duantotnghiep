using AppData.Model;

namespace APPMVC.IService
{
    public interface INhanVienService
    {
        Task<List<NhanVien>> GetAllNhaVien();
        Task<NhanVien> GetIdNhanVien(Guid id);
        Task<NhanVien?> LoginKH(string email, string password);
        Task CreateNV(NhanVien nv);
        Task UpdateNV(NhanVien nv);
        Task DeleteNV(Guid id);
    }
}
