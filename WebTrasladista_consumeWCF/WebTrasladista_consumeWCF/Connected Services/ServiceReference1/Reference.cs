﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebTrasladista_consumeWCF.ServiceReference1 {
    using System;
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.FlagsAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="DateTimeFormatFlags", Namespace="http://schemas.datacontract.org/2004/07/System.Globalization")]
    public enum DateTimeFormatFlags : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UseGenitiveMonth = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UseLeapYearMonth = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UseSpacesInMonthNames = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UseHebrewRule = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UseSpacesInDayNames = 16,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UseDigitPrefixInTokens = 32,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotInitialized = -1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenOperador", ReplyAction="http://tempuri.org/IService1/ObtenOperadorResponse")]
        WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorResponse ObtenOperador(WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenOperador", ReplyAction="http://tempuri.org/IService1/ObtenOperadorResponse")]
        System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorResponse> ObtenOperadorAsync(WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MuestraDatos", ReplyAction="http://tempuri.org/IService1/MuestraDatosResponse")]
        void MuestraDatos(System.Collections.Generic.List<string> cad, System.Web.UI.WebControls.DropDownList cmb1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MuestraDatos", ReplyAction="http://tempuri.org/IService1/MuestraDatosResponse")]
        System.Threading.Tasks.Task MuestraDatosAsync(System.Collections.Generic.List<string> cad, System.Web.UI.WebControls.DropDownList cmb1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertaGasto", ReplyAction="http://tempuri.org/IService1/InsertaGastoResponse")]
        WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoResponse InsertaGasto(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertaGasto", ReplyAction="http://tempuri.org/IService1/InsertaGastoResponse")]
        System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoResponse> InsertaGastoAsync(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertaGastoVehiculo", ReplyAction="http://tempuri.org/IService1/InsertaGastoVehiculoResponse")]
        WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoResponse InsertaGastoVehiculo(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertaGastoVehiculo", ReplyAction="http://tempuri.org/IService1/InsertaGastoVehiculoResponse")]
        System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoResponse> InsertaGastoVehiculoAsync(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenOperador", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ObtenOperadorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string msj;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public System.Collections.Generic.List<int> ids;
        
        public ObtenOperadorRequest() {
        }
        
        public ObtenOperadorRequest(string msj, System.Collections.Generic.List<int> ids) {
            this.msj = msj;
            this.ids = ids;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenOperadorResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ObtenOperadorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Collections.Generic.List<string> ObtenOperadorResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string msj;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public System.Collections.Generic.List<int> ids;
        
        public ObtenOperadorResponse() {
        }
        
        public ObtenOperadorResponse(System.Collections.Generic.List<string> ObtenOperadorResult, string msj, System.Collections.Generic.List<int> ids) {
            this.ObtenOperadorResult = ObtenOperadorResult;
            this.msj = msj;
            this.ids = ids;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertaGasto", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertaGastoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int duracion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string restriccion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string necesidad;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public double km;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public int tiempo_trans;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public double costo_trans;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public double sueldo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7)]
        public double salario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=8)]
        public double costo_casetas;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=9)]
        public double total;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=10)]
        public string mensaje;
        
        public InsertaGastoRequest() {
        }
        
        public InsertaGastoRequest(int duracion, string restriccion, string necesidad, double km, int tiempo_trans, double costo_trans, double sueldo, double salario, double costo_casetas, double total, string mensaje) {
            this.duracion = duracion;
            this.restriccion = restriccion;
            this.necesidad = necesidad;
            this.km = km;
            this.tiempo_trans = tiempo_trans;
            this.costo_trans = costo_trans;
            this.sueldo = sueldo;
            this.salario = salario;
            this.costo_casetas = costo_casetas;
            this.total = total;
            this.mensaje = mensaje;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertaGastoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertaGastoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int InsertaGastoResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensaje;
        
        public InsertaGastoResponse() {
        }
        
        public InsertaGastoResponse(int InsertaGastoResult, string mensaje) {
            this.InsertaGastoResult = InsertaGastoResult;
            this.mensaje = mensaje;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertaGastoVehiculo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertaGastoVehiculoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int cantidad;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public double precio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int fkgasto;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int fkvehiculo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string mensaje;
        
        public InsertaGastoVehiculoRequest() {
        }
        
        public InsertaGastoVehiculoRequest(int cantidad, double precio, int fkgasto, int fkvehiculo, string mensaje) {
            this.cantidad = cantidad;
            this.precio = precio;
            this.fkgasto = fkgasto;
            this.fkvehiculo = fkvehiculo;
            this.mensaje = mensaje;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertaGastoVehiculoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertaGastoVehiculoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string mensaje;
        
        public InsertaGastoVehiculoResponse() {
        }
        
        public InsertaGastoVehiculoResponse(string mensaje) {
            this.mensaje = mensaje;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebTrasladista_consumeWCF.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebTrasladista_consumeWCF.ServiceReference1.IService1>, WebTrasladista_consumeWCF.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorResponse WebTrasladista_consumeWCF.ServiceReference1.IService1.ObtenOperador(WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorRequest request) {
            return base.Channel.ObtenOperador(request);
        }
        
        public System.Collections.Generic.List<string> ObtenOperador(ref string msj, ref System.Collections.Generic.List<int> ids) {
            WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorRequest inValue = new WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorRequest();
            inValue.msj = msj;
            inValue.ids = ids;
            WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorResponse retVal = ((WebTrasladista_consumeWCF.ServiceReference1.IService1)(this)).ObtenOperador(inValue);
            msj = retVal.msj;
            ids = retVal.ids;
            return retVal.ObtenOperadorResult;
        }
        
        public System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorResponse> ObtenOperadorAsync(WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorRequest request) {
            return base.Channel.ObtenOperadorAsync(request);
        }
        
        public void MuestraDatos(System.Collections.Generic.List<string> cad, System.Web.UI.WebControls.DropDownList cmb1) {
            base.Channel.MuestraDatos(cad, cmb1);
        }
        
        public System.Threading.Tasks.Task MuestraDatosAsync(System.Collections.Generic.List<string> cad, System.Web.UI.WebControls.DropDownList cmb1) {
            return base.Channel.MuestraDatosAsync(cad, cmb1);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoResponse WebTrasladista_consumeWCF.ServiceReference1.IService1.InsertaGasto(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoRequest request) {
            return base.Channel.InsertaGasto(request);
        }
        
        public int InsertaGasto(int duracion, string restriccion, string necesidad, double km, int tiempo_trans, double costo_trans, double sueldo, double salario, double costo_casetas, double total, ref string mensaje) {
            WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoRequest inValue = new WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoRequest();
            inValue.duracion = duracion;
            inValue.restriccion = restriccion;
            inValue.necesidad = necesidad;
            inValue.km = km;
            inValue.tiempo_trans = tiempo_trans;
            inValue.costo_trans = costo_trans;
            inValue.sueldo = sueldo;
            inValue.salario = salario;
            inValue.costo_casetas = costo_casetas;
            inValue.total = total;
            inValue.mensaje = mensaje;
            WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoResponse retVal = ((WebTrasladista_consumeWCF.ServiceReference1.IService1)(this)).InsertaGasto(inValue);
            mensaje = retVal.mensaje;
            return retVal.InsertaGastoResult;
        }
        
        public System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoResponse> InsertaGastoAsync(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoRequest request) {
            return base.Channel.InsertaGastoAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoResponse WebTrasladista_consumeWCF.ServiceReference1.IService1.InsertaGastoVehiculo(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoRequest request) {
            return base.Channel.InsertaGastoVehiculo(request);
        }
        
        public void InsertaGastoVehiculo(int cantidad, double precio, int fkgasto, int fkvehiculo, ref string mensaje) {
            WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoRequest inValue = new WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoRequest();
            inValue.cantidad = cantidad;
            inValue.precio = precio;
            inValue.fkgasto = fkgasto;
            inValue.fkvehiculo = fkvehiculo;
            inValue.mensaje = mensaje;
            WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoResponse retVal = ((WebTrasladista_consumeWCF.ServiceReference1.IService1)(this)).InsertaGastoVehiculo(inValue);
            mensaje = retVal.mensaje;
        }
        
        public System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoResponse> InsertaGastoVehiculoAsync(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoRequest request) {
            return base.Channel.InsertaGastoVehiculoAsync(request);
        }
    }
}
