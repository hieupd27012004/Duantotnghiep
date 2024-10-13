﻿using AppData.Model;

namespace APPMVC.IService
{
    public interface ISanPhamChiTietService
    {
        Task<List<SanPhamChiTiet>> GetSanPhamChiTiets();
        Task<SanPhamChiTiet> GetSanPhamChiTietById(Guid id);
        Task Create(SanPhamChiTiet sanPhamChiTiet);
        Task Update(SanPhamChiTiet sanPhamChiTiet);
        Task Delete(Guid id);

    }
}
