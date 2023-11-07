using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository User { get; }
    IUserTokenRepository UserTokens { get; }

    IAuthorsRepository Authors { get; }
    IBasketRepository Basket { get; }
    IBooksRepository Books { get; }
    ICategoriesRepository Categories { get; }
    ICommentRepository Comment { get; }
    IFavouritesRepository Favourites { get; }
    IOrdersRepository Orders { get; }
    ISaleRepository Sale { get; }
    IAddressRepository Address{ get; }
    IContactRepository Contact { get; }
  
    IBooksCategoriesRepository BooksCategories { get; }

    IBooksBasketRepository  BooksBasket { get; }

    Task<int> CommitAsync();
  Task<int> SaveChangesAsync();
}
