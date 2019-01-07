using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RaceTimeManager.ViewModels
{
    class Result {
        public int BibNumber
        {
            get;
        }
        public DateTime StartTime
        {
            get;
        }
        public DateTime FinishTime
        {
            get;
        }
    }
    class ResultsViewModel : BaseViewModel
    {
        private ObservableCollection<Race> raceList;
        private ObservableCollection<StartFinishTime> resultsList;
        private int raceSelectedIndex = -1;
        private int tabViewSelectedIndex = 0;
        private int raceID;
        

        private RaceTimeManagerEntities rtmData;

        public ResultsViewModel()
        {
            rtmData = new RaceTimeManagerEntities();
            raceList = new ObservableCollection<Race>(rtmData.Races.ToList());
        }


        private void selectRace()
        {
            if (raceSelectedIndex != -1)
            {
                raceID = raceList[raceSelectedIndex].ID;
                TabViewSelectedIndex = 1;
            }

        }


        public ICommand SelectRace
        {
            get
            {
                return new RelayCommand(o => selectRace());
            }
        }


        private void overallResults()
        {
            if (raceSelectedIndex != -1)
            {
                raceID = raceList[raceSelectedIndex].ID;
                TabViewSelectedIndex = 1;

                var resultsQuery = from timeEntry in rtmData.StartFinishTimes
                                  where timeEntry.RaceID == raceID
                                  select timeEntry;
                var results = resultsQuery.ToList();
                ResultsList = new ObservableCollection<StartFinishTime>(results);
                foreach (var row in resultsList)
                {
                    //row.FinishTime = 
                }
            }
            
            /*
            StartFinishTime results = resultsQuery.Cast<StartFinishTime>().First();
            if (entry != null)
            {
                entry.FinishTime = DateTime.Now;
                rtmData.SaveChanges();
                BibNumber = "";
            }
            else
            {
                // Error: No race results
            }
            */

        }


        public ICommand OverallResults
        {
            get
            {
                return new RelayCommand(o => overallResults());
            }
        }

        public ObservableCollection<StartFinishTime> ResultsList
        {
            get
            {
                return resultsList;
            }

            set
            {
                resultsList = value;
                RaisePropertyChangedEvent("ResultsList");
            }
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

        public int RaceSelectedIndex
        {
            get { return raceSelectedIndex; }

            set
            {
                raceSelectedIndex = value;
                RaisePropertyChangedEvent("RaceSelectedIndex");
            }
        }

        public int TabViewSelectedIndex
        {
            get { return tabViewSelectedIndex; }

            set
            {
                tabViewSelectedIndex = value;
                RaisePropertyChangedEvent("TabViewSelectedIndex");
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
