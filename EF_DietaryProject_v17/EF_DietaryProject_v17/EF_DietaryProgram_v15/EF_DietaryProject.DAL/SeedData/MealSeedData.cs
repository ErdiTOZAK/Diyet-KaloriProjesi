using EF_DietaryProject.Entities.EnumEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.SeedData;

public class MealSeedData : IEntityTypeConfiguration<Meal>
{
    public void Configure(EntityTypeBuilder<Meal> builder)
    {
        builder.HasData(
            new Meal
            {
                Id = 1,
                Name = "Breakfast",
                //Status = Entities.Enums.Status.Added,
            },
            new Meal
            {
                Id = 2,
                Name = "Lunch",
                //Status = Entities.Enums.Status.Added,
            },
            new Meal
            {
                Id = 3,
                Name = "Dinner",
                //Status = Entities.Enums.Status.Added,
            },
            new Meal
            {
                Id = 4,
                Name = "Snack",
                //Status = Entities.Enums.Status.Added,
            });
    }
}
