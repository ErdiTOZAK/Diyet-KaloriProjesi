using EF_DietaryProject.Entities.Entities;
using EF_DietaryProject.Entities.EnumEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.SeedData
{
    internal class FoodFeatureSeedData : IEntityTypeConfiguration<FoodFeature>
    {
        public void Configure(EntityTypeBuilder<FoodFeature> builder)
        {
            List<FoodFeature> foodFeatures = new List<FoodFeature>()
            {
                  // 1.MainCourse için;

              new FoodFeature { FoodId = 1, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 1, FoodCategoryId = 1, MealId = 3 },
              new FoodFeature { FoodId = 2, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 2, FoodCategoryId = 1, MealId = 3 },
              new FoodFeature { FoodId = 3, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 3, FoodCategoryId = 1, MealId = 3 },
              new FoodFeature { FoodId = 4, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 4, FoodCategoryId = 1, MealId = 3 },
              new FoodFeature { FoodId = 5, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 5, FoodCategoryId = 1, MealId = 3 },
              new FoodFeature { FoodId = 6, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 6, FoodCategoryId = 1, MealId = 3 },
              new FoodFeature { FoodId = 7, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 7, FoodCategoryId = 1, MealId = 3 },
              new FoodFeature { FoodId = 8, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 8, FoodCategoryId = 1, MealId = 3 },
              new FoodFeature { FoodId = 9, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 9, FoodCategoryId = 1, MealId = 3 },
              new FoodFeature { FoodId = 10, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 10, FoodCategoryId = 1, MealId = 3 },
              new FoodFeature { FoodId = 11, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 11, FoodCategoryId = 1, MealId = 3 },
              new FoodFeature { FoodId = 12, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 12, FoodCategoryId = 1, MealId = 3 },
              new FoodFeature { FoodId = 13, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 13, FoodCategoryId = 1, MealId = 3 },
              new FoodFeature { FoodId = 14, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 14, FoodCategoryId = 1, MealId = 3 },
              new FoodFeature { FoodId = 15, FoodCategoryId = 1, MealId = 2 },
              new FoodFeature { FoodId = 15, FoodCategoryId = 1, MealId = 3 },

            // 2.Side Meal için; 

              new FoodFeature { FoodId = 16, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 16, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 17, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 18, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 18, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 19, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 19, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 20, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 20, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 21, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 22, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 23, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 23, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 24, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 24, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 25, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 25, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 26, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 26, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 27, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 27, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 28, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 28, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 29, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 29, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 30, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 30, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 31, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 31, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 32, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 32, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 33, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 34, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 34, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 35, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 35, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 36, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 36, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 37, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 37, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 38, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 38, FoodCategoryId = 2, MealId = 3 },
              new FoodFeature { FoodId = 39, FoodCategoryId = 2, MealId = 2 },
              new FoodFeature { FoodId = 39, FoodCategoryId = 2, MealId = 3 },

                 // 3. Soup için;
         
              new FoodFeature { FoodId = 40, FoodCategoryId = 3, MealId = 2 },
              new FoodFeature { FoodId = 40, FoodCategoryId = 3, MealId = 3 },
              new FoodFeature { FoodId = 41, FoodCategoryId = 3, MealId = 2 },
              new FoodFeature { FoodId = 41, FoodCategoryId = 3, MealId = 3 },
              new FoodFeature { FoodId = 42, FoodCategoryId = 3, MealId = 2 },
              new FoodFeature { FoodId = 42, FoodCategoryId = 3, MealId = 3 },
              new FoodFeature { FoodId = 43, FoodCategoryId = 3, MealId = 2 },
              new FoodFeature { FoodId = 43, FoodCategoryId = 3, MealId = 3 },
              new FoodFeature { FoodId = 44, FoodCategoryId = 3, MealId = 2 },
              new FoodFeature { FoodId = 44, FoodCategoryId = 3, MealId = 3 },
              new FoodFeature { FoodId = 45, FoodCategoryId = 3, MealId = 2 },
              new FoodFeature { FoodId = 45, FoodCategoryId = 3, MealId = 3 },
              new FoodFeature { FoodId = 46, FoodCategoryId = 3, MealId = 2 },
              new FoodFeature { FoodId = 46, FoodCategoryId = 3, MealId = 3 },
              new FoodFeature { FoodId = 47, FoodCategoryId = 3, MealId = 2 },
              new FoodFeature { FoodId = 47, FoodCategoryId = 3, MealId = 3 },
              new FoodFeature { FoodId = 48, FoodCategoryId = 3, MealId = 2 },
              new FoodFeature { FoodId = 48, FoodCategoryId = 3, MealId = 3 },
              new FoodFeature { FoodId = 49, FoodCategoryId = 3, MealId = 2 },
              new FoodFeature { FoodId = 49, FoodCategoryId = 3, MealId = 3 },

               // 4. Grain için;

              new FoodFeature { FoodId = 50, FoodCategoryId = 4, MealId = 2 },
              new FoodFeature { FoodId = 50, FoodCategoryId = 4, MealId = 3 },
              new FoodFeature { FoodId = 51, FoodCategoryId = 4, MealId = 2 },
              new FoodFeature { FoodId = 51, FoodCategoryId = 4, MealId = 3 },
              new FoodFeature { FoodId = 52, FoodCategoryId = 4, MealId = 2 },
              new FoodFeature { FoodId = 52, FoodCategoryId = 4, MealId = 3 },
              new FoodFeature { FoodId = 53, FoodCategoryId = 4, MealId = 2 },
              new FoodFeature { FoodId = 53, FoodCategoryId = 4, MealId = 3 },
              new FoodFeature { FoodId = 54, FoodCategoryId = 4, MealId = 2 },
              new FoodFeature { FoodId = 54, FoodCategoryId = 4, MealId = 3 },
              new FoodFeature { FoodId = 55, FoodCategoryId = 4, MealId = 2 },
              new FoodFeature { FoodId = 55, FoodCategoryId = 4, MealId = 3 },
              new FoodFeature { FoodId = 56, FoodCategoryId = 4, MealId = 2 },
              new FoodFeature { FoodId = 56, FoodCategoryId = 4, MealId = 3 },
              new FoodFeature { FoodId = 57, FoodCategoryId = 4, MealId = 2 },
              new FoodFeature { FoodId = 57, FoodCategoryId = 4, MealId = 3 },
              new FoodFeature { FoodId = 58, FoodCategoryId = 4, MealId = 2 },
              new FoodFeature { FoodId = 58, FoodCategoryId = 4, MealId = 3 },
              new FoodFeature { FoodId = 59, FoodCategoryId = 4, MealId = 2 },
              new FoodFeature { FoodId = 59, FoodCategoryId = 4, MealId = 3 },


                       // 5. For Brekafast için;

              new FoodFeature { FoodId = 60, FoodCategoryId = 5, MealId = 2 },
              new FoodFeature { FoodId = 60, FoodCategoryId = 5, MealId = 3 },
              new FoodFeature { FoodId = 61, FoodCategoryId = 5, MealId = 2 },
              new FoodFeature { FoodId = 61, FoodCategoryId = 5, MealId = 3 },
              new FoodFeature { FoodId = 62, FoodCategoryId = 5, MealId = 2 },
              new FoodFeature { FoodId = 62, FoodCategoryId = 5, MealId = 3 },
              new FoodFeature { FoodId = 63, FoodCategoryId = 5, MealId = 2 },
              new FoodFeature { FoodId = 63, FoodCategoryId = 5, MealId = 3 },
              new FoodFeature { FoodId = 64, FoodCategoryId = 5, MealId = 2 },
              new FoodFeature { FoodId = 64, FoodCategoryId = 5, MealId = 3 },
              new FoodFeature { FoodId = 65, FoodCategoryId = 5, MealId = 2 },
              new FoodFeature { FoodId = 65, FoodCategoryId = 5, MealId = 3 },
              new FoodFeature { FoodId = 66, FoodCategoryId = 5, MealId = 2 },
              new FoodFeature { FoodId = 66, FoodCategoryId = 5, MealId = 1 },
              new FoodFeature { FoodId = 67, FoodCategoryId = 5, MealId = 2 },
              new FoodFeature { FoodId = 67, FoodCategoryId = 5, MealId = 3 },
              new FoodFeature { FoodId = 68, FoodCategoryId = 5, MealId = 2 },
              new FoodFeature { FoodId = 68, FoodCategoryId = 5, MealId = 1 },
              new FoodFeature { FoodId = 69, FoodCategoryId = 5, MealId = 2 },
              new FoodFeature { FoodId = 69, FoodCategoryId = 5, MealId = 1 },

              // 6. Snack için;

              new FoodFeature { FoodId = 70, FoodCategoryId = 6, MealId = 2 },
              new FoodFeature { FoodId = 70, FoodCategoryId = 6, MealId = 3 },
              new FoodFeature { FoodId = 71, FoodCategoryId = 6, MealId = 2 },
              new FoodFeature { FoodId = 71, FoodCategoryId = 6, MealId = 3 },
              new FoodFeature { FoodId = 72, FoodCategoryId = 6, MealId = 2 },
              new FoodFeature { FoodId = 72, FoodCategoryId = 6, MealId = 3 },
              new FoodFeature { FoodId = 73, FoodCategoryId = 6, MealId = 4 },
              new FoodFeature { FoodId = 73, FoodCategoryId = 6, MealId = 3 },
              new FoodFeature { FoodId = 74, FoodCategoryId = 6, MealId = 2 },
              new FoodFeature { FoodId = 74, FoodCategoryId = 6, MealId = 3 },
              new FoodFeature { FoodId = 75, FoodCategoryId = 6, MealId = 2 },
              new FoodFeature { FoodId = 75, FoodCategoryId = 6, MealId = 4 },
              new FoodFeature { FoodId = 76, FoodCategoryId = 6, MealId = 2 },
              new FoodFeature { FoodId = 76, FoodCategoryId = 6, MealId = 3 },
              new FoodFeature { FoodId = 77, FoodCategoryId = 6, MealId = 2 },
              new FoodFeature { FoodId = 77, FoodCategoryId = 6, MealId = 3 },
              new FoodFeature { FoodId = 78, FoodCategoryId = 6, MealId = 2 },
              new FoodFeature { FoodId = 78, FoodCategoryId = 6, MealId = 3 },
              new FoodFeature { FoodId = 79, FoodCategoryId = 6, MealId = 2 },
              new FoodFeature { FoodId = 79, FoodCategoryId = 6, MealId = 3 },

              // 7.Drink için;

              
              new FoodFeature { FoodId = 80, FoodCategoryId = 7, MealId = 2 },
              new FoodFeature { FoodId = 80, FoodCategoryId = 7, MealId = 3 },
              new FoodFeature { FoodId = 81, FoodCategoryId = 7, MealId = 2 },
              new FoodFeature { FoodId = 81, FoodCategoryId = 7, MealId = 3 },
              new FoodFeature { FoodId = 82, FoodCategoryId = 7, MealId = 2 },
              new FoodFeature { FoodId = 82, FoodCategoryId = 7, MealId = 3 },
              new FoodFeature { FoodId = 83, FoodCategoryId = 7, MealId = 2 },
              new FoodFeature { FoodId = 83, FoodCategoryId = 7, MealId = 3 },
              new FoodFeature { FoodId = 84, FoodCategoryId = 7, MealId = 2 },
              new FoodFeature { FoodId = 84, FoodCategoryId = 7, MealId = 3 },
              new FoodFeature { FoodId = 85, FoodCategoryId = 7, MealId = 2 },
              new FoodFeature { FoodId = 85, FoodCategoryId = 7, MealId = 3 },
              new FoodFeature { FoodId = 86, FoodCategoryId = 7, MealId = 2 },
              new FoodFeature { FoodId = 86, FoodCategoryId = 7, MealId = 3 },
              new FoodFeature { FoodId = 87, FoodCategoryId = 7, MealId = 2 },
              new FoodFeature { FoodId = 87, FoodCategoryId = 7, MealId = 3 },
              new FoodFeature { FoodId = 88, FoodCategoryId = 7, MealId = 2 },
              new FoodFeature { FoodId = 88, FoodCategoryId = 7, MealId = 3 },
              new FoodFeature { FoodId = 89, FoodCategoryId = 7, MealId = 2 },
              new FoodFeature { FoodId = 89, FoodCategoryId = 7, MealId = 3 },

              // 8.Salad için;


              new FoodFeature { FoodId = 90, FoodCategoryId = 8, MealId = 2 },
              new FoodFeature { FoodId = 90, FoodCategoryId = 8, MealId = 3 },
              new FoodFeature { FoodId = 91, FoodCategoryId = 8, MealId = 4 },
              new FoodFeature { FoodId = 91, FoodCategoryId = 8, MealId = 3 },
              new FoodFeature { FoodId = 92, FoodCategoryId = 8, MealId = 2 },
              new FoodFeature { FoodId = 92, FoodCategoryId = 8, MealId = 4 },
              new FoodFeature { FoodId = 93, FoodCategoryId = 8, MealId = 2 },
              new FoodFeature { FoodId = 93, FoodCategoryId = 8, MealId = 3 },
              new FoodFeature { FoodId = 94, FoodCategoryId = 8, MealId = 4 },
              new FoodFeature { FoodId = 94, FoodCategoryId = 8, MealId = 3 },
              new FoodFeature { FoodId = 95, FoodCategoryId = 8, MealId = 2 },
              new FoodFeature { FoodId = 95, FoodCategoryId = 8, MealId = 3 },
              new FoodFeature { FoodId = 96, FoodCategoryId = 8, MealId = 2 },
              new FoodFeature { FoodId = 96, FoodCategoryId = 8, MealId = 3 },
              new FoodFeature { FoodId = 97, FoodCategoryId = 8, MealId = 4 },
              new FoodFeature { FoodId = 97, FoodCategoryId = 8, MealId = 3 },
              new FoodFeature { FoodId = 98, FoodCategoryId = 8, MealId = 2 },
              new FoodFeature { FoodId = 98, FoodCategoryId = 8, MealId = 4 },
              new FoodFeature { FoodId = 99, FoodCategoryId = 8, MealId = 2 },
              new FoodFeature { FoodId = 99, FoodCategoryId = 8, MealId = 3 },


              // 9.Desert için;


              new FoodFeature { FoodId = 100, FoodCategoryId = 9, MealId = 2 },
              new FoodFeature { FoodId = 100, FoodCategoryId = 9, MealId = 3 },
              new FoodFeature { FoodId = 101, FoodCategoryId = 9, MealId = 2 },
              new FoodFeature { FoodId = 101, FoodCategoryId = 9, MealId = 3 },
              new FoodFeature { FoodId = 102, FoodCategoryId = 9, MealId = 2 },
              new FoodFeature { FoodId = 103, FoodCategoryId = 9, MealId = 3 },
              new FoodFeature { FoodId = 103, FoodCategoryId = 9, MealId = 2 },
              new FoodFeature { FoodId = 104, FoodCategoryId = 9, MealId = 3 },
              new FoodFeature { FoodId = 104, FoodCategoryId = 9, MealId = 2 },
              new FoodFeature { FoodId = 105, FoodCategoryId = 9, MealId = 3 },
              new FoodFeature { FoodId = 105, FoodCategoryId = 9, MealId = 2 },
              new FoodFeature { FoodId = 106, FoodCategoryId = 9, MealId = 3 },
              new FoodFeature { FoodId = 106, FoodCategoryId = 9, MealId = 2 },
              new FoodFeature { FoodId = 107, FoodCategoryId = 9, MealId = 3 },
              new FoodFeature { FoodId = 107, FoodCategoryId = 9, MealId = 2 },
              new FoodFeature { FoodId = 108, FoodCategoryId = 9, MealId = 3 },
              new FoodFeature { FoodId = 108, FoodCategoryId = 9, MealId = 2 },
              new FoodFeature { FoodId = 109, FoodCategoryId = 9, MealId = 3 },
              new FoodFeature { FoodId = 109, FoodCategoryId = 9, MealId = 2 },
              


              // 10.Fruit için;


              new FoodFeature { FoodId = 110, FoodCategoryId = 10, MealId = 2 },
              new FoodFeature { FoodId = 110, FoodCategoryId = 10, MealId = 3 },
              new FoodFeature { FoodId = 111, FoodCategoryId = 10, MealId = 4 },
              new FoodFeature { FoodId = 111, FoodCategoryId = 10, MealId = 3 },
              new FoodFeature { FoodId = 112, FoodCategoryId = 10, MealId = 2 },
              new FoodFeature { FoodId = 112, FoodCategoryId = 10, MealId = 4 },
              new FoodFeature { FoodId = 113, FoodCategoryId = 10, MealId = 2 },
              new FoodFeature { FoodId = 113, FoodCategoryId = 10, MealId = 3 },
              new FoodFeature { FoodId = 114, FoodCategoryId = 10, MealId = 4 },
              new FoodFeature { FoodId = 114, FoodCategoryId = 10, MealId = 3 },
              new FoodFeature { FoodId = 115, FoodCategoryId = 10, MealId = 2 },
              new FoodFeature { FoodId = 115, FoodCategoryId = 10, MealId = 3 },
              new FoodFeature { FoodId = 116, FoodCategoryId = 10, MealId = 2 },
              new FoodFeature { FoodId = 116, FoodCategoryId = 10, MealId = 3 },
              new FoodFeature { FoodId = 117, FoodCategoryId = 10, MealId = 4 },
              new FoodFeature { FoodId = 117, FoodCategoryId = 10, MealId = 3 },
              new FoodFeature { FoodId = 118, FoodCategoryId = 10, MealId = 2 },
              new FoodFeature { FoodId = 118, FoodCategoryId = 10, MealId = 4 },
              new FoodFeature { FoodId = 119, FoodCategoryId = 10, MealId = 2 },
              new FoodFeature { FoodId = 119, FoodCategoryId = 10, MealId = 3 }
            };

            for (int i = 0; i < foodFeatures.Count; i++)
            {
                foodFeatures[i].Id = i + 1;
            }

            builder.HasData(foodFeatures);
        }
    }
}
