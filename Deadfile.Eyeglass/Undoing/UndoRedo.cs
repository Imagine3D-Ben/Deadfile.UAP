using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.Undoing
{
    internal sealed class UndoRedo
    {
        readonly Action undo;
        readonly Action redo;
        public UndoRedo(Action undo, Action redo)
        {
            this.undo = undo;
            this.redo = redo;
        }
        public void Undo()
        {
            undo();
        }
        public void Redo()
        {
            redo();
        }
    }
}
