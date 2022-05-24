using System;
using System.Reflection;
using ToDoApp.UI.Classes;
using ToDoApp.UI.Commands;

namespace ToDoApp.UI.ViewModels
{
    public class WindowShellViewModel : MasterViewModel
    {

        private string appTitle = "To Do App";

        public string AppTitle
        {
            get { return appTitle; }
            set
            {
                if (value != null && value != String.Empty)
                {
                    appTitle = value;
                    OnPropertyChanged("AppTitle");
                }
            }
        }

        private static string execPath = Assembly.GetEntryAssembly().Location;
        private string appLogo = $@"{execPath}/../Images/Icons/LogoExample.png";

        public string AppLogo
        {
            get { return appLogo; }
            set
            {
                appLogo = value;
                OnPropertyChanged("LogoImage");
            }
        }


        private bool darkMode = true;

        public bool DarkMode
        {
            get { return darkMode; }
            set
            {
                darkMode = value;
                OnPropertyChanged("DarkMode");
                appTheme.DarkMode(DarkMode);
            }
        }

        private AppTheme appTheme;

        public WindowShellViewModel()
        {
            appTheme = new AppTheme();
        }
    }
}
