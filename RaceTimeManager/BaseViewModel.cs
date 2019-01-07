using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTimeManager.Misc;

namespace RaceTimeManager.ViewModels
{
    public class BaseViewModel : ChangeNotifier
    {

        /*
        public event PropertyChangedEventHandler PropertyChanged;

        // Taken from https://msdn.microsoft.com/en-us/library/ms229614.aspx
        protected void RaisePropertyChangedEvent(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    */

        protected MainWindow AppWindow
        {
            get { return App.Current.MainWindow as MainWindow; }
        }

        protected void SwitchViewModel(BaseViewModel view)
        {
            if (AppWindow != null)
            {
                AppWindow.SwitchViewModel(view);
            }
        }
    }
}
