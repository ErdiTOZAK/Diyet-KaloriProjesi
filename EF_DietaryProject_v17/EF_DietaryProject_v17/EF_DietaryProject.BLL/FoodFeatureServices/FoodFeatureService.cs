using EF_DietaryProject.DAL;
using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.FoodFeatureService
{
    public class FoodFeatureService : IFoodFeatureService
    {
        public bool Add(FoodFeature foodFeature)
        {
            if (foodFeature == null)
            {
                return false;
            }

            var result = UnitOfWork.Instance.FoodFeatureRepository.Add(foodFeature);

            if (result == null)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int foodFeatureId)
        {
            if (foodFeatureId == null)
            {
                return false;
            }

            var result = UnitOfWork.Instance.FoodFeatureRepository.Remove(foodFeatureId);

            if (result == null)
            {
                return false;
            }
            return true;
        }

        public List<FoodFeature> GetAll()
        {
            return UnitOfWork.Instance.FoodFeatureRepository.GetAll().ToList();
        }

        public FoodFeature GetById(int foodFeatureId)
        {
            if (foodFeatureId == null)
            {
                return null;
            }
            return UnitOfWork.Instance.FoodFeatureRepository.GetById(foodFeatureId);
        }

        public bool Update(FoodFeature foodFeature)
        {
            if (foodFeature == null)
            {
                return false;
            }

            var result = UnitOfWork.Instance.FoodFeatureRepository.Update(foodFeature);

            if (result == null)
            {
                return false;
            }
            return true;
        }
    }
}
