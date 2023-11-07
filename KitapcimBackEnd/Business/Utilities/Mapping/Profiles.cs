using Business.Models.Request;
using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>();
        CreateMap<UserUpdateDto, User>();
        CreateMap<User, RegisterResponseDto>();

        CreateMap<CreateUserDto, User>();
        CreateMap<UserUpdateDto, User>();
        CreateMap<User, UserInfoDto>();

        CreateMap<CreateAddressDto, Address>();
        CreateMap<UpdateAddressDto, Address>();
        CreateMap<Address, AddressInfoDto>();

        CreateMap<CreateAuthorsDto, Authors>();
        CreateMap<UpdateAuthorsDto, Authors>();
        CreateMap<Authors, AuthorsInfoDto>();

        CreateMap<CreateBasketDto, Basket>();
        CreateMap<UpdateBasketDto, Basket>();
        CreateMap<Basket, BasketInfoDto>();

        CreateMap<CreateBookDto, Books>();
        CreateMap<UpdateBookDto, Books>();
        CreateMap<Books, BookInfoDto>();

        CreateMap<CreateBooksCategories, BooksCategories>();
        CreateMap<UpdateBooksCategoriesDto, BooksCategories>();
        CreateMap<BooksCategories, BooksCategoriesInfoDto>();

        CreateMap<CreateBooksBasketDto, BooksBasket>();
        CreateMap<UpdateBooksBasketDto, BooksBasket>();
        CreateMap<BooksBasket, BooksBasketInfoDto>();

        CreateMap<CreateCategoriesDto, Categories>();
        CreateMap<UpdateCategoriesDto, Categories>();
        CreateMap<Categories, CategoriesInfoDto>();

        CreateMap<CreateCommentDto, Comment>();
        CreateMap<UpdateCommentDto, Comment>();
        CreateMap<Comment, CommentInfoDto>();

        CreateMap<CreateFavouritesDto, Favourites>();
        CreateMap<UpdateFavouritesDto, Favourites>();
        CreateMap<Favourites, FavouritesInfoDto>();

        CreateMap<CreateOrdersDto, Orders>();
        CreateMap<UpdateOrdersDto, Orders>();
        CreateMap<Orders, OrdersInfoDto>();

        CreateMap<CreateSaleDto, Sale>();
        CreateMap<UpdateSaleDto, Sale>();
        CreateMap<Sale, SaleInfoDto>();

        CreateMap<CreateContactDto, Contact>();
        CreateMap<UpdateContactDto, Contact>();
        CreateMap<Contact, ContactInfoDto>();
       CreateMap<ChangePasswordDto, User>();
        CreateMap<User, EmailInfoDTO>();
  }
}
