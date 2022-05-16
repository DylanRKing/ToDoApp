using ToDoApp.UI.Commands;

namespace ToDoApp.UI.ViewModels
{
    public class WindowShellViewModel : MasterViewModel
    {

        private string windowTitle = "To-Do App";

        public string WindowTitle
        {
            get { return windowTitle; }
            set 
            { 
                windowTitle = value;
                OnPropertyChanged("WindowTitle");
            }
        }

        public ChangeNameCommand cNameCommand { get; set; }

        public WindowShellViewModel()
        {
            cNameCommand = new ChangeNameCommand(this);
        }

        public void ChangeWindowName()
        {
            WindowTitle = "Testing";
        }
    }
}
