using Caliburn.Micro;
using FLS_WPF_Caliburn.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FLS_WPF_Caliburn.ViewModels
{
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive
    {
        private PlayersDetailsView playersDetailsView;

        private  HomeViewModel homeArea;

        public HomeViewModel HomeArea
        {
            get { return homeArea; }
            set { homeArea = value; NotifyOfPropertyChange(() => HomeArea); }
        }

        public ShellViewModel(HomeViewModel homeViewModel)
        {
            this.HomeArea = new HomeViewModel();
            ActivateItem(HomeArea);
        }

    }
}
