using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace ToDoApp.UI.Converters
{
    public class StringToWindowStateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string windowState = (string)value;

            if (windowState == "Maximised")
                return WindowState.Maximized;
            return WindowState.Normal;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            WindowState windowState = (WindowState)value;

            if (windowState == WindowState.Maximized)
                return "Maximised";
            return "Normal";
        }
    }
}
