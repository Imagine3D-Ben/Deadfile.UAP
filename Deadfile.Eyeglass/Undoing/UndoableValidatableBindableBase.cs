using Deadfile.Eyeglass.Interfaces;
using Prism.Windows.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.Undoable
{
    public class UndoableValidatableBindableBase : ValidatableBindableBase, INotifyUndoablePropertyChanged
    {
        public event UndoablePropertyChangedEventHandler UndoablePropertyChanged;

        public void FireUndoablePropertyChanged<T>(string propertyName, T previous, T future)
        {
            UndoablePropertyChanged?.Invoke(this, new UndoablePropertyChangedEventArgs(propertyName, previous, future));
        }

        protected void SetValue<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (!object.Equals(storage, value))
            {
                FireUndoablePropertyChanged(propertyName, storage, value);
                SetProperty(ref storage, value, propertyName);
            }
        }
    }
}
