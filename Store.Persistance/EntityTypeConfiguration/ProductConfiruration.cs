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
    public class ProductConfiruration: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(product => product.Id);
            builder.HasIndex(product => product.Id).IsUnique();

            builder.Property(product => product.ProductName).HasMaxLength(128).IsRequired();

            builder.Property(product => product.ProductDescription).HasMaxLength(2048);

            builder.Property(product => product.ProductCost).IsRequired();


        }
    }
}
