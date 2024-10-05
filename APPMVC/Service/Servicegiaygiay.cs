using AppData.Model;


namespace APPMVC.Service
{
	public class Servicegiaygiay : IServicegiaygiay
	{
		HttpClient _httpClient;

		public Servicegiaygiay()
		{
			_httpClient = new HttpClient();
			_httpClient.BaseAddress = new Uri("https://localhost:7198");
		}
        public async Task Create(DayGiay daygiay)
        {
            await _httpClient.PostAsJsonAsync("api/GiayGiay/them", daygiay);
        }

        public async Task Delete(Guid id)
		{
			await _httpClient.DeleteAsync($"api/GiayGiay/Xoa?id={id}");
		}

		public Task<List<DayGiay>> GetDayGiay()
		{
			var repo = _httpClient.GetFromJsonAsync<List<DayGiay>>("api/GiayGiay/getall");
			return repo;
		}

		public Task<DayGiay> GetDayGiayById(Guid id)
		{
			var dayGiay = _httpClient.GetFromJsonAsync<DayGiay>($"api/GiayGiay/getbyid?id={id}");
			return dayGiay;
		}

		public async Task Update(DayGiay DayGiay)
		{
			await _httpClient.PutAsJsonAsync("api/GiayGiay/Sua", DayGiay);

		}
	}
}
