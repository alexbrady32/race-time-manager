using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RaceTimeManager.ViewModels
{
    class RegisterViewModel : BaseViewModel
    {
        
        private ObservableCollection<Runner> runnersList;
        private ObservableCollection<Race> raceList;
        private int runnersSelectedIndex = -1;
        private int raceSelectedIndex = -1;

        private RaceTimeManagerEntities rtmData;
        

        public RegisterViewModel()
        {
            rtmData = new RaceTimeManagerEntities();
            raceList = new ObservableCollection<Race>(rtmData.Races.ToList());
            runnersList = new ObservableCollection<Runner>(rtmData.Runners.ToList());
        }

        public ObservableCollection<Race> RaceList
        {
            get
            {
                return raceList;
            }

            set
            {
                raceList = value;
                RaisePropertyChangedEvent("RaceList");
            }
        }

        public ObservableCollection<Runner> RunnersList
        {
            get
            {
                return runnersList;
            }

            set
            {
                runnersList = value;
                RaisePropertyChangedEvent("RunnerList");
            }
        }

        public int RunnersSelectedIndex
        {
            get { return runnersSelectedIndex; }

            set
            {
                runnersSelectedIndex = value;
                RaisePropertyChangedEvent("RunnersSelectedIndex");
            }
        }

        public int RaceSelectedIndex
        {
            get { return raceSelectedIndex; }

            set
            {
                raceSelectedIndex = value;
                RaisePropertyChangedEvent("RaceSelectedIndex");
            }
        }

        private void registerRunner()
        {
            var raceEntry = new RaceEntry();
            raceEntry.RunnerID = runnersList[runnersSelectedIndex].ID;
            raceEntry.RaceID = raceList[raceSelectedIndex].ID;
            rtmData.RaceEntries.Add(raceEntry);
            rtmData.SaveChanges();
            RunnersSelectedIndex = -1;
            RaceSelectedIndex = -1;
            
        }


        public ICommand RegisterRunner
        {
            get
            {
                return new RelayCommand(o => registerRunner());
            }
        }

        private void mainMenu()
        {
            SwitchViewModel(new MainMenuViewModel());
        }


        public ICommand MainMenu
        {
            get
            {
                return new RelayCommand(o => mainMenu());
            }
        }
    }
}
