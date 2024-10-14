
using AppAPI.IRepository;
using AppAPI.IService;
using AppAPI.Repository;
using AppAPI.Service;
using AppData;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AppDbcontext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
//Khach Hang
builder.Services.AddTransient<IKhachHangService, KhachHangService>();
builder.Services.AddTransient<IKhachHangRepo, KhachHangRepo>();
//Chức Vụ
builder.Services.AddTransient<IChucVuService, ChucVuService>();
builder.Services.AddTransient<IChucVuRepo, ChucVuRepo>();
// Dây giày
builder.Services.AddTransient<IDayGiayService, DayGiayService>();
builder.Services.AddTransient<IDayGiayRepo, DayGiayRepo>();

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

//Hình Ảnh
builder.Services.AddTransient<IHinhAnhRepo, HinhAnhRepo>();


// Sản Phẩm Chi Tiết
builder.Services.AddTransient<ISanPhamChiTietService, SanPhamChiTietService>();
builder.Services.AddTransient<ISanPhamChiTietRepo, SanPhamChiTietRepo>();

// Sản Phẩm
builder.Services.AddTransient<ISanPhamService, SanPhamService>();
builder.Services.AddTransient<ISanPhamRepo, SanPhamRepo>();

// Nhân Viên
builder.Services.AddTransient<INhanVienService, NhanVienService>();
builder.Services.AddTransient<INhanVienRepo, NhanVienRepo>();

// Kích Cỡ
builder.Services.AddTransient<IKichCoService, KichCoService>();
builder.Services.AddTransient<IKichCoRepo, KichCoRepo > ();

// Màu Sắc
builder.Services.AddTransient<IMauSacService, MauSacService>();
builder.Services.AddTransient<IMauSacRepo, MauSacRepo>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}


app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
