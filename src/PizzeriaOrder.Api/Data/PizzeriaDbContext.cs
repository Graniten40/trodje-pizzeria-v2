using Microsoft.EntityFrameworkCore;
using PizzeriaOrder.Api.Data.Seed;
using PizzeriaOrder.Api.Models;
using PizzeriaOrder.Api.Models.Menu;
using PizzeriaOrder.Api.Models.Orders;

namespace PizzeriaOrder.Api.Data;

public class PizzeriaDbContext : DbContext
{
    public PizzeriaDbContext(
        DbContextOptions<PizzeriaDbContext> options)
        : base(options)
    {
    }

    public DbSet<Restaurant> Restaurants => Set<Restaurant>();

    public DbSet<MenuCategory> MenuCategories => Set<MenuCategory>();
    public DbSet<MenuItem> MenuItems => Set<MenuItem>();
    public DbSet<MenuItemVariant> MenuItemVariants => Set<MenuItemVariant>();
    public DbSet<MenuItemExtra> MenuItemExtras => Set<MenuItemExtra>();

    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();
    public DbSet<OrderItemExtra> OrderItemExtras => Set<OrderItemExtra>();
    public DbSet<OrderItemVariant> OrderItemVariants => Set<OrderItemVariant>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        ConfigureMenu(modelBuilder);
        ConfigureOrders(modelBuilder);

        PizzeriaSeedData.Apply(modelBuilder);
    }

    private static void ConfigureMenu(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Restaurant>()
            .HasMany(r => r.MenuCategories)
            .WithOne(c => c.Restaurant)
            .HasForeignKey(c => c.RestaurantId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<MenuCategory>()
            .HasMany(c => c.MenuItems)
            .WithOne(i => i.MenuCategory)
            .HasForeignKey(i => i.MenuCategoryId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<MenuItem>()
            .HasMany(i => i.Variants)
            .WithOne(v => v.MenuItem)
            .HasForeignKey(v => v.MenuItemId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<MenuItem>()
            .HasMany(i => i.Extras)
            .WithOne(e => e.MenuItem)
            .HasForeignKey(e => e.MenuItemId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<MenuItem>()
            .Property(i => i.Price)
            .HasPrecision(10, 2);

        modelBuilder.Entity<MenuItemVariant>()
            .Property(v => v.Price)
            .HasPrecision(10, 2);

        modelBuilder.Entity<MenuItemExtra>()
            .Property(e => e.PriceChange)
            .HasPrecision(10, 2);
    }

    private static void ConfigureOrders(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .HasMany(o => o.Items)
            .WithOne(i => i.Order)
            .HasForeignKey(i => i.OrderId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<OrderItem>()
            .HasMany(i => i.Extras)
            .WithOne(e => e.OrderItem)
            .HasForeignKey(e => e.OrderItemId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<OrderItem>()
            .HasOne(i => i.Variant)
            .WithOne(v => v.OrderItem)
            .HasForeignKey<OrderItemVariant>(v => v.OrderItemId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Restaurant)
            .WithMany()
            .HasForeignKey(o => o.RestaurantId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Order>()
            .Property(o => o.TotalPrice)
            .HasPrecision(10, 2);

        modelBuilder.Entity<OrderItem>()
            .Property(i => i.UnitPrice)
            .HasPrecision(10, 2);

        modelBuilder.Entity<OrderItem>()
            .Property(i => i.TotalPrice)
            .HasPrecision(10, 2);

        modelBuilder.Entity<OrderItemExtra>()
            .Property(e => e.PriceChange)
            .HasPrecision(10, 2);

        modelBuilder.Entity<OrderItemVariant>()
            .Property(v => v.Price)
            .HasPrecision(10, 2);

        modelBuilder.Entity<Order>()
            .Property(o => o.CustomerName)
            .HasMaxLength(150);

        modelBuilder.Entity<Order>()
            .Property(o => o.Phone)
            .HasMaxLength(50);

        modelBuilder.Entity<Order>()
            .Property(o => o.Email)
            .HasMaxLength(254);

        modelBuilder.Entity<Order>()
            .Property(o => o.Status)
            .HasMaxLength(50);

        modelBuilder.Entity<OrderItem>()
            .Property(i => i.Name)
            .HasMaxLength(200);

        modelBuilder.Entity<OrderItemExtra>()
            .Property(e => e.Name)
            .HasMaxLength(200);

        modelBuilder.Entity<OrderItemVariant>()
            .Property(v => v.Name)
            .HasMaxLength(200);
    }
}