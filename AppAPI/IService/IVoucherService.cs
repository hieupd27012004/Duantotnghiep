﻿using AppAPI.IRepository;
using AppData.Model;

namespace AppAPI.IService
{
    public interface IVoucherService
    {
        Task<List<Voucher>> GetVouchersAsync();
        Task<Voucher> GetVoucherByIdAsync(Guid id);
        Task<bool> CreateAsync(VoucherDto voucher, List<Guid> selectedKhachHangIds);
        Task<bool> UpdateAsync(Voucher voucher);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> AddLichSuSuDungVoucherAsync(LichSuSuDungVoucher lichSuSuDungVoucher);
        Task<List<KhachHang>> GetKhachHangDaNhanVoucherAsync(Guid voucherId);

    }
}
