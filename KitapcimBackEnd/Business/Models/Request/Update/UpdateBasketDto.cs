using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class UpdateBasketDto
    {
        public int TotalPrice { get; set; }
        public int Piece { get; set; }
        public int UserId { get; set; }
        public int BooksId { get; set; }
        public int BasketId { get; set; }
    }
}
