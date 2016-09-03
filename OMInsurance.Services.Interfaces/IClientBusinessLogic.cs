using OMInsurance.Services.Entities;
using OMInsurance.Services.Entities.Core;
using OMInsurance.Services.Entities.Searching;
using System;
using System.Collections.Generic;

namespace OMInsurance.Services.Interfaces
{
    public interface IClientBusinessLogic
    {
        List<Policy> PolicyFind(PolicySearchCriteria criteria);
        List<Region> GetRegions();
    }
}
