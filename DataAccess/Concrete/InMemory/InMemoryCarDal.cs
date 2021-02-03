using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car
                {
                    Id = 1,
                    BrandId = 1,
                    ColorId = 1,
                    ModelYear = 2005,
                    DailyPrice = 75000,
                    Description = "Citroen C4 1.6 Benzinli"
                },
                new Car
                {
                    Id = 2,
                    BrandId = 2,
                    ColorId = 1,
                    ModelYear = 2010,
                    DailyPrice = 250000,
                    Description = "Mercedes A180 2.0 TDI"
                },
                new Car
                {
                    Id = 3,
                    BrandId = 3,
                    ColorId = 3,
                    ModelYear = 2020,
                    DailyPrice = 250000,
                    Description = "Volvo S60 D5"
                },
                new Car
                {
                    Id = 4,
                    BrandId = 1,
                    ColorId = 2,
                    ModelYear = 2005,
                    DailyPrice = 75000,
                    Description = "Citroen C4 1.5 Dizel"
                }
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.BrandId == id).ToList();
        }
    }
}
