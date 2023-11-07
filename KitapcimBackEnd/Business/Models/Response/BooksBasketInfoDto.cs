using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class BooksBasketInfoDto
    {
        public int BooksId { get; set; }
        public int BasketId { get; set; }

        public BooksBasketInfoDto BooksBasket { get; set; }

    }

}
