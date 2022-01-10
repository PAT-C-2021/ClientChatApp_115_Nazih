﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientChatApp_115_Nazih.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServiceCallback", CallbackContract=typeof(ClientChatApp_115_Nazih.ServiceReference1.IServiceCallbackCallback))]
    public interface IServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCallback/gabung")]
        void gabung(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCallback/gabung")]
        System.Threading.Tasks.Task gabungAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCallback/kirimPesan")]
        void kirimPesan(string pesan);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCallback/kirimPesan")]
        System.Threading.Tasks.Task kirimPesanAsync(string pesan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCallback/GetData", ReplyAction="http://tempuri.org/IServiceCallback/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCallback/GetData", ReplyAction="http://tempuri.org/IServiceCallback/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCallback/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IServiceCallback/GetDataUsingDataContractResponse")]
        WCFService_2Way_115.CompositeType GetDataUsingDataContract(WCFService_2Way_115.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCallback/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IServiceCallback/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WCFService_2Way_115.CompositeType> GetDataUsingDataContractAsync(WCFService_2Way_115.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCallbackCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCallback/pesanKirim")]
        void pesanKirim(string user, string pesan);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCallbackChannel : ClientChatApp_115_Nazih.ServiceReference1.IServiceCallback, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCallbackClient : System.ServiceModel.DuplexClientBase<ClientChatApp_115_Nazih.ServiceReference1.IServiceCallback>, ClientChatApp_115_Nazih.ServiceReference1.IServiceCallback {
        
        public ServiceCallbackClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServiceCallbackClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServiceCallbackClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCallbackClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCallbackClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void gabung(string username) {
            base.Channel.gabung(username);
        }
        
        public System.Threading.Tasks.Task gabungAsync(string username) {
            return base.Channel.gabungAsync(username);
        }
        
        public void kirimPesan(string pesan) {
            base.Channel.kirimPesan(pesan);
        }
        
        public System.Threading.Tasks.Task kirimPesanAsync(string pesan) {
            return base.Channel.kirimPesanAsync(pesan);
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WCFService_2Way_115.CompositeType GetDataUsingDataContract(WCFService_2Way_115.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WCFService_2Way_115.CompositeType> GetDataUsingDataContractAsync(WCFService_2Way_115.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
