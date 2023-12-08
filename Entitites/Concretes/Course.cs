
using Core.Entitites;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Concretes
{
    public class Course : Entity<Guid>
    {
        public int CategoryId { get; set; }
        public string? Description { get; set; }

        public string? CourseName { get; set; }

    }
}
