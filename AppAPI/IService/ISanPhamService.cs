using AppData.Model;

namespace AppAPI.IService
{
    public interface ISanPhamService
    {
        List<SanPham> GetSanPham(string? name);
        SanPham GetSanPhamById(Guid id);
        bool Create(SanPham sanPham);
        bool Update(SanPham sanPham);
        bool Delete(Guid id);
    }
}
