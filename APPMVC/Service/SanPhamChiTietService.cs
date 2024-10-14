using AppData.Model;
using APPMVC.IService;

namespace APPMVC.Service
{
    public class SanPhamChiTietService : ISanPhamChiTietService
    {
        HttpClient _httpClient;

        public SanPhamChiTietService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7198");
        }

        public async Task Create(SanPhamChiTiet sanPhamChiTiet)
        {
            await _httpClient.PostAsJsonAsync("api/SanPhamChiTiet/them", sanPhamChiTiet);
        }

        public async Task Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"api/SanPhamChiTiet/Xoa?id={id}");
        }

        public Task<List<SanPhamChiTiet>> GetSanPhamChiTiets()
        {
            var repo = _httpClient.GetFromJsonAsync<List<SanPhamChiTiet>>($"api/SanPhamChiTiet/getall");
            return repo;
        }

        public Task<SanPhamChiTiet> GetSanPhamChiTietById(Guid id)
        {
            var sanPhamChiTiet = _httpClient.GetFromJsonAsync<SanPhamChiTiet>($"api/SanPhamChiTiet/getbyid?id={id}");
            return sanPhamChiTiet;
        }

        public async Task Update(SanPhamChiTiet sanPhamChiTiet)
        {
            await _httpClient.PutAsJsonAsync("api/SanPhamChiTiet/Sua", sanPhamChiTiet);
        }

    }
}
