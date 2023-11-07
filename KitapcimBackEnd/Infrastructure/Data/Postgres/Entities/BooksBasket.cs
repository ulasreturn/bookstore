using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class BooksBasket : Entity<int>
    {
        public Books Books { get; set; }
        public Basket Basket { get; set; }
        public  int BooksId { get; set; }
        public int BasketId { get; set;}
    }
}
