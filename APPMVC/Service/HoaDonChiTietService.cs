using AppData.Model;
using APPMVC.IService;

namespace APPMVC.Service
{
    public class HoaDonChiTietService : IHoaDonChiTietService
    {
        private readonly HttpClient _httpClient;

        public HoaDonChiTietService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7198") 
            };
        }

        // Thêm chi tiết hóa đơn
        public async Task AddAsync(HoaDonChiTiet hoaDonChiTiet)
        {
            var response = await _httpClient.PostAsJsonAsync("api/HoaDonChiTiet/them", hoaDonChiTiet);
            response.EnsureSuccessStatusCode();
        }

        // Xóa chi tiết hóa đơn theo ID
        public async Task DeleteAsync(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/HoaDonChiTiet/xoa?id={id}");
            response.EnsureSuccessStatusCode();
        }

        // Lấy tất cả chi tiết hóa đơn
        public async Task<List<HoaDonChiTiet>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("api/HoaDonChiTiet/getall");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<HoaDonChiTiet>>();
        }

        // Lấy chi tiết hóa đơn theo ID
        public async Task<HoaDonChiTiet> GetByIdAsync(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/HoaDonChiTiet/getbyid?id={id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<HoaDonChiTiet>();
        }

        // Cập nhật chi tiết hóa đơn
        public async Task UpdateAsync(HoaDonChiTiet hoaDonChiTiet)
        {
            var response = await _httpClient.PutAsJsonAsync("api/HoaDonChiTiet/sua", hoaDonChiTiet);
            response.EnsureSuccessStatusCode();
        }
    }
}
