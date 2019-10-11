using BonusRestaurantDashboard.Model;
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
        FicheRestaurant FicheSelectionee { get; set; }
        ObservableCollection<FicheRestaurant> Fiches { get; set; }
    }
}
