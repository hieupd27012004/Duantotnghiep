using AppAPI.IRepository;
using AppAPI.IService;
using AppData.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppAPI.Service
{
    public class SanPhamChiTietService : ISanPhamChiTietService
    {
        private readonly ISanPhamChiTietRepo _repository;

        public SanPhamChiTietService(ISanPhamChiTietRepo repository)
        {
            _repository = repository;
        }

        public bool Create(SanPhamChiTiet sanPhamChiTiet)
        {
            return _repository.Create(sanPhamChiTiet);
        }

        public bool Delete(Guid id)
        {
            return _repository.Delete(id);
        }

        public SanPhamChiTiet GetSanPhamChitietById(Guid id)
        {
            return _repository.GetSanPhamChitietById(id);
        }

        // Phương thức GetSanPhamChiTiet (Bất đồng bộ)
        public List<SanPhamChiTiet> GetSanPhamChiTiet()
        {
            return _repository.GetSanPhamChiTiet();
        }

        // Phương thức Update (Bất đồng bộ)
        public bool Update(SanPhamChiTiet sanPhamChiTiet)
        {
            return _repository.Update(sanPhamChiTiet);
        }

        public async Task<SanPhamChiTiet> GetSanPhamChiTietBySanPhamId(Guid sanPhamId)
        {
            return await _repository.GetSanPhamChiTietBySanPhamId(sanPhamId);
        }
    }
}