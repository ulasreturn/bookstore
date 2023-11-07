using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Functional
{
    public class ContactDto
    {
        public int UserID { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string UserSurname { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string CommentText { get; set; } = default!;

    }
}
