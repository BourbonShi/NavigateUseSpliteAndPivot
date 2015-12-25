using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo.BaseObject
{
    public class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Action<Object> MyExecute { get; set; }
        public Func<Object, bool> MyCanExecute { get; set; }

        public DelegateCommand(Action<Object> execute, Func<Object, bool> canExecute)
        {
            this.MyExecute = execute;
            this.MyCanExecute = canExecute;
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }

        public bool CanExecute(object parameter)
        {
            return MyCanExecute == null ? true : MyCanExecute(parameter);
        }

        public void Execute(object parameter)
        {
            try
            {
                MyExecute(parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
