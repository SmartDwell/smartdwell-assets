using Microsoft.EntityFrameworkCore;
using Models;

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
    /// Коллекция параметров категорий.
    /// </summary>
    public DbSet<CategoryParameter> CategoryParameters { get; set; } = null!;
    
    /// <summary>
    /// Коллекция параметров категорий, прикрепленных к активам.
    /// </summary>
    public DbSet<AssetCategoryParameter> AssetCategoryParameters { get; set; } = null!;
    
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
            entity.HasMany(e => e.Categories).WithOne(e => e.Asset).HasForeignKey(e => e.AssetId);
        });
        
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Description);
            entity.Property(e => e.UseForApi);
            entity.HasMany(e => e.CategoryParameters).WithOne(e => e.Category).HasForeignKey(e => e.CategoryId);
            
            entity.HasData(
                new Category { Id = Guid.NewGuid(), Name = "Жилой комплекс", UseForApi = true, },
                new Category { Id = Guid.NewGuid(), Name = "Дом", UseForApi = true, },
                new Category { Id = Guid.NewGuid(), Name = "Квартира", UseForApi = true, },
                new Category { Id = Guid.NewGuid(), Name = "Подъезд", UseForApi = true, },
                new Category { Id = Guid.NewGuid(), Name = "Этаж", UseForApi = true, },
                new Category { Id = Guid.NewGuid(), Name = "Игровая площадка", UseForApi = true, },
                new Category { Id = Guid.NewGuid(), Name = "Детсткая площадка", UseForApi = true, }
            );
        });
        
        modelBuilder.Entity<Parameter>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.TypeCode).IsRequired();
            entity.HasMany(e => e.CategoryParameters).WithOne(e => e.Parameter).HasForeignKey(e => e.ParameterId);
        });

        modelBuilder.Entity<CategoryParameter>(entity =>
        {
            entity.HasKey(e => e.Id); 
            entity.Property(e => e.CategoryId).IsRequired();
            entity.Property(e => e.ParameterId).IsRequired();
            entity.HasOne(e => e.Category).WithMany(e => e.CategoryParameters).HasForeignKey(e => e.CategoryId);
            entity.HasOne(e => e.Parameter).WithMany(e => e.CategoryParameters).HasForeignKey(e => e.ParameterId);
        });

        modelBuilder.Entity<AssetCategoryParameter>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.AssetId).IsRequired();
            entity.Property(e => e.CategoryParameterId).IsRequired();
            entity.Property(e => e.Value).IsRequired();
            entity.HasOne(e => e.Asset).WithMany(e => e.Categories).HasForeignKey(e => e.AssetId);
            entity.HasOne(e => e.CategoryParameter).WithMany(e => e.AssetCategoryParameters).HasForeignKey(e => e.CategoryParameterId);
        });
    }
}