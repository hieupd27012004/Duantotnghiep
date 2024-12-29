using APPMVC.IService;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

public class PromotionStatusUpdaterService : IHostedService, IDisposable
{
    private readonly IPromotionService _promotionService;
    private readonly ILogger<PromotionStatusUpdaterService> _logger;
    private Timer _timer;

    public PromotionStatusUpdaterService(IPromotionService promotionService, ILogger<PromotionStatusUpdaterService> logger)
    {
        _promotionService = promotionService;
        _logger = logger;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(UpdatePromotionStatus, null, TimeSpan.Zero, TimeSpan.FromSeconds(10));
        return Task.CompletedTask;
    }

    private async void UpdatePromotionStatus(object state)
    {
        try
        {
            var promotions = await _promotionService.GetPromotionsAsync();
            var currentDateTime = DateTime.Now;

            foreach (var promotion in promotions)
            {
                if (promotion.NgayKetThuc < currentDateTime && promotion.TrangThai == 1)
                {
                    promotion.TrangThai = 0;
                    await _promotionService.UpdateAsync(promotion);
                    _logger.LogInformation($"Updated promotion status to inactive for Id: {promotion.IdPromotion}");
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while updating promotion statuses");
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _timer?.Dispose();
    }
}