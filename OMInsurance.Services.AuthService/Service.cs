using OMInsurance.Services.BusinessLogic;
using OMInsurance.Services.Entities;
using OMInsurance.Services.Interfaces;
using OMInsurance.Services.Utils;

namespace OMInsurance.Services.AuthService
{
    public class Service : IAuthService
    {
        public bool CheckPassword(string username, string password)
        {
            UserBusinessLogic userBll = new UserBusinessLogic();
            User user = userBll.User_GetByLogin(username);
            if (user == null)
            {
                return false;
            }
            else
            {
                return PasswordHash.ValidatePassword(password, user.PasswordHash);
            }
        }
    }
}
