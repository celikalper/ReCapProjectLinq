using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string CarName { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
