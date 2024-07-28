using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.AppUserDetailService;

public interface IAppUserDetailService
{
    bool Add(AppUserDetail appUserDetail);
    bool Update(AppUserDetail appUserDetail);
    bool Delete(int appUserDetailId);
    AppUserDetail GetById(int appUserDetailId);
    List<AppUserDetail> GetAll();
}
