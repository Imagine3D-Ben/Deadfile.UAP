using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Deadfile.Eyeglass.Interfaces
{
    public interface IShellViewModel
    {
        ICommand SplitViewCommand { get; set; }
        ICommand HomePageCommand { get; set; }
        ICommand ClientsPageCommand { get; set; }
    }
}
