using EF_DietaryProject.DAL;
using EF_DietaryProject.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.TargetServices;

public class TargetService : ITargetService
{
    public bool Add(Target Target)
    {
        if (Target == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.TargetRepository.Add(Target);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    public bool Delete(int TargetId)
    {
        if (TargetId == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.TargetRepository.Remove(TargetId);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    public List<Target> GetAll()
    {
        return UnitOfWork.Instance.TargetRepository.GetAll();
    }

    public Target GetById(int TargetId)
    {
        if (TargetId == null)
        {
            return null;
        }
        return UnitOfWork.Instance.TargetRepository.GetById(TargetId);
    }



    public bool Update(Target Target)
    {
        if (Target == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.TargetRepository.Update(Target);

        if (result == null)
        {
            return false;
        }
        return true;
    }
}
