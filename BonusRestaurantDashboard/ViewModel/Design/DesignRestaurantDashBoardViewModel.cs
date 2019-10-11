using BonusRestaurantDashboard.Model;
using BonusRestaurantDashboard.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusRestaurantDashboard.ViewModel.Design
{
    public class DesignRestaurantDashBoardViewModel : IRestaurantDashBoard
    {
        public FicheRestaurant FicheSelectionee
        {
            get => new FicheRestaurant() { Nom = "Le Wauthier", Numero = "06 73 81 03 98", MaxClient = 80, Ville = "Paris"};
            set { }
        }
        public ObservableCollection<FicheRestaurant> Fiches
        {
            get => new ObservableCollection<FicheRestaurant>() { FicheSelectionee };
            set { }
        }
    }
}
