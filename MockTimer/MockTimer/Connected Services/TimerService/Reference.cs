﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MockTimer.TimerService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TimerService.ITimer")]
    public interface ITimer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimer/TriggerUpdate", ReplyAction="http://tempuri.org/ITimer/TriggerUpdateResponse")]
        void TriggerUpdate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimer/TriggerUpdate", ReplyAction="http://tempuri.org/ITimer/TriggerUpdateResponse")]
        System.Threading.Tasks.Task TriggerUpdateAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITimerChannel : MockTimer.TimerService.ITimer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TimerClient : System.ServiceModel.ClientBase<MockTimer.TimerService.ITimer>, MockTimer.TimerService.ITimer {
        
        public TimerClient() {
        }
        
        public TimerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TimerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TimerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TimerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void TriggerUpdate() {
            base.Channel.TriggerUpdate();
        }
        
        public System.Threading.Tasks.Task TriggerUpdateAsync() {
            return base.Channel.TriggerUpdateAsync();
        }
    }
}
