﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LB_GPVH.ServiceWSUsuarios {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceWSUsuarios.IWSUsuarios")]
    public interface IWSUsuarios {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/getListadoUsuarios", ReplyAction="http://tempuri.org/IWSUsuarios/getListadoUsuariosResponse")]
        WS_GPVH.Usuario[] getListadoUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/getListadoUsuarios", ReplyAction="http://tempuri.org/IWSUsuarios/getListadoUsuariosResponse")]
        System.Threading.Tasks.Task<WS_GPVH.Usuario[]> getListadoUsuariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/getUsuarioById", ReplyAction="http://tempuri.org/IWSUsuarios/getUsuarioByIdResponse")]
        WS_GPVH.Usuario getUsuarioById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/getUsuarioById", ReplyAction="http://tempuri.org/IWSUsuarios/getUsuarioByIdResponse")]
        System.Threading.Tasks.Task<WS_GPVH.Usuario> getUsuarioByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/addUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/addUsuarioResponse")]
        int addUsuario(string nombre, string clave, string tipo, int run);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/addUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/addUsuarioResponse")]
        System.Threading.Tasks.Task<int> addUsuarioAsync(string nombre, string clave, string tipo, int run);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/modifyUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/modifyUsuarioResponse")]
        int modifyUsuario(int id, string nombre, string clave, string tipo, int run);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/modifyUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/modifyUsuarioResponse")]
        System.Threading.Tasks.Task<int> modifyUsuarioAsync(int id, string nombre, string clave, string tipo, int run);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/deleteUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/deleteUsuarioResponse")]
        int deleteUsuario(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/deleteUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/deleteUsuarioResponse")]
        System.Threading.Tasks.Task<int> deleteUsuarioAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/AutenticarUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/AutenticarUsuarioResponse")]
        WS_GPVH.Usuario AutenticarUsuario(string nombre, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/AutenticarUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/AutenticarUsuarioResponse")]
        System.Threading.Tasks.Task<WS_GPVH.Usuario> AutenticarUsuarioAsync(string nombre, string clave);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSUsuariosChannel : LB_GPVH.ServiceWSUsuarios.IWSUsuarios, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSUsuariosClient : System.ServiceModel.ClientBase<LB_GPVH.ServiceWSUsuarios.IWSUsuarios>, LB_GPVH.ServiceWSUsuarios.IWSUsuarios {
        
        public WSUsuariosClient() {
        }
        
        public WSUsuariosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSUsuariosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSUsuariosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSUsuariosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WS_GPVH.Usuario[] getListadoUsuarios() {
            return base.Channel.getListadoUsuarios();
        }
        
        public System.Threading.Tasks.Task<WS_GPVH.Usuario[]> getListadoUsuariosAsync() {
            return base.Channel.getListadoUsuariosAsync();
        }
        
        public WS_GPVH.Usuario getUsuarioById(int id) {
            return base.Channel.getUsuarioById(id);
        }
        
        public System.Threading.Tasks.Task<WS_GPVH.Usuario> getUsuarioByIdAsync(int id) {
            return base.Channel.getUsuarioByIdAsync(id);
        }
        
        public int addUsuario(string nombre, string clave, string tipo, int run) {
            return base.Channel.addUsuario(nombre, clave, tipo, run);
        }
        
        public System.Threading.Tasks.Task<int> addUsuarioAsync(string nombre, string clave, string tipo, int run) {
            return base.Channel.addUsuarioAsync(nombre, clave, tipo, run);
        }
        
        public int modifyUsuario(int id, string nombre, string clave, string tipo, int run) {
            return base.Channel.modifyUsuario(id, nombre, clave, tipo, run);
        }
        
        public System.Threading.Tasks.Task<int> modifyUsuarioAsync(int id, string nombre, string clave, string tipo, int run) {
            return base.Channel.modifyUsuarioAsync(id, nombre, clave, tipo, run);
        }
        
        public int deleteUsuario(int id) {
            return base.Channel.deleteUsuario(id);
        }
        
        public System.Threading.Tasks.Task<int> deleteUsuarioAsync(int id) {
            return base.Channel.deleteUsuarioAsync(id);
        }
        
        public WS_GPVH.Usuario AutenticarUsuario(string nombre, string clave) {
            return base.Channel.AutenticarUsuario(nombre, clave);
        }
        
        public System.Threading.Tasks.Task<WS_GPVH.Usuario> AutenticarUsuarioAsync(string nombre, string clave) {
            return base.Channel.AutenticarUsuarioAsync(nombre, clave);
        }
    }
}