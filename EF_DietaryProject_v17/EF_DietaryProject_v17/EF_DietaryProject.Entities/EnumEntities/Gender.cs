using EF_DietaryProject.Entities.Base;
using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.Entities.EnumEntities;

public class Gender : BaseEnumEntity
{
    //Nav prop
    public virtual List<AppUserDetail> AppUserDetails { get; set; }

    public override string ToString()
    {
        return Name;
    }
}
