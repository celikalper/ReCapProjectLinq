using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine(car.Description+"Araç başarıyla eklendi.");
            }
            else
            {
                Console.WriteLine("Günlük fiyat 0'dan yüksek olmalıdır");
            }
           
        }

        public void Update(Car car)
        {
            if (car.DailyPrice>0)
            {
                _carDal.Update(car);
                Console.WriteLine("Araç güncellendi.");
            }
            else
            {
                Console.WriteLine("Hatalı giriş yapıldı.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
    }
}
