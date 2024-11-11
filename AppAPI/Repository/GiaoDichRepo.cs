using AppAPI.IRepository;
using AppData;
using AppData.Model;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository
{
    public class GiaoDichRepo : IGiaoDichRepo
    {
        private readonly AppDbcontext _context;

        public GiaoDichRepo(AppDbcontext context)
        {
            _context = context;
        }

        public async Task<List<GiaoDich>> GetAllAsync()
        {
            return await _context.giaoDiches.ToListAsync();
        }

        public async Task<GiaoDich> GetByIdAsync(Guid id)
        {
            return await _context.giaoDiches.FindAsync(id);
        }

        public async Task AddAsync(GiaoDich giaoDich)
        {
            await _context.giaoDiches.AddAsync(giaoDich);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(GiaoDich giaoDich)
        {
            _context.giaoDiches.Update(giaoDich);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var giaoDich = await GetByIdAsync(id);
            if (giaoDich != null)
            {
                _context.giaoDiches.Remove(giaoDich);
                await _context.SaveChangesAsync();
            }
        }
    }
}
