using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal: EfEntityRepositoryBase<Car, CarDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDBContext context = new CarDBContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands
                        on c.BrandId equals b.Id
                    join c1 in context.Colors
                        on c.ColorId equals c1.Id
                    select new CarDetailDto
                    {
                        BrandName = b.BrandName,
                        CarName = c.CarName,
                        ColorName = c1.ColorName,
                        ModelYear = c.ModelYear,
                        Description = c.Description

                    };
                return result.ToList();

            }
        }
    }
}
