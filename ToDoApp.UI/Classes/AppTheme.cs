using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ToDoApp.UI.Classes
{
    public class AppTheme
    {
        readonly PaletteHelper paletteHelper;
        private ITheme theme;

        public AppTheme()
        {
            paletteHelper = new PaletteHelper();
            theme = paletteHelper.GetTheme();
        }

        public void DarkMode(bool DarkMode)
        {
            if (DarkMode)
                theme.SetBaseTheme(Theme.Dark);
            else
                theme.SetBaseTheme(Theme.Light);
            paletteHelper.SetTheme(theme);
        }
    }
}
