using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Functional
{
    public class FavouritesDto
    {
        public int CategoryID { get; set; } = default!;

        public Books Books { get; set; }
        public int BookID { get; set; } = default!;

        public int UserID { get; set; } = default!;
    }
}
