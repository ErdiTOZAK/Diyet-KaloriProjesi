using EF_DietaryProject.Entities.Base;
using EF_DietaryProject.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.Entities.Entities;

public class Dish : BaseEntity
{
    public DateTime MealDate { get; set; }
    public float CaloriesTaken { get; set; } = 0;

    //Nav prop
    public int AppUserDetailId { get; set; }
    public virtual AppUserDetail AppUserDetail { get; set; }

    //Nav prop
    public int MealId { get; set; }
    public virtual Meal Meal { get; set; }

    //Nav prop
    public List<DishDetail> DishDetails { get; set; }
}
