using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RaceTimeManager.ViewModels
{
    class MainMenuViewModel : BaseViewModel
    {
        private void viewAddRunnerView()
        {
            SwitchViewModel(new AddRunnerViewModel());
        }

        public ICommand ViewAddRunnerView
        {
            get
            {
                return new RelayCommand(o => viewAddRunnerView());
            }
        }

        private void viewRacesView()
        {
            SwitchViewModel(new RacesViewModel());
        }

        public ICommand ViewRacesView
        {
            get
            {
                return new RelayCommand(o => viewRacesView());
            }
        }

        private void viewRegisterView()
        {
            SwitchViewModel(new RegisterViewModel());
        }

        public ICommand ViewRegisterView
        {
            get
            {
                return new RelayCommand(o => viewRegisterView());
            }
        }

        private void viewEnterTimesView()
        {
            SwitchViewModel(new EnterTimesViewModel());
        }

        public ICommand ViewEnterTimesView
        {
            get
            {
                return new RelayCommand(o => viewEnterTimesView());
            }
        }

        private void viewResultsView()
        {
            SwitchViewModel(new ResultsViewModel());
        }

        public ICommand ViewResultsView
        {
            get
            {
                return new RelayCommand(o => viewResultsView());
            }
        }

    }
}
