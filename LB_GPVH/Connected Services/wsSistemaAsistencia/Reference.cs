﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LB_GPVH.wsSistemaAsistencia {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservice/", ConfigurationName="wsSistemaAsistencia.WebServiceSistemaAsistencia")]
    public interface WebServiceSistemaAsistencia {
        
        // CODEGEN: Generating message contract since element name return from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/WebServiceSistemaAsistencia/listarAsistenciasRequest", ReplyAction="http://webservice/WebServiceSistemaAsistencia/listarAsistenciasResponse")]
        LB_GPVH.wsSistemaAsistencia.listarAsistenciasResponse listarAsistencias(LB_GPVH.wsSistemaAsistencia.listarAsistenciasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/WebServiceSistemaAsistencia/listarAsistenciasRequest", ReplyAction="http://webservice/WebServiceSistemaAsistencia/listarAsistenciasResponse")]
        System.Threading.Tasks.Task<LB_GPVH.wsSistemaAsistencia.listarAsistenciasResponse> listarAsistenciasAsync(LB_GPVH.wsSistemaAsistencia.listarAsistenciasRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class listarAsistenciasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="listarAsistencias", Namespace="http://webservice/", Order=0)]
        public LB_GPVH.wsSistemaAsistencia.listarAsistenciasRequestBody Body;
        
        public listarAsistenciasRequest() {
        }
        
        public listarAsistenciasRequest(LB_GPVH.wsSistemaAsistencia.listarAsistenciasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class listarAsistenciasRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.DateTime fechaInicio;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public System.DateTime fechaTermino;
        
        public listarAsistenciasRequestBody() {
        }
        
        public listarAsistenciasRequestBody(System.DateTime fechaInicio, System.DateTime fechaTermino) {
            this.fechaInicio = fechaInicio;
            this.fechaTermino = fechaTermino;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class listarAsistenciasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="listarAsistenciasResponse", Namespace="http://webservice/", Order=0)]
        public LB_GPVH.wsSistemaAsistencia.listarAsistenciasResponseBody Body;
        
        public listarAsistenciasResponse() {
        }
        
        public listarAsistenciasResponse(LB_GPVH.wsSistemaAsistencia.listarAsistenciasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class listarAsistenciasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public listarAsistenciasResponseBody() {
        }
        
        public listarAsistenciasResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSistemaAsistenciaChannel : LB_GPVH.wsSistemaAsistencia.WebServiceSistemaAsistencia, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSistemaAsistenciaClient : System.ServiceModel.ClientBase<LB_GPVH.wsSistemaAsistencia.WebServiceSistemaAsistencia>, LB_GPVH.wsSistemaAsistencia.WebServiceSistemaAsistencia {
        
        public WebServiceSistemaAsistenciaClient() {
        }
        
        public WebServiceSistemaAsistenciaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSistemaAsistenciaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSistemaAsistenciaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSistemaAsistenciaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LB_GPVH.wsSistemaAsistencia.listarAsistenciasResponse LB_GPVH.wsSistemaAsistencia.WebServiceSistemaAsistencia.listarAsistencias(LB_GPVH.wsSistemaAsistencia.listarAsistenciasRequest request) {
            return base.Channel.listarAsistencias(request);
        }
        
        public string listarAsistencias(System.DateTime fechaInicio, System.DateTime fechaTermino) {
            LB_GPVH.wsSistemaAsistencia.listarAsistenciasRequest inValue = new LB_GPVH.wsSistemaAsistencia.listarAsistenciasRequest();
            inValue.Body = new LB_GPVH.wsSistemaAsistencia.listarAsistenciasRequestBody();
            inValue.Body.fechaInicio = fechaInicio;
            inValue.Body.fechaTermino = fechaTermino;
            LB_GPVH.wsSistemaAsistencia.listarAsistenciasResponse retVal = ((LB_GPVH.wsSistemaAsistencia.WebServiceSistemaAsistencia)(this)).listarAsistencias(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LB_GPVH.wsSistemaAsistencia.listarAsistenciasResponse> LB_GPVH.wsSistemaAsistencia.WebServiceSistemaAsistencia.listarAsistenciasAsync(LB_GPVH.wsSistemaAsistencia.listarAsistenciasRequest request) {
            return base.Channel.listarAsistenciasAsync(request);
        }
        
        public System.Threading.Tasks.Task<LB_GPVH.wsSistemaAsistencia.listarAsistenciasResponse> listarAsistenciasAsync(System.DateTime fechaInicio, System.DateTime fechaTermino) {
            LB_GPVH.wsSistemaAsistencia.listarAsistenciasRequest inValue = new LB_GPVH.wsSistemaAsistencia.listarAsistenciasRequest();
            inValue.Body = new LB_GPVH.wsSistemaAsistencia.listarAsistenciasRequestBody();
            inValue.Body.fechaInicio = fechaInicio;
            inValue.Body.fechaTermino = fechaTermino;
            return ((LB_GPVH.wsSistemaAsistencia.WebServiceSistemaAsistencia)(this)).listarAsistenciasAsync(inValue);
        }
    }
}
