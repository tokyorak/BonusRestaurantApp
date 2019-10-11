using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BonusRestaurantDashboard.Model
{
    public class FicheRestaurant: INotifyPropertyChanged
    {
        private string nom;
        private string numero;
        private int maxClient;
        private string ville;

        public string Nom { get => nom; set => NotifyChanges(ref nom, value); }
        public string Numero { get => numero; set => NotifyChanges(ref numero, value); }
        public int MaxClient { get => maxClient; set => NotifyChanges(ref maxClient, value); }
        public string Ville { get => ville; set => NotifyChanges(ref ville, value); }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyChanges<T>(ref T member, T value, [CallerMemberName]string name = null)
        {
            if (!Equals(member, value))
            {
                member = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
