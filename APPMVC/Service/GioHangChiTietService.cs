using AppData.Model;
using APPMVC.IService;
using System.Net.Http.Json;

namespace APPMVC.Service
{
	public class GioHangChiTietService : IGioHangChiTietService
	{
		private readonly HttpClient _httpClient;

		public GioHangChiTietService()
		{
			_httpClient = new HttpClient
			{
				BaseAddress = new Uri("https://localhost:7198")
			};
		}

		// Thêm giỏ hàng chi tiết
		public async Task AddAsync(GioHangChiTiet gioHangChiTiet)
		{
			var response = await _httpClient.PostAsJsonAsync("api/GioHangChiTiet/them", gioHangChiTiet);
			response.EnsureSuccessStatusCode();
		}

		// Xóa giỏ hàng chi tiết theo ID
		public async Task DeleteAsync(Guid id)
		{
			var response = await _httpClient.DeleteAsync($"api/GioHangChiTiet/xoa?id={id}");
			response.EnsureSuccessStatusCode();
		}

		// Lấy tất cả giỏ hàng chi tiết
		public async Task<List<GioHangChiTiet>> GetAllAsync()
		{
			var response = await _httpClient.GetAsync("api/GioHangChiTiet/getall");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadFromJsonAsync<List<GioHangChiTiet>>();
		}

		// Lấy giỏ hàng chi tiết theo ID
		public async Task<GioHangChiTiet> GetByIdAsync(Guid id)
		{
			var response = await _httpClient.GetAsync($"api/GioHangChiTiet/getbyid?id={id}");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadFromJsonAsync<GioHangChiTiet>();
		}

		// Cập nhật giỏ hàng chi tiết
		public async Task UpdateAsync(GioHangChiTiet gioHangChiTiet)
		{
			var response = await _httpClient.PutAsJsonAsync("api/GioHangChiTiet/sua", gioHangChiTiet);
			response.EnsureSuccessStatusCode();
		}
	}
}