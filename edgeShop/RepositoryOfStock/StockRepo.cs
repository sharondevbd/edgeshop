using edgeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edgeShop.RepositoryOfStock
{
    public class StockRepo<T> : IRepo<T> where T : BaseDTO
    {
        private readonly List<T> All; //filed Variable of A (List Type) Obj All.

        public StockRepo() //Contructior
        {
            All = new List<T>();
        }


        public void AddRange(List<T> items)
        {
            foreach (var item in items)
            {
                All.Add(item);   
            }
        }

        public void Create(T item)
        {
            All.Add(item);
        }

        public void Delete(int Id)
        {
            var item = All.Find(x => x.Id == Id);
            All.Remove(item);
        }

        public List<T> GetAll()
        {
            return All;
        }

        public T GetById(int Id)
        {
            return All.Find(x => x.Id == Id);
        }

        public void Update(T item)
        {
            var i = All.IndexOf(item);
            All.RemoveAt(i);
            All.Insert(i, item);
        }
    }
}
