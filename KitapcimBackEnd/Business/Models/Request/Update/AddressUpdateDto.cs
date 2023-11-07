using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class AddressUpdateDto
    {
        public string AddressTitle { get; set; } = default!;
        public String Country { get; set; } = default!;
        public string City { get; set; } = default!;
        public int PostalCode { get; set; } = default!;
        public String AddressText { get; set; } = default!;
    }
}
