using Deadfile.Eyeglass.Undoable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.Interfaces
{
    public interface INotifyUndoablePropertyChanged
    {
        event UndoablePropertyChangedEventHandler UndoablePropertyChanged;
    }
}
