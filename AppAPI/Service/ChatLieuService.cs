using AppAPI.Repository;
using AppData.Model;

namespace AppAPI.Service
{
    public class ChatLieuService : IChatLieuService
    {
        public IChatLieuRepo _repo;
        public ChatLieuService(IChatLieuRepo repo)
        {
            _repo = repo;
        }
        public async Task<ChatLieu> CreateChatLieu(ChatLieu chatLieu)
        {
            return await _repo.CreateChatLieu(chatLieu);
        }

        public async Task DeleteChatLieu(Guid id)
        {
            await _repo.DeleteChatLieu(id);
        }

        public async Task<List<ChatLieu>> GetAllChatLieu()
        {
            return await _repo.GetAllChatLieu();
        }

        public async Task<ChatLieu> GetIdChatLieu(Guid id)
        {
            return await _repo.GetIdChatLieu(id);
        }

        public async Task<ChatLieu> UpdateChatLieu(ChatLieu chatLieu)
        {
            return await _repo.UpdateChatLieu(chatLieu);
        }
    }
}
