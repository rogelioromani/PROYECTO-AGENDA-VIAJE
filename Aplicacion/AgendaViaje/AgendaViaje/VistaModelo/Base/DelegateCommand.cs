using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AgendaViaje.VistaModelo.Base
{
    public class DelegateCommand : ICommand
    {
        Action execute;
        Func<Boolean> CanExecuteMethod;
        public DelegateCommand(Action commandExecute, Func<Boolean> canExecuteMethod)
        {
            execute = commandExecute;
            CanExecuteMethod = canExecuteMethod;
        }

        bool ICommand.CanExecute(object parameter)
        {
            return CanExecuteMethod();
        }

        void ICommand.Execute(object parameter)
        {
            execute();
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, new EventArgs());
        }
    }
}
