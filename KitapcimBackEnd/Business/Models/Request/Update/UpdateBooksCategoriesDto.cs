﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class UpdateBooksCategoriesDto
    {
        public int BooksId { get; set; }
        public int CategoriesId { get; set; }
    }
}
