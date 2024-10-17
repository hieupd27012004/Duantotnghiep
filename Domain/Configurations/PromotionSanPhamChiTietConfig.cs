using AppData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Configurations
{
    public class PromotionSanPhamChiTietConfig : IEntityTypeConfiguration<PromotionSanPhamChiTiet>
    {
        public void Configure(EntityTypeBuilder<PromotionSanPhamChiTiet> builder)
        {
            builder.HasKey(psct => new {psct.IdPromotion, psct.IdSanPhamChiTiet});

            builder.HasOne(psct => psct.Promotion)
                .WithMany(p => p.PromotionSanPhamChiTiets)
                .HasForeignKey(psct => psct.IdPromotion);
            builder.HasOne(psct => psct.SanPhamChiTiet)
                .WithMany(spct => spct.PromotionSanPhamChiTiets)
                .HasForeignKey(psct => psct.IdSanPhamChiTiet);
        }
    }
}
