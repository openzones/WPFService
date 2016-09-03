using OMInsurance.Services.DataAccess.Core;
using OMInsurance.Services.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OMInsurance.Services.DataAccess.Materializers
{
    public class PolicyMaterializer : IMaterializer<Policy>
    {
        private static readonly PolicyMaterializer _instance = new PolicyMaterializer();

        public static PolicyMaterializer Instance
        {
            get
            {
                return _instance;
            }
        }

        public Policy Materialize(DataReaderAdapter reader)
        {
            return Materialize_List(reader).FirstOrDefault();
        }

        public List<Policy> Materialize_List(DataReaderAdapter reader)
        {
            List<Policy> items = new List<Policy>();

            while (reader.Read())
            {
                Policy obj = ReadItemFields(reader);
                items.Add(obj);
            }
            return items;
        }

        public Policy ReadItemFields(DataReaderAdapter reader, Policy item = null)
        {
            if (item == null)
            {
                item = new Policy();
            }

            item.Id = reader.GetInt64("ID");
            item.RegionId = reader.GetInt64("RegionId");
            item.TemporaryPolicyNumber = reader.GetString("TemporaryPolicyNumber");
            item.UnifiedPolicyNumber = reader.GetString("UnifiedPolicyNumber");
            item.PolicySeries = reader.GetString("PolicySeries");
            item.PolicyNumber = reader.GetString("PolicyNumber");
            item.PolicyStatus.Id = reader.GetInt64Null("StatusId") ?? 0; ;
            item.PolicyStatus.Name = reader.GetString("StatusName");
            item.ClientVisitDate = reader.GetDateTimeNull("ClientVisitDate");
            item.ApplicationMethod = reader.GetString("ApplicationMethod");
            item.DeliveryCenter.Id = reader.GetInt64Null("DeliveryCenterId") ?? 0;
            item.DeliveryCenter.Code = reader.GetString("DeliveryCenterCode");
            item.DeliveryCenter.Name = reader.GetString("DeliveryCenterName");
            item.Firstname = reader.GetString("FirstName");
            item.Secondname = reader.GetString("Secondname");
            item.Lastname = reader.GetString("Lastname");
            item.Sex = reader.GetString("Sex");
            item.Birthday = reader.GetDateTimeNull("Birthday");
            item.Phone = reader.GetString("Phone");
            item.Category = reader.GetString("Category");
            item.Citizenship = reader.GetString("Citizenship");
            item.DeliveryPoint.Id = reader.GetInt64Null("DeliveryPointId") ?? 0;
            item.DeliveryPoint.Code = reader.GetString("DeliveryPointCode");
            item.DeliveryPoint.Name = reader.GetString("DeliveryPointName");
            item.IssueDate = reader.GetDateTimeNull("IssueDate");
            item.StatusDate = reader.GetDateTimeNull("StatusDate");
            item.NomernikStatus = reader.GetString("NomernikStatus");
            item.LPU = reader.GetString("LPU");
            item.AttachmentDate = reader.GetDateTimeNull("AttachmentDate");
            item.AttachmentMethod = reader.GetString("AttachmentMethod");
            item.BlankNumber = reader.GetString("BlankNumber");
            item.SaveDate = reader.GetDateTimeNull("SaveDate");

            return item;
        }
    }
}
