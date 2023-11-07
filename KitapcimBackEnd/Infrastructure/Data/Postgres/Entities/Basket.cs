using Infrastructure.Data.Postgres.Entities.Base;
namespace Infrastructure.Data.Postgres.Entities;

public class Basket : Entity<int>
{

    public int TotalPrice { get; set; }
    public int Piece { get; set; }

    public IList<Books> Books { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }

    public IList<BooksBasket> BooksBasket { get; set; }

}



