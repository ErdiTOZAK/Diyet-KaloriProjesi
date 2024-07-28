using EF_DietaryProject.Entities.Base;
using EF_DietaryProject.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.Entities.Entities;

public class AppUser : BaseEntity
{
    public string Username { get; set; }
    public string Password { get; set; }

    //Nav prop
    public virtual AppUserDetail AppUserDetail { get; set; }

   

}
