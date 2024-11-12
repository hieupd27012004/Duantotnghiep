﻿using AppAPI.IRepository;
using AppData;
using AppData.Model;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository
{
    public class HoaDonRepo : IHoaDonRepo
    {
        private readonly AppDbcontext _context;

        public HoaDonRepo(AppDbcontext context)
        {
            _context = context;
        }

        public async Task<List<HoaDon>> GetAllAsync()  // Đổi kiểu trả về thành List<HoaDon>
        {
            return await _context.hoaDons.ToListAsync();
        }

        public async Task<HoaDon> GetByIdAsync(Guid id)
        {
            return await _context.hoaDons.FindAsync(id);
        }

        public async Task AddAsync(HoaDon hoaDon)
        {
            await _context.hoaDons.AddAsync(hoaDon);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(HoaDon hoaDon)
        {
            _context.hoaDons.Update(hoaDon);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var hoaDon = await GetByIdAsync(id);
            if (hoaDon != null)
            {
                _context.hoaDons.Remove(hoaDon);
                await _context.SaveChangesAsync();
            }
        }
    }
}