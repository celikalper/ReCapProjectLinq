using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //Test(carManager);

            foreach (var car in carManager.GetCarDetails())
            {

                Console.WriteLine("{0} {1} ", "Marka :", car.BrandName);
                Console.WriteLine("{0} {1} ", "Model :", car.CarName);
                Console.WriteLine("{0} {1} ", "Renk :", car.ColorName);
                Console.WriteLine("{0} {1} ", "Yıl :", car.ModelYear);
                Console.WriteLine("{0} {1} ", "Açıklama :", car.Description);
                Console.WriteLine("-------------------------------------------");

            }



        }

        private static void Test(CarManager carManager)
        {
            Console.WriteLine("Bütün araçları göre listele");
            Console.WriteLine("");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("");
            Console.WriteLine("BrandId'ye göre listele");
            Console.WriteLine("");
            foreach (var car in carManager.GetCarsByBrandId(6))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("");
            Console.WriteLine("ColorId'ye göre listele");
            Console.WriteLine("");
            foreach (var car in carManager.GetCarsByColorId(4))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("");
            Console.WriteLine("Brand listele");
            Console.WriteLine("");

            //carManager.Add(new Car
            //{
            //    BrandId = 1,
            //    ColorId = 1,
            //    ModelYear = "1989",
            //    DailyPrice = 1,
            //    Description = "test"
            //});
            //carManager.Delete(new Car { Id = 18 });
        }
    }
}
