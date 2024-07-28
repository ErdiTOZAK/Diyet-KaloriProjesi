using EF_DietaryProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.Entities.Base;

public abstract class BaseEntity
{
    public int Id {  get; set; }    
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public Status Status { get; set; }
}
