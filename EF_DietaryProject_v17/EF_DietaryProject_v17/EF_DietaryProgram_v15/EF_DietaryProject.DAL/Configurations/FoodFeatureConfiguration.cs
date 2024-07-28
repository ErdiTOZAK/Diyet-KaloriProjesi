using EF_DietaryProject.Entities.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.Configurations;

public class FoodFeatureConfiguration : BaseEntityConfiguration<FoodFeature>
{
    public override void Configure(EntityTypeBuilder<FoodFeature> builder)
    {
        base.Configure(builder);
    }
}
