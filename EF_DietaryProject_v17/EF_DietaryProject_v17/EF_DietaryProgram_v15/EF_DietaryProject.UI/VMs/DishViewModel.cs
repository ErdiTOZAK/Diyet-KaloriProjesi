using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.UI.VMs;

public class DishViewModel
{
    public int Id { get; set; }
    public DateTime MealDate { get; set; }
    public float CaloriesTaken { get; set; }
    public string MealName { get; set; } // Bu property Meal'ın adını tutar
}
