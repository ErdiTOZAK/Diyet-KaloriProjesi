using EF_DietaryProject.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.Configurations;

public class DishDetailConfiguration : BaseEntityConfiguration<DishDetail>
{
    public override void Configure(EntityTypeBuilder<DishDetail> builder)
    {
        builder.Property(x => x.Gramme).IsRequired().HasDefaultValue(0);

        base.Configure(builder);
    }
}
