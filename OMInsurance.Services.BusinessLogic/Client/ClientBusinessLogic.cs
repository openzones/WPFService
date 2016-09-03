using OMInsurance.Services.DataAccess.DAO;
using OMInsurance.Services.Entities;
using OMInsurance.Services.Entities.Core;
using OMInsurance.Services.Entities.Core.Exeptions;
using OMInsurance.Services.Entities.Searching;
using OMInsurance.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OMInsurance.Services.BusinessLogic
{
    public class ClientBusinessLogic : IClientBusinessLogic
    {

        /// <summary>
        /// Returns sorted list of ClientVisitInfo by specified criteria
        /// </summary>
        /// <param name="criteria">Specified criteria</param>
        /// <param name="sortCriteria">Sort criteria</param>
        /// <param name="pageRequest">Page size and number</param>
        /// <returns>List of ClientVisitInfo</returns>
        public List<Policy> PolicyFind(PolicySearchCriteria criteria)
        {
            if (criteria == null)
            {
                throw new ArgumentNullException("criteria can't be null");
            }
            return ClientDao.Instance.PolicyFind(criteria);
        }

        public List<Region> GetRegions()
        {
            return ClientDao.Instance.GetRegions();
        }
    }
}
