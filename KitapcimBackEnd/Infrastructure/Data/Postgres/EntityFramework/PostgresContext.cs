using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Xml.Linq;

namespace Infrastructure.Data.Postgres.EntityFramework;

public class PostgresContext : DbContext

{
    private readonly IConfiguration _configuration;


    public PostgresContext(DbContextOptions<PostgresContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserTokenConfiguration());
        modelBuilder.ApplyConfiguration(new AuthorsConfiguration());
        modelBuilder.ApplyConfiguration(new BasketConfiguration());
        modelBuilder.ApplyConfiguration(new BooksConfiguration());
        modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());
        modelBuilder.ApplyConfiguration(new FavouritesConfiguration());
        modelBuilder.ApplyConfiguration(new OrdersConfiguration());
        modelBuilder.ApplyConfiguration(new SaleConfiguration());
        modelBuilder.ApplyConfiguration(new BooksCategoriesConfiguration());
        modelBuilder.ApplyConfiguration(new AddressConfiguration());
        modelBuilder.ApplyConfiguration(new ContactConfiguration());
        modelBuilder.ApplyConfiguration(new BooksBasketConfiguration());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        if (_configuration["EnvironmentAlias"] == "DEV")
        {
            optionsBuilder.LogTo(Console.Write);
        }
    }

    public DbSet<User> User => Set<User>();
    public DbSet<UserToken> UserTokens => Set<UserToken>();
    public DbSet<Favourites> Favourites => Set<Favourites>();

    public DbSet<Categories> Categories => Set<Categories>();

    public DbSet<Books> Books => Set<Books>();
    public DbSet<BooksCategories> BooksCategories => Set<BooksCategories>();

    public DbSet <Sale> Sale => Set<Sale>();
    public DbSet <Basket> Basket => Set<Basket>();

    public DbSet<Orders> Orders => Set<Orders>();
    public DbSet<Authors> Authors => Set<Authors>();

    public DbSet<Comment> Comment => Set<Comment>();


  public DbSet<Address> Address => Set<Address>();
    public DbSet<Contact> Contact => Set<Contact>();
    public DbSet<BooksBasket> BooksBasket => Set<BooksBasket>();

}
