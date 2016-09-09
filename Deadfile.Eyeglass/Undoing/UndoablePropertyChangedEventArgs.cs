using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.Undoable
{
    public class UndoablePropertyChangedEventArgs
    {
        public UndoablePropertyChangedEventArgs(string propertyName, object previous, object future)
        {
            PropertyName = propertyName;
            Previous = previous;
            Future = future;
        }
        public string PropertyName { get; private set; }
        public object Previous { get; private set; }
        public object Future { get; private set; }
    }
}
