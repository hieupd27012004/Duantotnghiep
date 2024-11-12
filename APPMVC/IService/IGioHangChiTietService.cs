﻿using AppData.Model;

namespace APPMVC.IService
{
    public interface IGioHangChiTietService
    {
		Task<List<GioHangChiTiet>> GetAllAsync();
		Task<GioHangChiTiet> GetByIdAsync(Guid id);
		Task AddAsync(GioHangChiTiet gioHangChiTiet);
		Task UpdateAsync(GioHangChiTiet gioHangChiTiet);
		Task DeleteAsync(Guid id);
	}
}