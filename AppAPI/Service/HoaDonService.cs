﻿using AppAPI.IRepository;
using AppAPI.IService;
using AppData.Model;

namespace AppAPI.Service
{
    public class HoaDonService : IHoaDonService
    {
        private readonly IHoaDonRepo _hoaDonRepository;

        public HoaDonService(IHoaDonRepo hoaDonRepository)
        {
            _hoaDonRepository = hoaDonRepository;
        }

        public async Task<List<HoaDon>> GetAllAsync()  
        {
            return await _hoaDonRepository.GetAllAsync();
        }

        public async Task<HoaDon> GetByIdAsync(Guid id)
        {
            return await _hoaDonRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(HoaDon hoaDon)
        {
            await _hoaDonRepository.AddAsync(hoaDon);
        }

        public async Task UpdateAsync(HoaDon hoaDon)
        {
            await _hoaDonRepository.UpdateAsync(hoaDon);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _hoaDonRepository.DeleteAsync(id);
        }
    }
}