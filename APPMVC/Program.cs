using APPMVC.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
builder.Services.AddTransient<IDanhMucService, DanhMucService>();
builder.Services.AddTransient<IThuongHieuService, ThuongHieuService>();
builder.Services.AddTransient<IChatLieuService, ChatLieuService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    // Tuyến đường mặc định cho Admin
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{area=Admin}/{controller=DanhMuc}/{action=GetAll}/{id?}");

    // Tuyến đường cho các area khác
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=DanhMuc}/{action=GetAll}/{id?}");

    // Cấu hình route cho area Client
    endpoints.MapControllerRoute(
        name: "Client",
        pattern: "{area:exists}/{controller=HomeClient}/{action=Index}/{id?}",
        defaults: new { area = "Client", controller = "HomeClient", action = "Index" });

	endpoints.MapControllerRoute(
	  name: "thuonghieu-list",
	  pattern: "Admin/ThuongHieu/Index",
	  defaults: new { controller = "ThuongHieu", action = "Index" });
    endpoints.MapControllerRoute(
        name: "chatlieu-list",
        pattern: "Admin/ChatLieu/Index",
        defaults: new { controller = "ChatLieu", action = "Index" });

});
app.Run();
