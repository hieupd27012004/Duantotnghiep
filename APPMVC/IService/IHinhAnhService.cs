﻿using AppData.Model;

namespace APPMVC.IService
{
    public interface IHinhAnhService
    {
        Task<List<HinhAnh>> GetHinhAnhsAsync();
        Task<HinhAnh> GetHinhAnhByIdAsync(Guid id);
        Task<bool> UploadAsync(HinhAnh hinhAnh);
        Task<bool> DeleteAsync(Guid id);
    }
}