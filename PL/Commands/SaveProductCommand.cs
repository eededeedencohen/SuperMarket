using System;
using System.Windows;
using System.Windows.Input;

namespace PL.Commands
{
    public class SaveProductCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //TODO save product logic
            MessageBox.Show("product saved");
        }
    }
}
