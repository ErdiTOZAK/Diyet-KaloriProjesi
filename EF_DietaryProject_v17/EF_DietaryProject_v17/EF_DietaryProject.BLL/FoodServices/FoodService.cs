using EF_DietaryProject.DAL;
using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.FoodService;

public class FoodService : IFoodService
{
    public bool Add(Food food)
    {
        if (food == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.FoodRepository.Add(food);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    public bool Delete(int foodId)
    {
        if (foodId == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.FoodRepository.Remove(foodId);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    public List<Food> GetAll()
    {
        return UnitOfWork.Instance.FoodRepository.GetAll().ToList();
    }

    public Food GetById(int foodId)
    {
        if (foodId == null)
        {
            return null;
        }
        return UnitOfWork.Instance.FoodRepository.GetById(foodId);
    }

    public bool Update(Food food)
    {
        if (food == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.FoodRepository.Update(food);

        if (result == null)
        {
            return false;
        }
        return true;
    }
}
