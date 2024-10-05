using AppData.Model;

namespace APPMVC.Service
{
    public interface IChatLieuService
    {
        Task<List<ChatLieu>> GetAllChatLieu();
        Task<ChatLieu> GetIdChatLieu(Guid id);
        Task CreateChatLieu(ChatLieu chatLieu);
        Task UpdateChatLieu(ChatLieu chatLieu);
        Task DeleteChatLieu(Guid id);
    }
}
