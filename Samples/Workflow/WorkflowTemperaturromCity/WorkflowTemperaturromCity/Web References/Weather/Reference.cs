﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace WorkflowTemperaturromCity.Weather {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="GlobalWeatherSoap", Namespace="http://www.webserviceX.NET")]
    public partial class GlobalWeather : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetWeatherOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCitiesByCountryOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public GlobalWeather() {
            this.Url = global::WorkflowTemperaturromCity.Properties.Settings.Default.WorkflowTemperaturromCity_weather_GlobalWeather;
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
        public event GetWeatherCompletedEventHandler GetWeatherCompleted;
        
        /// <remarks/>
        public event GetCitiesByCountryCompletedEventHandler GetCitiesByCountryCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/GetWeather", RequestNamespace="http://www.webserviceX.NET", ResponseNamespace="http://www.webserviceX.NET", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetWeather(string CityName, string CountryName) {
            object[] results = this.Invoke("GetWeather", new object[] {
                        CityName,
                        CountryName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetWeatherAsync(string CityName, string CountryName) {
            this.GetWeatherAsync(CityName, CountryName, null);
        }
        
        /// <remarks/>
        public void GetWeatherAsync(string CityName, string CountryName, object userState) {
            if ((this.GetWeatherOperationCompleted == null)) {
                this.GetWeatherOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetWeatherOperationCompleted);
            }
            this.InvokeAsync("GetWeather", new object[] {
                        CityName,
                        CountryName}, this.GetWeatherOperationCompleted, userState);
        }
        
        private void OnGetWeatherOperationCompleted(object arg) {
            if ((this.GetWeatherCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetWeatherCompleted(this, new GetWeatherCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/GetCitiesByCountry", RequestNamespace="http://www.webserviceX.NET", ResponseNamespace="http://www.webserviceX.NET", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetCitiesByCountry(string CountryName) {
            object[] results = this.Invoke("GetCitiesByCountry", new object[] {
                        CountryName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetCitiesByCountryAsync(string CountryName) {
            this.GetCitiesByCountryAsync(CountryName, null);
        }
        
        /// <remarks/>
        public void GetCitiesByCountryAsync(string CountryName, object userState) {
            if ((this.GetCitiesByCountryOperationCompleted == null)) {
                this.GetCitiesByCountryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCitiesByCountryOperationCompleted);
            }
            this.InvokeAsync("GetCitiesByCountry", new object[] {
                        CountryName}, this.GetCitiesByCountryOperationCompleted, userState);
        }
        
        private void OnGetCitiesByCountryOperationCompleted(object arg) {
            if ((this.GetCitiesByCountryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCitiesByCountryCompleted(this, new GetCitiesByCountryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void GetWeatherCompletedEventHandler(object sender, GetWeatherCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetWeatherCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetWeatherCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void GetCitiesByCountryCompletedEventHandler(object sender, GetCitiesByCountryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCitiesByCountryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCitiesByCountryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591