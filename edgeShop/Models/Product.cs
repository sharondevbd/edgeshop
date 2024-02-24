using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edgeShop.Models
{
    public class Product:BaseDTO
    {
        public string Name { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public int CatagoryId { get; set; }
    }
}
