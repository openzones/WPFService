using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace OMInsurance.Services.DMZ.PolicyStatusService
{
    public class Authenticator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (null == userName || null == password)
            {
                throw new ArgumentNullException();
            }

            using (var client = new OMInsurance.Services.DMZ.PolicyStatusService.Host.InternalAuthService.AuthServiceClient())
            {
                if (!client.CheckPassword(userName, password))
                {
                    throw new SecurityTokenException("Invalid Username or Password");
                }
            }
        }
    }
}