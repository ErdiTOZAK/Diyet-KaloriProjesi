using EF_DietaryProject.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.BLL.GenderServices;

public interface IGenderService 
{
    bool Add(Gender Gender);
    bool Update(Gender Gender);
    bool Delete(int GenderId);
    Gender GetById(int GenderId);
    List<Gender> GetAll();
}
