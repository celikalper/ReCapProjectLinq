using System;
using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDBContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarDBContext context = new CarDBContext())
            {
                var result = from r in context.Rentals
                    join c in context.Customers
                        on r.CustomerId equals c.Id
                    join car in context.Cars
                        on r.CarId equals car.Id
                    join u in context.Users
                        on c.UserId equals u.Id
                    select new RentalDetailDto
                    {
                        CompanyName = c.CompanyName,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        CarName = car.CarName,
                        Description = car.Description,
                        DailyPrice = car.DailyPrice,
                        RentDate = r.RentDate,
                        ReturnDate = r.ReturnDate
                    };
                return result.ToList();

            }
        }
    }
}