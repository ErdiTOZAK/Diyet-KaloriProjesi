using EF_DietaryProject.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.Entities.Entities;

public class Food : BaseEntity
{
    public string FoodName { get; set; }
    public float CaloryPerGram { get; set; }
    public string? PhotoPath { get; set; }

    //public byte[]? Photo { get; set; }

    //Nav prop
    public virtual List<DishDetail> DishDetails { get; set; }

    //Nav prop
    public virtual List<FoodFeature> FoodFeatures { get; set; }
}
