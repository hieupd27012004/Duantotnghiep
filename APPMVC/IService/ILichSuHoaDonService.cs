﻿using AppData.Model;

namespace APPMVC.IService
{
    public interface ILichSuHoaDonService
    {
        Task<List<LichSuHoaDon>> GetAllAsync();
        Task<LichSuHoaDon> GetByIdAsync(Guid id);
        Task AddAsync(LichSuHoaDon lichSuHoaDon);
        Task UpdateAsync(LichSuHoaDon lichSuHoaDon);
        Task DeleteAsync(Guid id);
    }
}
