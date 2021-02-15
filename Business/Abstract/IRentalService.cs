using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        
        IDataResult<List<RentalDetailDto>> GetRentalDetails();


    }
}