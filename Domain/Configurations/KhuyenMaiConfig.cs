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
	public class KhuyenMaiConfig : IEntityTypeConfiguration<KhuyenMai>
	{
		public void Configure(EntityTypeBuilder<KhuyenMai> builder)
		{
			builder.HasKey(p => p.IdKhuyenMai);
		}
	}
}
