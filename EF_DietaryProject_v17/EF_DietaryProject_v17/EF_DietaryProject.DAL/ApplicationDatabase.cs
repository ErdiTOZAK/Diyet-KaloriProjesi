using EF_DietaryProject.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL;

public class ApplicationDatabase
{
    private static DietaryDbContext context;

    public static DietaryDbContext Context
    {
        get
        {
            if (context == null)
            {
                context = new DietaryDbContext();
            }
            return context;
        }
    }
}
