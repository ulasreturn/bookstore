using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Categories : Entity<int>
{

    public string CategoryName { get; set; } = default!;


    public IList<Books> Books { get; set; }
    public IList<BooksCategories> BooksCategories { get; set; }

}

