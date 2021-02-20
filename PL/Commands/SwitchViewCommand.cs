using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PL.ViewModels;

namespace PL.Commands
{
    public class SwitchViewCommand : ICommand
    {
        

        public event EventHandler CanExecuteChanged;
        public MainWindowViewModel mainWindow { get; set; }
        public int MyProperty { get; set; }

        public SwitchViewCommand(MainWindowViewModel mainWindow)
        {
            this.mainWindow = mainWindow;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter.ToString()=="Product")
            {
                mainWindow.SelectedViewModel = new ProductViewModel();
            }

            if (parameter.ToString() == "ShoppingData")
            {
                mainWindow.SelectedViewModel = new ShoppingDataViewModel();
            }

            if (parameter.ToString() == "ShoppingRecommendation")
            {
                mainWindow.SelectedViewModel = new ShoppingRecommedationViewModel();
            }
        }
    }
}
