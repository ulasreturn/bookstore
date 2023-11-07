using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Address : Entity<int>
    {
        public string AddressTitle { get; set; } = default!;
        public String Country { get; set; } = default!;
        public string City { get; set; } = default!;
        public int PostalCode { get; set; } = default!;
        public String AddressText { get; set; } = default!;

        public User User { get; set; } = default!;
        public int UserId { get; set; } = default!;

    }
}
