using Core.Utilities;
using Infrastructure.Data.Postgres.Entities.Base.Interface;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Infrastructure.Data.Postgres;

public class UnitOfWork : IUnitOfWork
{
    private readonly PostgresContext _postgresContext;

    private UserRepository? _userRepository;
    private UserTokenRepository? _userTokenRepository;
    private AuthorsRepository? _authorsRepository;
    private BasketRepository? _basketRepository;
    private BooksRepository? _booksRepository;
    private CategoriesRepository? _categoriesRepository;
    private CommentRepository? _commentRepository;
    private FavouritesRepository? _favouritesRepository;
    private OrdersRepository? _ordersRepository;
    private SaleRepository? _saleRepository;
    private BooksCategoriesRepository? _booksCategoriesRepository;
    private AddressRepository? _addressRepository;
    private ContactRepository? _contactRepository;
    private BooksBasketRepository? _booksBasketRepository;
    public UnitOfWork(PostgresContext postgresContext)
    {
        _postgresContext = postgresContext;
    }

    public IUserRepository User => _userRepository ??= new UserRepository(_postgresContext);
    public IUserTokenRepository UserTokens => _userTokenRepository ??= new UserTokenRepository(_postgresContext);
    public IAuthorsRepository Authors => _authorsRepository ??= new AuthorsRepository(_postgresContext);
    public IBasketRepository Basket => _basketRepository ??= new BasketRepository(_postgresContext);
    public IBooksRepository Books => _booksRepository ??= new BooksRepository(_postgresContext);
    public ICategoriesRepository Categories => _categoriesRepository ??= new CategoriesRepository(_postgresContext);
    public ICommentRepository Comment => _commentRepository ??= new CommentRepository(_postgresContext);
    public IFavouritesRepository Favourites => _favouritesRepository ??= new FavouritesRepository(_postgresContext);
    public IOrdersRepository Orders => _ordersRepository ??= new OrdersRepository(_postgresContext);
    public ISaleRepository Sale => _saleRepository ??= new SaleRepository(_postgresContext);
    public IAddressRepository Address => _addressRepository ??= new AddressRepository(_postgresContext);
    public IBooksCategoriesRepository BooksCategories => _booksCategoriesRepository??= new BooksCategoriesRepository(_postgresContext);
    public IContactRepository Contact => _contactRepository ??= new ContactRepository(_postgresContext);
    public IBooksBasketRepository BooksBasket => _booksBasketRepository ??= new BooksBasketRepository(_postgresContext);

    public IBasketRepository BasketRepository => throw new NotImplementedException();

    public IBooksRepository BooksRepository => throw new NotImplementedException();

    public ICategoriesRepository CategoriesRepository => throw new NotImplementedException();

    public ICommentRepository CommentRepository => throw new NotImplementedException();

    public IFavouritesRepository FavoritesRepository => throw new NotImplementedException();

    public IOrdersRepository OrdersRepository => throw new NotImplementedException();

    public ISaleRepository SalesRepository => throw new NotImplementedException();

    public IBooksCategoriesRepository BookCategories => throw new NotImplementedException();




    public async Task<int> CommitAsync()
    {
        var updatedEntities = _postgresContext.ChangeTracker.Entries<IEntity>()
            .Where(e => e.State == EntityState.Modified)
            .Select(e => e.Entity);

        foreach (var updatedEntity in updatedEntities)
        {
            updatedEntity.UpdatedAt = DateTime.UtcNow.ToTimeZone();
        }

        var result = await _postgresContext.SaveChangesAsync();

        return result;
    }
  public async Task<int> SaveChangesAsync()
  {
    try
    {
      return await _postgresContext.SaveChangesAsync();
    }
    catch (DbUpdateException ex)
    {
      // Hata durumunu ele alabilirsiniz.
      throw ex;
    }
  }

  public void Dispose()
    {
        _postgresContext.Dispose();
    }
}
