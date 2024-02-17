using edgeShop.Models;
using edgeShop.RepositoryOfStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edgeShop.FactoryRepo.Implementation.FactroryPattern
{
    internal class FactoryContainer
    {
        IrepoFactory factory; //Variable of IrepoFactory
        public FactoryContainer(IrepoFactory repo)
        {
            this.factory = repo;
        }

        public void Excute()
        {
            #region CatagoryCRUD_Operation
            IRepo<Catagory> CatagoryRepo = factory.CreateRepo<Catagory>(); //Problem

            //Create Multiple Catagory
            CatagoryRepo.AddRange(new List<Catagory> {
            new Catagory{Id = 1, Name="Desktop", ParentId=1,IsAvailable= true},
            new Catagory{Id = 2, Name="Laptop", ParentId=2,IsAvailable= true},
            new Catagory{Id = 3, Name="Component", ParentId=3,IsAvailable= true},
            new Catagory{Id = 4, Name="Networking", ParentId=4,IsAvailable= true},
            new Catagory{Id = 5, Name="Mobile", ParentId=5,IsAvailable= true}
            });

            //Read Operation
            Console.WriteLine("----------------------------Catagory List----------------------------");
            Console.WriteLine("ID \t Name \t ParentID \t Active?");
            CatagoryRepo.GetAll().ForEach(c => { Console.WriteLine($"{c.Id}\t{c.Name}\t{c.ParentId}\t{c.IsAvailable}"); });
            
            //Update Operation
            
            var updateCat = CatagoryRepo.GetById(4);
            updateCat.IsAvailable = false;
            CatagoryRepo.Update(updateCat);

            //Delete Operation

            CatagoryRepo.Delete(4);
            Console.WriteLine("----------------------------Catagory List----------------------------");
            Console.WriteLine("ID \t Name \t ParentID \t Active?");
            CatagoryRepo.GetAll().ForEach(c => { Console.WriteLine($"{c.Id}\t{c.Name}\t{c.ParentId}\t{c.IsAvailable}"); });
            #endregion
        }

    }
}
