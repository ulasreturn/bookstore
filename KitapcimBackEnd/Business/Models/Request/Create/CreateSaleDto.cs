using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CreateSaleDto
    {
        public string PaymentMethod { get; set; } = default!;
        public string Buyer { get; set; } = default!;
        public string SalesInfo { get; set; } = default!;
        public int UserId { get; set; } 
 
    }
}
