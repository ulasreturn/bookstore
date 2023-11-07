using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Orders : Entity<int>
{
    public DateTime OrderDate { get; set; }
    public string  PaymentMethod { get; set; } = default!;
    public int AddressId { get; set; } = default!;
    public int OrderPiece { get; set; } = default!;

    public User User { get; set; }

    public int UserId { get; set; } = default!;

}


