﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientIncrDecrPassif.ServiceIncrDecr {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceIncrDecr.IIncrDecrService", CallbackContract=typeof(ClientIncrDecrPassif.ServiceIncrDecr.IIncrDecrServiceCallback))]
    public interface IIncrDecrService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIncrDecrService/Decr", ReplyAction="http://tempuri.org/IIncrDecrService/DecrResponse")]
        void Decr();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIncrDecrService/Decr", ReplyAction="http://tempuri.org/IIncrDecrService/DecrResponse")]
        System.Threading.Tasks.Task DecrAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIncrDecrService/Incr", ReplyAction="http://tempuri.org/IIncrDecrService/IncrResponse")]
        void Incr();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIncrDecrService/Incr", ReplyAction="http://tempuri.org/IIncrDecrService/IncrResponse")]
        System.Threading.Tasks.Task IncrAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIncrDecrService/SubscribeIncrEvent", ReplyAction="http://tempuri.org/IIncrDecrService/SubscribeIncrEventResponse")]
        void SubscribeIncrEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIncrDecrService/SubscribeIncrEvent", ReplyAction="http://tempuri.org/IIncrDecrService/SubscribeIncrEventResponse")]
        System.Threading.Tasks.Task SubscribeIncrEventAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIncrDecrService/SubscribeDecrEvent", ReplyAction="http://tempuri.org/IIncrDecrService/SubscribeDecrEventResponse")]
        void SubscribeDecrEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIncrDecrService/SubscribeDecrEvent", ReplyAction="http://tempuri.org/IIncrDecrService/SubscribeDecrEventResponse")]
        System.Threading.Tasks.Task SubscribeDecrEventAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIncrDecrServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IIncrDecrService/IncrFinished")]
        void IncrFinished(int val);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IIncrDecrService/DecrFinished")]
        void DecrFinished(int val);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIncrDecrServiceChannel : ClientIncrDecrPassif.ServiceIncrDecr.IIncrDecrService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IncrDecrServiceClient : System.ServiceModel.DuplexClientBase<ClientIncrDecrPassif.ServiceIncrDecr.IIncrDecrService>, ClientIncrDecrPassif.ServiceIncrDecr.IIncrDecrService {
        
        public IncrDecrServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public IncrDecrServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public IncrDecrServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public IncrDecrServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public IncrDecrServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Decr() {
            base.Channel.Decr();
        }
        
        public System.Threading.Tasks.Task DecrAsync() {
            return base.Channel.DecrAsync();
        }
        
        public void Incr() {
            base.Channel.Incr();
        }
        
        public System.Threading.Tasks.Task IncrAsync() {
            return base.Channel.IncrAsync();
        }
        
        public void SubscribeIncrEvent() {
            base.Channel.SubscribeIncrEvent();
        }
        
        public System.Threading.Tasks.Task SubscribeIncrEventAsync() {
            return base.Channel.SubscribeIncrEventAsync();
        }
        
        public void SubscribeDecrEvent() {
            base.Channel.SubscribeDecrEvent();
        }
        
        public System.Threading.Tasks.Task SubscribeDecrEventAsync() {
            return base.Channel.SubscribeDecrEventAsync();
        }
    }
}