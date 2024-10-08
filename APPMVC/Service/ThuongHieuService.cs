using AppData.Model;
using APPMVC.IService;
using System.Net.Http;

namespace APPMVC.Service
{
    public class ThuongHieuService : IThuongHieuService
	{
		HttpClient _client;
        public ThuongHieuService()
        {
            _client = new HttpClient();
			_client.BaseAddress = new Uri("https://localhost:7198");
        }

        public async Task CreateThuongHieu(ThuongHieu th)
        {
            await _client.PostAsJsonAsync("api/ThuongHieu/CreateTH", th);
        }

        public async Task DeleteThuongHieu(Guid id)
        {
            var delete = await _client.DeleteAsync($"/api/ThuongHieu/DeleteTH?id={id}");
            delete.EnsureSuccessStatusCode();
        }

        public async Task<List<ThuongHieu>> GetAllThuongHieu()
        {
            var getall = await _client.GetFromJsonAsync<List<ThuongHieu>>("/api/ThuongHieu/GetAllTH");
            return getall;
        }

        public async Task<ThuongHieu> GetIdThuongHieu(Guid id)
        {
            var getId = await _client.GetFromJsonAsync<ThuongHieu>($"/api/ThuongHieu/GetIdTH?id={id}");
            return getId;
        }

        public async Task UpdateThuongHieu(ThuongHieu th)
        {
            var update = await _client.PutAsJsonAsync($"/api/ThuongHieu/UpdateTH", th);
            update.EnsureSuccessStatusCode();
        }

    }
}
