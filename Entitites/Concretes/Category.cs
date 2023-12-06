using Core.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Concretes
{
    public class Category:Entity<int>
    {
        public string? CategoryName { get; set; }
    }
}
