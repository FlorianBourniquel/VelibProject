﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceCalc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCalc.ICalcService", CallbackContract=typeof(Client.ServiceCalc.ICalcServiceCallback))]
    public interface ICalcService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Calculate", ReplyAction="http://tempuri.org/ICalcService/CalculateResponse")]
        void Calculate(int nOp, double dblNum1, double dblNum2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Calculate", ReplyAction="http://tempuri.org/ICalcService/CalculateResponse")]
        System.Threading.Tasks.Task CalculateAsync(int nOp, double dblNum1, double dblNum2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/SubscribeCalculatedEvent", ReplyAction="http://tempuri.org/ICalcService/SubscribeCalculatedEventResponse")]
        void SubscribeCalculatedEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/SubscribeCalculatedEvent", ReplyAction="http://tempuri.org/ICalcService/SubscribeCalculatedEventResponse")]
        System.Threading.Tasks.Task SubscribeCalculatedEventAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/SubscribeCalculationFinishedEvent", ReplyAction="http://tempuri.org/ICalcService/SubscribeCalculationFinishedEventResponse")]
        void SubscribeCalculationFinishedEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/SubscribeCalculationFinishedEvent", ReplyAction="http://tempuri.org/ICalcService/SubscribeCalculationFinishedEventResponse")]
        System.Threading.Tasks.Task SubscribeCalculationFinishedEventAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalcService/Calculated")]
        void Calculated(int nOp, double dblNum1, double dblNum2, double dblResult);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalcService/CalculationFinished")]
        void CalculationFinished();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcServiceChannel : Client.ServiceCalc.ICalcService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcServiceClient : System.ServiceModel.DuplexClientBase<Client.ServiceCalc.ICalcService>, Client.ServiceCalc.ICalcService {
        
        public CalcServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public CalcServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public CalcServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalcServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalcServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Calculate(int nOp, double dblNum1, double dblNum2) {
            base.Channel.Calculate(nOp, dblNum1, dblNum2);
        }
        
        public System.Threading.Tasks.Task CalculateAsync(int nOp, double dblNum1, double dblNum2) {
            return base.Channel.CalculateAsync(nOp, dblNum1, dblNum2);
        }
        
        public void SubscribeCalculatedEvent() {
            base.Channel.SubscribeCalculatedEvent();
        }
        
        public System.Threading.Tasks.Task SubscribeCalculatedEventAsync() {
            return base.Channel.SubscribeCalculatedEventAsync();
        }
        
        public void SubscribeCalculationFinishedEvent() {
            base.Channel.SubscribeCalculationFinishedEvent();
        }
        
        public System.Threading.Tasks.Task SubscribeCalculationFinishedEventAsync() {
            return base.Channel.SubscribeCalculationFinishedEventAsync();
        }
    }
}
