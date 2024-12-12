using AppData.ViewModel;
using APPMVC.IService;
using Newtonsoft.Json;

namespace APPMVC.Service
{
    public class ThongKeService : IThongKeService
    {
        private readonly HttpClient _httpClient;
        public ThongKeService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7198");
        }
        public async Task<List<ThongKeNgay>> GetStatisticsByDate(DateTime date)
        {
            var respone = await _httpClient.GetAsync($"/api/ThongKe/ThongKeTheoNgay?date={date}");
            respone.EnsureSuccessStatusCode();
           
            return await respone.Content.ReadFromJsonAsync<List<ThongKeNgay>>();

        }
        public async Task<List<ThongKeNgay>> GetStatisticsByWeek(DateTime date)
        {
            var respone = await _httpClient.GetAsync($"/api/ThongKe/ThongKeTheoTuan?date={date}");
            respone.EnsureSuccessStatusCode();
            return await respone.Content.ReadFromJsonAsync<List<ThongKeNgay>>();
        }
        public async Task<List<ThongKeNgay>> GetStatisticsByMonth(int year, int month)
        {
            var respone = await _httpClient.GetAsync($"/api/ThongKe/ThongKeTheoThang?year={year}&month={month}");
            respone.EnsureSuccessStatusCode();
            return await respone.Content.ReadFromJsonAsync<List<ThongKeNgay>>();
        }
        public async Task<List<ThongKeThang>> GetStatisticsByYear(int year)
        {
            var respone = await _httpClient.GetAsync($"/api/ThongKe/ThongKeTheoNam?year={year}");
            respone.EnsureSuccessStatusCode();
            return await respone.Content.ReadFromJsonAsync<List<ThongKeThang>>();
        }

        public async Task<ThongKeTongQuan> GetTotalOrdersAndRevenue()
        {
            var response = await _httpClient.GetAsync($"/api/ThongKe/TongQuan");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ThongKeTongQuan>();
        }
        public async Task<List<ThongKeKhoangThoiGian>> GetStatisticsByTimeRange(DateTime startDate, DateTime endDate)
        {
            var response = await _httpClient.GetAsync($"/api/ThongKe/ThongKeTheoKhoangThoiGian?startDate={startDate}&endDate={endDate}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<ThongKeKhoangThoiGian>>();
        }
        public async Task<List<TopSellingProductViewModel>> GetTopSellingProductsAsync(DateTime? startDate, DateTime? endDate)
        {
            var response = await _httpClient.GetAsync($"/api/ThongKe/TopSellingProducts?startDate={startDate}&endDate={endDate}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<TopSellingProductViewModel>>();
        }
    }
}
