using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class FavouritesInfoDto
    {
        public int Id { get; set; }
        public int CategoriesId { get; set; } = default!;

        public Books Books { get; set; }
        public int BooksId { get; set; } = default!;

        public int UserId { get; set; } = default!;
        public User User { get; set; }
        public FavouritesInfoDto Favourites { get; set; }

    }
}
