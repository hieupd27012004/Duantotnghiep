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
	public class HinhAnhConfig : IEntityTypeConfiguration<HinhAnh>
	{
		public void Configure(EntityTypeBuilder<HinhAnh> builder)
		{
			builder.HasKey(p => p.IdHinhAnh);

			builder.HasOne(p => p.SanPham)
			   .WithMany(p => p.HinhAnhs)
			   .HasForeignKey(p => p.IdSanPham);


			builder.HasOne(p => p.MauSac)
				   .WithMany(p => p.HinhAnhs)
				   .HasForeignKey(p => p.IdMauSac);
		}
	}
}
