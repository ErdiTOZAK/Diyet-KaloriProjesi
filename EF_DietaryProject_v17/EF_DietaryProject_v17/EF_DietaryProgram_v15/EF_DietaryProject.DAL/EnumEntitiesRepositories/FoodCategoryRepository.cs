using EF_DietaryProject.DAL.EnumEntitiesRepositoryInterfaces;
using EF_DietaryProject.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.EnumEntitiesRepositories;
public class FoodCategoryRepository : BaseEnumRepository<FoodCategory>,IFoodCategoryRepository
{
}
