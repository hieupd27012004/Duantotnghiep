using AppData.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppAPI.Service
{
    public interface IServiceHinhAnh
    {
        Task<List<HinhAnh>> GetHinhAnhsAsync();
        Task<HinhAnh> GetHinhAnhByIdAsync(Guid id);
        Task<bool> UploadAsync(HinhAnh hinhAnh);
        Task<bool> DeleteAsync(Guid id);
    }
}