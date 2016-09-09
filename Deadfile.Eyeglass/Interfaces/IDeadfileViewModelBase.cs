using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Deadfile.Eyeglass.Interfaces
{
    public interface IDeadfileViewModelBase
    {
        void DiscardChanges();
        bool HasChanges { get; }
        void GoBack();
        bool CanGoBack { get; }
    }
}
