using EF_DietaryProject.Entities.EnumEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.SeedData;

public class GenderSeedData : IEntityTypeConfiguration<Gender>
{
    public void Configure(EntityTypeBuilder<Gender> builder)
    {
        builder.HasData(
            new Gender
            {
                Id = 1,
                Name = "Male",
                //Status = Entities.Enums.Status.Added,
            },
            new Gender
            {
                Id = 2,
                Name = "Female",
                //Status = Entities.Enums.Status.Added,
            });
    }
}
