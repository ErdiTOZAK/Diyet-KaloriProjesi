using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.DishService;

public interface IDishService
{
    bool Add(Dish dish);
    bool Update(Dish dish);
    bool Delete(int dishId);
    Dish GetById(int dishId);
    List<Dish> GetAll();
}
