﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class CategoriesInfoDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = default!;

        public CategoriesInfoDto Categories { get; set; }

    }
}
