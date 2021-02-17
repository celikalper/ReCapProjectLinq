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
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //Test(carManager);
            //GetByIdTest(carManager);

            //var result = rentalManager.GetRentalDetails();

            //foreach (var r in result.Data)
            //{
            //    Console.WriteLine(r.FirstName);
            //    Console.WriteLine(r.LastName);
            //    Console.WriteLine(r.CompanyName);
            //    Console.WriteLine(r.CarName);
            //    Console.WriteLine(r.Description);
            //    Console.WriteLine(r.DailyPrice);
            //    Console.WriteLine(r.RentDate);
            //    Console.WriteLine(r.ReturnDate);
            //    Console.WriteLine("----------------------------------------");

            //}

        }

        private static void GetByIdTest(CarManager carManager)
        {
            var result = carManager.GetById(6);

            if (result.Success == true)
            {
                Console.WriteLine("{0} {1}", "Model :", result.Data.CarName);
                Console.WriteLine("{0} {1}", "Model :", result.Data.Description);
                Console.WriteLine("-------------------------------------------");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void Test(CarManager carManager)
        {
            Console.WriteLine("Bütün araçları göre listele");
            Console.WriteLine("");
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("");
            Console.WriteLine("BrandId'ye göre listele");
            Console.WriteLine("");
            foreach (var car in carManager.GetCarsByBrandId(6).Data)
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("");
            Console.WriteLine("ColorId'ye göre listele");
            Console.WriteLine("");
            foreach (var car in carManager.GetCarsByColorId(4).Data)
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
