﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class DeletedCategoryResponse
    {
        public Guid Id { get; set; }
        public string? CategoryName { get; set; }
      //  public DateTime DeletedDate { get; set; } = DateTime.Now;
    }
}