using Deadfile.Eyeglass.Interfaces;
using Deadfile.Eyeglass.Messaging;
using Prism.Events;
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
    public abstract class DeadfileViewModelBase : ViewModelBase, IDeadfileViewModelBase
    {
        protected readonly INavigationService navigationService;
        protected readonly IEventAggregator eventAggregator;

        public abstract bool HasChanges { get; }

        public abstract bool CanGoBack { get; }

        public DeadfileViewModelBase(INavigationService navigationService, IEventAggregator eventAggregator)
        {
            this.navigationService = navigationService;
            this.eventAggregator = eventAggregator;
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            eventAggregator.GetEvent<PaneContextChangedEvent>().Publish(this);
            base.OnNavigatedTo(e, viewModelState);
        }

        public abstract void DiscardChanges();

        public abstract void GoBack();
    }
}
