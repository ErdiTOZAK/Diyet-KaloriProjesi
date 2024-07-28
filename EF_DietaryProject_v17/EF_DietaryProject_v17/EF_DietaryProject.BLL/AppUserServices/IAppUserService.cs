using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.AppUserService;

public interface IAppUserService
{
    bool Add(AppUser appUser);
    bool Update(AppUser appUser);
    bool Delete(int appUserId);
    AppUser GetById(int appUserId);
    List<AppUser> GetAll();

}
