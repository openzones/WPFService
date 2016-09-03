using OMInsurance.Services.BusinessLogic;
using OMInsurance.Services.Entities;
using OMInsurance.Services.Entities.Core;
using OMInsurance.Services.Entities.Core.Faults;
using OMInsurance.Services.Entities.Searching;
using OMInsurance.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System;

namespace OMInsurance.Services.PolicyStatusService
{
    public class Service : IPolicyStatusService
    {
        private IClientBusinessLogic clientBll;
        public Service()
        {
            clientBll = new ClientBusinessLogic();
        }

        /// <summary>
        /// Возвращаем список регионов
        /// </summary>
        /// <returns></returns>
        public List<Region> GetRegions()
        {
            List<Region> listRegions = clientBll.GetRegions();
            if (listRegions.Count > 0)
            {
                return clientBll.GetRegions();
            }
            else
            {
                string errorMessage = string.Format("List regions not found {0}");
                throw new FaultException<DataObjectNotFoundFault>(
                    new DataObjectNotFoundFault()
                    {
                        ErrorMessage = errorMessage
                    }, errorMessage);
            }
        }

        public PolicyInfo GetStatusByUnifiedPolicyNumber(int regionId, string unifiedPolicyNumber)
        {
            PolicySearchCriteria criteria = new PolicySearchCriteria()
            {
                RegionId = regionId,
                UnifiedPolicyNumber = unifiedPolicyNumber
            };
            List<Policy> listPolicy = clientBll.PolicyFind(criteria);
            if (listPolicy.Count > 0)
            {
                Policy policy = listPolicy.LastOrDefault();
                return new PolicyInfo(policy);
            }
            else
            {
                string errorMessage = string.Format("Policy not found {0}", unifiedPolicyNumber);
                throw new FaultException<DataObjectNotFoundFault>(
                    new DataObjectNotFoundFault()
                    {
                        ErrorMessage = errorMessage
                    }, errorMessage);
            }
        }

        public PolicyInfo GetStatusByNumber(int regionId, string series, string number)
        {
            PolicySearchCriteria criteria = new PolicySearchCriteria()
            {
                RegionId = regionId,
                PolicySeries = series,
                PolicyNumber = number
            };
            List<Policy> listPolicy = clientBll.PolicyFind(criteria);
            if (listPolicy.Count > 0)
            {
                Policy policy = listPolicy.LastOrDefault();
                return new PolicyInfo(policy);
            }
            else
            {
                string errorMessage = string.Format("Policy not found {0} {1}", series, number);
                throw new FaultException<DataObjectNotFoundFault>(
                    new DataObjectNotFoundFault()
                    {
                        ErrorMessage = errorMessage
                    }, errorMessage);
            }
        }

        public PolicyInfo GetStatusByTemporaryPolicyNumber(int regionId, string temporaryPolicyNumber)
        {
            PolicySearchCriteria criteria = new PolicySearchCriteria()
            {
                RegionId = regionId,
                TemporaryPolicyNumber = temporaryPolicyNumber
            };
            List<Policy> listPolicy = clientBll.PolicyFind(criteria);
            if (listPolicy.Count > 0)
            {
                Policy policy = listPolicy.LastOrDefault();
                return new PolicyInfo(policy);
            }
            else
            {
                string errorMessage = string.Format("Policy not found {0}", temporaryPolicyNumber);
                throw new FaultException<DataObjectNotFoundFault>(
                    new DataObjectNotFoundFault()
                    {
                        ErrorMessage = errorMessage
                    }, errorMessage);
            }
        }

        public Policy GetStatusByFIOBirthday(int regionId, string lastname, string firstname, string secondname, DateTime? birthday)
        {
            PolicySearchCriteria criteria = new PolicySearchCriteria()
            {
                RegionId = regionId,
                Lastname = lastname,
                Firstname = firstname,
                Secondname = secondname,
                Birthday = birthday
            };
            List<Policy> listPolicy = clientBll.PolicyFind(criteria);
            if (listPolicy.Count > 0)
            {
                Policy policy = listPolicy.LastOrDefault();
                return policy;
            }
            else
            {
                string errorMessage = string.Format("Policy not found");
                throw new FaultException<DataObjectNotFoundFault>(
                    new DataObjectNotFoundFault()
                    {
                        ErrorMessage = errorMessage
                    }, errorMessage);
            }
        }

        public Person GetFIOByPhone(int regionId, string phone)
        {
            PolicySearchCriteria criteria = new PolicySearchCriteria()
            {
                RegionId = regionId,
                Phone = phone
            };
            List<Policy> listPolicy = clientBll.PolicyFind(criteria);
            if (listPolicy.Count > 0)
            {
                Policy policy = listPolicy.LastOrDefault();
                return new Person(policy);
            }
            else
            {
                string errorMessage = string.Format("Policy not found");
                throw new FaultException<DataObjectNotFoundFault>(
                    new DataObjectNotFoundFault()
                    {
                        ErrorMessage = errorMessage
                    }, errorMessage);
            }
        }
    }
}
