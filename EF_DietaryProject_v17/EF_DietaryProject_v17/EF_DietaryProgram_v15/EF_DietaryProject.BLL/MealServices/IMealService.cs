using EF_DietaryProject.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.MealServices;

public interface IMealService
{
    bool Add(Meal Meal);
    bool Update(Meal Meal);
    bool Delete(int MealId);
    Meal GetById(int MealId);
    List<Meal> GetAll();
}
