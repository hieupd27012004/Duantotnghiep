using AppData.Model;

namespace AppAPI.Service
{
	public interface IServicegiaygiay
	{
        List<DayGiay> GetDayGiay();
        DayGiay GetDayGiayById(Guid id);
        bool Create(DayGiay daygiay);
        bool Update(DayGiay DayGiay);
        bool Delete(Guid id);
    }
}
