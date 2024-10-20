using AppData.Model;

namespace AppAPI.IService
{
    public interface ISanPhamChiTietService
    {
        List<SanPhamChiTiet> GetSanPhamChiTiet();
        SanPhamChiTiet GetSanPhamChitietById(Guid id);
        bool Create(SanPhamChiTiet sanPhamChitiet);
        bool Update(SanPhamChiTiet sanPhamChitiet);
        bool Delete(Guid id);
        Task<List<SanPhamChiTiet>> GetSanPhamChiTietBySanPhamId(Guid sanPhamId);
    }

}
