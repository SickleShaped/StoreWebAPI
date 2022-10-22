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
    public class UserConfiruration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.UserId);
            builder.HasIndex(user => user.UserId).IsUnique();

            builder.Property(user => user.Name).HasMaxLength(28);

            builder.Property(user => user.LastName).HasMaxLength(28);

            builder.Property(user => user.Email).IsRequired();

            builder.Property(user=>user.HashPassord).IsRequired();

            builder.Property(user => user.Username).IsRequired().HasMaxLength(28);

        }
    }
}
