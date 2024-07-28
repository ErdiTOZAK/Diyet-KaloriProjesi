using EF_DietaryProject.DAL;
using EF_DietaryProject.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.MealServices;

public class MealService : IMealService
{
    public bool Add(Meal Meal)
    {
        if (Meal == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.MealRepository.Add(Meal);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    public bool Delete(int MealId)
    {
        if (MealId == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.MealRepository.Remove(MealId);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    public List<Meal> GetAll()
    {
        return UnitOfWork.Instance.MealRepository.GetAll();
    }

    public Meal GetById(int MealId)
    {
        if (MealId == null)
        {
            return null;
        }
        return UnitOfWork.Instance.MealRepository.GetById(MealId);
    }



    public bool Update(Meal Meal)
    {
        if (Meal == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.MealRepository.Update(Meal);

        if (result == null)
        {
            return false;
        }
        return true;
    }

}
