using edgeShop.FactoryRepo.Implementation.FactroryPattern;
using edgeShop.FactoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edgeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IrepoFactory repo = new FactoryRepo.FactoryRepo();
            FactoryContainer data = new FactoryContainer(repo);
            data.Excute();

            ////Method Pattern
            //Console.WriteLine("---DI----------------Method pattern---------");
            //MethodContainer methodContainer = new MethodContainer();
            //methodContainer.Execute(repo);

            Console.ReadKey();
        }
    }
}



