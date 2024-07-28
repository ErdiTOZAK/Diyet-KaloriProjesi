using EF_DietaryProject.DAL;
using EF_DietaryProject.Entities.Entities;
using EF_DietaryProject.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.FoodCategoryServices;

public class FoodCategoryService : IFoodCategoryService
{
    public bool Add(FoodCategory foodCategory)
    {
        if (foodCategory == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.FoodCategoryRepository.Add(foodCategory);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    public bool Delete(int foodCategoryId)
    {
        if (foodCategoryId == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.FoodCategoryRepository.Remove(foodCategoryId);

        if (result == null)
        {
            return false;
        }
        return true;
    }

        public List<FoodCategory> GetAll()
    {
        return UnitOfWork.Instance.FoodCategoryRepository.GetAll();
    }

    public FoodCategory GetById(int foodCategoryId)
    {
        if (foodCategoryId == null)
        {
            return null;
        }
        return UnitOfWork.Instance.FoodCategoryRepository.GetById(foodCategoryId);
    }

    public bool Update(FoodCategory foodCategory)
    {
        if (foodCategory == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.FoodCategoryRepository.Update(foodCategory);

        if (result == null)
        {
            return false;
        }
        return true;
    }
}
