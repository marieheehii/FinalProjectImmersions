using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<KitchenInventory> Items {get; set;}
    public DbSet<Recipe> Recipes {get; set;}
    public DbSet<GroceryList> GroceryLists {get; set;}
    public DbSet<Customer> Customers {get; set;}

    }
