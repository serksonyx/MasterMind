using System;
using System.Windows.Input;

namespace MasterMindUI
{
    public class CommandHandler<T> : ICommand where T : class
    {
        private readonly Action<T> _action;
        private readonly bool _canExecute;

        public CommandHandler(Action<T> action, bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public void Execute(object parameter)
        {
            _action(parameter as T);
        }

        public event EventHandler CanExecuteChanged;
    }
}
