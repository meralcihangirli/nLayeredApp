﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedCategoryResponse
    {
        public Guid Id { get; set; }
        public string? CategoryName { get; set; }
    }
}
