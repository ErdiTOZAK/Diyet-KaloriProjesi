using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.DishDetailService;

public interface IDishDetailService
{
    bool Add(DishDetail dishDetail);
    bool Update(DishDetail dishDetail);
    bool Delete(int dishDetailId);
    DishDetail GetById(int dishDetailId);
    List<DishDetail> GetAll();
}
