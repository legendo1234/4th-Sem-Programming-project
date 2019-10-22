﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopFormsClient.ProductReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductReference.IProduct")]
    public interface IProduct {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Create", ReplyAction="http://tempuri.org/IProduct/CreateResponse")]
        bool Create(ShopService.Transporter.TProduct product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Create", ReplyAction="http://tempuri.org/IProduct/CreateResponse")]
        System.Threading.Tasks.Task<bool> CreateAsync(ShopService.Transporter.TProduct product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Read", ReplyAction="http://tempuri.org/IProduct/ReadResponse")]
        ShopService.Transporter.TProduct Read(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Read", ReplyAction="http://tempuri.org/IProduct/ReadResponse")]
        System.Threading.Tasks.Task<ShopService.Transporter.TProduct> ReadAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/ReadAll", ReplyAction="http://tempuri.org/IProduct/ReadAllResponse")]
        ShopService.Transporter.TProduct[] ReadAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/ReadAll", ReplyAction="http://tempuri.org/IProduct/ReadAllResponse")]
        System.Threading.Tasks.Task<ShopService.Transporter.TProduct[]> ReadAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Update", ReplyAction="http://tempuri.org/IProduct/UpdateResponse")]
        bool Update(ShopService.Transporter.TProduct product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Update", ReplyAction="http://tempuri.org/IProduct/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(ShopService.Transporter.TProduct product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Delete", ReplyAction="http://tempuri.org/IProduct/DeleteResponse")]
        bool Delete(ShopService.Transporter.TProduct product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Delete", ReplyAction="http://tempuri.org/IProduct/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(ShopService.Transporter.TProduct product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Restock", ReplyAction="http://tempuri.org/IProduct/RestockResponse")]
        bool Restock(ShopService.Transporter.TProduct product, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Restock", ReplyAction="http://tempuri.org/IProduct/RestockResponse")]
        System.Threading.Tasks.Task<bool> RestockAsync(ShopService.Transporter.TProduct product, int quantity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductChannel : ShopFormsClient.ProductReference.IProduct, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductClient : System.ServiceModel.ClientBase<ShopFormsClient.ProductReference.IProduct>, ShopFormsClient.ProductReference.IProduct {
        
        public ProductClient() {
        }
        
        public ProductClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Create(ShopService.Transporter.TProduct product) {
            return base.Channel.Create(product);
        }
        
        public System.Threading.Tasks.Task<bool> CreateAsync(ShopService.Transporter.TProduct product) {
            return base.Channel.CreateAsync(product);
        }
        
        public ShopService.Transporter.TProduct Read(int id) {
            return base.Channel.Read(id);
        }
        
        public System.Threading.Tasks.Task<ShopService.Transporter.TProduct> ReadAsync(int id) {
            return base.Channel.ReadAsync(id);
        }
        
        public ShopService.Transporter.TProduct[] ReadAll() {
            return base.Channel.ReadAll();
        }
        
        public System.Threading.Tasks.Task<ShopService.Transporter.TProduct[]> ReadAllAsync() {
            return base.Channel.ReadAllAsync();
        }
        
        public bool Update(ShopService.Transporter.TProduct product) {
            return base.Channel.Update(product);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(ShopService.Transporter.TProduct product) {
            return base.Channel.UpdateAsync(product);
        }
        
        public bool Delete(ShopService.Transporter.TProduct product) {
            return base.Channel.Delete(product);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(ShopService.Transporter.TProduct product) {
            return base.Channel.DeleteAsync(product);
        }
        
        public bool Restock(ShopService.Transporter.TProduct product, int quantity) {
            return base.Channel.Restock(product, quantity);
        }
        
        public System.Threading.Tasks.Task<bool> RestockAsync(ShopService.Transporter.TProduct product, int quantity) {
            return base.Channel.RestockAsync(product, quantity);
        }
    }
}