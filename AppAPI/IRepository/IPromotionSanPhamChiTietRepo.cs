using AppData.Model;

namespace AppAPI.IRepository
{
    public interface IPromotionSanPhamChiTietRepo
    {
        Task<List<PromotionSanPhamChiTiet>> GetPromotionSanPhamChiTietAsync();

        Task<PromotionSanPhamChiTiet> GetPromotionByIdAsync(Guid id);

        Task<bool> CreateAsync(PromotionSanPhamChiTiet promotion);

        Task<bool> UpdateAsync(PromotionSanPhamChiTiet promotion);
        Task<bool> DeleteAsync(Guid id);
        Task<Promotion> GetPromotionsBySanPhamChiTietIdAsync(Guid sanPhamChiTietId);
    }
}
