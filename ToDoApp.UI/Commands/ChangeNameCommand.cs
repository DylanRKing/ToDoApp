using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoApp.UI.ViewModels;

namespace ToDoApp.UI.Commands
{
    public class ChangeNameCommand : ICommand
    {
        private WindowShellViewModel vm { get; set; }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public ChangeNameCommand(WindowShellViewModel vM)
        {
            vm = vM;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            vm.ChangeWindowName();
        }
    }
}
