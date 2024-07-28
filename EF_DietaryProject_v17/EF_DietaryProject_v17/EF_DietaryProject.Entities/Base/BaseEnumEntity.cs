using EF_DietaryProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.Entities.Base;

public abstract class BaseEnumEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    //public Status Status { get; set; }
}
