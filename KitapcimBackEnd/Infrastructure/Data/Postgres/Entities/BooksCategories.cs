using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class BooksCategories : Entity<int>
{
    public Books Books { get; set; }
    public int BooksId { get; set; }
    public Categories Categories { get; set; }
    public int CategoriesId { get; set; }

}


