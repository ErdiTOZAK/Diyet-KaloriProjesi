using EF_DietaryProject.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.EnumEntitiesRepositoryInterfaces
{
    public interface IFoodCategoryRepository : IBaseEnumRepository<FoodCategory>
    {
    }
}
