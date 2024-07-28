using EF_DietaryProject.Entities.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.Configurations;

public class AppUserDetailConfiguration : BaseEntityConfiguration<AppUserDetail>
{
    public override void Configure(EntityTypeBuilder<AppUserDetail> builder)
    {
        builder.Property(x => x.Firstname).IsRequired().HasMaxLength(128);
        builder.Property(x => x.Lastname).IsRequired().HasMaxLength(128);
        builder.Property(x => x.BirthDate).IsRequired();
        builder.Ignore(x => x.Age);
        builder.Property(x => x.Height).IsRequired();
        builder.Property(x => x.Weight).IsRequired();

        base.Configure(builder);
    }
}
