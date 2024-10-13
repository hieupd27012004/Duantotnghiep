using AppData.Model;
using APPMVC.IService;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace APPMVC.Service
{
    public class HinhAnhService : IHinhAnhService
    {
        private readonly HttpClient _httpClient;

        public HinhAnhService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _httpClient.BaseAddress = new Uri("https://localhost:7198");
        }

        public async Task<bool> UploadAsync(HinhAnh hinhAnh)
        {
            try
            {
                if (hinhAnh == null)
                    throw new ArgumentNullException(nameof(hinhAnh));

                Console.WriteLine($"Preparing to upload HinhAnh: Id={hinhAnh.IdHinhAnh}, Type={hinhAnh.LoaiFileHinhAnh}, Size={hinhAnh.DataHinhAnh?.Length ?? 0} bytes");

                var response = await _httpClient.PostAsJsonAsync("api/HinhAnh/UploadHinhAnh", hinhAnh);

                Console.WriteLine($"Upload response status: {response.StatusCode}");

                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response content: {content}");

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Upload failed. Status: {response.StatusCode}, Content: {content}");
                    return false;
                }

                return true;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP request error when uploading HinhAnh: {ex.Message}");
                Console.WriteLine($"Error details: {ex.InnerException?.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when uploading HinhAnh: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return false;
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"api/HinhAnh/DeleteHinhAnh?id={id}");
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP request error when deleting HinhAnh: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when deleting HinhAnh: {ex.Message}");
                return false;
            }
        }

        public async Task<List<HinhAnh>> GetHinhAnhsAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<HinhAnh>>("api/HinhAnh/GetAllHinhAnh") ?? new List<HinhAnh>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP request error when getting all HinhAnh: {ex.Message}");
                return new List<HinhAnh>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when getting all HinhAnh: {ex.Message}");
                return new List<HinhAnh>();
            }
        }

        public async Task<HinhAnh> GetHinhAnhByIdAsync(Guid id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/HinhAnh/GetHinhAnhById?id={id}");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsByteArrayAsync();
                return new HinhAnh
                {
                    IdHinhAnh = id,
                    DataHinhAnh = content,
                    LoaiFileHinhAnh = response.Content.Headers.ContentType?.ToString()
                };
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP request error when getting HinhAnh by ID: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when getting HinhAnh by ID: {ex.Message}");
                return null;
            }
        }
    }
}