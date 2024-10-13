using APPMVC.IService;
using APPMVC.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Thời gian tồn tại của session
});

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

builder.Services.AddTransient<IKhachHangService, KhachHangService>();
builder.Services.AddTransient<IDayGiayService, DayGiayService>();
builder.Services.AddTransient<IDanhMucService, DanhMucService>();
builder.Services.AddTransient<IThuongHieuService, ThuongHieuService>();
builder.Services.AddTransient<IChatLieuService, ChatLieuService>();
builder.Services.AddTransient<IKieuDangService, KieuDangService>();
builder.Services.AddTransient<IHinhAnhService, HinhAnhService>();
//Nhân Viên
builder.Services.AddTransient<INhanVienService, NhanVienService>();
//Chức vụ
builder.Services.AddTransient<IChucVuService, ChucVuService>();

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

var app = builder.Build();
app.UseSession();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
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
