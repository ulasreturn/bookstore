using Infrastructure.Data.Postgres.Entities.Base;
using System;

namespace Infrastructure.Data.Postgres.Entities;

public class Comment : Entity<int>
{
    public string CommentText { get; set; } = default!;
    public DateTime CommentDate { get; set; } = default!;

    public int BooksId { get; set; } = default!;
    public Books Books { get; set; }= default!;
    public User User { get; set; } = default!;

    public int UserId { get; set; }= default!;

}



