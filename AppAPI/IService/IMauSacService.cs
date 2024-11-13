﻿using AppData.Model;

namespace AppAPI.IService
{
    public interface IMauSacService
    {
        List<MauSac> GetMauSac(string? name);
        MauSac GetMauSacById(Guid id);
        bool Create(MauSac mauSac);
        bool Update(MauSac mauSac);
        bool Delete(Guid id);
        Task<List<MauSac>> GetMauSacBySanPhamId(Guid sanPhamId);

        Task<List<MauSac>> GetMauSacByIdsAsync(List<Guid> mauSacIds);
    }
}