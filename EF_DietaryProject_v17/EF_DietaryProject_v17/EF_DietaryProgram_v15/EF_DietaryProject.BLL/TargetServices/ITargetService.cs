using EF_DietaryProject.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.TargetServices;

public interface ITargetService
{
    bool Add(Target Target);
    bool Update(Target Target);
    bool Delete(int TargetId);
    Target GetById(int TargetId);
    List<Target> GetAll();
}
