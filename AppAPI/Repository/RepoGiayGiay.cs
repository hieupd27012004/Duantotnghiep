using AppData;
using AppData.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAPI.Repository
{
    public class Repogiaygiay : IRepogiaygiay
    {
        private readonly AppDbcontext _context;

        public Repogiaygiay(AppDbcontext context)
        {
            _context = context;
        }

        public bool Create(DayGiay dayGiay)
        {
            try
            {
                _context.dayGiay.Add(dayGiay);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var dayGiay = _context.dayGiay.Find(id);
                if (dayGiay != null)
                {
                    _context.dayGiay.Remove(dayGiay);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DayGiay GetDayGiayById(Guid id)
        {
            var dayGiay = _context.dayGiay.Find(id);
            return dayGiay;
        }

        public List<DayGiay> GetDayGiay()
        {
            return _context.dayGiay.ToList();
        }

        public bool Update(DayGiay dayGiay)
        {
            var dayGiayUpdate = _context.dayGiay.Find(dayGiay.IdDayGiay);
            if (dayGiayUpdate != null)
            {
                dayGiayUpdate.TenDayGiay = dayGiay.TenDayGiay;
                dayGiayUpdate.NgayCapNhat = dayGiay.NgayCapNhat;
                dayGiayUpdate.NgayTao = dayGiay.NgayTao;
                dayGiayUpdate.NguoiCapNhat = dayGiay.NguoiCapNhat;
                dayGiayUpdate.NguoiTao = dayGiay.NguoiTao;
                _context.dayGiay.Update(dayGiayUpdate);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}