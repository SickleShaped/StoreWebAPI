using Microsoft.EntityFrameworkCore;
using Store.Application.Interfaces;
using Store.Domain;
using Store.Persistance.EntityTypeCpnfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Store.Persistance
{
    public class ProductDbContext:DbContext, IProductDbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options) { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductConfiruration());
            base.OnModelCreating(builder);
        }
    }
}
