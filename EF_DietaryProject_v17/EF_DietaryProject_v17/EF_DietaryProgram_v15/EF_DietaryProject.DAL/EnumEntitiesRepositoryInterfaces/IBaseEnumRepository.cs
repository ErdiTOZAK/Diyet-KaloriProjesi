using EF_DietaryProject.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.EnumEntitiesRepositoryInterfaces
{
    public interface IBaseEnumRepository<T> where T : BaseEnumEntity
    {
        T Add(T entity);
        T Update(T entity);
        T Remove(int id);
        T GetById(int id);
        List<T> GetAll();
    
    }
}
