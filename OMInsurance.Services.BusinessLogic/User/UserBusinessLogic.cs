using OMInsurance.Services.DataAccess.DAO;
using OMInsurance.Services.Entities;
using OMInsurance.Services.Entities.Core;
using OMInsurance.Services.Interfaces;
using System.Collections.Generic;

namespace OMInsurance.Services.BusinessLogic
{
    public class UserBusinessLogic : IUserBusinessLogic
    {

        /// <summary>
        /// Returns user by login
        /// </summary>
        /// <param name="login">User login</param>
        /// <returns>Instance of user</returns>
        public User User_GetByLogin(string login)
        {
            return UserDao.Instance.User_GetByLogin(login);
        }
    }
}
