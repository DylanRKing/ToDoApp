using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ToDoApp.UI.Views
{
    /// <summary>
    /// Interaction logic for WindowShellView.xaml
    /// </summary>
    public partial class WindowShellView : Window
    {
        public WindowShellView()
        {
            InitializeComponent();
        }

        private void WindowMinimiseButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void WindowMaximiseButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
            WindowMaximiseButton.Visibility = Visibility.Collapsed;
            WindowRestoreButton.Visibility = Visibility.Visible;
        }

        private void WindowRestoreButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Normal;
            WindowRestoreButton.Visibility = Visibility.Collapsed;
            WindowMaximiseButton.Visibility = Visibility.Visible;
        }

        private void WindowCloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
