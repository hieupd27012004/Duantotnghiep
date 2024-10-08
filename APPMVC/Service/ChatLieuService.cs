using AppData.Model;
using APPMVC.IService;

namespace APPMVC.Service
{
    public class ChatLieuService : IChatLieuService
    {
        private readonly HttpClient _httpClient;
        public ChatLieuService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7198");
        }

        public async Task CreateChatLieu(ChatLieu chatLieu)
        {
            await _httpClient.PostAsJsonAsync("api/ChatLieu/CreateCL", chatLieu);
        }

        public async Task DeleteChatLieu(Guid id)
        {
            var delete = await _httpClient.DeleteAsync($"/api/ChatLieu/DeleteCL?id={id}");
            delete.EnsureSuccessStatusCode();
        }

        public async Task<List<ChatLieu>> GetAllChatLieu()
        {
            var getall = await _httpClient.GetFromJsonAsync<List<ChatLieu>>("/api/ChatLieu/GetAllCL");
            return getall;
        }

        public async Task<ChatLieu> GetIdChatLieu(Guid id)
        {
            var getId = await _httpClient.GetFromJsonAsync<ChatLieu>($"/api/ChatLieu/GetIdCL?id={id}");
            return getId;
        }

        public async Task UpdateChatLieu(ChatLieu chatLieu)
        {
            await _httpClient.PutAsJsonAsync("api/ChatLieu/UpdateCL", chatLieu);
        }
    }
}
