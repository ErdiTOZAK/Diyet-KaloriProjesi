using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.FoodService;

public interface IFoodService
{
    bool Add(Food food);
    bool Update(Food food);
    bool Delete(int foodId);
    Food GetById(int foodId);
    List<Food> GetAll();
}
