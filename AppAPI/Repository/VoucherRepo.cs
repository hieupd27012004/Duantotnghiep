using AppAPI.IRepository;
using AppData;
using AppData.Model;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository
{
    public class VoucherRepo : IVoucherRepo
    {
        private readonly AppDbcontext _context;
        private readonly ILogger<VoucherRepo> _logger;
        public VoucherRepo(AppDbcontext context, ILogger<VoucherRepo> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<List<Voucher>> GetVouchersAsync()
        {
            try
            {
                return await _context.vouchers.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in VoucherRepo.GetVouchersAsync: {ex.Message}");
                return new List<Voucher>();
            }
        }

        public async Task<Voucher> GetVoucherByIdAsync(Guid id)
        {
            return await _context.vouchers.FindAsync(id);
        }

        public async Task<bool> CreateAsync(Voucher voucher, List<Guid> selectedKhachHangIds)
        {
            try
            {
                _logger.LogInformation("Starting to add voucher to database.");

                if (voucher == null)
                {
                    _logger.LogWarning("Voucher is null.");
                    throw new ArgumentNullException(nameof(voucher));
                }

                // Kiểm tra các thuộc tính của voucher
                if (string.IsNullOrEmpty(voucher.MaVoucher))
                {
                    _logger.LogWarning("MaVoucher is required.");
                    throw new ArgumentException("MaVoucher is required");
                }

                if (voucher.NgayBatDau >= voucher.NgayKetThuc)
                {
                    _logger.LogWarning("NgayBatDau must be before NgayKetThuc.");
                    throw new ArgumentException("NgayBatDau must be before NgayKetThuc");
                }

                // Save the voucher to the database
                _context.vouchers.Add(voucher);
                var result = await _context.SaveChangesAsync();

                if (result > 0)
                {
                    _logger.LogInformation("Voucher saved successfully.");
                    foreach (var khachHangId in selectedKhachHangIds)
                    {
                        var lichSuSuDung = new LichSuSuDungVoucher
                        {
                            IdKhachHang = khachHangId,
                            IdVoucher = voucher.VoucherId,
                            TrangThaiVoucher = 1
                        };
                        _context.LichSuSuDungVouchers.Add(lichSuSuDung);
                    }

                    // Lưu lịch sử sử dụng voucher
                    await _context.SaveChangesAsync();
                    _logger.LogInformation($"Successfully added voucher with ID: {voucher.VoucherId}");
                    return true;
                }

                _logger.LogWarning("Failed to save voucher to database.");
                return false;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in CreateAsync method in VoucherRepo.");
                throw; // Rethrow to handle in upper layers
            }
        }
        public async Task<bool> UpdateAsync(Voucher voucher)
        {
            try
            {
                var existingVoucher = await _context.vouchers.FindAsync(voucher.VoucherId);
                if (existingVoucher == null)
                {
                    return false;
                }

                // Update properties
                existingVoucher.MaVoucher = voucher.MaVoucher;
                existingVoucher.MoTaVoucher = voucher.MoTaVoucher;
                existingVoucher.LoaiGiamGia = voucher.LoaiGiamGia;
                existingVoucher.GiaTriGiam = voucher.GiaTriGiam;
                existingVoucher.GiaTriDonHangToiThieu = voucher.GiaTriDonHangToiThieu;
                existingVoucher.SoTienToiDa = voucher.SoTienToiDa;
                existingVoucher.NgayBatDau = voucher.NgayBatDau;
                existingVoucher.NgayKetThuc = voucher.NgayKetThuc;
                existingVoucher.TongSoLuongVoucher = voucher.TongSoLuongVoucher;
                existingVoucher.SoLuongVoucherConLai = voucher.SoLuongVoucherConLai;
                existingVoucher.TrangThai = voucher.TrangThai;
                existingVoucher.NgayUpdate = voucher.NgayUpdate;
                existingVoucher.NguoiUpdate = voucher.NguoiUpdate;

                _context.vouchers.Update(existingVoucher);
                var result = await _context.SaveChangesAsync();
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in VoucherRepo.UpdateAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var voucher = await _context.vouchers.FindAsync(id);
                if (voucher != null)
                {
                    _context.vouchers.Remove(voucher);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;   
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error in VoucherRepo.DeleteAsync: {ex.Message}");
                return false;
            }
        }
        public async Task<bool> AddLichSuSuDungVoucherAsync(LichSuSuDungVoucher lichSuSuDungVoucher)
        {
            try
            {
                _context.LichSuSuDungVouchers.Add(lichSuSuDungVoucher);
                var result = await _context.SaveChangesAsync();
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in VoucherRepo.AddLichSuSuDungVoucherAsync: {ex.Message}");
                return false;
            }
        }
        public async Task<List<KhachHang>> GetKhachHangDaNhanVoucherAsync(Guid voucherId)
        {
            return await _context.LichSuSuDungVouchers
                .Where(ls => ls.IdVoucher == voucherId)
                .Select(ls => ls.KhachHang)
                .ToListAsync();
        }
    }
}
