﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OMInsurance.Services.DMZ.PolicyStatusService.Host.InternalPolicyStatusService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InternalPolicyStatusService.IPolicyStatusService")]
    public interface IPolicyStatusService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetStatusByUnifiedPolicyNumber", ReplyAction="http://tempuri.org/IPolicyStatusService/GetStatusByUnifiedPolicyNumberResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OMInsurance.Entities.Core.Faults.DataObjectNotFoundFault), Action="http://tempuri.org/IPolicyStatusService/GetStatusByUnifiedPolicyNumberDataObjectN" +
            "otFoundFaultFault", Name="DataObjectNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/OMInsurance.Entities.Core.Faults")]
        OMInsurance.Entities.PolicyStatus GetStatusByUnifiedPolicyNumber(string unifiedPolicyNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetStatusByUnifiedPolicyNumber", ReplyAction="http://tempuri.org/IPolicyStatusService/GetStatusByUnifiedPolicyNumberResponse")]
        System.Threading.Tasks.Task<OMInsurance.Entities.PolicyStatus> GetStatusByUnifiedPolicyNumberAsync(string unifiedPolicyNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetStatusByNumber", ReplyAction="http://tempuri.org/IPolicyStatusService/GetStatusByNumberResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OMInsurance.Entities.Core.Faults.DataObjectNotFoundFault), Action="http://tempuri.org/IPolicyStatusService/GetStatusByNumberDataObjectNotFoundFaultF" +
            "ault", Name="DataObjectNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/OMInsurance.Entities.Core.Faults")]
        OMInsurance.Entities.PolicyStatus GetStatusByNumber(string series, string number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetStatusByNumber", ReplyAction="http://tempuri.org/IPolicyStatusService/GetStatusByNumberResponse")]
        System.Threading.Tasks.Task<OMInsurance.Entities.PolicyStatus> GetStatusByNumberAsync(string series, string number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetStatusByTemporaryPolicyNumber", ReplyAction="http://tempuri.org/IPolicyStatusService/GetStatusByTemporaryPolicyNumberResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OMInsurance.Entities.Core.Faults.DataObjectNotFoundFault), Action="http://tempuri.org/IPolicyStatusService/GetStatusByTemporaryPolicyNumberDataObjec" +
            "tNotFoundFaultFault", Name="DataObjectNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/OMInsurance.Entities.Core.Faults")]
        OMInsurance.Entities.PolicyStatus GetStatusByTemporaryPolicyNumber(string temporaryPolicyNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyStatusService/GetStatusByTemporaryPolicyNumber", ReplyAction="http://tempuri.org/IPolicyStatusService/GetStatusByTemporaryPolicyNumberResponse")]
        System.Threading.Tasks.Task<OMInsurance.Entities.PolicyStatus> GetStatusByTemporaryPolicyNumberAsync(string temporaryPolicyNumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPolicyStatusServiceChannel : OMInsurance.Services.DMZ.PolicyStatusService.Host.InternalPolicyStatusService.IPolicyStatusService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PolicyStatusServiceClient : System.ServiceModel.ClientBase<OMInsurance.Services.DMZ.PolicyStatusService.Host.InternalPolicyStatusService.IPolicyStatusService>, OMInsurance.Services.DMZ.PolicyStatusService.Host.InternalPolicyStatusService.IPolicyStatusService {
        
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
        
        public OMInsurance.Entities.PolicyStatus GetStatusByUnifiedPolicyNumber(string unifiedPolicyNumber) {
            return base.Channel.GetStatusByUnifiedPolicyNumber(unifiedPolicyNumber);
        }
        
        public System.Threading.Tasks.Task<OMInsurance.Entities.PolicyStatus> GetStatusByUnifiedPolicyNumberAsync(string unifiedPolicyNumber) {
            return base.Channel.GetStatusByUnifiedPolicyNumberAsync(unifiedPolicyNumber);
        }
        
        public OMInsurance.Entities.PolicyStatus GetStatusByNumber(string series, string number) {
            return base.Channel.GetStatusByNumber(series, number);
        }
        
        public System.Threading.Tasks.Task<OMInsurance.Entities.PolicyStatus> GetStatusByNumberAsync(string series, string number) {
            return base.Channel.GetStatusByNumberAsync(series, number);
        }
        
        public OMInsurance.Entities.PolicyStatus GetStatusByTemporaryPolicyNumber(string temporaryPolicyNumber) {
            return base.Channel.GetStatusByTemporaryPolicyNumber(temporaryPolicyNumber);
        }
        
        public System.Threading.Tasks.Task<OMInsurance.Entities.PolicyStatus> GetStatusByTemporaryPolicyNumberAsync(string temporaryPolicyNumber) {
            return base.Channel.GetStatusByTemporaryPolicyNumberAsync(temporaryPolicyNumber);
        }
    }
}
