using BonusRestaurantDashboard.ViewModel.FrameWorkMVVM;
using BonusRestaurantDashboard.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BonusRestaurantDashboard.ViewModel
{
    public class RestaurantDashBoardViewModel : RestaurantDashBoardBase, IRestaurantDashBoard
    {
        #region Attributes
        //Gère la selection d'une fiche
        private RestaurantServiceReference.FicheRestaurant ficheSelectionee;
        public RestaurantServiceReference.FicheRestaurant FicheSelectionee
        {
            get => ficheSelectionee;
            set => NotifyChanges(ref ficheSelectionee, value);
        }

        //Gère la liste des fiches restaurant
        private ObservableCollection<RestaurantServiceReference.FicheRestaurant> fiches;
        public ObservableCollection<RestaurantServiceReference.FicheRestaurant> Fiches
        {
            get => fiches;
            set => NotifyChanges(ref fiches, value);
        }
        #endregion

        #region Commands
        //Création des commandes pour..
        //L'ajout de fiche
        ICommand cmdAjouter;
        public ICommand CmdAjouter
        {
            get
            {
                if (cmdAjouter == null)
                    cmdAjouter = new RelayCommand<object>(o =>
                    {
                        //Connexion au service
                        var client = new RestaurantServiceReference.FichesRestaurantServiceClient();
                        client.AjouterRestaurant();
                        //Mise à jour de la liste de restaurants
                        Fiches = new ObservableCollection<RestaurantServiceReference.FicheRestaurant>(client.GetFichesRestaurant());
                        //fermeture du service après utilisation
                        client.Close();
                    });
                return cmdAjouter;
            }
        }
        //La suppression de fiche
        ICommand cmdSupprimer;
        public ICommand CmdSupprimer
        {
            get
            {
                if(cmdSupprimer == null)
                {
                    cmdSupprimer = new RelayCommand<RestaurantServiceReference.FicheRestaurant>(fiche =>
                   {    
                       //connexion au service
                       var client = new RestaurantServiceReference.FichesRestaurantServiceClient();
                       //suppression de la fiche
                       client.SupprimerRestaurant(fiche);
                       //MAJ de la liste
                       Fiches = new ObservableCollection<RestaurantServiceReference.FicheRestaurant>(client.GetFichesRestaurant());
                       client.Close();
                   });
                }
                return cmdSupprimer;
            }
        }
        //La modification d'une fiche
        ICommand cmdModifier;
        public ICommand CmdModifier
        {
            get
            {
                if(cmdModifier == null)
                {
                    cmdModifier = new RelayCommand<RestaurantServiceReference.FicheRestaurant>(fiche =>
                   {
                        //connexion au service
                        var client = new RestaurantServiceReference.FichesRestaurantServiceClient();
                        //Modification du client
                        client.ModifierRestaurant(fiche);
                       //MAJ des données de la liste
                       Fiches = new ObservableCollection<RestaurantServiceReference.FicheRestaurant>(client.GetFichesRestaurant());
                       //fermeture du service
                       client.Close();
                   });
                }
                return cmdModifier;
            }
        }
        #endregion

        #region Constructor
        public RestaurantDashBoardViewModel()
        {
            //Ajouter la référence avec le service FichesRestaurantService
            //var client = new RestaurantServiceReference.FichesRestaurantServiceClient();
            //fiches = client.GetFichesRestaurant();
            //client.Close();
            var client = new RestaurantServiceReference.FichesRestaurantServiceClient();
            Fiches = new ObservableCollection<RestaurantServiceReference.FicheRestaurant>(client.GetFichesRestaurant());
            client.Close();
        }
        #endregion
    }
}
