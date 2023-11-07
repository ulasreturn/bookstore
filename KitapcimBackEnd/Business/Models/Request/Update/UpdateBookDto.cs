using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class UpdateBookDto
    {
   
      public int Id { get; set; } // Bu özellik eklenmeli
                                  // Diğer özellikler
    

    public string CoverPhoto { get; set; } = default!;
        public string BookName { get; set; } = default!;
        public int Price { get; set; }
        public int Piece { get; set; }
        public string BookStatus { get; set; } = default!;
        public int SaleId { get; set; }
        public int UserId { get; set; }

    }
}
