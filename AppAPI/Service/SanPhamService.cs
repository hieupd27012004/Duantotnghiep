using AppAPI.IRepository;
using AppAPI.IService;
using AppData.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppAPI.Service
{
    public class SanPhamService : ISanPhamService
    {
        private readonly ISanPhamRepo _repository;

        public SanPhamService(ISanPhamRepo repository)
        {
            _repository = repository;
        }

        public bool Create(SanPham sanPham)
        {
            return _repository.Create(sanPham);
        }

        public bool Delete(Guid id)
        {
            return _repository.Delete(id);
        }

        public SanPham GetSanPhamById(Guid id)
        {
            return _repository.GetSanPhamById(id);
        }

        // Phương thức GetSanPham (Bất đồng bộ)
        public List<SanPham> GetSanPham(string? name)
        {
            return _repository.GetSanPham(name);
        }

        // Phương thức Update (Bất đồng bộ)
        public bool Update(SanPham sanPham)
        {
            return _repository.Update(sanPham);
        }
    }
}