using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using Partiel.UI.IService;
using Partiel.UI.IViewModel;
using Partiel.UI.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Navigation;

namespace Partiel.UI.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
            SimpleIoc.Default.Register<IMainPageService, MainPageService>();
            SimpleIoc.Default.Register<IMainPageViewModel, MainPageViewModel>();
        }


        public IMainPageViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IMainPageViewModel>();
            }
        }

    }
}
