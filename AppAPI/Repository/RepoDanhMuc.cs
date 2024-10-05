using AppData;
using AppData.Model;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository
{
    public class RepoDanhMuc : IRepoDanhMuc
    {
        AppDbcontext _context;
        public RepoDanhMuc()
        {
            _context = new AppDbcontext();
        }

        public async Task<DanhMuc> CreateDM(DanhMuc dm)
        {
            _context.danhMuc.Add(dm);
            await _context.SaveChangesAsync();
            return dm;
        }

        public async Task DeleteDM(Guid id)
        {
            var danhMuc = await _context.danhMuc.FindAsync(id);
            if(danhMuc != null)
            {
                _context.danhMuc.Remove(danhMuc);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<DanhMuc>> GetAllDanhMuc()
        {
            return await _context.danhMuc.ToListAsync();
        }

        public async Task<DanhMuc> GetIdDanhMuc(Guid id)
        {
            return await _context.danhMuc.FindAsync(id);
        }

        public async Task<DanhMuc> UpdateDM(DanhMuc dm)
        {
           _context.Entry(dm).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return dm;
        }
    }
}
