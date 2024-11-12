﻿using AppData.Model;

namespace AppAPI.IService
{
    public interface ISanPhamChiTietService
    {
        List<SanPhamChiTiet> GetSanPhamChiTiet();
        SanPhamChiTiet GetSanPhamChitietById(Guid id);
        bool Create(SanPhamChiTiet sanPhamChitiet);
        Task<bool> Update(SanPhamChiTiet sanPhamChiTiet);
        Task<bool> Delete(Guid id);
        Task<List<SanPhamChiTiet>> GetSanPhamChiTietBySanPhamId(Guid sanPhamId);
        Task<Guid?> GetIdSanPhamChiTietByFilter(Guid idSanPham, Guid idKichCo, Guid idMauSac);
    }

}
