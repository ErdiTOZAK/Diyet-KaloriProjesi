using EF_DietaryProject.Entities.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.Configurations;

public class AppUserConfiguration : BaseEntityConfiguration<AppUser>
{
    public override void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.Property(x => x.Username).IsRequired();

        builder.Property(x => x.Password).IsRequired();

        base.Configure(builder);
    }
}
