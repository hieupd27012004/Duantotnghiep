using AppData.Model;
using APPMVC.IService;

namespace APPMVC.Service
{
    public class HoaDonService : IHoaDonService
    {
        private readonly HttpClient _httpClient;

        public HoaDonService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7198") 
            };
        }

        // Thêm hóa đơn
        public async Task AddAsync(HoaDon hoaDon)
        {
            var response = await _httpClient.PostAsJsonAsync("api/HoaDon/them", hoaDon);
            response.EnsureSuccessStatusCode();
        }

        // Xóa hóa đơn theo ID
        public async Task DeleteAsync(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/HoaDon/xoa?id={id}");
            response.EnsureSuccessStatusCode();
        }

        // Lấy tất cả hóa đơn
        public async Task<List<HoaDon>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("api/HoaDon/getall");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<HoaDon>>();
        }

        // Lấy hóa đơn theo ID
        public async Task<HoaDon> GetByIdAsync(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/HoaDon/getbyid?id={id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<HoaDon>();
        }

        // Cập nhật hóa đơn
        public async Task UpdateAsync(HoaDon hoaDon)
        {
            var response = await _httpClient.PutAsJsonAsync("api/HoaDon/sua", hoaDon);
            response.EnsureSuccessStatusCode();
        }
    }
}
