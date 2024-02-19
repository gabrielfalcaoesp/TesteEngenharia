using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TesteAlvenaria.Libs
{
    internal class GenericCommand : ICommand
    {
        #region Variables and Properties

        private Action<object> m_executeMethod;
        private Func<object, bool> m_canExecuteMethod;

        #endregion

        #region Constructors

        public GenericCommand(Action<object> executeMethod) : this(executeMethod, (obj) => { return true; })
        { }

        public GenericCommand(Action<object> executeMethod, Func<object, bool> canExecuteMethod)
        {
            m_executeMethod = executeMethod;
            m_canExecuteMethod = canExecuteMethod;
        }

        #endregion

        public bool CanExecute(object parameter)
        {
            if (m_canExecuteMethod != null)
                return m_canExecuteMethod(parameter);
            return false;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter) => m_executeMethod(parameter);
    }
}
