using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edgeShop.Models
{
    internal class Catagory:BaseDTO
    {
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}
