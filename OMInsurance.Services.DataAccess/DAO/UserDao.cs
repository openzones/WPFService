using OMInsurance.Services.DataAccess.Core;
using OMInsurance.Services.DataAccess.Core.Helpers;
using OMInsurance.Services.DataAccess.Materializers;
using OMInsurance.Services.Entities;
using OMInsurance.Services.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OMInsurance.Services.DataAccess.DAO
{
    public class UserDao : ItemDao
    {
        private static UserDao _instance = new UserDao();

        private UserDao()
            : base(DatabaseAliases.OMInsurance, new DatabaseErrorHandler())
        {
        }

        public static UserDao Instance
        {
            get
            {
                return _instance;
            }
        }


        public User User_GetByLogin(string userLogin)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.AddInputParameter("@Login", SqlDbType.NVarChar, userLogin);
            User user = Execute_Get(UserMaterializer.Instance, "User_GetByLogin", parameters);
            return user;
        }
    }
}
