using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
     public class CreateOrdersDto
    {
        public DateTime OrderDate { get; set; }
        public string PaymentMethod { get; set; } = default!;
        public int AddressId { get; set; } = default!;
        public int OrderPiece { get; set; } = default!;
        public int UserId { get; set; } = default!;
    }
}
