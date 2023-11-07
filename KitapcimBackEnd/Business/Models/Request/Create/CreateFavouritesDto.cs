using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CreateFavouritesDto
    {
        public int CategoriesId { get; set; } = default!;

        public int BooksId { get; set; } = default!;

        public int UserId { get; set; } = default!;
    }
}
