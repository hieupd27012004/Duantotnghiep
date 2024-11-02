
using AppAPI.Hubs;
using AppAPI.IRepository;
using AppAPI.IService;
using AppAPI.ModelRestPassword;
using AppAPI.Repository;
using AppAPI.Service;
using AppData;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<RedisSettings>(builder.Configuration.GetSection("RedisSettings"));
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetValue<string>("RedisSettings:ConnectionString");
});

builder.Services.AddDbContext<AppDbcontext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});
//Khach Hang
builder.Services.AddTransient<IKhachHangService, KhachHangService>();
builder.Services.AddTransient<IKhachHangRepo, KhachHangRepo>();
//Chức Vụ
builder.Services.AddTransient<IChucVuService, ChucVuService>();
builder.Services.AddTransient<IChucVuRepo, ChucVuRepo>();
// Dây giày
//builder.Services.AddTransient<IDayGiayService, DayGiayService>();
//builder.Services.AddTransient<IDayGiayRepo, DayGiayRepo>();

//Đế Giày
builder.Services.AddTransient<IDeGiayService, DeGiayService>();
builder.Services.AddTransient<IDeGiayRepo, DeGiayRepo>();

//Chất liêu
builder.Services.AddTransient<IChatLieuService, ChatLieuService>();
builder.Services.AddTransient<IChatLieuRepo, ChatLieuRepo>();

// Kiểu dáng
builder.Services.AddTransient<IKieuDangService, KieuDangService>();
builder.Services.AddTransient<IKieuDangRepo, KieuDangRepo>();

//Danh mục
builder.Services.AddTransient<IDanhMucService, DanhMucService>();
builder.Services.AddTransient<IDanhMucRepo, DanhMucRepo>();

// THương Hiệu
builder.Services.AddTransient<IThuongHieuRepo, ThuongHieuRepo>();
builder.Services.AddTransient<IThuongHieuService, ThuongHieuService>();

// Sản Phẩm Chi Tiết
builder.Services.AddTransient<ISanPhamChiTietService, SanPhamChiTietService>();
builder.Services.AddTransient<ISanPhamChiTietRepo, SanPhamChiTietRepo>();

// Sản Phẩm
builder.Services.AddTransient<ISanPhamService, SanPhamService>();
builder.Services.AddTransient<ISanPhamRepo, SanPhamRepo>();

// Nhân Viên
builder.Services.AddTransient<INhanVienService, NhanVienService>();
builder.Services.AddTransient<INhanVienRepo, NhanVienRepo>();


//Địa Chỉ
builder.Services.AddTransient<IDiaChiService, DiaChiService>();
builder.Services.AddTransient<IDiaChiRepo, DiaChiRepo>();

//Mail

builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.AddTransient<IEmailRepo, EmailRepo>();
builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("SmtpSettings"));

var app = builder.Build();

// Kích Cỡ
builder.Services.AddTransient<IKichCoService, KichCoService>();
builder.Services.AddTransient<IKichCoRepo, KichCoRepo > ();

// Màu Sắc
builder.Services.AddTransient<IMauSacService, MauSacService>();
builder.Services.AddTransient<IMauSacRepo, MauSacRepo>();

// Hình Ảnh
builder.Services.AddTransient<IHinhAnhService, HinhAnhService>();
builder.Services.AddTransient<IHinhAnhRepo, HinhAnhRepo>();

//Promotion
builder.Services.AddTransient<IPromotionRepo, PromotionRepo>();
builder.Services.AddTransient<IPromotionService, PromotionService>();

//Voucher
builder.Services.AddTransient<IVoucherRepo, VoucherRepo>();
builder.Services.AddTransient<IVoucherService, VoucherService>();

// Sản Phẩm Chi Tiết Màu Sắc
builder.Services.AddTransient<ISanPhamChiTietMauSacRepo, SanPhamChiTietMauSacRepo>();
builder.Services.AddTransient<ISanPhamChiTietMauSacService, SanPhamChiTietMauSacService>();

// Sản Phẩm Chi Tiết Kích Cỡ
builder.Services.AddTransient<ISanPhamChiTietKichCoRepo, SanPhamChiTietKichCoRepo>();
builder.Services.AddTransient<ISanPhamChiTietKichCoService, SanPhamChiTietKichCoService>();

//Check thời gian áp dụng voucher
builder.Services.AddHostedService<VoucherStatusUpdater>();
builder.Services.AddSignalR();

var app = builder.Build();

app.UseStaticFiles();


app.UseHttpsRedirection();

app.UseAuthorization();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}


app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapHub<VoucherHub>("/voucherHub");
});


app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
