﻿using AppData.Model;
using AppData;
using AppAPI.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository
{
    public class SanPhamChiTietRepo : ISanPhamChiTietRepo
    {
        private readonly AppDbcontext _context;

        public SanPhamChiTietRepo(AppDbcontext context)
        {
            _context = context;
        }

        public bool Create(SanPhamChiTiet sanPhamChitiet)
        {
            try
            {
                _context.sanPhamChiTiets.Add(sanPhamChitiet);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Delete(Guid id)
        {
            var hinhAnhs = _context.hinhAnh.Where(h => h.IdSanPhamChiTiet == id).ToList();

            // Xóa tất cả hình ảnh liên quan
            _context.hinhAnh.RemoveRange(hinhAnhs);

            // Xóa sản phẩm chi tiết
            var sanPhamChiTiet = await _context.sanPhamChiTiets.FindAsync(id); // Sử dụng FindAsync để tìm kiếm bất đồng bộ
            if (sanPhamChiTiet != null)
            {
                _context.sanPhamChiTiets.Remove(sanPhamChiTiet);
                await _context.SaveChangesAsync(); // Chờ cho đến khi lưu thay đổi hoàn tất
                return true;
            }

            return false; // Không tìm thấy sản phẩm chi tiết
        }

        public SanPhamChiTiet GetSanPhamChitietById(Guid id)
        {
            var sanPhamChitiet = _context.sanPhamChiTiets.Find(id);
            return sanPhamChitiet;
        }

        public List<SanPhamChiTiet> GetSanPhamChiTiet()
        {
            var list = _context.sanPhamChiTiets.ToList();
            return list;
        }
        public async Task<bool> Update(SanPhamChiTiet sanPhamChiTiet)
        {
            // Tìm sản phẩm chi tiết trong cơ sở dữ liệu
            var sanPhamChitietUpdate = await _context.sanPhamChiTiets.FindAsync(sanPhamChiTiet.IdSanPhamChiTiet);

            if (sanPhamChitietUpdate != null)
            {
                // Cập nhật các thuộc tính của sản phẩm chi tiết
                sanPhamChitietUpdate.Gia = sanPhamChiTiet.Gia;
                sanPhamChitietUpdate.SoLuong = sanPhamChiTiet.SoLuong;
                sanPhamChitietUpdate.NgayCapNhat = sanPhamChiTiet.NgayCapNhat;
                sanPhamChitietUpdate.NgayTao = sanPhamChiTiet.NgayTao;
                sanPhamChitietUpdate.NguoiCapNhat = sanPhamChiTiet.NguoiCapNhat;
                sanPhamChitietUpdate.NguoiTao = sanPhamChiTiet.NguoiTao;
                sanPhamChitietUpdate.XuatXu = sanPhamChiTiet.XuatXu;
                // Nếu cần thiết, hãy quyết định có cập nhật thuộc tính KichHoat hay không
                // sanPhamChitietUpdate.KichHoat = sanPhamChiTiet.KichHoat == 1 ? 1 : 0;

                // Lưu thay đổi vào cơ sở dữ liệu
                await _context.SaveChangesAsync();
                return true; // Trả về true nếu cập nhật thành công
            }

            return false; // Trả về false nếu không tìm thấy sản phẩm chi tiết
        }

        public async Task<List<SanPhamChiTiet>> GetSanPhamChiTietBySanPhamId(Guid sanPhamId)
        {
            return await _context.sanPhamChiTiets              
                 .Where(s => s.IdSanPham == sanPhamId)
                 .ToListAsync();
        }

    }
}
