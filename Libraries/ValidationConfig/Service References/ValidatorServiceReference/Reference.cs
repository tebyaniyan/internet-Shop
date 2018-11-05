﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ValidationConfig.ValidatorServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ValidatorServiceReference.Service1Soap")]
    public interface Service1Soap {
        
        // CODEGEN: Generating message contract since element name url from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetValidationStatus", ReplyAction="*")]
        ValidationConfig.ValidatorServiceReference.GetValidationStatusResponse GetValidationStatus(ValidationConfig.ValidatorServiceReference.GetValidationStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetValidationStatus", ReplyAction="*")]
        System.Threading.Tasks.Task<ValidationConfig.ValidatorServiceReference.GetValidationStatusResponse> GetValidationStatusAsync(ValidationConfig.ValidatorServiceReference.GetValidationStatusRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetValidationStatusRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetValidationStatus", Namespace="http://tempuri.org/", Order=0)]
        public ValidationConfig.ValidatorServiceReference.GetValidationStatusRequestBody Body;
        
        public GetValidationStatusRequest() {
        }
        
        public GetValidationStatusRequest(ValidationConfig.ValidatorServiceReference.GetValidationStatusRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetValidationStatusRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string url;
        
        public GetValidationStatusRequestBody() {
        }
        
        public GetValidationStatusRequestBody(string url) {
            this.url = url;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetValidationStatusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetValidationStatusResponse", Namespace="http://tempuri.org/", Order=0)]
        public ValidationConfig.ValidatorServiceReference.GetValidationStatusResponseBody Body;
        
        public GetValidationStatusResponse() {
        }
        
        public GetValidationStatusResponse(ValidationConfig.ValidatorServiceReference.GetValidationStatusResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetValidationStatusResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool GetValidationStatusResult;
        
        public GetValidationStatusResponseBody() {
        }
        
        public GetValidationStatusResponseBody(bool GetValidationStatusResult) {
            this.GetValidationStatusResult = GetValidationStatusResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : ValidationConfig.ValidatorServiceReference.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<ValidationConfig.ValidatorServiceReference.Service1Soap>, ValidationConfig.ValidatorServiceReference.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ValidationConfig.ValidatorServiceReference.GetValidationStatusResponse ValidationConfig.ValidatorServiceReference.Service1Soap.GetValidationStatus(ValidationConfig.ValidatorServiceReference.GetValidationStatusRequest request) {
            return base.Channel.GetValidationStatus(request);
        }
        
        public bool GetValidationStatus(string url) {
            ValidationConfig.ValidatorServiceReference.GetValidationStatusRequest inValue = new ValidationConfig.ValidatorServiceReference.GetValidationStatusRequest();
            inValue.Body = new ValidationConfig.ValidatorServiceReference.GetValidationStatusRequestBody();
            inValue.Body.url = url;
            ValidationConfig.ValidatorServiceReference.GetValidationStatusResponse retVal = ((ValidationConfig.ValidatorServiceReference.Service1Soap)(this)).GetValidationStatus(inValue);
            return retVal.Body.GetValidationStatusResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ValidationConfig.ValidatorServiceReference.GetValidationStatusResponse> ValidationConfig.ValidatorServiceReference.Service1Soap.GetValidationStatusAsync(ValidationConfig.ValidatorServiceReference.GetValidationStatusRequest request) {
            return base.Channel.GetValidationStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<ValidationConfig.ValidatorServiceReference.GetValidationStatusResponse> GetValidationStatusAsync(string url) {
            ValidationConfig.ValidatorServiceReference.GetValidationStatusRequest inValue = new ValidationConfig.ValidatorServiceReference.GetValidationStatusRequest();
            inValue.Body = new ValidationConfig.ValidatorServiceReference.GetValidationStatusRequestBody();
            inValue.Body.url = url;
            return ((ValidationConfig.ValidatorServiceReference.Service1Soap)(this)).GetValidationStatusAsync(inValue);
        }
    }
}