using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Laison.MES.Domain;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.MES.EntityFrameworkCore
{
    /// <summary>
    /// Order Mapping to db
    /// </summary>
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.ConfigureByConvention();
            // primary key
            builder.HasKey(o => o.Id);
            // object relations
            builder.HasMany(o => o.OrderLines).WithOne(ol => ol.Order).HasForeignKey(ol => ol.OrderId).IsRequired();
        }
    }
}