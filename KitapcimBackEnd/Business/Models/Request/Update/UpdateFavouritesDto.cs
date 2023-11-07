using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class UpdateFavouritesDto
    {
        public int CategoriesId { get; set; } = default!;

        public Books Books { get; set; }
        public int BooksId { get; set; } = default!;

        public int UserId { get; set; } = default!;
    }
}
