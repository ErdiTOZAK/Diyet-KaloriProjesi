using EF_DietaryProject.Entities.EnumEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.SeedData;

public class TargetSeedData : IEntityTypeConfiguration<Target>
{
    public void Configure(EntityTypeBuilder<Target> builder)
    {
        builder.HasData(
            new Target
            {
                Id = 1,
                Name = "Lose Weight",
                //Status = Entities.Enums.Status.Added,
            },
            new Target
            {
                Id = 2,
                Name = "Maintain Weight",
                //Status = Entities.Enums.Status.Added,
            },
            new Target
            {
                Id = 3,
                Name = "Gain Weight",
                //Status = Entities.Enums.Status.Added,
            });
    }
}
