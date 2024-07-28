using EF_DietaryProject.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.Entities.Entities;

public class DishDetail : BaseEntity
{
    public float Gramme { get; set; }

    //Nav prop
    public int DishId { get; set; }
    public virtual Dish Dish { get; set; }

    //Nav prop
    public int FoodId { get; set; }
    public virtual Food Food { get; set; }

}
