using AppAPI.Repository;
using AppAPI.Service;
using AppData;
using Microsoft.Data.SqlClient;
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
// Dây giày
builder.Services.AddTransient<IServicegiaygiay, Servicegiaygiay>();
builder.Services.AddTransient<IRepogiaygiay, Repogiaygiay>();
//Chất liêu
builder.Services.AddTransient<IChatLieuService, ChatLieuService>();
builder.Services.AddTransient<IChatLieuRepo, ChatLieuRepo>();
// Kiểu dáng
builder.Services.AddTransient<IServiceKieuDang, ServiceKieuDang>();
builder.Services.AddTransient<IRepoKieuDang, RepoKieuDang>();

//Danh mục
builder.Services.AddTransient<IDanhMucService, DanhMucService>();
builder.Services.AddTransient<IRepoDanhMuc, RepoDanhMuc>();

// THương Hiệu
builder.Services.AddTransient<IThuongHiepRepo, ThuongHieuRepo>();
builder.Services.AddTransient<IThuongHieuService, ThuongHieuService>();


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
