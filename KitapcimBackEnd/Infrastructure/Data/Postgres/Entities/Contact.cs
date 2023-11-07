using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Contact : Entity<int>
    {
        public string ContactText { get; set; } = default!;
        public DateTime ContactDate { get; set; } = default!;
        public User User { get; set; }
        public int UserId { get; set; } = default!;

    }
}
