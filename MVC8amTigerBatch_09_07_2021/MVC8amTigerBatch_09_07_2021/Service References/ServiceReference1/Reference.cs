﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC8amTigerBatch_09_07_2021.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.CalculatorSoap")]
    public interface CalculatorSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldResponse HelloWorld(MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldResponse> HelloWorldAsync(MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorSoapChannel : MVC8amTigerBatch_09_07_2021.ServiceReference1.CalculatorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorSoapClient : System.ServiceModel.ClientBase<MVC8amTigerBatch_09_07_2021.ServiceReference1.CalculatorSoap>, MVC8amTigerBatch_09_07_2021.ServiceReference1.CalculatorSoap {
        
        public CalculatorSoapClient() {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldResponse MVC8amTigerBatch_09_07_2021.ServiceReference1.CalculatorSoap.HelloWorld(MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldRequest inValue = new MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldRequest();
            inValue.Body = new MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldRequestBody();
            MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldResponse retVal = ((MVC8amTigerBatch_09_07_2021.ServiceReference1.CalculatorSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldResponse> MVC8amTigerBatch_09_07_2021.ServiceReference1.CalculatorSoap.HelloWorldAsync(MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldRequest inValue = new MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldRequest();
            inValue.Body = new MVC8amTigerBatch_09_07_2021.ServiceReference1.HelloWorldRequestBody();
            return ((MVC8amTigerBatch_09_07_2021.ServiceReference1.CalculatorSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
    }
}
