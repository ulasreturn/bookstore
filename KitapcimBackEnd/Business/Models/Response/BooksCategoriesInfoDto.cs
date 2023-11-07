using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class BooksCategoriesInfoDto
    {
        public int BooksId { get; set; }
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }

        public Books Books { get; set; }

        public BooksCategoriesInfoDto BooksCategories { get; set; }

    }
}
