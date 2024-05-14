using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_D2.Commands
{
    public class DelegateCommand : ICommand
    {
        Action<object> _Execute;
        Predicate<object> _CanExecute;
        public DelegateCommand(Action<object> _exucute , Predicate<object> _canExecute)
        {
            _Execute = _exucute;
            _CanExecute = _canExecute;
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return _CanExecute(parameter) == null ? true : _CanExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _Execute.Invoke(parameter);
        }
    }
}
