using AppData.Model;

namespace AppAPI.IRepository
{
    public interface ISanPhamChiTietRepo
    {
        List<SanPhamChiTiet> GetSanPhamChiTiet();
        SanPhamChiTiet GetSanPhamChitietById(Guid id);
        bool Create(SanPhamChiTiet sanPhamChitiet);
        Task<bool> Update(SanPhamChiTiet sanPhamChiTiet);
        Task<bool> Delete(Guid id);

        Task<List<SanPhamChiTiet>> GetSanPhamChiTietBySanPhamId(Guid sanPhamId);

        Task<SanPhamChiTiet> GetIdSanPhamChiTietByFilter(Guid idSanPham, Guid idKichCo, Guid idMauSac);

    }
}
