using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);

                
            }
            Console.WriteLine("------------------- BrandId'ye göre Sonuç. -------------------");
            foreach (var car in carManager.GetById(3))
            {
                Console.WriteLine("BrandId'si "+car.BrandId+" olan araçlar: "+ car.Description);
            }
            
          
        }
    }
}
