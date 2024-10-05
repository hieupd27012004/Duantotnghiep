using AppData;
using AppData.Model;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository
{
	public class ThuongHieuRepo : IThuongHiepRepo
	{
		AppDbcontext _context;
        public ThuongHieuRepo()
        {
            _context = new AppDbcontext();
        }

        public async Task<ThuongHieu> CreateTH(ThuongHieu th)
        {
            _context.thuongHieus.Add(th);
            await _context.SaveChangesAsync();
            return th;
        }

        public async Task DeleteTH(Guid id)
        {
            var delete = await _context.thuongHieus.FindAsync(id);
            if(delete != null)
            {
                _context.thuongHieus.Remove(delete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<ThuongHieu>> GetAllThuongHieu()
        {
            return await _context.thuongHieus.ToListAsync();

        }

        public async Task<ThuongHieu> GetIdThuongHieu(Guid id)
        {
            return await _context.thuongHieus.FindAsync(id);
        }

        public async Task<ThuongHieu> UpdateTH(ThuongHieu th)
        {
            _context.Entry(th).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return th;
        }
    }
}
