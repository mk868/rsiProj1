﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace appClient.InfoService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EventViewModel", Namespace="http://schemas.datacontract.org/2004/07/rsiProj1.ViewModels")]
    [System.SerializableAttribute()]
    public partial class EventViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid TypeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WeekOfYearField;
        
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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid TypeId {
            get {
                return this.TypeIdField;
            }
            set {
                if ((this.TypeIdField.Equals(value) != true)) {
                    this.TypeIdField = value;
                    this.RaisePropertyChanged("TypeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeName {
            get {
                return this.TypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeNameField, value) != true)) {
                    this.TypeNameField = value;
                    this.RaisePropertyChanged("TypeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WeekOfYear {
            get {
                return this.WeekOfYearField;
            }
            set {
                if ((this.WeekOfYearField.Equals(value) != true)) {
                    this.WeekOfYearField = value;
                    this.RaisePropertyChanged("WeekOfYear");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EventListItemViewModel", Namespace="http://schemas.datacontract.org/2004/07/rsiProj1.ViewModels")]
    [System.SerializableAttribute()]
    public partial class EventListItemViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WeekOfYearField;
        
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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WeekOfYear {
            get {
                return this.WeekOfYearField;
            }
            set {
                if ((this.WeekOfYearField.Equals(value) != true)) {
                    this.WeekOfYearField = value;
                    this.RaisePropertyChanged("WeekOfYear");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InfoService.IInfoService")]
    public interface IInfoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoService/GetEventById", ReplyAction="http://tempuri.org/IInfoService/GetEventByIdResponse")]
        appClient.InfoService.EventViewModel GetEventById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoService/GetEventById", ReplyAction="http://tempuri.org/IInfoService/GetEventByIdResponse")]
        System.Threading.Tasks.Task<appClient.InfoService.EventViewModel> GetEventByIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoService/GetEventsForDay", ReplyAction="http://tempuri.org/IInfoService/GetEventsForDayResponse")]
        System.Collections.Generic.List<appClient.InfoService.EventListItemViewModel> GetEventsForDay(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoService/GetEventsForDay", ReplyAction="http://tempuri.org/IInfoService/GetEventsForDayResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<appClient.InfoService.EventListItemViewModel>> GetEventsForDayAsync(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoService/GetEventsForWeek", ReplyAction="http://tempuri.org/IInfoService/GetEventsForWeekResponse")]
        System.Collections.Generic.List<appClient.InfoService.EventListItemViewModel> GetEventsForWeek(int week, System.Nullable<int> year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoService/GetEventsForWeek", ReplyAction="http://tempuri.org/IInfoService/GetEventsForWeekResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<appClient.InfoService.EventListItemViewModel>> GetEventsForWeekAsync(int week, System.Nullable<int> year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoService/GetPdfSummaryForDay", ReplyAction="http://tempuri.org/IInfoService/GetPdfSummaryForDayResponse")]
        byte[] GetPdfSummaryForDay(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoService/GetPdfSummaryForDay", ReplyAction="http://tempuri.org/IInfoService/GetPdfSummaryForDayResponse")]
        System.Threading.Tasks.Task<byte[]> GetPdfSummaryForDayAsync(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoService/GetPdfSummaryForWeek", ReplyAction="http://tempuri.org/IInfoService/GetPdfSummaryForWeekResponse")]
        byte[] GetPdfSummaryForWeek(int week, System.Nullable<int> year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoService/GetPdfSummaryForWeek", ReplyAction="http://tempuri.org/IInfoService/GetPdfSummaryForWeekResponse")]
        System.Threading.Tasks.Task<byte[]> GetPdfSummaryForWeekAsync(int week, System.Nullable<int> year);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInfoServiceChannel : appClient.InfoService.IInfoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InfoServiceClient : System.ServiceModel.ClientBase<appClient.InfoService.IInfoService>, appClient.InfoService.IInfoService {
        
        public InfoServiceClient() {
        }
        
        public InfoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InfoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InfoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InfoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public appClient.InfoService.EventViewModel GetEventById(string id) {
            return base.Channel.GetEventById(id);
        }
        
        public System.Threading.Tasks.Task<appClient.InfoService.EventViewModel> GetEventByIdAsync(string id) {
            return base.Channel.GetEventByIdAsync(id);
        }
        
        public System.Collections.Generic.List<appClient.InfoService.EventListItemViewModel> GetEventsForDay(string date) {
            return base.Channel.GetEventsForDay(date);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<appClient.InfoService.EventListItemViewModel>> GetEventsForDayAsync(string date) {
            return base.Channel.GetEventsForDayAsync(date);
        }
        
        public System.Collections.Generic.List<appClient.InfoService.EventListItemViewModel> GetEventsForWeek(int week, System.Nullable<int> year) {
            return base.Channel.GetEventsForWeek(week, year);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<appClient.InfoService.EventListItemViewModel>> GetEventsForWeekAsync(int week, System.Nullable<int> year) {
            return base.Channel.GetEventsForWeekAsync(week, year);
        }
        
        public byte[] GetPdfSummaryForDay(string date) {
            return base.Channel.GetPdfSummaryForDay(date);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetPdfSummaryForDayAsync(string date) {
            return base.Channel.GetPdfSummaryForDayAsync(date);
        }
        
        public byte[] GetPdfSummaryForWeek(int week, System.Nullable<int> year) {
            return base.Channel.GetPdfSummaryForWeek(week, year);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetPdfSummaryForWeekAsync(int week, System.Nullable<int> year) {
            return base.Channel.GetPdfSummaryForWeekAsync(week, year);
        }
    }
}
