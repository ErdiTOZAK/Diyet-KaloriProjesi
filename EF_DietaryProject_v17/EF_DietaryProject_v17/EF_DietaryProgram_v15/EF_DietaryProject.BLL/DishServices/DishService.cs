using EF_DietaryProject.DAL;
using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.DishService;

public class DishService : IDishService
{
    public bool Add(Dish dish)
    {
        if (dish == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.DishRepository.Add(dish);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    public bool Delete(int dishId)
    {
        if (dishId == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.DishRepository.Remove(dishId);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    public List<Dish> GetAll()
    {
        return UnitOfWork.Instance.DishRepository.GetAll().ToList();
    }

    public Dish GetById(int dishId)
    {
        if (dishId == null)
        {
            return null;
        }
        return UnitOfWork.Instance.DishRepository.GetById(dishId);
    }

    public bool Update(Dish dish)
    {
        if (dish == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.DishRepository.Update(dish);

        if (result == null)
        {
            return false;
        }
        return true;
    }
}
