using edgeShop.FactoryRepo.Implementation.FactroryPattern;
using edgeShop.FactoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using edgeShop.FactoryRepo.Implementation.MethodPattern;

namespace edgeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IrepoFactory repo = new FactoryRepo.FactoryRepo();
                FactoryContainer data = new FactoryContainer(repo);
                data.Excute();

                ////Method Pattern
                Console.WriteLine("____________________Method pattern____________________");
                MethodContainer methodConObj = new MethodContainer();
                methodConObj.ExecMethod(repo);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { Console.WriteLine("\nThanks To Respected Assesors & IsDB, Md. Naimul Islam Sharon, WADA-58, 1281042"); }
            Console.ReadKey();
        }
    }
}



