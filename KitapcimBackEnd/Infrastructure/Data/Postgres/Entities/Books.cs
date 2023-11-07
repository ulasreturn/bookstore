using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Books : Entity<int>
{
    public string CoverPhoto { get; set; } = default!;
    public string BookName { get; set; } = default!;
    public int Price { get; set; }
    public int Piece { get; set; }
    public string BookStatus { get; set; } = default!;
    public string Statement { get; set; } = default!;


   // public int CategoryID { get; set; } = default!;

    
    public  IList<Basket> Basket { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
    public IList<Comment> Comment { get; set; }
    public IList<Favourites> Favourites { get; set; }
    public IList<Categories> Categories { get; set; }

    public IList<BooksCategories> BooksCategories { get; set; }

    public IList<BooksBasket> BooksBasket { get; set; }


}



