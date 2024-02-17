using edgeShop.Models;
using edgeShop.RepositoryOfStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace edgeShop.FactoryRepo
{
    public class FactoryRepo : IrepoFactory
    {
        IRepo<T> IrepoFactory.CreateRepo<T>()
        {
            return new StockRepo<T>();
        }
    }

}
