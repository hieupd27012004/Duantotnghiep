using AppData.Model;
using APPMVC.IService;
using Newtonsoft.Json;
using System.Net.Http;

namespace APPMVC.Service
{
    public class NhanVienService : INhanVienService
    {
        HttpClient _client;
        public NhanVienService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7198");
        }
        public async Task CreateNV(NhanVien nv)
        {
            var response = await _client.PostAsJsonAsync("/api/NhanVien/CreateNhanVien", nv);
            response.EnsureSuccessStatusCode(); // Ném ngoại lệ nếu không thành công
        }

        public Task DeleteNV(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<NhanVien>> GetAllNhaVien()
        {
            var repo = await _client.GetFromJsonAsync<List<NhanVien>>("/api/NhanVien/GetAllNhanVien");
            return repo;
        }

        public Task<NhanVien> GetIdNhanVien(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateNV(NhanVien nv)
        {
            throw new NotImplementedException();
        }
        public async Task<NhanVien?> LoginKH(string email, string password)
        {
            var response = await _client.PostAsJsonAsync("/api/NhanVien/Login", new { Email = email, MatKhau = password });
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                // Deserializing chuỗi JSON thành đối tượng KhachHang
                return JsonConvert.DeserializeObject<NhanVien>(responseContent);
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception(errorMessage);
            }
        }
    }
}
