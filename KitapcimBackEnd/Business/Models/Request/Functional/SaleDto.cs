using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Functional
{
    public class SaleDto
    {
        public string PaymentMethod { get; set; } = default!;
        public string Buyer { get; set; } = default!;
        public string SalesInfo { get; set; } = default!;
    }
}
