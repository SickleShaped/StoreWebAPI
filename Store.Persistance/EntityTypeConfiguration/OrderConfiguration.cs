using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Store.Persistance.EntityTypeCpnfiguration
{
    public class OrderConfiruration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(order => order.OrderId);
            builder.HasIndex(order => order.OrderId).IsUnique();

            builder.Property(order =>order.UserId).IsRequired();

            builder.Property(order => order.TotalCost).IsRequired();
        }
    }
}
