﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WF_GPVH.ServiceWSPermisos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Permiso", Namespace="http://schemas.datacontract.org/2004/07/WS_GPVH.WebServices.Permisos")]
    [System.SerializableAttribute()]
    public partial class Permiso : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Autorizante_run_sin_dvField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Desc_permisoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fecha_inicioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fecha_solicitudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fecha_terminoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_permisoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Solicitante_run_sin_dvField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Tipo_permisoField;
        
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
        public int Autorizante_run_sin_dv {
            get {
                return this.Autorizante_run_sin_dvField;
            }
            set {
                if ((this.Autorizante_run_sin_dvField.Equals(value) != true)) {
                    this.Autorizante_run_sin_dvField = value;
                    this.RaisePropertyChanged("Autorizante_run_sin_dv");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Desc_permiso {
            get {
                return this.Desc_permisoField;
            }
            set {
                if ((object.ReferenceEquals(this.Desc_permisoField, value) != true)) {
                    this.Desc_permisoField = value;
                    this.RaisePropertyChanged("Desc_permiso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha_inicio {
            get {
                return this.Fecha_inicioField;
            }
            set {
                if ((this.Fecha_inicioField.Equals(value) != true)) {
                    this.Fecha_inicioField = value;
                    this.RaisePropertyChanged("Fecha_inicio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha_solicitud {
            get {
                return this.Fecha_solicitudField;
            }
            set {
                if ((this.Fecha_solicitudField.Equals(value) != true)) {
                    this.Fecha_solicitudField = value;
                    this.RaisePropertyChanged("Fecha_solicitud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha_termino {
            get {
                return this.Fecha_terminoField;
            }
            set {
                if ((this.Fecha_terminoField.Equals(value) != true)) {
                    this.Fecha_terminoField = value;
                    this.RaisePropertyChanged("Fecha_termino");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_permiso {
            get {
                return this.Id_permisoField;
            }
            set {
                if ((this.Id_permisoField.Equals(value) != true)) {
                    this.Id_permisoField = value;
                    this.RaisePropertyChanged("Id_permiso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Solicitante_run_sin_dv {
            get {
                return this.Solicitante_run_sin_dvField;
            }
            set {
                if ((this.Solicitante_run_sin_dvField.Equals(value) != true)) {
                    this.Solicitante_run_sin_dvField = value;
                    this.RaisePropertyChanged("Solicitante_run_sin_dv");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tipo_permiso {
            get {
                return this.Tipo_permisoField;
            }
            set {
                if ((object.ReferenceEquals(this.Tipo_permisoField, value) != true)) {
                    this.Tipo_permisoField = value;
                    this.RaisePropertyChanged("Tipo_permiso");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Documento", Namespace="http://schemas.datacontract.org/2004/07/WS_GPVH.WebServices.Permisos")]
    [System.SerializableAttribute()]
    public partial class Documento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DirField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fecha_creacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Formato_documentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_documentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_permisoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_documentoField;
        
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
        public string Dir {
            get {
                return this.DirField;
            }
            set {
                if ((object.ReferenceEquals(this.DirField, value) != true)) {
                    this.DirField = value;
                    this.RaisePropertyChanged("Dir");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha_creacion {
            get {
                return this.Fecha_creacionField;
            }
            set {
                if ((this.Fecha_creacionField.Equals(value) != true)) {
                    this.Fecha_creacionField = value;
                    this.RaisePropertyChanged("Fecha_creacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Formato_documento {
            get {
                return this.Formato_documentoField;
            }
            set {
                if ((object.ReferenceEquals(this.Formato_documentoField, value) != true)) {
                    this.Formato_documentoField = value;
                    this.RaisePropertyChanged("Formato_documento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_documento {
            get {
                return this.Id_documentoField;
            }
            set {
                if ((this.Id_documentoField.Equals(value) != true)) {
                    this.Id_documentoField = value;
                    this.RaisePropertyChanged("Id_documento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_permiso {
            get {
                return this.Id_permisoField;
            }
            set {
                if ((this.Id_permisoField.Equals(value) != true)) {
                    this.Id_permisoField = value;
                    this.RaisePropertyChanged("Id_permiso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_documento {
            get {
                return this.Nombre_documentoField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_documentoField, value) != true)) {
                    this.Nombre_documentoField = value;
                    this.RaisePropertyChanged("Nombre_documento");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceWSPermisos.IWSPermisos")]
    public interface IWSPermisos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPermisos/getPermisosByFuncionario", ReplyAction="http://tempuri.org/IWSPermisos/getPermisosByFuncionarioResponse")]
        WF_GPVH.ServiceWSPermisos.Permiso[] getPermisosByFuncionario(int run, int condicion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPermisos/getPermisosByFuncionario", ReplyAction="http://tempuri.org/IWSPermisos/getPermisosByFuncionarioResponse")]
        System.Threading.Tasks.Task<WF_GPVH.ServiceWSPermisos.Permiso[]> getPermisosByFuncionarioAsync(int run, int condicion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPermisos/getDocumentosByPermiso", ReplyAction="http://tempuri.org/IWSPermisos/getDocumentosByPermisoResponse")]
        WF_GPVH.ServiceWSPermisos.Documento[] getDocumentosByPermiso(int id_permiso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPermisos/getDocumentosByPermiso", ReplyAction="http://tempuri.org/IWSPermisos/getDocumentosByPermisoResponse")]
        System.Threading.Tasks.Task<WF_GPVH.ServiceWSPermisos.Documento[]> getDocumentosByPermisoAsync(int id_permiso);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSPermisosChannel : WF_GPVH.ServiceWSPermisos.IWSPermisos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSPermisosClient : System.ServiceModel.ClientBase<WF_GPVH.ServiceWSPermisos.IWSPermisos>, WF_GPVH.ServiceWSPermisos.IWSPermisos {
        
        public WSPermisosClient() {
        }
        
        public WSPermisosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSPermisosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSPermisosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSPermisosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WF_GPVH.ServiceWSPermisos.Permiso[] getPermisosByFuncionario(int run, int condicion) {
            return base.Channel.getPermisosByFuncionario(run, condicion);
        }
        
        public System.Threading.Tasks.Task<WF_GPVH.ServiceWSPermisos.Permiso[]> getPermisosByFuncionarioAsync(int run, int condicion) {
            return base.Channel.getPermisosByFuncionarioAsync(run, condicion);
        }
        
        public WF_GPVH.ServiceWSPermisos.Documento[] getDocumentosByPermiso(int id_permiso) {
            return base.Channel.getDocumentosByPermiso(id_permiso);
        }
        
        public System.Threading.Tasks.Task<WF_GPVH.ServiceWSPermisos.Documento[]> getDocumentosByPermisoAsync(int id_permiso) {
            return base.Channel.getDocumentosByPermisoAsync(id_permiso);
        }
    }
}
