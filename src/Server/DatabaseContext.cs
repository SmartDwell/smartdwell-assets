using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Models;
using Server.Helpers;

namespace Server;

/// <summary>
/// Контекст базы данных.
/// </summary>
public sealed class DatabaseContext : DbContext
{
    #region Tables

    /// <summary>
    /// Коллекция активов.
    /// </summary>
    public DbSet<Asset> Assets { get; set; } = null!;

    /// <summary>
    /// Коллекция категорий.
    /// </summary>
    public DbSet<Category> Categories { get; set; } = null!;
    
    /// <summary>
    /// Коллекция параметров.
    /// </summary>
    public DbSet<Parameter> Parameters { get; set; } = null!;
    
    /// <summary>
    /// Коллекция единиц измерения.
    /// </summary>
    public DbSet<MeasureUnit> MeasureUnits { get; set; } = null!;
    
    #endregion
    
    /// <summary>
    /// Конструктор по умолчанию
    /// </summary>
    public DatabaseContext() { }
    
    /// <summary>
    /// Конструктор с параметрами
    /// </summary>
    /// <param name="options">Параметры</param>
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
    {
        if (Database.GetPendingMigrations().Any())
            Database.Migrate();
    }

    /// <inheritdoc cref="DbContext.OnModelCreating(ModelBuilder)"/>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asset>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Description);
            entity.Property(e => e.Images).IsRequired();
            entity.HasMany(e => e.Categories).WithMany(e => e.Assets);
        });
        
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Description);
            entity.HasMany(e => e.Parameters).WithMany(e => e.Categories);
            entity.HasMany(e => e.Assets).WithMany(e => e.Categories);
            
            entity.HasData(
                new Category { Id = Guid.NewGuid(), Name = "Жилой комплекс" },
                new Category { Id = Guid.NewGuid(), Name = "Дом" },
                new Category { Id = Guid.NewGuid(), Name = "Квартира" },
                new Category { Id = Guid.NewGuid(), Name = "Подъезд" },
                new Category { Id = Guid.NewGuid(), Name = "Этаж" }
            );
        });
        
        modelBuilder.Entity<Parameter>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Description);
            entity.Property(e => e.Type).IsRequired();
            entity.Property(e => e.Value).IsRequired();
            entity.HasOne(e => e.MeasureUnit).WithMany(e => e.Parameters);
            entity.HasMany(e => e.Categories).WithMany(e => e.Parameters);
        });
        
        modelBuilder.Entity<MeasureUnit>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.HasMany(e => e.Parameters).WithOne(e => e.MeasureUnit);
        });
    }
}