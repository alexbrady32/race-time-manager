using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data.Entity;

namespace RaceTimeManager.ViewModels
{
    class RacesViewModel : BaseViewModel
    {
        private string raceName;
        private string raceDate;
        private string raceDistance;
        private string raceUnits;
        private ObservableCollection<Race> raceList;
        private ObservableCollection<String> unitTypes = new ObservableCollection<string> { "km", "mi", "m" };

        private RaceTimeManagerEntities rtmData = new RaceTimeManagerEntities();


        public string RaceName
        {
            get { return raceName; }

            set
            {
                raceName = value;
                RaisePropertyChangedEvent("RaceName");
            }
        }

        public string RaceDate
        {
            get { return raceDate; }

            set
            {
                raceDate = value;
                RaisePropertyChangedEvent("RaceDate");
            }
        }

        public string RaceDistance
        {
            get { return raceDistance; }

            set {
                raceDistance = value;
                RaisePropertyChangedEvent("RaceDistance");

            }
        }

        public string RaceUnits
        {
            get { return raceUnits; }

            set
            {
                raceUnits = value;
                RaisePropertyChangedEvent("RaceUnits");

            }
        }

        public ObservableCollection<Race> RaceList
        {
            get
            {
                // TODO: Find better way to get the new runner list when just adding new rows
                raceList = new ObservableCollection<Race>(rtmData.Races.ToList());
                return raceList;
            }

            set
            {
                raceList = value;
                RaisePropertyChangedEvent("RaceList");
            }
        }

        public ObservableCollection<String> UnitTypes
        {
            get
            {   return unitTypes; }

        }

        private void addRace()
        {
            var race = new Race();
            race.RaceName = raceName;
            race.RaceDate = System.Convert.ToDateTime(raceDate);
            race.Distance = System.Convert.ToDecimal(raceDistance);
            race.Units = raceUnits;
            rtmData.Races.Add(race);
            rtmData.SaveChanges();
            RaceName = "";
            RaceDate = "";
            RaceDistance = "";
            RaceUnits = "";
            RaisePropertyChangedEvent("RaceList");
        }


        public ICommand AddRace
        {
            get
            {
                return new RelayCommand(o => addRace());
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
