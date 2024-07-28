using EF_DietaryProject.Entities.Base;
using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.Entities.EnumEntities;

public class FoodCategory : BaseEnumEntity
{
    //Nav prop
    public virtual List<FoodFeature> FoodFeautures { get; set; }
}
