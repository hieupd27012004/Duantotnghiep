using AppData.Model;

namespace APPMVC.Service
{
	public interface IServicegiaygiay
	{
		Task<List<DayGiay>> GetDayGiay();
		Task<DayGiay> GetDayGiayById(Guid id);
		Task Create(DayGiay daygiay);
		Task Update(DayGiay DayGiay);
		Task Delete(Guid id);
	}
}
