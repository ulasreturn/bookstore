using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CreateContactDto
    {
        public string ContactText { get; set; } = default!;
        public DateTime ContactDate { get; set; } = default!;
        public int UserId { get; set; } = default!;
    }
}
