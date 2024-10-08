﻿using AppData.Model;

namespace AppAPI.IRepository
{
    public interface IThuongHiepRepo
    {
        Task<List<ThuongHieu>> GetAllThuongHieu();
        Task<ThuongHieu> GetIdThuongHieu(Guid id);
        Task<ThuongHieu> CreateTH(ThuongHieu th);
        Task<ThuongHieu> UpdateTH(ThuongHieu th);
        Task DeleteTH(Guid id);
    }
}