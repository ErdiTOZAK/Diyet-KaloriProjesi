using EF_DietaryProject.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.RepositoryInterfaces;

public interface IBaseRepository<T> where T : BaseEntity
{
    T Add(T entity);
    T Update(T entity);
    T Remove(int id);
    T GetById(int id);
    IQueryable<T> GetAll();
}
