using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RaceTimeManager.Misc;

namespace RaceTimeManager.ViewModels
{
    class MainViewModel : ChangeNotifier
    {
        private BaseViewModel viewModel;

        public MainViewModel()
        {
            viewModel = new MainMenuViewModel();
            
        }

        public void SwitchViewModel(BaseViewModel view)
        {
            ViewModel = view;
        }

        public BaseViewModel ViewModel
        {
            get { return viewModel; }
            set { viewModel = value; RaisePropertyChangedEvent("ViewModel"); }
        }



        


    }
}
