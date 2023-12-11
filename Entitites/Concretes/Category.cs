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
        public List<Product> Products { get; set; }//bir kategorinin bir sürü nesnnesi var 
    }
}
