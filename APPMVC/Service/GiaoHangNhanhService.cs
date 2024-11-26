using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class GiaoHangNhanhService
{
    private readonly HttpClient _httpClient;

    public GiaoHangNhanhService(string apiToken, string shopId)
    {
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("Token", apiToken);
        _httpClient.DefaultRequestHeaders.Add("ShopId", shopId);
    }

    public async Task<double> CalculateShippingFee(int fromDistrictId, string fromWardCode, int toDistrictId, string toWardCode, double height, double length, double weight, double width, int serviceTypeId)
    {
        var requestData = new
        {
            service_type_id = serviceTypeId,
            from_district_id = fromDistrictId,
            from_ward_code = fromWardCode,
            to_district_id = toDistrictId,
            to_ward_code = toWardCode,
            height = height,
            length = length,
            weight = weight,
            width = width,
            insurance_value = 0,
            coupon = (string)null,
            items = new[]
            {
            new
            {
                name = "Sample Item",
                quantity = 1,
                height = height,
                weight = weight,
                length = length,
                width = width
            }
        }
        };

        var json = JsonConvert.SerializeObject(requestData);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var request = new HttpRequestMessage(HttpMethod.Post, "https://dev-online-gateway.ghn.vn/shiip/public-api/v2/shipping-order/fee")
        {
            Content = content
        };

        // Thêm headers
        request.Headers.Add("Token", "bcf656fe-256b-11ef-9e93-f2508e67c133"); 
        request.Headers.Add("ShopId", "5120262"); 

        try
        {
            HttpResponseMessage response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var shipInfo = await response.Content.ReadAsStringAsync();
                JObject jsonResponse = JObject.Parse(shipInfo);
                return Convert.ToDouble(jsonResponse["data"]["total"]);
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new Exception($"Không thể lấy thông tin phí vận chuyển: {response.ReasonPhrase}. Nội dung lỗi: {errorContent}");
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Đã xảy ra lỗi: {ex.Message}");
        }
    }
}