using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Partiel.UI.IService;
using Partiel.UI.IViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Navigation;

namespace Partiel.UI.ViewModel
{
    public class MainPageViewModel : ViewModelBase, IMainPageViewModel
    {
        private INavigationService _iNavigationService;
        private IMainPageService _iMainPageService;
        public ICommand SearchAdressCommand { get; set; }
        private string _coordonnes;

        public string Coordonnees
        {
            get { return _coordonnes; }
            set { _coordonnes = value;
                Set(() => _coordonnes, ref _coordonnes, value);
                RaisePropertyChanged("Coordonnees");
            }
        }

        private string _adresse;

        public string Adresse
        {
            get { return _adresse; }
            set
            {
                _adresse = value;
                Set(() => _adresse, ref _adresse, value);
                RaisePropertyChanged("Adresse");
            }
        }

        public MainPageViewModel(INavigationService iNavigationService, IMainPageService mainPageService)
        {
            _iNavigationService = iNavigationService;
            _iMainPageService = mainPageService;
            SearchAdressCommand = new Command(Search);
        }

        private async void Search()
        {
           try
           {
              string result = await _iMainPageService.GetCoordonnees(Adresse);
                Coordonnees = result;
           }
           catch (Exception e)
           {
                throw e;
           }
        }
    }
}
