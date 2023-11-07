using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class AddressInfoDto
    {
        public int Id { get; set; } = default!;
        public int UserId { get; set; }
        public string AddressTitle { get; set; } = default!;
        public string Country { get; set; } = default!;
        public string City { get; set; } = default!;
        public int PostalCode { get; set; } = default!;
        public string AddressText { get; set; } = default!;

        public UserInfoDto User { get; set; }        

    }
}
