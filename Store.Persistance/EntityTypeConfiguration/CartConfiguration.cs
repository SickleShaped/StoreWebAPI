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
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(cart => cart.UserId);
            builder.HasIndex(cart => cart.UserId).IsUnique();

            builder.Property(cart => cart.TotalCost).IsRequired();
        }
    }
}
