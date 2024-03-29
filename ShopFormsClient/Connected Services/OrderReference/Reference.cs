﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopFormsClient.OrderReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderReference.IOrder")]
    public interface IOrder {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/Create", ReplyAction="http://tempuri.org/IOrder/CreateResponse")]
        bool Create(ShopService.Transporter.TOrder order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/Create", ReplyAction="http://tempuri.org/IOrder/CreateResponse")]
        System.Threading.Tasks.Task<bool> CreateAsync(ShopService.Transporter.TOrder order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderChannel : ShopFormsClient.OrderReference.IOrder, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderClient : System.ServiceModel.ClientBase<ShopFormsClient.OrderReference.IOrder>, ShopFormsClient.OrderReference.IOrder {
        
        public OrderClient() {
        }
        
        public OrderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Create(ShopService.Transporter.TOrder order) {
            return base.Channel.Create(order);
        }
        
        public System.Threading.Tasks.Task<bool> CreateAsync(ShopService.Transporter.TOrder order) {
            return base.Channel.CreateAsync(order);
        }
    }
}
