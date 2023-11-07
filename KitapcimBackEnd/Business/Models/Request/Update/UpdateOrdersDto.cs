using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class UpdateOrdersDto
    {
        public DateTime OrderDate { get; set; }
        public string PaymentMethod { get; set; } = default!;
        public int AddressId { get; set; } = default!;
        public int OrderPiece { get; set; } = default!;

    }
}
