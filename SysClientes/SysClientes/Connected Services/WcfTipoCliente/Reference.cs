﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysClientes.WcfTipoCliente {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Clientes", Namespace="http://schemas.datacontract.org/2004/07/WCF_CRUD")]
    [System.SerializableAttribute()]
    public partial class Clientes : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GetSetCLIE_CPFField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> GetSetCLIE_FK_PK_SICLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> GetSetCLIE_FK_PK_TICLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> GetSetCLIE_NASCIMENTOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GetSetCLIE_NOMEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> GetSetCLIE_PK_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GetSetCLIE_SEXOField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GetSetCLIE_CPF {
            get {
                return this.GetSetCLIE_CPFField;
            }
            set {
                if ((object.ReferenceEquals(this.GetSetCLIE_CPFField, value) != true)) {
                    this.GetSetCLIE_CPFField = value;
                    this.RaisePropertyChanged("GetSetCLIE_CPF");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> GetSetCLIE_FK_PK_SICL {
            get {
                return this.GetSetCLIE_FK_PK_SICLField;
            }
            set {
                if ((this.GetSetCLIE_FK_PK_SICLField.Equals(value) != true)) {
                    this.GetSetCLIE_FK_PK_SICLField = value;
                    this.RaisePropertyChanged("GetSetCLIE_FK_PK_SICL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> GetSetCLIE_FK_PK_TICL {
            get {
                return this.GetSetCLIE_FK_PK_TICLField;
            }
            set {
                if ((this.GetSetCLIE_FK_PK_TICLField.Equals(value) != true)) {
                    this.GetSetCLIE_FK_PK_TICLField = value;
                    this.RaisePropertyChanged("GetSetCLIE_FK_PK_TICL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> GetSetCLIE_NASCIMENTO {
            get {
                return this.GetSetCLIE_NASCIMENTOField;
            }
            set {
                if ((this.GetSetCLIE_NASCIMENTOField.Equals(value) != true)) {
                    this.GetSetCLIE_NASCIMENTOField = value;
                    this.RaisePropertyChanged("GetSetCLIE_NASCIMENTO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GetSetCLIE_NOME {
            get {
                return this.GetSetCLIE_NOMEField;
            }
            set {
                if ((object.ReferenceEquals(this.GetSetCLIE_NOMEField, value) != true)) {
                    this.GetSetCLIE_NOMEField = value;
                    this.RaisePropertyChanged("GetSetCLIE_NOME");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> GetSetCLIE_PK_ID {
            get {
                return this.GetSetCLIE_PK_IDField;
            }
            set {
                if ((this.GetSetCLIE_PK_IDField.Equals(value) != true)) {
                    this.GetSetCLIE_PK_IDField = value;
                    this.RaisePropertyChanged("GetSetCLIE_PK_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GetSetCLIE_SEXO {
            get {
                return this.GetSetCLIE_SEXOField;
            }
            set {
                if ((object.ReferenceEquals(this.GetSetCLIE_SEXOField, value) != true)) {
                    this.GetSetCLIE_SEXOField = value;
                    this.RaisePropertyChanged("GetSetCLIE_SEXO");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfTipoCliente.ICliente")]
    public interface ICliente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/InsertClientes", ReplyAction="http://tempuri.org/ICliente/InsertClientesResponse")]
        string InsertClientes(SysClientes.WcfTipoCliente.Clientes eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/InsertClientes", ReplyAction="http://tempuri.org/ICliente/InsertClientesResponse")]
        System.Threading.Tasks.Task<string> InsertClientesAsync(SysClientes.WcfTipoCliente.Clientes eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/GetClientes", ReplyAction="http://tempuri.org/ICliente/GetClientesResponse")]
        System.Data.DataSet GetClientes(SysClientes.WcfTipoCliente.Clientes eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/GetClientes", ReplyAction="http://tempuri.org/ICliente/GetClientesResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetClientesAsync(SysClientes.WcfTipoCliente.Clientes eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/FetchUpdatedRecords", ReplyAction="http://tempuri.org/ICliente/FetchUpdatedRecordsResponse")]
        System.Data.DataSet FetchUpdatedRecords(SysClientes.WcfTipoCliente.Clientes eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/FetchUpdatedRecords", ReplyAction="http://tempuri.org/ICliente/FetchUpdatedRecordsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> FetchUpdatedRecordsAsync(SysClientes.WcfTipoCliente.Clientes eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/UpdateClientes", ReplyAction="http://tempuri.org/ICliente/UpdateClientesResponse")]
        string UpdateClientes(SysClientes.WcfTipoCliente.Clientes eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/UpdateClientes", ReplyAction="http://tempuri.org/ICliente/UpdateClientesResponse")]
        System.Threading.Tasks.Task<string> UpdateClientesAsync(SysClientes.WcfTipoCliente.Clientes eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/DeleteClientes", ReplyAction="http://tempuri.org/ICliente/DeleteClientesResponse")]
        bool DeleteClientes(SysClientes.WcfTipoCliente.Clientes eDatils);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/DeleteClientes", ReplyAction="http://tempuri.org/ICliente/DeleteClientesResponse")]
        System.Threading.Tasks.Task<bool> DeleteClientesAsync(SysClientes.WcfTipoCliente.Clientes eDatils);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteChannel : SysClientes.WcfTipoCliente.ICliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteClient : System.ServiceModel.ClientBase<SysClientes.WcfTipoCliente.ICliente>, SysClientes.WcfTipoCliente.ICliente {
        
        public ClienteClient() {
        }
        
        public ClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertClientes(SysClientes.WcfTipoCliente.Clientes eDatils) {
            return base.Channel.InsertClientes(eDatils);
        }
        
        public System.Threading.Tasks.Task<string> InsertClientesAsync(SysClientes.WcfTipoCliente.Clientes eDatils) {
            return base.Channel.InsertClientesAsync(eDatils);
        }
        
        public System.Data.DataSet GetClientes(SysClientes.WcfTipoCliente.Clientes eDatils) {
            return base.Channel.GetClientes(eDatils);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetClientesAsync(SysClientes.WcfTipoCliente.Clientes eDatils) {
            return base.Channel.GetClientesAsync(eDatils);
        }
        
        public System.Data.DataSet FetchUpdatedRecords(SysClientes.WcfTipoCliente.Clientes eDatils) {
            return base.Channel.FetchUpdatedRecords(eDatils);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FetchUpdatedRecordsAsync(SysClientes.WcfTipoCliente.Clientes eDatils) {
            return base.Channel.FetchUpdatedRecordsAsync(eDatils);
        }
        
        public string UpdateClientes(SysClientes.WcfTipoCliente.Clientes eDatils) {
            return base.Channel.UpdateClientes(eDatils);
        }
        
        public System.Threading.Tasks.Task<string> UpdateClientesAsync(SysClientes.WcfTipoCliente.Clientes eDatils) {
            return base.Channel.UpdateClientesAsync(eDatils);
        }
        
        public bool DeleteClientes(SysClientes.WcfTipoCliente.Clientes eDatils) {
            return base.Channel.DeleteClientes(eDatils);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteClientesAsync(SysClientes.WcfTipoCliente.Clientes eDatils) {
            return base.Channel.DeleteClientesAsync(eDatils);
        }
    }
}
