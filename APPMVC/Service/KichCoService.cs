﻿using AppData.Model;
using APPMVC.IService;

namespace APPMVC.Service
{
    public class KichCoService : IKichCoService
    {
        HttpClient _httpClient;

        public KichCoService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7198");
        }

        public async Task Create(KichCo kichCo)
        {
            await _httpClient.PostAsJsonAsync("api/KichCo/them", kichCo);
        }

        public async Task Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"api/KichCo/Xoa?id={id}");
        }

        public Task<List<KichCo>> GetKichCo(string? name)
        {
            var repo = _httpClient.GetFromJsonAsync<List<KichCo>>($"api/KichCo/getall?name={name}");
            return repo;
        }

        public Task<KichCo> GetKichCoById(Guid id)
        {
            var kichCo = _httpClient.GetFromJsonAsync<KichCo>($"api/KichCo/getbyid?id={id}");
            return kichCo;
        }

        public async Task Update(KichCo kichCo)
        {
            await _httpClient.PutAsJsonAsync("api/KichCo/Sua", kichCo);
        }
    }
}