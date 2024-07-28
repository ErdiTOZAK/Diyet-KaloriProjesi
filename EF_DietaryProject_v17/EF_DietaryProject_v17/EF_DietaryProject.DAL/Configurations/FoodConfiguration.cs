using EF_DietaryProject.Entities.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.Configurations;

public class FoodConfiguration : BaseEntityConfiguration<Food>
{
    public override void Configure(EntityTypeBuilder<Food> builder)
    {
        builder.Property(x => x.CaloryPerGram).IsRequired();
        builder.Property(x => x.PhotoPath).IsRequired(false);
        //builder.Property(x => x.Photo).IsRequired(false);

        base.Configure(builder);
    }
}
