using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TestProjectMobiele.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public ICommand ImageHomeClicked { get; private set; }
        public ICommand ImageSchoolClicked { get; private set; }
        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Klas applicatie";
            ImageHomeClicked = new DelegateCommand(() =>
            {
                NavigationService.NavigateAsync("LogInPage");
            });

            ImageSchoolClicked = new DelegateCommand(() =>
             {
                  NavigationService.NavigateAsync("FotosKleutersPage");
             });

        }
        

    }
}
