using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Favourites : Entity<int>
{
    public int CategoriesId { get; set; } = default!;

    public int BooksId { get; set; } = default!;

    public int UserId { get; set; } = default!;
    public Books Books { get; set; }
    public User User { get; set; }

}



