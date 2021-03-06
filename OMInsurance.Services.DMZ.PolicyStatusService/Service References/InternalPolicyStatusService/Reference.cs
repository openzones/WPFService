﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OMInsurance.Services.DMZ.PolicyStatusService.InternalPolicyStatusService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InternalPolicyStatusService.IPolicyStatusService")]
    public interface IPolicyStatusService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetStatusByUnifiedPolicyNumber", ReplyAction="http://tempuri.org/IPolicyStatusService/GetStatusByUnifiedPolicyNumberResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OMInsurance.Services.Entities.Core.Faults.DataObjectNotFoundFault), Action="http://tempuri.org/IPolicyStatusService/GetStatusByUnifiedPolicyNumberDataObjectN" +
            "otFoundFaultFault", Name="DataObjectNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/OMInsurance.Services.Entities.Core.Faults" +
            "")]
        OMInsurance.Services.Entities.PolicyInfo GetStatusByUnifiedPolicyNumber(int regionId, string unifiedPolicyNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetStatusByUnifiedPolicyNumber", ReplyAction="http://tempuri.org/IPolicyStatusService/GetStatusByUnifiedPolicyNumberResponse")]
        System.Threading.Tasks.Task<OMInsurance.Services.Entities.PolicyInfo> GetStatusByUnifiedPolicyNumberAsync(int regionId, string unifiedPolicyNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetStatusByNumber", ReplyAction="http://tempuri.org/IPolicyStatusService/GetStatusByNumberResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OMInsurance.Services.Entities.Core.Faults.DataObjectNotFoundFault), Action="http://tempuri.org/IPolicyStatusService/GetStatusByNumberDataObjectNotFoundFaultF" +
            "ault", Name="DataObjectNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/OMInsurance.Services.Entities.Core.Faults" +
            "")]
        OMInsurance.Services.Entities.PolicyInfo GetStatusByNumber(int regionId, string series, string number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetStatusByNumber", ReplyAction="http://tempuri.org/IPolicyStatusService/GetStatusByNumberResponse")]
        System.Threading.Tasks.Task<OMInsurance.Services.Entities.PolicyInfo> GetStatusByNumberAsync(int regionId, string series, string number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetStatusByTemporaryPolicyNumber", ReplyAction="http://tempuri.org/IPolicyStatusService/GetStatusByTemporaryPolicyNumberResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OMInsurance.Services.Entities.Core.Faults.DataObjectNotFoundFault), Action="http://tempuri.org/IPolicyStatusService/GetStatusByTemporaryPolicyNumberDataObjec" +
            "tNotFoundFaultFault", Name="DataObjectNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/OMInsurance.Services.Entities.Core.Faults" +
            "")]
        OMInsurance.Services.Entities.PolicyInfo GetStatusByTemporaryPolicyNumber(int regionId, string temporaryPolicyNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetStatusByTemporaryPolicyNumber", ReplyAction="http://tempuri.org/IPolicyStatusService/GetStatusByTemporaryPolicyNumberResponse")]
        System.Threading.Tasks.Task<OMInsurance.Services.Entities.PolicyInfo> GetStatusByTemporaryPolicyNumberAsync(int regionId, string temporaryPolicyNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetStatusByFIOBirthday", ReplyAction="http://tempuri.org/IPolicyStatusService/GetStatusByFIOBirthdayResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OMInsurance.Services.Entities.Core.Faults.DataObjectNotFoundFault), Action="http://tempuri.org/IPolicyStatusService/GetStatusByFIOBirthdayDataObjectNotFoundF" +
            "aultFault", Name="DataObjectNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/OMInsurance.Services.Entities.Core.Faults" +
            "")]
        OMInsurance.Services.Entities.Policy GetStatusByFIOBirthday(int regionId, string lastname, string firstname, string secondname, System.Nullable<System.DateTime> birthday);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetStatusByFIOBirthday", ReplyAction="http://tempuri.org/IPolicyStatusService/GetStatusByFIOBirthdayResponse")]
        System.Threading.Tasks.Task<OMInsurance.Services.Entities.Policy> GetStatusByFIOBirthdayAsync(int regionId, string lastname, string firstname, string secondname, System.Nullable<System.DateTime> birthday);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetFIOByPhone", ReplyAction="http://tempuri.org/IPolicyStatusService/GetFIOByPhoneResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OMInsurance.Services.Entities.Core.Faults.DataObjectNotFoundFault), Action="http://tempuri.org/IPolicyStatusService/GetFIOByPhoneDataObjectNotFoundFaultFault" +
            "", Name="DataObjectNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/OMInsurance.Services.Entities.Core.Faults" +
            "")]
        OMInsurance.Services.Entities.Person GetFIOByPhone(int regionId, string Phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetFIOByPhone", ReplyAction="http://tempuri.org/IPolicyStatusService/GetFIOByPhoneResponse")]
        System.Threading.Tasks.Task<OMInsurance.Services.Entities.Person> GetFIOByPhoneAsync(int regionId, string Phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetRegions", ReplyAction="http://tempuri.org/IPolicyStatusService/GetRegionsResponse")]
        System.Collections.Generic.List<OMInsurance.Services.Entities.Region> GetRegions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetRegions", ReplyAction="http://tempuri.org/IPolicyStatusService/GetRegionsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<OMInsurance.Services.Entities.Region>> GetRegionsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPolicyStatusServiceChannel : OMInsurance.Services.DMZ.PolicyStatusService.InternalPolicyStatusService.IPolicyStatusService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PolicyStatusServiceClient : System.ServiceModel.ClientBase<OMInsurance.Services.DMZ.PolicyStatusService.InternalPolicyStatusService.IPolicyStatusService>, OMInsurance.Services.DMZ.PolicyStatusService.InternalPolicyStatusService.IPolicyStatusService {
        
        public PolicyStatusServiceClient() {
        }
        
        public PolicyStatusServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PolicyStatusServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PolicyStatusServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PolicyStatusServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public OMInsurance.Services.Entities.PolicyInfo GetStatusByUnifiedPolicyNumber(int regionId, string unifiedPolicyNumber) {
            return base.Channel.GetStatusByUnifiedPolicyNumber(regionId, unifiedPolicyNumber);
        }
        
        public System.Threading.Tasks.Task<OMInsurance.Services.Entities.PolicyInfo> GetStatusByUnifiedPolicyNumberAsync(int regionId, string unifiedPolicyNumber) {
            return base.Channel.GetStatusByUnifiedPolicyNumberAsync(regionId, unifiedPolicyNumber);
        }
        
        public OMInsurance.Services.Entities.PolicyInfo GetStatusByNumber(int regionId, string series, string number) {
            return base.Channel.GetStatusByNumber(regionId, series, number);
        }
        
        public System.Threading.Tasks.Task<OMInsurance.Services.Entities.PolicyInfo> GetStatusByNumberAsync(int regionId, string series, string number) {
            return base.Channel.GetStatusByNumberAsync(regionId, series, number);
        }
        
        public OMInsurance.Services.Entities.PolicyInfo GetStatusByTemporaryPolicyNumber(int regionId, string temporaryPolicyNumber) {
            return base.Channel.GetStatusByTemporaryPolicyNumber(regionId, temporaryPolicyNumber);
        }
        
        public System.Threading.Tasks.Task<OMInsurance.Services.Entities.PolicyInfo> GetStatusByTemporaryPolicyNumberAsync(int regionId, string temporaryPolicyNumber) {
            return base.Channel.GetStatusByTemporaryPolicyNumberAsync(regionId, temporaryPolicyNumber);
        }
        
        public OMInsurance.Services.Entities.Policy GetStatusByFIOBirthday(int regionId, string lastname, string firstname, string secondname, System.Nullable<System.DateTime> birthday) {
            return base.Channel.GetStatusByFIOBirthday(regionId, lastname, firstname, secondname, birthday);
        }
        
        public System.Threading.Tasks.Task<OMInsurance.Services.Entities.Policy> GetStatusByFIOBirthdayAsync(int regionId, string lastname, string firstname, string secondname, System.Nullable<System.DateTime> birthday) {
            return base.Channel.GetStatusByFIOBirthdayAsync(regionId, lastname, firstname, secondname, birthday);
        }
        
        public OMInsurance.Services.Entities.Person GetFIOByPhone(int regionId, string Phone) {
            return base.Channel.GetFIOByPhone(regionId, Phone);
        }
        
        public System.Threading.Tasks.Task<OMInsurance.Services.Entities.Person> GetFIOByPhoneAsync(int regionId, string Phone) {
            return base.Channel.GetFIOByPhoneAsync(regionId, Phone);
        }
        
        public System.Collections.Generic.List<OMInsurance.Services.Entities.Region> GetRegions() {
            return base.Channel.GetRegions();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<OMInsurance.Services.Entities.Region>> GetRegionsAsync() {
            return base.Channel.GetRegionsAsync();
        }
    }
}
