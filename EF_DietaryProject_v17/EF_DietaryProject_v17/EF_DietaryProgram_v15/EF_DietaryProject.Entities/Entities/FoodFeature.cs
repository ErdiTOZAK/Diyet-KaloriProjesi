using EF_DietaryProject.Entities.Base;
using EF_DietaryProject.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.Entities.Entities;

public class FoodFeature : BaseEntity
{
    //Nav prop
    public int FoodCategoryId { get; set; }
    public virtual FoodCategory FoodCategory { get; set; }

    //Nav prop
    public int FoodId { get; set; }
    public virtual Food Food { get; set; }

    //Nav prop
    public int MealId { get; set; }
    public virtual Meal Meal { get; set; }
}
