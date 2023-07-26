using ReplicatingGMAIL.Interface;
using ReplicatingGMAIL.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ReplicatingGMAIL.ViewModels
{
    public class BarreDeNavigationCustomiseViewModel
    {
        // Declaration des commandes 
        public Command PageDeMenu { get; }
        public Command PageDeRechercheAvancee { get; }
        public Command PagePopUp { get; }


        //Constructeur
        public BarreDeNavigationCustomiseViewModel()
        {
            PageDeMenu = new Command(OuvriMenu);
            PageDeRechercheAvancee = new Command(AllerARecherche);
            PagePopUp = new Command(OuvrirPopUp);
        }


        /// <summary>
        /// Ouvrir le PopUp sur la page actuelle
        /// </summary>
        /// <param name="obj"></param>
        private async void OuvrirPopUp(object obj)
        {

            await PopupNavigation.Instance.PushAsync(new PoPUpProfilUtilisateur());
        }

        /// <summary>
        /// Rediriger l'utilisateur vers la page de recherche avancee
        /// </summary>
        /// <param name="obj"></param>
        private async void AllerARecherche(object obj)
        {
            await Shell.Current.GoToAsync(nameof(PageDeRecherche));
        }


        /// <summary>
        /// Permet d'afficher le menu lateral 'tiroir'
        /// </summary>
        /// <param name="obj"></param>
        /// 
        private void OuvriMenu(object obj)
        {
            Shell.Current.FlyoutIsPresented = true;
            DependencyService.Get<IStatusBar>().HideStatusBar();
        }
    }
}
