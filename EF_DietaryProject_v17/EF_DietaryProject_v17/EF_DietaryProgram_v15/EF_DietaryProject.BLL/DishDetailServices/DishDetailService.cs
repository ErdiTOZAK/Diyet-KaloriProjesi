using EF_DietaryProject.DAL;
using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.DishDetailService;

public class DishDetailService : IDishDetailService
{
    public bool Add(DishDetail dishDetail)
    {
        if (dishDetail == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.DishDetailRepository.Add(dishDetail);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    public bool Delete(int dishDetailId)
    {
        if (dishDetailId == null)  // if (dishDetailId == Guid.Empty)
        {
            return false;
        }

        var result = UnitOfWork.Instance.DishDetailRepository.Remove(dishDetailId);

        if (result == null)
        {
            return false;
        }
        return true;
    }

    public List<DishDetail> GetAll()
    {
        return UnitOfWork.Instance.DishDetailRepository.GetAll().ToList();
    }

    public DishDetail GetById(int dishDetailId)
    {
        if (dishDetailId == null)
        {
            return null;
        }
        return UnitOfWork.Instance.DishDetailRepository.GetById(dishDetailId);
    }

    public bool Update(DishDetail dishDetail)
    {
        if (dishDetail == null)
        {
            return false;
        }

        var result = UnitOfWork.Instance.DishDetailRepository.Update(dishDetail);

        if (result == null)
        {
            return false;
        }
        return true;
    }
}
