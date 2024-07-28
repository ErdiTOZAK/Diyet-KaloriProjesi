using EF_DietaryProject.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.Configurations;

public class DishConfiguration : BaseEntityConfiguration<Dish>
{
    public override void Configure(EntityTypeBuilder<Dish> builder)
    {
        builder.Property(x => x.MealDate).IsRequired();
        builder.Property(x => x.CaloriesTaken).IsRequired().HasDefaultValue(0);

        base.Configure(builder);
    }
}
