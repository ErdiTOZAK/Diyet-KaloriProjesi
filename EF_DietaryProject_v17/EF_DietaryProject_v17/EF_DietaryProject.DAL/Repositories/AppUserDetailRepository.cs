using EF_DietaryProject.DAL.RepositoryInterfaces;
using EF_DietaryProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.Repositories;

public class AppUserDetailRepository : BaseRepository<AppUserDetail>, IAppUserDetailRepository
{
}
