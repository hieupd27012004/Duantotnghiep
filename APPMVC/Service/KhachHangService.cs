using AppData.Model;
using APPMVC.IService;
using Newtonsoft.Json;
using System.Text;

namespace APPMVC.Service
{
    public class KhachHangService : IKhachHangService
    {
        HttpClient _httpClient;
        public KhachHangService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7198");
        }
        public async Task AddKhachHang(KhachHang kh)
        {
             await _httpClient.PostAsJsonAsync("/api/KhachHang/DangKy", kh);          
        }
        public async Task<KhachHang?> LoginKH(string email, string password)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/KhachHang/Login", new { Email = email, MatKhau = password });
            if(response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                // Deserializing chuỗi JSON thành đối tượng KhachHang
                return JsonConvert.DeserializeObject<KhachHang>(responseContent);
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception(errorMessage);
            }
        }
        public Task DeleteKhachHang(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<KhachHang>> GetAllKhachHang()
        {
            return await _httpClient.GetFromJsonAsync<List<KhachHang>>("/api/KhachHang/GetAllKhachHang");
        }

        public Task<KhachHang> GetIdKhachHang(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateKhachHang(KhachHang kh)
        {
            throw new NotImplementedException();
        }
    }
}
