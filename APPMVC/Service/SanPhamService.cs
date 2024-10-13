using AppData.Model;
using APPMVC.IService;

namespace APPMVC.Service
{
    public class SanPhamService : ISanPhamService
    {
        HttpClient _httpClient;

        public SanPhamService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7198");
        }

        public async Task Create(SanPham sanPham)
        {
            await _httpClient.PostAsJsonAsync("api/SanPham/them", sanPham);
        }

        public async Task Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"api/SanPham/Xoa?id={id}");
        }

        public Task<List<SanPham>> GetSanPhams(string? name)
        {
            var repo = _httpClient.GetFromJsonAsync<List<SanPham>>($"api/SanPham/getall?name={name}");
            return repo;
        }

        public Task<SanPham> GetSanPhamById(Guid id)
        {
            var sanPham = _httpClient.GetFromJsonAsync<SanPham>($"api/SanPham/getbyid?id={id}");
            return sanPham;
        }

        public async Task Update(SanPham sanPham)
        {
            await _httpClient.PutAsJsonAsync("api/SanPham/Sua", sanPham);
        }
    }
}
