using AppData.Model;
using APPMVC.IService;

namespace APPMVC.Service
{
    public class GiaoDichService : IGiaoDichService
    {
        private readonly HttpClient _httpClient;

        public GiaoDichService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7198") // Địa chỉ API
            };
        }

        // Thêm giao dịch
        public async Task AddAsync(GiaoDich giaoDich)
        {
            var response = await _httpClient.PostAsJsonAsync("api/GiaoDich/them", giaoDich);
            response.EnsureSuccessStatusCode();
        }

        // Xóa giao dịch theo ID
        public async Task DeleteAsync(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/GiaoDich/xoa?id={id}");
            response.EnsureSuccessStatusCode();
        }

        // Lấy tất cả giao dịch
        public async Task<List<GiaoDich>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("api/GiaoDich/getall");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<GiaoDich>>();
        }

        // Lấy giao dịch theo ID
        public async Task<GiaoDich> GetByIdAsync(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/GiaoDich/getbyid?id={id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<GiaoDich>();
        }

        // Cập nhật giao dịch
        public async Task UpdateAsync(GiaoDich giaoDich)
        {
            var response = await _httpClient.PutAsJsonAsync("api/GiaoDich/sua", giaoDich);
            response.EnsureSuccessStatusCode();
        }
    }
}
