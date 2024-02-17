using edgeShop.Models;
using edgeShop.RepositoryOfStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edgeShop.FactoryRepo.Implementation.MethodPattern
{
    internal class MethodContainer
    {
        public void ExecMethod(IrepoFactory factory)
        {
            #region CatagoryCRUD_Operation
                IRepo<Product> ProductRepo = factory.CreateRepo<Product>(); //Problem

            //Create Multiple Catagory
            ProductRepo.AddRange(new List<Product> {
            
            new Product{Id=1, CatagoryId=1, Name="Hp Workstation Z200",PurchasePrice=45000,SalePrice=52000,IsAvailable=true},
            new Product{Id=2, CatagoryId=2, Name="Dell Inspiration 15 3543",PurchasePrice=32000,SalePrice=35000,IsAvailable=true},
            new Product{Id=3, CatagoryId=3, Name="Logitech Mouse & Keyboard",PurchasePrice=1500,SalePrice=1800,IsAvailable=true},
            new Product{Id=4, CatagoryId=4, Name="Cisco C1111-4P ISR",PurchasePrice=82000,SalePrice=89000,IsAvailable=true},
            new Product{Id=5, CatagoryId=5, Name="Samsung J4+",PurchasePrice=16000,SalePrice=20000,IsAvailable=true}

            });

                //Read Operation
                Console.WriteLine("----------------------------Catagory List----------------------------");
                Console.WriteLine("ID \t Catagory Id \t Name \t PurchasePrice \t SalePrice \t Avilable");
            ProductRepo.GetAll().ForEach(p => { Console.WriteLine($"{p.Id}\t{p.CatagoryId}\t{p.Name}\t{p.PurchasePrice}\t{p.SalePrice}\t{p.IsAvailable}"); });

                //Update Operation

                var updateItem = ProductRepo.GetById(4);
            updateItem.IsAvailable = false;
            ProductRepo.Update(updateItem);

            //Delete Operation

            ProductRepo.Delete(4);
            Console.WriteLine("----------------------------Product List----------------------------");
            Console.WriteLine("ID \t Catagory Id \t Name \t PurchasePrice \t SalePrice \t Avilable");
            ProductRepo.GetAll().ForEach(p => { Console.WriteLine($"{p.Id}\t{p.CatagoryId}\t{p.Name}\t{p.PurchasePrice}\t{p.SalePrice}\t{p.IsAvailable}"); });

            #endregion

        }
    }
}
