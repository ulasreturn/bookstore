using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Sale : Entity<int>
{
    public string PaymentMethod { get; set; } = default!;
    public string Buyer { get; set; } = default!;
    public string SalesInfo { get; set; } = default!;

    
    public User User { get; set; }

    public int UserId { get; set; }


}




