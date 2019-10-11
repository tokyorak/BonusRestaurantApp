using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BonusRestaurantService
{
    public class FichesRestaurantService : IFichesRestaurantService
    {
        public bool AjouterRestaurant()
        {
            try
            {
                using(var entities = new RestaurantDBEntities())
                {
                    entities.Restaurants.Add(new Restaurant()
                    {
                        //générer un ID public incrémental
                        PublicID = entities.Restaurants.Count()+1,
                        Nom = "Modifier",
                        Numero = "Modifier",
                        MaxClients = 0,
                        Ville = "Modifier"
                    });
                    entities.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ObservableCollection<FicheRestaurant> GetFichesRestaurant()
        {
            ObservableCollection<FicheRestaurant> collection = null;
            //Initialisation de la collection avec les valeurs de la table
            //Ouverture de la connexion a la BDD
            using(var entities = new RestaurantDBEntities())
            {
                collection = new ObservableCollection<FicheRestaurant>(entities.Restaurants.Select(
                    restau => new FicheRestaurant()
                    {
                        PublicID = restau.PublicID.Value,
                        Nom = restau.Nom,
                        Numero = restau.Numero,
                        MaxClient = restau.MaxClients.Value,
                        Ville = restau.Ville
                    }
                    ));
            }
            return collection;
        }

        public bool ModifierRestaurant(FicheRestaurant fiche)
        {
            try
            {
                using (var entities = new RestaurantDBEntities())
                {
                    var ficheAModifier = entities.Restaurants.FirstOrDefault(restau => restau.PublicID.Value == fiche.PublicID);
                    if(ficheAModifier != null)
                    {
                        ficheAModifier.Nom = fiche.Nom;
                        ficheAModifier.Numero = fiche.Numero;
                        ficheAModifier.Ville = fiche.Ville;
                        ficheAModifier.MaxClients = fiche.MaxClient;
                        entities.SaveChanges();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SupprimerRestaurant(FicheRestaurant fiche)
        {
            try
            {
                using(var entities = new RestaurantDBEntities())
                {
                    var ficheASupprimer = entities.Restaurants.Where(
                        resto => 
                            resto.Nom == fiche.Nom 
                            && resto.Numero == fiche.Numero 
                            && resto.Ville == fiche.Ville 
                            && resto.MaxClients == fiche.MaxClient
                            && resto.PublicID == fiche.PublicID
                        ).ToArray();
                    if(ficheASupprimer != null)
                    {
                        entities.Restaurants.RemoveRange(ficheASupprimer);
                        entities.SaveChanges();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
