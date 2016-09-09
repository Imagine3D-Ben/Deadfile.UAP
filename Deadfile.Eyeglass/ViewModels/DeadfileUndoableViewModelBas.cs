using Deadfile.Eyeglass.Interfaces;
using Deadfile.Eyeglass.Undoing;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.ViewModels
{
    public class DeadfileUndoableViewModelBase<T> : DeadfileViewModelBase where T : INotifyUndoablePropertyChanged, new()
    {
        public DeadfileUndoableViewModelBase(INavigationService navigationService) : base(navigationService)
        {
        }
        readonly Stack<UndoRedo> undo = new Stack<UndoRedo>();
        readonly Stack<UndoRedo> redo = new Stack<UndoRedo>();
        bool suspendChangeTracking = false;
        private T value = new T();

        protected void StartTracking(T src)
        {
            suspendChangeTracking = true;
            undo.Clear();
            redo.Clear();
            foreach (var property in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance & (~BindingFlags.DeclaredOnly)))
            {
                property.SetMethod.Invoke(value, new object[1] { property.GetMethod.Invoke(src, new object[0] { }) });
            }
            suspendChangeTracking = false;
        }

        protected void SetValue(T model)
        {

        }
    }
}
