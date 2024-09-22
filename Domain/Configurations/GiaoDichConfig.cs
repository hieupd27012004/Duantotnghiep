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
	public class GiaoDichConfig : IEntityTypeConfiguration<GiaoDich>
	{
		public void Configure(EntityTypeBuilder<GiaoDich> builder)
		{
			builder.HasKey(p => p.IdGiaoDich);

			builder.HasOne(p => p.HoaDon)
				.WithMany(p => p.GiaoDichs)
				.HasForeignKey(p => p.IdHoaDon)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(p => p.TrangThai)
				.WithMany(p => p.GiaoDich)
				.HasForeignKey(p => p.IdTrangThai)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
