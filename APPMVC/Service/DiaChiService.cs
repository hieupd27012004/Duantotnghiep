using AppData.Model;
using APPMVC.IService;
using Microsoft.EntityFrameworkCore;

namespace APPMVC.Service
{
    public class DiaChiService : IDiaChiService
    {
        HttpClient _httpClient;
        public DiaChiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7198");
        }
        public async Task Create(DiaChi dc)
        {
            await _httpClient.PostAsJsonAsync("api/DiaChi/them",dc);
        }

        public async Task Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"api/DiaChi/Xoa?id={id}");
        }

        public Task<List<DiaChi>> GetDiaChi(string? name)
        {
            var repo = _httpClient.GetFromJsonAsync<List<DiaChi>>($"api/DiaChi/GetAll?name={name}");
            return repo;
        }

        public Task<DiaChi> GetDiaChiById(Guid id)
        {
            var dc = _httpClient.GetFromJsonAsync<DiaChi>($"api/DiaChi/GetById?id={id}");
            return dc;
        }
        public async Task<List<DiaChi>> GetDiaChiByIdKH(Guid id)
        {
            var dc = await _httpClient.GetFromJsonAsync<List<DiaChi>>($"api/DiaChi/GetDiaChiByIdKH?id={id}");
            return dc;
        }
        public async Task Update(DiaChi dc)
        {
            await _httpClient.PutAsJsonAsync("api/DiaChi/Sua", dc);
        }
        public async Task UpdateDCbyIdKH(Guid id, DiaChi diaChi)
        {
            await _httpClient.PutAsJsonAsync($"api/DiaChi/SuaTheoIdKh?id={id}", diaChi);
        }
    }
}
