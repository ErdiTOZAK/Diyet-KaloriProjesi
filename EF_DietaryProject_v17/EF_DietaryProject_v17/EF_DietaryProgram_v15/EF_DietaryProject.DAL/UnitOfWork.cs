using EF_DietaryProject.DAL.EnumEntitiesRepositories;
using EF_DietaryProject.DAL.EnumEntitiesRepositoryInterfaces;
using EF_DietaryProject.DAL.Repositories;
using EF_DietaryProject.DAL.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL;

public class UnitOfWork
{
    private UnitOfWork()
    {
       
    }

    private static UnitOfWork instance;

    public static UnitOfWork Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new UnitOfWork();
            }
            return instance;
        }
    }

    public IAppUserRepository AppUserRepository
    {
        get
        {
            return new AppUserRepository();
        }
    }

    public IAppUserDetailRepository AppUserDetailRepository
    {
        get
        {
            return new AppUserDetailRepository();
        }
    }

    public IDishRepository DishRepository
    {
        get
        {
            return new DishRepository();
        }
    }

    public IDishDetailRepository DishDetailRepository
    {
        get
        {
            return new DishDetailRepository();
        }
    }

    public IFoodRepository FoodRepository
    {
        get
        {
            return new FoodRepository();
        }
    }

    public IFoodFeatureRepository FoodFeatureRepository
    {
        get
        {
            return new FoodFeatureRepository();
        }
    }
    public IFoodCategoryRepository FoodCategoryRepository
    {
        get
        {
            return new FoodCategoryRepository();
        }
    }

    public IGenderRepository GenderRepository
    {
        get
        {
            return new GenderRepository();
        }
    }

    public IMealRepository MealRepository
    {
        get
        {
            return new MealRepository();
        }
    }

    public ITargetRepository TargetRepository
    {
        get
        {
            return new TargetRepository();
        }
    }

}
