﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.225.
// 
#pragma warning disable 1591

namespace B2BAISERA.WsProd {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="B2BAIWebServiceDMZSoap", Namespace="http://apps.astra.co.id/")]
    public partial class B2BAIWebServiceDMZ : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback LoginAuthenticationOperationCompleted;
        
        private System.Threading.SendOrPostCallback UploadDocumentOperationCompleted;
        
        private System.Threading.SendOrPostCallback DownloadDocumentOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateDocumentStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback DownloadDocumentStatusOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public B2BAIWebServiceDMZ() {
            this.Url = global::B2BAISERA.Properties.Settings.Default.B2BAISERA_S02002_WsProd_B2BAIWebServiceDMZ;
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
        public event LoginAuthenticationCompletedEventHandler LoginAuthenticationCompleted;
        
        /// <remarks/>
        public event UploadDocumentCompletedEventHandler UploadDocumentCompleted;
        
        /// <remarks/>
        public event DownloadDocumentCompletedEventHandler DownloadDocumentCompleted;
        
        /// <remarks/>
        public event UpdateDocumentStatusCompletedEventHandler UpdateDocumentStatusCompleted;
        
        /// <remarks/>
        public event DownloadDocumentStatusCompletedEventHandler DownloadDocumentStatusCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://apps.astra.co.id/LoginAuthentication", RequestNamespace="http://apps.astra.co.id/", ResponseNamespace="http://apps.astra.co.id/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CommonResponse LoginAuthentication(LoginRequest loginRequest) {
            object[] results = this.Invoke("LoginAuthentication", new object[] {
                        loginRequest});
            return ((CommonResponse)(results[0]));
        }
        
        /// <remarks/>
        public void LoginAuthenticationAsync(LoginRequest loginRequest) {
            this.LoginAuthenticationAsync(loginRequest, null);
        }
        
        /// <remarks/>
        public void LoginAuthenticationAsync(LoginRequest loginRequest, object userState) {
            if ((this.LoginAuthenticationOperationCompleted == null)) {
                this.LoginAuthenticationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginAuthenticationOperationCompleted);
            }
            this.InvokeAsync("LoginAuthentication", new object[] {
                        loginRequest}, this.LoginAuthenticationOperationCompleted, userState);
        }
        
        private void OnLoginAuthenticationOperationCompleted(object arg) {
            if ((this.LoginAuthenticationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginAuthenticationCompleted(this, new LoginAuthenticationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://apps.astra.co.id/UploadDocument", RequestNamespace="http://apps.astra.co.id/", ResponseNamespace="http://apps.astra.co.id/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CommonResponse UploadDocument(UploadRequest uploadRequest) {
            object[] results = this.Invoke("UploadDocument", new object[] {
                        uploadRequest});
            return ((CommonResponse)(results[0]));
        }
        
        /// <remarks/>
        public void UploadDocumentAsync(UploadRequest uploadRequest) {
            this.UploadDocumentAsync(uploadRequest, null);
        }
        
        /// <remarks/>
        public void UploadDocumentAsync(UploadRequest uploadRequest, object userState) {
            if ((this.UploadDocumentOperationCompleted == null)) {
                this.UploadDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUploadDocumentOperationCompleted);
            }
            this.InvokeAsync("UploadDocument", new object[] {
                        uploadRequest}, this.UploadDocumentOperationCompleted, userState);
        }
        
        private void OnUploadDocumentOperationCompleted(object arg) {
            if ((this.UploadDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UploadDocumentCompleted(this, new UploadDocumentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://apps.astra.co.id/DownloadDocument", RequestNamespace="http://apps.astra.co.id/", ResponseNamespace="http://apps.astra.co.id/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DownloadResponse DownloadDocument(DownloadRequest downloadRequest) {
            object[] results = this.Invoke("DownloadDocument", new object[] {
                        downloadRequest});
            return ((DownloadResponse)(results[0]));
        }
        
        /// <remarks/>
        public void DownloadDocumentAsync(DownloadRequest downloadRequest) {
            this.DownloadDocumentAsync(downloadRequest, null);
        }
        
        /// <remarks/>
        public void DownloadDocumentAsync(DownloadRequest downloadRequest, object userState) {
            if ((this.DownloadDocumentOperationCompleted == null)) {
                this.DownloadDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDownloadDocumentOperationCompleted);
            }
            this.InvokeAsync("DownloadDocument", new object[] {
                        downloadRequest}, this.DownloadDocumentOperationCompleted, userState);
        }
        
        private void OnDownloadDocumentOperationCompleted(object arg) {
            if ((this.DownloadDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DownloadDocumentCompleted(this, new DownloadDocumentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://apps.astra.co.id/UpdateDocumentStatus", RequestNamespace="http://apps.astra.co.id/", ResponseNamespace="http://apps.astra.co.id/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CommonResponse UpdateDocumentStatus(UpdateStatusRequest updateStatusRequest) {
            object[] results = this.Invoke("UpdateDocumentStatus", new object[] {
                        updateStatusRequest});
            return ((CommonResponse)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateDocumentStatusAsync(UpdateStatusRequest updateStatusRequest) {
            this.UpdateDocumentStatusAsync(updateStatusRequest, null);
        }
        
        /// <remarks/>
        public void UpdateDocumentStatusAsync(UpdateStatusRequest updateStatusRequest, object userState) {
            if ((this.UpdateDocumentStatusOperationCompleted == null)) {
                this.UpdateDocumentStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateDocumentStatusOperationCompleted);
            }
            this.InvokeAsync("UpdateDocumentStatus", new object[] {
                        updateStatusRequest}, this.UpdateDocumentStatusOperationCompleted, userState);
        }
        
        private void OnUpdateDocumentStatusOperationCompleted(object arg) {
            if ((this.UpdateDocumentStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateDocumentStatusCompleted(this, new UpdateDocumentStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://apps.astra.co.id/DownloadDocumentStatus", RequestNamespace="http://apps.astra.co.id/", ResponseNamespace="http://apps.astra.co.id/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DownloadDocumentStatusResponse DownloadDocumentStatus(DownloadRequest downloadRequest) {
            object[] results = this.Invoke("DownloadDocumentStatus", new object[] {
                        downloadRequest});
            return ((DownloadDocumentStatusResponse)(results[0]));
        }
        
        /// <remarks/>
        public void DownloadDocumentStatusAsync(DownloadRequest downloadRequest) {
            this.DownloadDocumentStatusAsync(downloadRequest, null);
        }
        
        /// <remarks/>
        public void DownloadDocumentStatusAsync(DownloadRequest downloadRequest, object userState) {
            if ((this.DownloadDocumentStatusOperationCompleted == null)) {
                this.DownloadDocumentStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDownloadDocumentStatusOperationCompleted);
            }
            this.InvokeAsync("DownloadDocumentStatus", new object[] {
                        downloadRequest}, this.DownloadDocumentStatusOperationCompleted, userState);
        }
        
        private void OnDownloadDocumentStatusOperationCompleted(object arg) {
            if ((this.DownloadDocumentStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DownloadDocumentStatusCompleted(this, new DownloadDocumentStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://apps.astra.co.id/")]
    public partial class LoginRequest {
        
        private string userNameField;
        
        private string passwordField;
        
        private string clientTagField;
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public string ClientTag {
            get {
                return this.clientTagField;
            }
            set {
                this.clientTagField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://apps.astra.co.id/")]
    public partial class TransactionDataDocumentStatus {
        
        private int idField;
        
        private string transGUIDField;
        
        private string documentNumberField;
        
        private string fileTypeField;
        
        private string iPAddressField;
        
        private string destinationUserField;
        
        private string key1Field;
        
        private string key2Field;
        
        private string key3Field;
        
        private int dataLengthField;
        
        private string[] dataField;
        
        private string[] transDataStatusDetailField;
        
        /// <remarks/>
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string TransGUID {
            get {
                return this.transGUIDField;
            }
            set {
                this.transGUIDField = value;
            }
        }
        
        /// <remarks/>
        public string DocumentNumber {
            get {
                return this.documentNumberField;
            }
            set {
                this.documentNumberField = value;
            }
        }
        
        /// <remarks/>
        public string FileType {
            get {
                return this.fileTypeField;
            }
            set {
                this.fileTypeField = value;
            }
        }
        
        /// <remarks/>
        public string IPAddress {
            get {
                return this.iPAddressField;
            }
            set {
                this.iPAddressField = value;
            }
        }
        
        /// <remarks/>
        public string DestinationUser {
            get {
                return this.destinationUserField;
            }
            set {
                this.destinationUserField = value;
            }
        }
        
        /// <remarks/>
        public string Key1 {
            get {
                return this.key1Field;
            }
            set {
                this.key1Field = value;
            }
        }
        
        /// <remarks/>
        public string Key2 {
            get {
                return this.key2Field;
            }
            set {
                this.key2Field = value;
            }
        }
        
        /// <remarks/>
        public string Key3 {
            get {
                return this.key3Field;
            }
            set {
                this.key3Field = value;
            }
        }
        
        /// <remarks/>
        public int DataLength {
            get {
                return this.dataLengthField;
            }
            set {
                this.dataLengthField = value;
            }
        }
        
        /// <remarks/>
        public string[] Data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        public string[] TransDataStatusDetail {
            get {
                return this.transDataStatusDetailField;
            }
            set {
                this.transDataStatusDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://apps.astra.co.id/")]
    public partial class DownloadDocumentStatusResponse {
        
        private bool acknowledgeField;
        
        private string ticketNoField;
        
        private string messageField;
        
        private TransactionDataDocumentStatus[] transactionDataDocumentStatusField;
        
        /// <remarks/>
        public bool Acknowledge {
            get {
                return this.acknowledgeField;
            }
            set {
                this.acknowledgeField = value;
            }
        }
        
        /// <remarks/>
        public string TicketNo {
            get {
                return this.ticketNoField;
            }
            set {
                this.ticketNoField = value;
            }
        }
        
        /// <remarks/>
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        public TransactionDataDocumentStatus[] transactionDataDocumentStatus {
            get {
                return this.transactionDataDocumentStatusField;
            }
            set {
                this.transactionDataDocumentStatusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://apps.astra.co.id/")]
    public partial class TransactionDataID {
        
        private string transGUIDField;
        
        private string documentNumberField;
        
        private string key1Field;
        
        private string key2Field;
        
        private string key3Field;
        
        private string transStatusField;
        
        private string logMessageField;
        
        /// <remarks/>
        public string TransGUID {
            get {
                return this.transGUIDField;
            }
            set {
                this.transGUIDField = value;
            }
        }
        
        /// <remarks/>
        public string DocumentNumber {
            get {
                return this.documentNumberField;
            }
            set {
                this.documentNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Key1 {
            get {
                return this.key1Field;
            }
            set {
                this.key1Field = value;
            }
        }
        
        /// <remarks/>
        public string Key2 {
            get {
                return this.key2Field;
            }
            set {
                this.key2Field = value;
            }
        }
        
        /// <remarks/>
        public string Key3 {
            get {
                return this.key3Field;
            }
            set {
                this.key3Field = value;
            }
        }
        
        /// <remarks/>
        public string TransStatus {
            get {
                return this.transStatusField;
            }
            set {
                this.transStatusField = value;
            }
        }
        
        /// <remarks/>
        public string LogMessage {
            get {
                return this.logMessageField;
            }
            set {
                this.logMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://apps.astra.co.id/")]
    public partial class UpdateStatusRequest {
        
        private string ticketNoField;
        
        private string clientTagField;
        
        private TransactionDataID[] transactionDataIDField;
        
        /// <remarks/>
        public string TicketNo {
            get {
                return this.ticketNoField;
            }
            set {
                this.ticketNoField = value;
            }
        }
        
        /// <remarks/>
        public string ClientTag {
            get {
                return this.clientTagField;
            }
            set {
                this.clientTagField = value;
            }
        }
        
        /// <remarks/>
        public TransactionDataID[] transactionDataID {
            get {
                return this.transactionDataIDField;
            }
            set {
                this.transactionDataIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://apps.astra.co.id/")]
    public partial class DownloadResponse {
        
        private bool acknowledgeField;
        
        private string ticketNoField;
        
        private string messageField;
        
        private TransactionData[] transactionDataField;
        
        /// <remarks/>
        public bool Acknowledge {
            get {
                return this.acknowledgeField;
            }
            set {
                this.acknowledgeField = value;
            }
        }
        
        /// <remarks/>
        public string TicketNo {
            get {
                return this.ticketNoField;
            }
            set {
                this.ticketNoField = value;
            }
        }
        
        /// <remarks/>
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        public TransactionData[] transactionData {
            get {
                return this.transactionDataField;
            }
            set {
                this.transactionDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://apps.astra.co.id/")]
    public partial class TransactionData {
        
        private int idField;
        
        private string transGUIDField;
        
        private string documentNumberField;
        
        private string fileTypeField;
        
        private string iPAddressField;
        
        private string destinationUserField;
        
        private string key1Field;
        
        private string key2Field;
        
        private string key3Field;
        
        private int dataLengthField;
        
        private string[] dataField;
        
        /// <remarks/>
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string TransGUID {
            get {
                return this.transGUIDField;
            }
            set {
                this.transGUIDField = value;
            }
        }
        
        /// <remarks/>
        public string DocumentNumber {
            get {
                return this.documentNumberField;
            }
            set {
                this.documentNumberField = value;
            }
        }
        
        /// <remarks/>
        public string FileType {
            get {
                return this.fileTypeField;
            }
            set {
                this.fileTypeField = value;
            }
        }
        
        /// <remarks/>
        public string IPAddress {
            get {
                return this.iPAddressField;
            }
            set {
                this.iPAddressField = value;
            }
        }
        
        /// <remarks/>
        public string DestinationUser {
            get {
                return this.destinationUserField;
            }
            set {
                this.destinationUserField = value;
            }
        }
        
        /// <remarks/>
        public string Key1 {
            get {
                return this.key1Field;
            }
            set {
                this.key1Field = value;
            }
        }
        
        /// <remarks/>
        public string Key2 {
            get {
                return this.key2Field;
            }
            set {
                this.key2Field = value;
            }
        }
        
        /// <remarks/>
        public string Key3 {
            get {
                return this.key3Field;
            }
            set {
                this.key3Field = value;
            }
        }
        
        /// <remarks/>
        public int DataLength {
            get {
                return this.dataLengthField;
            }
            set {
                this.dataLengthField = value;
            }
        }
        
        /// <remarks/>
        public string[] Data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://apps.astra.co.id/")]
    public partial class DownloadRequest {
        
        private string ticketNoField;
        
        private string clientTagField;
        
        private string fileTypeField;
        
        private string sourceUserField;
        
        private string statusField;
        
        private System.DateTime transDateFromField;
        
        private System.DateTime transDateToField;
        
        private string key1Field;
        
        private string key2Field;
        
        private string key3Field;
        
        /// <remarks/>
        public string TicketNo {
            get {
                return this.ticketNoField;
            }
            set {
                this.ticketNoField = value;
            }
        }
        
        /// <remarks/>
        public string ClientTag {
            get {
                return this.clientTagField;
            }
            set {
                this.clientTagField = value;
            }
        }
        
        /// <remarks/>
        public string FileType {
            get {
                return this.fileTypeField;
            }
            set {
                this.fileTypeField = value;
            }
        }
        
        /// <remarks/>
        public string SourceUser {
            get {
                return this.sourceUserField;
            }
            set {
                this.sourceUserField = value;
            }
        }
        
        /// <remarks/>
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime TransDateFrom {
            get {
                return this.transDateFromField;
            }
            set {
                this.transDateFromField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime TransDateTo {
            get {
                return this.transDateToField;
            }
            set {
                this.transDateToField = value;
            }
        }
        
        /// <remarks/>
        public string Key1 {
            get {
                return this.key1Field;
            }
            set {
                this.key1Field = value;
            }
        }
        
        /// <remarks/>
        public string Key2 {
            get {
                return this.key2Field;
            }
            set {
                this.key2Field = value;
            }
        }
        
        /// <remarks/>
        public string Key3 {
            get {
                return this.key3Field;
            }
            set {
                this.key3Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://apps.astra.co.id/")]
    public partial class UploadRequest {
        
        private string ticketNoField;
        
        private string clientTagField;
        
        private TransactionData[] transactionDataField;
        
        /// <remarks/>
        public string TicketNo {
            get {
                return this.ticketNoField;
            }
            set {
                this.ticketNoField = value;
            }
        }
        
        /// <remarks/>
        public string ClientTag {
            get {
                return this.clientTagField;
            }
            set {
                this.clientTagField = value;
            }
        }
        
        /// <remarks/>
        public TransactionData[] transactionData {
            get {
                return this.transactionDataField;
            }
            set {
                this.transactionDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://apps.astra.co.id/")]
    public partial class CommonResponse {
        
        private bool acknowledgeField;
        
        private string ticketNoField;
        
        private string messageField;
        
        /// <remarks/>
        public bool Acknowledge {
            get {
                return this.acknowledgeField;
            }
            set {
                this.acknowledgeField = value;
            }
        }
        
        /// <remarks/>
        public string TicketNo {
            get {
                return this.ticketNoField;
            }
            set {
                this.ticketNoField = value;
            }
        }
        
        /// <remarks/>
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void LoginAuthenticationCompletedEventHandler(object sender, LoginAuthenticationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginAuthenticationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginAuthenticationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CommonResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CommonResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void UploadDocumentCompletedEventHandler(object sender, UploadDocumentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UploadDocumentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UploadDocumentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CommonResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CommonResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void DownloadDocumentCompletedEventHandler(object sender, DownloadDocumentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DownloadDocumentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DownloadDocumentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DownloadResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DownloadResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void UpdateDocumentStatusCompletedEventHandler(object sender, UpdateDocumentStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateDocumentStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateDocumentStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CommonResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CommonResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void DownloadDocumentStatusCompletedEventHandler(object sender, DownloadDocumentStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DownloadDocumentStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DownloadDocumentStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DownloadDocumentStatusResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DownloadDocumentStatusResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591