using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Deadfile.Eyeglass.Interfaces
{
    public interface IDialogService
    {
        void ShowMessage(string title, string message);
        void ShowChoice(string title, string message, string yesText, ICommand yesCommand, string noText);
    }
}
