using EF_DietaryProject.DAL.Configurations;
using EF_DietaryProject.DAL.SeedData;
using EF_DietaryProject.Entities.Base;
using EF_DietaryProject.Entities.Entities;
using EF_DietaryProject.Entities.EnumEntities;
using EF_DietaryProject.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DietaryProject.DAL.Context;

public class DietaryDbContext : DbContext
{
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<AppUserDetail> AppUserDetails { get; set; }
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<DishDetail> DishDetails { get; set; }
    public DbSet<Food> Foods { get; set; }
    public DbSet<FoodFeature> FoodFeatures { get; set; }
    public DbSet<FoodCategory> FoodCategories { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<Meal> Meals { get; set; }
    public DbSet<Target> Targets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LAPTOP-1RUKRP01\\SQLEXPRESS;Initial Catalog=EF_Dietary;Trusted_Connection=True;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<AppUserDetail>()
        //    .HasOne(ad => ad.Dish)
        //    .WithOne(d => d.AppUserDetail)
        //    .HasForeignKey<Dish>(d => d.AppUserDetailId); // AppUserDetailId, Dish sınıfındaki AppUserDetail'ı belirten dış anahtar

        modelBuilder.Entity<AppUser>()
            .HasOne(au => au.AppUserDetail)
            .WithOne(ad => ad.AppUser)
            .HasForeignKey<AppUserDetail>(ad => ad.AppUserId); // AppUserId, AppUserDetail sınıfındaki AppUser'ı belirten dış anahtar

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IEntityConfiguration).Assembly);

        //Enumların veritabanında sayı olarak değil isim olarak tutulmasını sağlar.


       // modelBuilder.Ignore<BaseEntity>();

        base.OnModelCreating(modelBuilder);
    }

    public override int SaveChanges()
    {
        SetBaseProperties();

        return base.SaveChanges();
    }

    private void SetBaseProperties()
    {
        var entries = ChangeTracker.Entries<BaseEntity>();

        foreach (var entry in entries)
        {
            SetIfAdded(entry);
            SetIfModified(entry);
            SetIfDeleted(entry);
        }
    }

    private void SetIfDeleted(EntityEntry<BaseEntity> entry)
    {
        if (entry.State == EntityState.Deleted)
        {
            entry.State = EntityState.Modified;
            entry.Entity.Status = Status.Deleted;
            entry.Entity.DeletedDate = DateTime.Now;
        }
    }

    private void SetIfModified(EntityEntry<BaseEntity> entry)
    {
        if (entry.State == EntityState.Modified)
        {
            entry.Entity.Status = Status.Updated;
            entry.Entity.UpdatedDate = DateTime.Now;
        }
    }

    private void SetIfAdded(EntityEntry<BaseEntity> entry)
    {
        if (entry.State == EntityState.Added)
        {
            entry.Entity.Status = Status.Added;
            entry.Entity.CreatedDate = DateTime.Now;
        }
    }

}
