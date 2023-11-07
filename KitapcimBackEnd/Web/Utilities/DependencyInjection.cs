using Business.Services;
using Business.Services.Interface;
using Business.Utilities.Mapping;
using Business.Utilities.Mapping.Interface;
using Business.Utilities.Security.Auth.Jwt;
using Business.Utilities.Security.Auth.Jwt.Interface;
using Business.Utilities.Validation;
using Business.Utilities.Validation.Interface;
using Core.Utilities.Mail;
using Infrastructure.Data.Postgres;

namespace Web.Utilities;

public static class DependencyInjection
{
    public static void AddMyScoped(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
        serviceCollection.AddScoped<IClaimHelper, ClaimHelper>();
        serviceCollection.AddScoped<IAuthService, AuthService>();
        serviceCollection.AddScoped<IAddressService, AddressService>();
        serviceCollection.AddScoped<IAuthorsService, AuthorsService>();
        serviceCollection.AddScoped<IBasketService, BasketService>();
        serviceCollection.AddScoped<IBooksService, BooksService>();
        serviceCollection.AddScoped<ICategoriesService, CategoriesService>();
        serviceCollection.AddScoped<ICommentService, CommentService>();
        serviceCollection.AddScoped<IContactService, ContactService>();
        serviceCollection.AddScoped<IFavouritesService, FavouritesService>();
        serviceCollection.AddScoped<IOrdersService, OrdersService>();
        serviceCollection.AddScoped<ISaleService, SaleService>();
        serviceCollection.AddScoped<IBooksCategoriesService, BooksCategoriesService>();
        serviceCollection.AddScoped<IBooksBasketService, BooksBasketService>();
        serviceCollection.AddScoped<IUserService, UserService>();
        serviceCollection.AddScoped<IEmailInfoService, EmailInfoService>();

  }

    public static void AddMySingleton(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        serviceCollection.AddSingleton<IMapperHelper, MapperHelper>();
        serviceCollection.AddSingleton<IValidationHelper, ValidationHelper>();
        serviceCollection.AddSingleton<IJwtTokenHelper, JwtTokenHelper>();
        serviceCollection.AddSingleton<IHashingHelper, HashingHelper>();
        serviceCollection.AddSingleton<IMailHelper, MailHelper>();
 

    }

    public static void AddMyTransient(this IServiceCollection serviceCollection)
    {
    }
}
