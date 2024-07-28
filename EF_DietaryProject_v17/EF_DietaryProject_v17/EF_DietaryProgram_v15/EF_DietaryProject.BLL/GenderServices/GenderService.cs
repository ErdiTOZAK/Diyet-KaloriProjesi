using EF_DietaryProject.DAL;
using EF_DietaryProject.DAL.EnumEntitiesRepositoryInterfaces;
using EF_DietaryProject.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.GenderServices;

public class GenderService : IGenderService
{
    public bool Add(Gender Gender)
    {
        if (Gender == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.GenderRepository.Add(Gender);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    public bool Delete(int GenderId)
    {
        if (GenderId == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.GenderRepository.Remove(GenderId);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    public List<Gender> GetAll()
    {
        return UnitOfWork.Instance.GenderRepository.GetAll();
    }

    public Gender GetById(int GenderId)
    {
        if (GenderId == null)
        {
            return null;
        }
        return UnitOfWork.Instance.GenderRepository.GetById(GenderId);
    }

   

    public bool Update(Gender Gender)
    {
        if (Gender == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.GenderRepository.Update(Gender);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    
}
