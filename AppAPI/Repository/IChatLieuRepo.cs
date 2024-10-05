using AppData.Model;

namespace AppAPI.Repository
{
    public interface IChatLieuRepo
    {
        Task<List<ChatLieu>> GetAllChatLieu();
        Task<ChatLieu> GetIdChatLieu(Guid id);
        Task<ChatLieu> CreateChatLieu(ChatLieu chatLieu);
        Task<ChatLieu> UpdateChatLieu(ChatLieu chatLieu);
        Task DeleteChatLieu(Guid id);

    }
}
