﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BonusRestaurantDashboard.RestaurantServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FicheRestaurant", Namespace="http://schemas.datacontract.org/2004/07/BonusRestaurantService")]
    [System.SerializableAttribute()]
    public partial class FicheRestaurant : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxClientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PublicIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VilleField;
        
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
        public int MaxClient {
            get {
                return this.MaxClientField;
            }
            set {
                if ((this.MaxClientField.Equals(value) != true)) {
                    this.MaxClientField = value;
                    this.RaisePropertyChanged("MaxClient");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Numero {
            get {
                return this.NumeroField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroField, value) != true)) {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PublicID {
            get {
                return this.PublicIDField;
            }
            set {
                if ((this.PublicIDField.Equals(value) != true)) {
                    this.PublicIDField = value;
                    this.RaisePropertyChanged("PublicID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ville {
            get {
                return this.VilleField;
            }
            set {
                if ((object.ReferenceEquals(this.VilleField, value) != true)) {
                    this.VilleField = value;
                    this.RaisePropertyChanged("Ville");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RestaurantServiceReference.IFichesRestaurantService")]
    public interface IFichesRestaurantService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFichesRestaurantService/GetFichesRestaurant", ReplyAction="http://tempuri.org/IFichesRestaurantService/GetFichesRestaurantResponse")]
        BonusRestaurantDashboard.RestaurantServiceReference.FicheRestaurant[] GetFichesRestaurant();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFichesRestaurantService/GetFichesRestaurant", ReplyAction="http://tempuri.org/IFichesRestaurantService/GetFichesRestaurantResponse")]
        System.Threading.Tasks.Task<BonusRestaurantDashboard.RestaurantServiceReference.FicheRestaurant[]> GetFichesRestaurantAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFichesRestaurantService/AjouterRestaurant", ReplyAction="http://tempuri.org/IFichesRestaurantService/AjouterRestaurantResponse")]
        bool AjouterRestaurant();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFichesRestaurantService/AjouterRestaurant", ReplyAction="http://tempuri.org/IFichesRestaurantService/AjouterRestaurantResponse")]
        System.Threading.Tasks.Task<bool> AjouterRestaurantAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFichesRestaurantService/SupprimerRestaurant", ReplyAction="http://tempuri.org/IFichesRestaurantService/SupprimerRestaurantResponse")]
        bool SupprimerRestaurant(BonusRestaurantDashboard.RestaurantServiceReference.FicheRestaurant fiche);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFichesRestaurantService/SupprimerRestaurant", ReplyAction="http://tempuri.org/IFichesRestaurantService/SupprimerRestaurantResponse")]
        System.Threading.Tasks.Task<bool> SupprimerRestaurantAsync(BonusRestaurantDashboard.RestaurantServiceReference.FicheRestaurant fiche);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFichesRestaurantService/ModifierRestaurant", ReplyAction="http://tempuri.org/IFichesRestaurantService/ModifierRestaurantResponse")]
        bool ModifierRestaurant(BonusRestaurantDashboard.RestaurantServiceReference.FicheRestaurant fiche);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFichesRestaurantService/ModifierRestaurant", ReplyAction="http://tempuri.org/IFichesRestaurantService/ModifierRestaurantResponse")]
        System.Threading.Tasks.Task<bool> ModifierRestaurantAsync(BonusRestaurantDashboard.RestaurantServiceReference.FicheRestaurant fiche);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFichesRestaurantServiceChannel : BonusRestaurantDashboard.RestaurantServiceReference.IFichesRestaurantService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FichesRestaurantServiceClient : System.ServiceModel.ClientBase<BonusRestaurantDashboard.RestaurantServiceReference.IFichesRestaurantService>, BonusRestaurantDashboard.RestaurantServiceReference.IFichesRestaurantService {
        
        public FichesRestaurantServiceClient() {
        }
        
        public FichesRestaurantServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FichesRestaurantServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FichesRestaurantServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FichesRestaurantServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BonusRestaurantDashboard.RestaurantServiceReference.FicheRestaurant[] GetFichesRestaurant() {
            return base.Channel.GetFichesRestaurant();
        }
        
        public System.Threading.Tasks.Task<BonusRestaurantDashboard.RestaurantServiceReference.FicheRestaurant[]> GetFichesRestaurantAsync() {
            return base.Channel.GetFichesRestaurantAsync();
        }
        
        public bool AjouterRestaurant() {
            return base.Channel.AjouterRestaurant();
        }
        
        public System.Threading.Tasks.Task<bool> AjouterRestaurantAsync() {
            return base.Channel.AjouterRestaurantAsync();
        }
        
        public bool SupprimerRestaurant(BonusRestaurantDashboard.RestaurantServiceReference.FicheRestaurant fiche) {
            return base.Channel.SupprimerRestaurant(fiche);
        }
        
        public System.Threading.Tasks.Task<bool> SupprimerRestaurantAsync(BonusRestaurantDashboard.RestaurantServiceReference.FicheRestaurant fiche) {
            return base.Channel.SupprimerRestaurantAsync(fiche);
        }
        
        public bool ModifierRestaurant(BonusRestaurantDashboard.RestaurantServiceReference.FicheRestaurant fiche) {
            return base.Channel.ModifierRestaurant(fiche);
        }
        
        public System.Threading.Tasks.Task<bool> ModifierRestaurantAsync(BonusRestaurantDashboard.RestaurantServiceReference.FicheRestaurant fiche) {
            return base.Channel.ModifierRestaurantAsync(fiche);
        }
    }
}
