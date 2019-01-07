using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace RaceTimeManager.ViewModels
{
    class AddRunnerViewModel : BaseViewModel
    {
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private ObservableCollection<Runner> runnerList; 

        private RaceTimeManagerEntities rtmData = new RaceTimeManagerEntities();

        public AddRunnerViewModel()
        {
            //runnerList = new ObservableCollection<Runner>(rtmData.Runners.ToList());
            
        }
       
        public string FirstName
        {

            set {
                firstName = value;
                RaisePropertyChangedEvent("FirstName");
            }
        }

        public string LastName
        {
            get { return lastName; }

            set {
                lastName = value;
                RaisePropertyChangedEvent("LastName");
            }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }

            set { dateOfBirth = value; }
        }

        public ObservableCollection<Runner> RunnerList
        {
            get {
                // TODO: Find better way to get the new runner list when just adding new rows
                runnerList = new ObservableCollection<Runner>(rtmData.Runners.ToList());
                return runnerList;
            }

            set
            {
                runnerList = value;
                RaisePropertyChangedEvent("RunnerList");
            }
        }

        private void addRunner()
        {
            var runner = new Runner();
            runner.FirstName = firstName;
            runner.LastName = lastName;
            rtmData.Runners.Add(runner);
            rtmData.SaveChanges();
            FirstName = "";
            LastName = "";
            RaisePropertyChangedEvent("RunnerList");
        }


        public ICommand AddRunner
        {
            get
            {
                return new RelayCommand(o => addRunner());
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
