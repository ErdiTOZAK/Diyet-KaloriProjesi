using EF_DietaryProject.Entities.EnumEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.SeedData;

public class FoodCategorySeedData : IEntityTypeConfiguration<FoodCategory>
{
    public void Configure(EntityTypeBuilder<FoodCategory> builder)
    {
        builder.HasData(
            new FoodCategory
            {
                Id = 1,
                Name = "Main Course",
                
            },
            new FoodCategory
            {
                Id = 2,
                Name = "Side Meal",
                
            },
            new FoodCategory
            {
                Id = 3,
                Name = "Soup",
                
            },
            new FoodCategory
            {
                Id = 4,
                Name = "Grain",
                
            },
            new FoodCategory
            {
                Id = 5,
                Name = "For Breakfast",
                
            },
            new FoodCategory
            {
                Id = 6,
                Name = "Snack",
               
            },
            new FoodCategory
            {
                Id = 7,
                Name = "Drink",
                
            },
            new FoodCategory
            {
                Id = 8,
                Name = "Salad",
               
            },
            new FoodCategory
            {
                Id = 9,
                Name = "Desert",
                
            },
            new FoodCategory
            {
                Id = 10,
                Name = "Fruit",
                
            },
            new FoodCategory
            {
                Id = 11,
                Name = "All Categories",
            });
    }
}
