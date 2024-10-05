using AppData;
using AppData.Model;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository
{
    public class ChatLieuRepo : IChatLieuRepo
    {
        AppDbcontext _context;
        public ChatLieuRepo()
        {
            _context = new AppDbcontext();
        }
        public async Task<ChatLieu> CreateChatLieu(ChatLieu chatLieu)
        {
            _context.chatLieus.Add(chatLieu);
            await _context.SaveChangesAsync();
            return chatLieu;
        }

        public async Task DeleteChatLieu(Guid id)
        {
            var chatLieu = await _context.chatLieus.FindAsync(id);
            if(chatLieu != null)
            {
                _context.chatLieus.Remove(chatLieu);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<ChatLieu>> GetAllChatLieu()
        {
            return await _context.chatLieus.ToListAsync();
        }

        public async Task<ChatLieu> GetIdChatLieu(Guid id)
        {
            return await _context.chatLieus.FindAsync(id);
        }

        public async Task<ChatLieu> UpdateChatLieu(ChatLieu chatLieu)
        {
            _context.Entry(chatLieu).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return chatLieu;
        }
    }
}
