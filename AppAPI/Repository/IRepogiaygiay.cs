using AppData.Model;

namespace AppAPI.Repository
{
	public interface IRepogiaygiay
	{
		List<DayGiay> GetDayGiay();
		DayGiay GetDayGiayById(Guid id);
		bool Create(DayGiay daygiay);
		bool Update(DayGiay DayGiay);
		bool Delete(Guid id);
	}
}
