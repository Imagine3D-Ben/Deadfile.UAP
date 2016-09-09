using Deadfile.Eyeglass.Interfaces;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Deadfile.Eyeglass.ViewModels
{
    public class DeadfileViewModelBase : ViewModelBase
    {
        protected readonly INavigationService navigationService;
        public DeadfileViewModelBase(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
    }
}
