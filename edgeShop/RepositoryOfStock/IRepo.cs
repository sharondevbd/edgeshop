using edgeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edgeShop.RepositoryOfStock
{
    internal interface IRepo<T> where T : BaseDTO
    {
        //CRUD OPeration Methods Decleareation
        void Create(T item);
        void AddRange(List<T> item);
        void Update (T item);
        void Delete(int Id);
        List<T> GetAll();
        T GetById(int Id);
    }
}
