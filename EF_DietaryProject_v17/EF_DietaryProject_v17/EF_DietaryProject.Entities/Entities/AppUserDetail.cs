using EF_DietaryProject.Entities.Base;
using EF_DietaryProject.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.Entities.Entities;

public class AppUserDetail : BaseEntity
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateTime BirthDate { get; set; }

    [NotMapped]
    public int Age { get { return (DateTime.Now.Year - BirthDate.Year); } }

    public float Height { get; set; }
    public float Weight { get; set; }

    //Nav prop
    public int? GenderId { get; set; }
    public virtual Gender? Gender { get; set; }

    //Nav prop
    public int  AppUserId { get; set; }
    public virtual AppUser AppUser { get; set; }

    //Nav prop
    public int? TargetId { get; set; }
    public virtual Target? Target { get; set; }

    //Nav prop
    public virtual List<Dish> Dishes { get; set; }
}
