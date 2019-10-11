using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusRestaurantDashboard.ViewModel.Interface
{
    public interface IRestaurantDashBoard
    {
        RestaurantServiceReference.FicheRestaurant FicheSelectionee { get; set; }
        ObservableCollection<RestaurantServiceReference.FicheRestaurant> Fiches { get; set; }
    }
}
