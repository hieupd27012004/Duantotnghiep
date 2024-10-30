using AppAPI.Service;
using AppData;
using APPMVC.IService;
using APPMVC.Service;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbcontext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 10485760; // 10 MB
});

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Thời gian tồn tại của session
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

//builder.Services.AddTransient<IDayGiayService, DayGiayService>();
builder.Services.AddTransient<IDanhMucService, DanhMucService>();
builder.Services.AddTransient<IThuongHieuService, ThuongHieuService>();
builder.Services.AddTransient<IChatLieuService, ChatLieuService>();
builder.Services.AddTransient<IKieuDangService, KieuDangService>();
builder.Services.AddTransient<IHinhAnhService, HinhAnhService>();
builder.Services.AddTransient<IPromotionService, PromotionService>();

builder.Services.AddTransient<IDeGiayService, DeGiayService>();
builder.Services.AddTransient<IKichCoService, KichCoService>();
builder.Services.AddTransient<IMauSacService, MauSacService>();
builder.Services.AddTransient<ISanPhamService, SanPhamService>();
builder.Services.AddTransient<ISanPhamChiTietService, SanPhamChiTietService>();
builder.Services.AddTransient<INhanVienService, NhanVienService>();
builder.Services.AddTransient<IKhachHangService, KhachHangService>();
builder.Services.AddTransient<IChucVuService, ChucVuService>();

builder.Services.AddTransient<ISanPhamChiTietMauSacService, SanPhamChiTietMauSacService>();
builder.Services.AddTransient<ISanPhamChiTietKichCoService, SanPhamChiTietKichCoService>();
builder.Services.AddTransient<IVoucherService, VoucherService>();



var app = builder.Build();
app.UseSession();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
app.UseSession();

app.UseHttpsRedirection();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseStaticFiles();

app.UseCors("AllowAll");
app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{area=Admin}/{controller=HomeAdmin}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=HomeAdmin}/{action=Index}/{id?}");

    // Cấu hình route cho area Customer
    endpoints.MapControllerRoute(
        name: "Client",
        pattern: "{area:exists}/{controller=HomeClient}/{action=Index}/{id?}",
        defaults: new { area = "Client", controller = "HomeClient", action = "Index" });
});

app.Run();
