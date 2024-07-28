using EF_DietaryProject.DAL;
using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.AppUserService;

public class AppUserService : IAppUserService
{
    public bool Add(AppUser appUser)
    {
        if (appUser != null)
        {
            var result = UnitOfWork.Instance.AppUserRepository.Add(appUser);

            if(result != null)
            {
                return true;
            }
            return false;
           
        }
        return false;
    }

    public bool Delete(int appUserId)
    {
        if (appUserId == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.AppUserRepository.Remove(appUserId);

        if(result == null)
        {
            return false;
        }

        return true;
    }

    public List<AppUser> GetAll()
    {
        return UnitOfWork.Instance.AppUserRepository.GetAll().ToList();
    }

    public AppUser GetById(int appUserId)
    {
        if(appUserId == null) //Guid.Empty()
        {
            return null;
        }

        return UnitOfWork.Instance.AppUserRepository.GetById(appUserId);
    }

    public bool Update(AppUser appUser)
    {
        if (appUser == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.AppUserRepository.Update(appUser);

        if (result == null)
        {
            return false;
        }

        return true;
    }
}
