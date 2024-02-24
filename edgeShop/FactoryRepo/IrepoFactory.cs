using edgeShop.Models;
using edgeShop.RepositoryOfStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edgeShop.FactoryRepo
{
    public interface IrepoFactory
    {
        IRepo<T> CreateRepo<T>() where T : BaseDTO;
    }
}
