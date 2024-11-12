using AppData.Model;
using APPMVC.IService;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;

namespace APPMVC.Service
{
    public class SanPhamChiTietService : ISanPhamChiTietService
    {
        HttpClient _httpClient;

        public SanPhamChiTietService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7198");
        }

        public async Task Create(SanPhamChiTiet sanPhamChiTiet)
        {
            await _httpClient.PostAsJsonAsync("api/SanPhamChiTiet/them", sanPhamChiTiet);
        }

        public async Task Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"api/SanPhamChiTiet/Xoa?id={id}");
        }

        public Task<List<SanPhamChiTiet>> GetSanPhamChiTiets()
        {
            var repo = _httpClient.GetFromJsonAsync<List<SanPhamChiTiet>>($"api/SanPhamChiTiet/getall");
            return repo;
        }

        public Task<SanPhamChiTiet> GetSanPhamChiTietById(Guid id)
        {
            var sanPhamChiTiet = _httpClient.GetFromJsonAsync<SanPhamChiTiet>($"api/SanPhamChiTiet/getbyid?id={id}");
            return sanPhamChiTiet;
        }

        public async Task Update(SanPhamChiTiet sanPhamChiTiet)
        {
            await _httpClient.PutAsJsonAsync("api/SanPhamChiTiet/Sua", sanPhamChiTiet);
        }

        public async Task<List<SanPhamChiTiet>> GetSanPhamChiTietBySanPhamId(Guid sanPhamId)
        {
            var response = await _httpClient.GetAsync($"api/SanPhamChiTiet/getbysanphamid?sanPhamId={sanPhamId}");

            if (response.IsSuccessStatusCode)
            {
                // Read the response content as a list of SanPhamChiTiet
                var sanPhamChiTietList = await response.Content.ReadFromJsonAsync<List<SanPhamChiTiet>>();
                return sanPhamChiTietList;
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
            {
                // No data found, return an empty list instead of null
                return new List<SanPhamChiTiet>();
            }
            else
            {
                // Handle other errors
                throw new HttpRequestException($"Error calling API: {response.StatusCode}");
            }
        }
        public async Task<Guid?> GetIdSanPhamChiTietByFilter(Guid idSanPham, Guid idKichCo, Guid idMauSac)
        {

            var response = await _httpClient.GetAsync($"api/SanPhamChiTiet/get-by-filter?idSanPham={idSanPham}&idKichCo={idKichCo}&idMauSac={idMauSac}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Guid>();
            }
            else
            {
                return null;
            }
        }
    }
}
