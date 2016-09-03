using OMInsurance.Services.Entities;
using OMInsurance.Services.Entities.Core;
using System.Collections.Generic;

namespace OMInsurance.Services.Interfaces
{
    public interface IUserBusinessLogic
    {
        User User_GetByLogin(string login);
    }
}
