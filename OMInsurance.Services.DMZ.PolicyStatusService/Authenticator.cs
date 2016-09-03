using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace OMInsurance.Services.DMZ.PolicyStatusService
{
    public class Authenticator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            try
            {
                if (null == userName || null == password)
                {
                    throw new ArgumentNullException();
                }

                using (var client = new InternalAuthService.AuthServiceClient())
                {
                    if (!client.CheckPassword(userName, password))
                    {
                        throw new SecurityTokenException("Invalid Username or Password");
                    }
                }
            }
            catch (SecurityTokenException ex)
            {
                using (var writer = new StreamWriter("C:\\Temp\\log.txt", true))
                {
                    writer.WriteLine(ex.GetType());
                    writer.WriteLine(ex.Message);
                    writer.WriteLine(ex.StackTrace);
                    writer.WriteLine(ex.InnerException);
                }
                throw ex;
            }
            catch (Exception ex)
            {
                using (var writer = new StreamWriter("C:\\Temp\\log.txt", true))
                {
                    writer.WriteLine(ex.GetType());
                    writer.WriteLine(ex.Message);
                    writer.WriteLine(ex.InnerException);
                    writer.WriteLine(ex.StackTrace);
                }
            }
        }
    }
}