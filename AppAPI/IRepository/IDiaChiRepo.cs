using AppData.Model;

namespace AppAPI.IRepository
{
    public interface IDiaChiRepo
    {
        List<DiaChi> GetDiaChi(string? name);
        DiaChi GetDiaChiById(Guid id);
        bool Create(DiaChi diaChi);
        bool Update(DiaChi diaChi);
        bool Delete(Guid id);
        Task<List<DiaChi>> GetDiaChiByIdKH(Guid idKH);
        bool UpdateDCbyIdKH(Guid id,DiaChi dc);
    }
}
