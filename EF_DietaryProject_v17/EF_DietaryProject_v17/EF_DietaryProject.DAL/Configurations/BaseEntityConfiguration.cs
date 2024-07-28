using EF_DietaryProject.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.Configurations;

public class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.CreatedDate).IsRequired();

        builder.Property(x => x.UpdatedDate).IsRequired(false);

        builder.Property(x => x.DeletedDate).IsRequired(false);

        builder.Property(x => x.Status).HasConversion<string>();
    }
}
