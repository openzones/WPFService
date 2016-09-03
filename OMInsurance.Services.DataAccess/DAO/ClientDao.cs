using OMInsurance.Services.DataAccess.Core;
using OMInsurance.Services.DataAccess.Core.Helpers;
using OMInsurance.Services.DataAccess.Materializers;
using OMInsurance.Services.Entities;
using OMInsurance.Services.Entities.Core;
using OMInsurance.Services.Entities.Searching;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OMInsurance.Services.DataAccess.DAO
{
    public class ClientDao : ItemDao
    {
        private static ClientDao _instance = new ClientDao();

        private ClientDao()
            : base(DatabaseAliases.OMInsurance, new DatabaseErrorHandler())
        {
        }

        public static ClientDao Instance
        {
            get
            {
                return _instance;
            }
        }

        public List<Policy> PolicyFind(PolicySearchCriteria criteria)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.AddInputParameter("@RegionId", SqlDbType.BigInt, criteria.RegionId);
            parameters.AddInputParameter("@ClientVisitDate", SqlDbType.DateTime, criteria.ClientVisitDate);
            parameters.AddInputParameter("@PolicyNumber", SqlDbType.NVarChar, criteria.PolicyNumber);
            parameters.AddInputParameter("@PolicySeries", SqlDbType.NVarChar, criteria.PolicySeries);
            parameters.AddInputParameter("@TemporaryPolicyNumber", SqlDbType.NVarChar, criteria.TemporaryPolicyNumber);
            parameters.AddInputParameter("@UnifiedPolicyNumber", SqlDbType.NVarChar, criteria.UnifiedPolicyNumber);

            parameters.AddInputParameter("@Firstname", SqlDbType.NVarChar, criteria.Firstname);
            parameters.AddInputParameter("@Secondname", SqlDbType.NVarChar, criteria.Secondname);
            parameters.AddInputParameter("@Lastname", SqlDbType.NVarChar, criteria.Lastname);

            parameters.AddInputParameter("@Birthday", SqlDbType.Date, criteria.Birthday);
            parameters.AddInputParameter("@Sex", SqlDbType.Char, criteria.Sex);

            parameters.AddInputParameter("@Phone", SqlDbType.NVarChar, criteria.Phone);
            return Execute_GetList(PolicyMaterializer.Instance, "Service_Client_Find", parameters);
        }

        public List<Region> GetRegions()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.AddInputParameter("@ReferenceName", SqlDbType.NVarChar, "UralsibRegionsRef");
            List<ReferenceItem> items = Execute_GetList<ReferenceItem>(ReferencesMaterializer.Instance, "Reference_GetList", parameters);
            List<Region> listRegions = new List<Region>();
            foreach(var item in items)
            {
                listRegions.Add( new Region() { Id = item.Id, Name = item.Name });
            }
            return listRegions;
        }
    }
}
