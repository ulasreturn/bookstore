using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Functional
{
    public class BasketDto
    {
        public int TotalPrice { get; set; }
        public int Piece { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public int BasketID { get; set; }
    }
}
