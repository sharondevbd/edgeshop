using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edgeShop.Models
{
    public abstract class BaseDTO
    {
        public int Id { get; set; }
        public bool IsAvailable { get; set; }

    }
}
