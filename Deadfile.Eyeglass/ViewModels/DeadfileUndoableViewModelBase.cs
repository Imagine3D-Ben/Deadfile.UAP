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
using Deadfile.Eyeglass.Undoable;
using Prism.Events;

namespace Deadfile.Eyeglass.ViewModels
{
    public class DeadfileUndoableViewModelBase<T> : DeadfileViewModelBase where T : INotifyUndoablePropertyChanged, new()
    {
        private T value = new T();

        public DeadfileUndoableViewModelBase(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService, eventAggregator)
        {
            value.UndoablePropertyChanged += UndoablePropertyChanged;
        }

        /// <summary>
        /// If change tracking then it means that the user has made an action on the model. So we should
        /// clear the redo actions, and add the user's action to the undo action stack.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UndoablePropertyChanged(object sender, UndoablePropertyChangedEventArgs e)
        {
            if (!suspendChangeTracking)
            {
                var property = typeof(T).GetProperty(e.PropertyName, BindingFlags.Public | BindingFlags.Instance | (~BindingFlags.DeclaredOnly));
                Action u = () => property.SetMethod.Invoke(value, new object[] { e.Previous });
                Action r = () => property.SetMethod.Invoke(value, new object[] { e.Future });
                undo.Push(new UndoRedo(u, r));
                redo.Clear();
            }
        }

        readonly Stack<UndoRedo> undo = new Stack<UndoRedo>();
        readonly Stack<UndoRedo> redo = new Stack<UndoRedo>();
        bool suspendChangeTracking = false;

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

        public T UnderEdit { get { return value; } }

        public override bool HasChanges
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool CanGoBack
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool CanUndo()
        {
            return undo.Count > 0;
        }

        public bool CanRedo()
        {
            return redo.Count > 0;
        }

        public void Undo()
        {
            suspendChangeTracking = true;
            var u = undo.Pop();
            u.Undo();
            redo.Push(u);
            suspendChangeTracking = false;
        }

        public void Redo()
        {
            suspendChangeTracking = true;
            var u = redo.Pop();
            u.Redo();
            undo.Push(u);
            suspendChangeTracking = false;
        }

        public override void DiscardChanges()
        {
            throw new NotImplementedException();
        }

        public override void GoBack()
        {
            throw new NotImplementedException();
        }
    }
}
