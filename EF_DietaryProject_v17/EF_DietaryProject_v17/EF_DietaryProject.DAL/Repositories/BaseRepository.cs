using EF_DietaryProject.DAL.RepositoryInterfaces;
using EF_DietaryProject.Entities.Base;
using EF_DietaryProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    public T Add(T entity)
    {
        var entry = ApplicationDatabase.Context.Set<T>().Add(entity);
        ApplicationDatabase.Context.SaveChanges();
        return entry.Entity;
    }

    public T Update(T entity)
    {
        var entityResult = ApplicationDatabase.Context.Set<T>().Update(entity).Entity;
        ApplicationDatabase.Context.SaveChanges();
        return entityResult;
    }

    public IQueryable<T> GetAll()
    {
        return ApplicationDatabase.Context.Set<T>().Where(x => x.Status != Status.Deleted);
    }

    public T GetById(int id)
    {
        return ApplicationDatabase.Context.Set<T>().FirstOrDefault(x => x.Id == id && x.Status != Status.Deleted);
    }

    public T Remove(int id)
    {
        var entity = ApplicationDatabase.Context.Set<T>().Remove(GetById(id)).Entity;
        ApplicationDatabase.Context.SaveChanges();
        return entity;
    }
}

