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
	public class SanPhamChiTietConfig : IEntityTypeConfiguration<SanPhamChiTiet>
	{
		public void Configure(EntityTypeBuilder<SanPhamChiTiet> builder)
		{
			builder.HasKey(p => p.IdSanPhamChiTiet);

			builder.HasOne(p => p.KichCo)
			   .WithMany(kh => kh.SanPhamChiTiets)
			   .HasForeignKey(p => p.IdKichCo);


			builder.HasOne(p => p.MauSac)
				   .WithMany(p => p.SanPhamChiTiets)
				   .HasForeignKey(p => p.IdMauSac);

			builder.HasOne(p => p.SanPham)
				   .WithMany(p => p.SanPhamChiTiets)
				   .HasForeignKey(p => p.IdSanPham);

			builder.HasOne(p => p.DayGiay)
				   .WithMany(p => p.SanPhamChiTiets)
				   .HasForeignKey(p => p.IdDayGiay);

			builder.HasOne(p => p.DeGiay)
				   .WithMany(p => p.SanPhamChiTiets)
				   .HasForeignKey(p => p.IdDeGiay);

			builder.HasMany(spct => spct.HinhAnhs)
				.WithOne(ha => ha.SanPhamChiTiet)
				.HasForeignKey(ha => ha.IdSanPhamChiTiet)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasMany(spct => spct.PromotionSanPhamChiTiets)
				.WithOne(psct => psct.SanPhamChiTiet)
				.HasForeignKey(psct => psct.IdSanPhamChiTiet);
		}
			//builder.HasOne(p => p.DayGiay)
			//	   .WithMany(p => p.SanPhamChiTiets)
			//	   .HasForeignKey(p => p.IdDayGiay);
        }
	}
}
