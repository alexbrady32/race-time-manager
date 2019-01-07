using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RaceTimeManager.ViewModels
{
    class EnterTimesViewModel : BaseViewModel
    {
        private ObservableCollection<String> unitTypes = new ObservableCollection<string> { "km", "mi", "m" };
        private ObservableCollection<Race> raceList;
        private string splitDistance;
        private string splitUnits;
        private int raceSelectedIndex = -1;
        private int tabViewSelectedIndex = 0;
        private int raceID;
        private string bibNumber;

        private RaceTimeManagerEntities rtmData;

        public EnterTimesViewModel()
        {
            rtmData = new RaceTimeManagerEntities();
            raceList = new ObservableCollection<Race>(rtmData.Races.ToList());
        }

        public string SplitDistance
        {
            get { return splitDistance; }

            set
            {
                splitDistance = value;
                RaisePropertyChangedEvent("SplitDistance");

            }
        }

        public string SplitUnits
        {
            get { return splitUnits; }

            set
            {
                splitUnits = value;
                RaisePropertyChangedEvent("SplitUnits");

            }
        }

        public string BibNumber
        {
            get { return bibNumber; }

            set
            {
                bibNumber = value;
                RaisePropertyChangedEvent("BibNumber");

            }
        }

        public ObservableCollection<String> UnitTypes
        {
            get
            { return unitTypes; }

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

        private void startTime()
        {
            var startTime = new StartFinishTime();
            startTime.BibNumber = Int32.Parse(bibNumber);
            startTime.RaceID = raceID;
            startTime.StartTime = DateTime.Now;
            rtmData.StartFinishTimes.Add(startTime);
            rtmData.SaveChanges();
            BibNumber = "";

        }


        public ICommand StartTime
        {
            get
            {
                return new RelayCommand(o => startTime());
            }
        }

        private void finishTime()
        {
            int bibNum = Int32.Parse(bibNumber);
            var startFinishQuery = from e in rtmData.StartFinishTimes
                               where e.BibNumber == bibNum && e.RaceID == raceID
                               select e;
            StartFinishTime entry = startFinishQuery.Cast<StartFinishTime>().First();
            if (entry != null)
            {
                entry.FinishTime = DateTime.Now;
                rtmData.SaveChanges();
                BibNumber = "";
            }
            else
            {
                // Error: Bib does not exist
            }


        }


        public ICommand FinishTime
        {
            get
            {
                return new RelayCommand(o => finishTime());
            }
        }

        private void addSplit()
        {
            var splitTime = new Split();
            splitTime.BibNumber = Int32.Parse(bibNumber);
            splitTime.RaceID = raceID;
            splitTime.SplitTime = DateTime.Now;
            splitTime.SplitDistance = System.Convert.ToDecimal(splitDistance);
            splitTime.SplitUnits = splitUnits;
            rtmData.Splits.Add(splitTime);
            rtmData.SaveChanges();
            BibNumber = "";
            SplitDistance = "";
        }


        public ICommand AddSplit
        {
            get
            {
                return new RelayCommand(o => addSplit());
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
