using AppData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Configurations
{
	public class KichCoConfig : IEntityTypeConfiguration<KichCo>
	{
		public void Configure(EntityTypeBuilder<KichCo> builder)
		{
			builder.HasKey(p => p.IdKichCo);
            builder.HasData(
            new KichCo
            {
                IdKichCo = Guid.NewGuid(),
                TenKichCo = "Small",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new KichCo
            {
                IdKichCo = Guid.NewGuid(),
                TenKichCo = "Medium",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            },
            new KichCo
            {
                IdKichCo = Guid.NewGuid(),
                TenKichCo = "Large",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                KichHoat = 1
            }
        );
        }
	}
}
