using AppData.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppAPI.IRepository
{
    public interface IDayGiayRepo
    {
        List<DayGiay> GetDayGiay(string? name);
        DayGiay GetDayGiayById(Guid id);
        bool Create(DayGiay daygiay);
        bool Update(DayGiay DayGiay);
        bool Delete(Guid id);
    }
}