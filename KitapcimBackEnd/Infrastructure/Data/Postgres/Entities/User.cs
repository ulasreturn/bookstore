using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{

  public string UserName { get; set; } = default!;
    public string UserSurname { get; set; } = default!;
    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;
    public string Country { get; set; } = default!;
    public string City { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Telephone { get; set; } = default!;

    public string UserPhoto { get;set; } = default!;
    public UserType UserType { get; set; }

    public int BasketId { get; set; } = default!;

    public IList<Comment> Comment { get; set; }
    public IList<Favourites>Favourites { get; set; }
    public IList<Sale>Sale { get; set; }
    public IList<Orders>Orders { get; set; }
    public Basket Basket {  get; set; }
    public IList<Books> Books {  get; set; }

    public IList<Address> Address { get; set; }
    public IList<Contact> Contact { get; set; }
  
}



public enum UserType
{
    Admin,
    User
}
