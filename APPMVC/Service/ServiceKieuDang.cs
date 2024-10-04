using AppData.Model;

namespace APPMVC.Service
{
    public class ServiceKieuDang : IServiceKieuDang
    {
        HttpClient _httpClient;
        public ServiceKieuDang()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7198");
        }
        public async Task Create(KieuDang kieuDang)
        {
            var response = await _httpClient.PostAsJsonAsync("api/KieuDang/CreateKieuDang", kieuDang);
            if (response.IsSuccessStatusCode)
            {
                // Lưu trữ các thay đổi vào cơ sở dữ liệu
                await response.Content.ReadAsStringAsync();
            }
        }

        public async Task Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/KieuDang/DeleteKieuDang?id={id}");
            if (response.IsSuccessStatusCode)
            {
                // Lưu trữ các thay đổi vào cơ sở dữ liệu
                await response.Content.ReadAsStringAsync();
            }
        }

        public Task<List<KieuDang>> GetKieuDang()
        {
            var repo = _httpClient.GetFromJsonAsync<List<KieuDang>>("api/KieuDang/GetAllKieuDang");
            return repo;
        }

        public Task<KieuDang> GetKieuDangById(Guid id)
        {
            var kieuDang = _httpClient.GetFromJsonAsync<KieuDang>($"api/KieuDang/GetKieuDangById?id={id}");
            return kieuDang;
        }

        public async Task Update(KieuDang kieuDang)
        {
            var response = await _httpClient.PutAsJsonAsync("api/KieuDang/EditKieuDang", kieuDang);
            if (response.IsSuccessStatusCode)
            {
                // Lưu trữ các thay đổi vào cơ sở dữ liệu
                await response.Content.ReadAsStringAsync();
            }
        }
    }
}