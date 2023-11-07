using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Authors : Entity<int>
{
    public string AuthorsName { get; set; } = default!;
    public string AuthorsSurname { get; set; } = default!;
    public string GeneralInfo { get; set; } = default!;
    public string AuthorsPhoto { get; set; } = default!;


}




