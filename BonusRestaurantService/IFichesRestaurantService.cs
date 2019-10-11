using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BonusRestaurantService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IFichesRestaurantService
    {
        [OperationContract]
        ObservableCollection<FicheRestaurant> GetFichesRestaurant();
        [OperationContract]
        bool AjouterRestaurant();
        [OperationContract]
        bool SupprimerRestaurant(FicheRestaurant fiche);
        [OperationContract]
        bool ModifierRestaurant(FicheRestaurant fiche);

        // TODO: ajoutez vos opérations de service ici
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class FicheRestaurant: INotifyPropertyChanged
    {
        private string nom;
        private string numero;
        private int maxClient;
        private string ville;

        [DataMember]
        public string Nom { get => nom; set => NotifyChanges(ref nom, value); }
        [DataMember]
        public string Numero { get => numero; set => NotifyChanges(ref numero, value); }
        [DataMember]
        public int MaxClient { get => maxClient; set => NotifyChanges(ref maxClient, value); }
        [DataMember]
        public string Ville { get => ville; set => NotifyChanges(ref ville, value); }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyChanges<T>(ref T member, T value, [CallerMemberName] string name = null)
        {
            if (!Equals(member, value))
            {
                member = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
