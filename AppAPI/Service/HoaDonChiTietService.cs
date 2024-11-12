﻿using AppAPI.IRepository;
using AppAPI.IService;
using AppData.Model;

namespace AppAPI.Service
{
    public class HoaDonChiTietService : IHoaDonChiTietService
    {
        private readonly IHoaDonChiTietRepo _hoaDonChiTietRepository;

        public HoaDonChiTietService(IHoaDonChiTietRepo hoaDonChiTietRepository)
        {
            _hoaDonChiTietRepository = hoaDonChiTietRepository;
        }

        public async Task<List<HoaDonChiTiet>> GetAllAsync()
        {
            return await _hoaDonChiTietRepository.GetAllAsync();
        }

        public async Task<HoaDonChiTiet> GetByIdAsync(Guid id)
        {
            return await _hoaDonChiTietRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(HoaDonChiTiet hoaDonChiTiet)
        {
            await _hoaDonChiTietRepository.AddAsync(hoaDonChiTiet);
        }

        public async Task UpdateAsync(HoaDonChiTiet hoaDonChiTiet)
        {
            await _hoaDonChiTietRepository.UpdateAsync(hoaDonChiTiet);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _hoaDonChiTietRepository.DeleteAsync(id);
        }
    }
}
