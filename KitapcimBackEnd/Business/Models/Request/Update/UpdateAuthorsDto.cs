using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class UpdateAuthorsDto
    {
        public string AuthorsName { get; set; } = default!;
        public string AuthorsSurname { get; set; } = default!;
        public string GeneralInfo { get; set; } = default!;
        public string AuthorsPhoto { get; set; } = default!;

    }
}
