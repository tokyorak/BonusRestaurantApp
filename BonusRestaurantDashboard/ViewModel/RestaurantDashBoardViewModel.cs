using BonusRestaurantDashboard.Model;
using BonusRestaurantDashboard.ViewModel.FrameWorkMVVM;
using BonusRestaurantDashboard.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusRestaurantDashboard.ViewModel
{
    public class RestaurantDashBoardViewModel : RestaurantDashBoardBase, IRestaurantDashBoard
    {
        #region Attributes
        private FicheRestaurant ficheSelectionee;
        public FicheRestaurant FicheSelectionee
        {
            get => ficheSelectionee;
            set => NotifyChanges(ref ficheSelectionee, value);
        }

        private ObservableCollection<FicheRestaurant> fiches;
        public ObservableCollection<FicheRestaurant> Fiches
        {
            get => fiches;
            set => NotifyChanges(ref fiches, value);
        }
        #endregion

        #region Commands
        #endregion

        #region Constructor
        public RestaurantDashBoardViewModel()
        {
            //Ajouter la référence avec le service FichesRestaurantService
            //var client = new RestaurantServiceReference.FichesRestaurantServiceClient();
            //fiches = client.GetFichesRestaurant();
            //client.Close();
        }
        #endregion
    }
}
