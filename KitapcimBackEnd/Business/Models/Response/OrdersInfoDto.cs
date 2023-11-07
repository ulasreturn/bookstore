using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class OrdersInfoDto
    {
        public int Id { get; set; } = default!;
        public DateTime OrderDate { get; set; }
        public string PaymentMethod { get; set; } = default!;
        public int AddressId { get; set; } = default!;
        public int OrderPiece { get; set; } = default!;
        public User User { get; set; }
        public OrdersInfoDto Orders { get; set; }


    }
}
