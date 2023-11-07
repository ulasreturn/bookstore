using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class BasketInfoDto
    {
        public int Id { get; set; }
        public int TotalPrice { get; set; }
        public int Piece { get; set; }
        public int UserId { get; set; }
        public int BooksId { get; set; }
        public int BasketId { get; set; }
        //public IList<Books> Books { get; set; }
        public BasketInfoDto Basket { get; set; }


    }
}
