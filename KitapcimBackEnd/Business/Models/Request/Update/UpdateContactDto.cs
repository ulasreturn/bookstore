using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class UpdateContactDto
    {
        public string ContactText { get; set; } = default!;
        public DateTime ContactDate { get; set; } = default!;
        public User User { get; set; }
        public int UserId { get; set; } = default!;
    }
}
