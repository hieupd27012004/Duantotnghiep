using AppAPI.Repository;
using AppAPI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowAll",
//        builder =>
//        {
//            builder
//                .AllowAnyOrigin()
//                .AllowAnyMethod()
//                .AllowAnyHeader();
//        });
//});


//DanhMuc
builder.Services.AddTransient<IDanhMucService, DanhMucService>();
builder.Services.AddTransient<IRepoDanhMuc, RepoDanhMuc>();
//Thuong Hieu
builder.Services.AddTransient<IThuongHieuService, ThuongHieuService>();
builder.Services.AddTransient<IThuongHiepRepo, ThuongHieuRepo>();
//Chat Li?u
builder.Services.AddTransient<IChatLieuService, ChatLieuService>();
builder.Services.AddTransient<IChatLieuRepo, ChatLieuRepo>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}


//app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
