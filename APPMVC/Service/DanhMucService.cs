using AppData.Model;

namespace APPMVC.Service
{
    public class DanhMucService : IDanhMucService
    {
        HttpClient _httpClient;
        public DanhMucService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7198");
        }
        public async Task Create(DanhMuc danhMuc)
        {
            await _httpClient.PostAsJsonAsync("/api/DanhMuc/ThemDanhMuc", danhMuc);
        }

        public async Task Delete(Guid id)
        {
            var delete = await _httpClient.DeleteAsync($"/api/DanhMuc/xoa?id={id}");
            delete.EnsureSuccessStatusCode();
        }

        public async Task<List<DanhMuc>> GetAllDanhMuc()
        {
            var repo = await _httpClient.GetFromJsonAsync<List<DanhMuc>>("/api/DanhMuc/GetAllDanhMuc");
            return repo;
        }

        public async Task<DanhMuc> GetIdDanhMuc(Guid id)
        {
            var getId = await _httpClient.GetFromJsonAsync<DanhMuc>($"/api/DanhMuc/GetIdDanhMuc?id={id}");
            return getId;
        }

        public async Task UpDate(DanhMuc danhMuc)
        {
            var update = await _httpClient.PutAsJsonAsync($"/api/DanhMuc/SuaDanhMuc", danhMuc);
            update.EnsureSuccessStatusCode();
        }
    }
}
