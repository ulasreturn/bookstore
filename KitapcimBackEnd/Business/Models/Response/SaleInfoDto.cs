using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class SaleInfoDto
    {
        public int Id { get; set; } = default!;

        public string PaymentMethod { get; set; } = default!;
        public string Buyer { get; set; } = default!;
        public string SalesInfo { get; set; } = default!;
        public int UserId { get; set; } = default!;
        public int BooksId { get; set; } = default!;

        public User User { get; set; } 
        public Books Books { get; set; }

        public SaleInfoDto Sale { get; set; }

    }
}
