using EF_DietaryProject.Entities.Entities;
using EF_DietaryProject.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.FoodCategoryServices;

public interface IFoodCategoryService
{
    bool Add(FoodCategory foodCategory);
    bool Update(FoodCategory foodCategory);
    bool Delete(int foodCategoryId);
    FoodCategory GetById(int foodCategoryId);
    List<FoodCategory> GetAll();
}
