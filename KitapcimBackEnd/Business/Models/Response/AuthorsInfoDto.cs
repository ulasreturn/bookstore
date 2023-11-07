using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class AuthorsInfoDto
    {
        public int Id { get; set; } = default!;
        public string AuthorsName { get; set; } = default!;
        public string AuthorsSurname { get; set; } = default!;
        public string GeneralInfo { get; set; } = default!;
        public string AuthorsPhoto { get; set; } = default!;
        public AuthorsInfoDto Authors { get; set; }

    }
}
