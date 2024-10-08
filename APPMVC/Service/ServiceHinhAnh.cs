using AppData.Model;
using static APPMVC.Service.ServiceHinhAnh;

namespace APPMVC.Service
{
    public class ServiceHinhAnh : IServiceHinhAnh
    {
        private readonly HttpClient _httpClient;

        public ServiceHinhAnh()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7198");
        }

        public async Task Create(HinhAnh hinhAnh)
        {
            try
            {
                if (hinhAnh.IdHinhAnh == Guid.Empty)
                {
                    hinhAnh.IdHinhAnh = Guid.NewGuid();
                }

                _httpClient.PostAsJsonAsync("api/HinhAnh/UploadHinhAnh", hinhAnh).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tạo HinhAnh: {ex.Message}");
            }
        }

        public async Task Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"api/HinhAnh/DeleteHinhAnh?id={id}");
        }

        public Task<List<HinhAnh>> GetHinhAnhs()
        {
            var repo = _httpClient.GetFromJsonAsync<List<HinhAnh>>("api/HinhAnh/GetAllHinhAnh");
            return repo;
        }

        public Task<HinhAnh> GetHinhAnhById(Guid id)
        {
            var hinhAnh = _httpClient.GetFromJsonAsync<HinhAnh>($"api/HinhAnh/GetHinhAnhById?id={id}");
            return hinhAnh;
        }

        public async Task Update(HinhAnh hinhAnh)
        {
            await _httpClient.PutAsJsonAsync("api/HinhAnh/UpdateHinhAnh", hinhAnh);
        }
    }
}

