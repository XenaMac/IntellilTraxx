﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Base_AVL.PolygonService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="polygonData", Namespace="http://schemas.datacontract.org/2004/07/LATATrax.Models")]
    [System.SerializableAttribute()]
    public partial class polygonData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool actionInField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string actionInEmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool actionOutField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string actionOutEmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Base_AVL.PolygonService.LatLon> geoFenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid geoFenceIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string geoTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string notesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string polyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double radiusField;
        
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
        public bool actionIn {
            get {
                return this.actionInField;
            }
            set {
                if ((this.actionInField.Equals(value) != true)) {
                    this.actionInField = value;
                    this.RaisePropertyChanged("actionIn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string actionInEmail {
            get {
                return this.actionInEmailField;
            }
            set {
                if ((object.ReferenceEquals(this.actionInEmailField, value) != true)) {
                    this.actionInEmailField = value;
                    this.RaisePropertyChanged("actionInEmail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool actionOut {
            get {
                return this.actionOutField;
            }
            set {
                if ((this.actionOutField.Equals(value) != true)) {
                    this.actionOutField = value;
                    this.RaisePropertyChanged("actionOut");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string actionOutEmail {
            get {
                return this.actionOutEmailField;
            }
            set {
                if ((object.ReferenceEquals(this.actionOutEmailField, value) != true)) {
                    this.actionOutEmailField = value;
                    this.RaisePropertyChanged("actionOutEmail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Base_AVL.PolygonService.LatLon> geoFence {
            get {
                return this.geoFenceField;
            }
            set {
                if ((object.ReferenceEquals(this.geoFenceField, value) != true)) {
                    this.geoFenceField = value;
                    this.RaisePropertyChanged("geoFence");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid geoFenceID {
            get {
                return this.geoFenceIDField;
            }
            set {
                if ((this.geoFenceIDField.Equals(value) != true)) {
                    this.geoFenceIDField = value;
                    this.RaisePropertyChanged("geoFenceID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string geoType {
            get {
                return this.geoTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.geoTypeField, value) != true)) {
                    this.geoTypeField = value;
                    this.RaisePropertyChanged("geoType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string notes {
            get {
                return this.notesField;
            }
            set {
                if ((object.ReferenceEquals(this.notesField, value) != true)) {
                    this.notesField = value;
                    this.RaisePropertyChanged("notes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string polyName {
            get {
                return this.polyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.polyNameField, value) != true)) {
                    this.polyNameField = value;
                    this.RaisePropertyChanged("polyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double radius {
            get {
                return this.radiusField;
            }
            set {
                if ((this.radiusField.Equals(value) != true)) {
                    this.radiusField = value;
                    this.RaisePropertyChanged("radius");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LatLon", Namespace="http://schemas.datacontract.org/2004/07/LATATrax.Models")]
    [System.SerializableAttribute()]
    public partial class LatLon : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double AltField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LonField;
        
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
        public double Alt {
            get {
                return this.AltField;
            }
            set {
                if ((this.AltField.Equals(value) != true)) {
                    this.AltField = value;
                    this.RaisePropertyChanged("Alt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Lat {
            get {
                return this.LatField;
            }
            set {
                if ((this.LatField.Equals(value) != true)) {
                    this.LatField = value;
                    this.RaisePropertyChanged("Lat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Lon {
            get {
                return this.LonField;
            }
            set {
                if ((this.LonField.Equals(value) != true)) {
                    this.LonField = value;
                    this.RaisePropertyChanged("Lon");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PolygonService.IPolygonService")]
    public interface IPolygonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolygonService/getPolygons", ReplyAction="http://tempuri.org/IPolygonService/getPolygonsResponse")]
        System.Collections.Generic.List<Base_AVL.PolygonService.polygonData> getPolygons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolygonService/getPolygons", ReplyAction="http://tempuri.org/IPolygonService/getPolygonsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Base_AVL.PolygonService.polygonData>> getPolygonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolygonService/getPolygon", ReplyAction="http://tempuri.org/IPolygonService/getPolygonResponse")]
        Base_AVL.PolygonService.polygonData getPolygon(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolygonService/getPolygon", ReplyAction="http://tempuri.org/IPolygonService/getPolygonResponse")]
        System.Threading.Tasks.Task<Base_AVL.PolygonService.polygonData> getPolygonAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolygonService/addPolygon", ReplyAction="http://tempuri.org/IPolygonService/addPolygonResponse")]
        string addPolygon(Base_AVL.PolygonService.polygonData poly);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolygonService/addPolygon", ReplyAction="http://tempuri.org/IPolygonService/addPolygonResponse")]
        System.Threading.Tasks.Task<string> addPolygonAsync(Base_AVL.PolygonService.polygonData poly);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolygonService/deletePolygon", ReplyAction="http://tempuri.org/IPolygonService/deletePolygonResponse")]
        void deletePolygon(System.Guid GeoFenceID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolygonService/deletePolygon", ReplyAction="http://tempuri.org/IPolygonService/deletePolygonResponse")]
        System.Threading.Tasks.Task deletePolygonAsync(System.Guid GeoFenceID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPolygonServiceChannel : Base_AVL.PolygonService.IPolygonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PolygonServiceClient : System.ServiceModel.ClientBase<Base_AVL.PolygonService.IPolygonService>, Base_AVL.PolygonService.IPolygonService {
        
        public PolygonServiceClient() {
        }
        
        public PolygonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PolygonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PolygonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PolygonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Base_AVL.PolygonService.polygonData> getPolygons() {
            return base.Channel.getPolygons();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Base_AVL.PolygonService.polygonData>> getPolygonsAsync() {
            return base.Channel.getPolygonsAsync();
        }
        
        public Base_AVL.PolygonService.polygonData getPolygon(string id) {
            return base.Channel.getPolygon(id);
        }
        
        public System.Threading.Tasks.Task<Base_AVL.PolygonService.polygonData> getPolygonAsync(string id) {
            return base.Channel.getPolygonAsync(id);
        }
        
        public string addPolygon(Base_AVL.PolygonService.polygonData poly) {
            return base.Channel.addPolygon(poly);
        }
        
        public System.Threading.Tasks.Task<string> addPolygonAsync(Base_AVL.PolygonService.polygonData poly) {
            return base.Channel.addPolygonAsync(poly);
        }
        
        public void deletePolygon(System.Guid GeoFenceID) {
            base.Channel.deletePolygon(GeoFenceID);
        }
        
        public System.Threading.Tasks.Task deletePolygonAsync(System.Guid GeoFenceID) {
            return base.Channel.deletePolygonAsync(GeoFenceID);
        }
    }
}