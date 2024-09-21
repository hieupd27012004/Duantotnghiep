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
	public class HoaDonChiTietConfig : IEntityTypeConfiguration<HoaDonChiTiet>
	{
		public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
		{
			builder.HasKey(p => p.IdHoaDonChiTiet);
		}
	}
}
