using AppData.Model;

namespace AppAPI.IRepository
{
    public interface ISanPhamChiTietRepo
    {
        List<SanPhamChiTiet> GetSanPhamChiTiet();
        SanPhamChiTiet GetSanPhamChitietById(Guid id);
        bool Create(SanPhamChiTiet sanPhamChitiet);
        bool Update(SanPhamChiTiet sanPhamChitiet);
        bool Delete(Guid id);

        Task<SanPhamChiTiet> GetSanPhamChiTietBySanPhamId(Guid sanPhamId);
    }
}
