using PL.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PL.ViewModels
{
    public class MainWindowViewModel :ViewModel
    {
        private ViewModel _selectedViewModel;


        public ViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set 
            {
                _selectedViewModel = value;
                onPropertyChange(nameof(SelectedViewModel));
            }
        }

        public ICommand SwitchView { get; set; }

        public MainWindowViewModel()
        {
            SelectedViewModel = new ShoppingDataViewModel();
            SwitchView = new SwitchViewCommand(this);
        }
    }
}
