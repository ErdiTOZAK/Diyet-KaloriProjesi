using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.FoodFeatureService
{
    public interface IFoodFeatureService
    {
        bool Add(FoodFeature foodFeature);
        bool Update(FoodFeature foodFeature);
        bool Delete(int foodFeatureId);
        FoodFeature GetById(int foodFeatureId);
        List<FoodFeature> GetAll();
    }
}
