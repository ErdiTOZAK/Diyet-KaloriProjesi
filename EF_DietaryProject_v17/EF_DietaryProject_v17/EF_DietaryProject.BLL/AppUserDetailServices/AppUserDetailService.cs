using EF_DietaryProject.DAL;
using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.AppUserDetailService;

public class AppUserDetailService : IAppUserDetailService
{
    public bool Add(AppUserDetail appUserDetail)
    {
        if (appUserDetail == null)
        {
            return false;
        }
        var result = UnitOfWork.Instance.AppUserDetailRepository.Add(appUserDetail);
        if (result == null)
        {
            return false;
        }
        return true;
    }

    public bool Delete(int appUserDetailId)
    {
        //if (appUserDetailId == null)
        //{
        //    return false;
        //}

        var result = UnitOfWork.Instance.AppUserDetailRepository.Remove(appUserDetailId);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    public List<AppUserDetail> GetAll()
    {
        return UnitOfWork.Instance.AppUserDetailRepository.GetAll().ToList();
    }

    public AppUserDetail? GetById(int appUserDetailId)
    {
        //if (appUserDetailId == null)
        //{
        //    return null;
        //}
        return UnitOfWork.Instance.AppUserDetailRepository.GetById(appUserDetailId);
    }

    public bool Update(AppUserDetail appUserDetail)
    {
        if (appUserDetail == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.AppUserDetailRepository.Update(appUserDetail);

        if (result == null)
        {
            return false;
        }
        return true;
    }
}
