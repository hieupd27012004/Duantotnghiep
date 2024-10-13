﻿using AppAPI.IRepository;
using AppData;
using AppData.Model;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository
{
    public class NhanVienRepo : INhanVienRepo
    {
        AppDbcontext _context;
        public NhanVienRepo()
        {
           
            _context = new AppDbcontext();
        }
        public async Task<NhanVien> CreateNV(NhanVien nv)
        {
            try
            {
                _context.nhanViens.AddAsync(nv);
                await _context.SaveChangesAsync();
                return nv;
            }
            catch (Exception ex)
            {
                // Log lỗi hoặc xử lý ngoại lệ theo cách bạn muốn
                throw new Exception("Có lỗi xảy ra khi thêm nhân viên: " + ex.Message);
            }
        }
        public async Task<NhanVien?> Login(string email, string password)
        {
            var kh = await _context.nhanViens.FirstOrDefaultAsync(kh => kh.Email == email);
            if (kh == null)
            {
                throw new Exception("Email Không tồn tại");
            }
            //Kiểm tra mk
            if (kh.MatKhau != password)
            {
                throw new Exception("Mật Khẩu Không Chính Xác");
            }

            //Hợp lệ trả về kh
            return kh;
        }
        public async Task DeleteDM(Guid id)
        {
           var nhanVien = await _context.nhanViens.FindAsync(id);
            if (nhanVien != null)
            {
                _context.nhanViens.Remove(nhanVien);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<NhanVien>> GetAllNhaVien()
        {
            return await _context.nhanViens.ToListAsync();
        }
        public async Task<NhanVien> GetByEmail(string email)
        {
            return await _context.nhanViens.FirstOrDefaultAsync(kh => kh.Email == email);
        }

        public async Task<NhanVien> GetBySDT(string sdT)
        {
            return await _context.nhanViens.FirstOrDefaultAsync(kh => kh.SoDienThoai == sdT);
        }
        public async Task<NhanVien> GetIdNhanVien(Guid id)
        {
            return await _context.nhanViens.FindAsync(id);
        }

        public async Task<NhanVien> UpdateNV(NhanVien nv)
        {
            _context.Entry(nv).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return nv;
        }
    }
}
