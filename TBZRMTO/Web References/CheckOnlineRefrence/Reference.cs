﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace HPS.CheckOnlineRefrence {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="OnlineInformationCheckingSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class OnlineInformationChecking : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetCarInformationOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDriverInformationOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetInformationOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public OnlineInformationChecking() {
            this.Url = "http://172.24.129.5/OnlineInformationChecking.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetCarInformationCompletedEventHandler GetCarInformationCompleted;
        
        /// <remarks/>
        public event GetDriverInformationCompletedEventHandler GetDriverInformationCompleted;
        
        /// <remarks/>
        public event GetInformationCompletedEventHandler GetInformationCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCarInformation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] GetCarInformation(string carCardNumber) {
            object[] results = this.Invoke("GetCarInformation", new object[] {
                        carCardNumber});
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public void GetCarInformationAsync(string carCardNumber) {
            this.GetCarInformationAsync(carCardNumber, null);
        }
        
        /// <remarks/>
        public void GetCarInformationAsync(string carCardNumber, object userState) {
            if ((this.GetCarInformationOperationCompleted == null)) {
                this.GetCarInformationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCarInformationOperationCompleted);
            }
            this.InvokeAsync("GetCarInformation", new object[] {
                        carCardNumber}, this.GetCarInformationOperationCompleted, userState);
        }
        
        private void OnGetCarInformationOperationCompleted(object arg) {
            if ((this.GetCarInformationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCarInformationCompleted(this, new GetCarInformationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetDriverInformation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] GetDriverInformation(string driverCardNumber) {
            object[] results = this.Invoke("GetDriverInformation", new object[] {
                        driverCardNumber});
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public void GetDriverInformationAsync(string driverCardNumber) {
            this.GetDriverInformationAsync(driverCardNumber, null);
        }
        
        /// <remarks/>
        public void GetDriverInformationAsync(string driverCardNumber, object userState) {
            if ((this.GetDriverInformationOperationCompleted == null)) {
                this.GetDriverInformationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDriverInformationOperationCompleted);
            }
            this.InvokeAsync("GetDriverInformation", new object[] {
                        driverCardNumber}, this.GetDriverInformationOperationCompleted, userState);
        }
        
        private void OnGetDriverInformationOperationCompleted(object arg) {
            if ((this.GetDriverInformationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDriverInformationCompleted(this, new GetDriverInformationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetInformation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] GetInformation(string driverCardNumber, string carCardNumber) {
            object[] results = this.Invoke("GetInformation", new object[] {
                        driverCardNumber,
                        carCardNumber});
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public void GetInformationAsync(string driverCardNumber, string carCardNumber) {
            this.GetInformationAsync(driverCardNumber, carCardNumber, null);
        }
        
        /// <remarks/>
        public void GetInformationAsync(string driverCardNumber, string carCardNumber, object userState) {
            if ((this.GetInformationOperationCompleted == null)) {
                this.GetInformationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetInformationOperationCompleted);
            }
            this.InvokeAsync("GetInformation", new object[] {
                        driverCardNumber,
                        carCardNumber}, this.GetInformationOperationCompleted, userState);
        }
        
        private void OnGetInformationOperationCompleted(object arg) {
            if ((this.GetInformationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetInformationCompleted(this, new GetInformationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetCarInformationCompletedEventHandler(object sender, GetCarInformationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCarInformationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCarInformationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetDriverInformationCompletedEventHandler(object sender, GetDriverInformationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDriverInformationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDriverInformationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetInformationCompletedEventHandler(object sender, GetInformationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetInformationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetInformationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591