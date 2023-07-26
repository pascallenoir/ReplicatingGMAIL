using ReplicatingGMAIL.Models;
using ReplicatingGMAIL.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReplicatingGMAIL.ViewModels
{
    public class BoiteDeReceptionEmailListeViewModel : BaseViewModel
    {


        //Element de selection d'email dans la lsite
        private Email _selectedItem;

        /// <summary>
        /// Liste des emails
        /// </summary>
        public ObservableCollection<Email> BoiteDeReceptionEmailList { get; }

        /// <summary>
        /// Selection de plusieurs elements
        /// </summary>
        private ObservableCollection<object> _selectedItems;
        public ObservableCollection<object> SelectedItems
        {
            get => _selectedItems;
            set => _selectedItems = value;
        }

        /// <summary>
        /// mode de selection
        /// </summary>
        private SelectionMode _selectionMode = SelectionMode.None;

        public SelectionMode SelectionMode { get => _selectionMode; set => SetProperty(ref _selectionMode, value); }

        /// <summary>
        /// Variables de commande d'action
        /// </summary>
        public Command LoadItemsCommand { get; }
        public Command ScrolledCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Email> ItemTapped { get; }
        public Command<Email> LongPressCommand { get; }

        //Visibilité du bouton flottant
        private bool _newMailButtonVisibility = true;
        public bool NewMailButtonVisibility
        {
            get { return _newMailButtonVisibility; }
            set { SetProperty(ref _newMailButtonVisibility, value); }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public BoiteDeReceptionEmailListeViewModel()
        {
            Title = "Boite de réception";

            BoiteDeReceptionEmailList = new ObservableCollection<Email>();

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            _selectedItems = new ObservableCollection<object>();

            ItemTapped = new Command<Email>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);

            ScrolledCommand = new Command<object>((object args) => ActionScrolledList(args));

            LongPressCommand = new Command<Email>(OnLongPressed);
        }

        /// <summary>
        /// Appuie prolongé
        /// </summary>
        /// <param name="email"></param>
        private void OnLongPressed(Email email)
        {
        
            if (_selectionMode == SelectionMode.None)
            {
                _selectionMode = SelectionMode.Multiple;
                SelectedItems.Add(email);
            }
        }

        /// <summary>
        /// Evenement pour le cotrole du scroll
        /// </summary>
        /// <param name="args"></param>
        private void ActionScrolledList(object args)
        {
            double i = 0;
            if (args is ItemsViewScrolledEventArgs itemArgs)
            {
                var test = (ItemsViewScrolledEventArgs)itemArgs;

                if (test.VerticalDelta < 0)
                {
                    NewMailButtonVisibility = true;
                }
                else if (test.VerticalDelta != i)
                {
                    NewMailButtonVisibility = false;
                }
                else
                {
                    NewMailButtonVisibility = true;
                }
            }
        }

        /// <summary>
        /// Charger la liste des emails A l'affichage de la page ou par refresh commande
        /// </summary>
        /// <returns></returns>
        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                BoiteDeReceptionEmailList.Clear();
                var items = await EmailDataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    BoiteDeReceptionEmailList.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        /// <summary>
        /// Quand la page apparait
        /// </summary>
        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        /// <summary>
        /// Selection d'un elemenr dans la liste
        /// </summary>
        public Email SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }

        /// <summary>
        /// Lorsqu'un elemen est selectionné dans la liste
        /// </summary>
        /// <param name="item"></param>
        async void OnItemSelected(Email item)
        {
            if (item == null)
                return;

            if (_selectionMode != SelectionMode.None)
            {
                if(_selectedItems.Contains(item))
                    SelectedItems.Remove(item);
                else 
                    SelectedItems.Add(item);
            }
            else
            {
                // This will push the ItemDetailPage onto the navigation stack
                await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
            }
           
        }
    }
}