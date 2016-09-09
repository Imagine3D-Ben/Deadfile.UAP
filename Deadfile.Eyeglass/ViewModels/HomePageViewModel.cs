using Deadfile.Eyeglass.Interfaces;
using Prism.Windows.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Windows.Navigation;
using System.Windows.Input;
using Prism.Events;
using Deadfile.Eyeglass.Messaging;

namespace Deadfile.Eyeglass.ViewModels
{
    public class HomePageViewModel : DeadfileViewModelBase, IHomePageViewModel
    {
        readonly IEventAggregator eventAggregator;
        public HomePageViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService)
        {
            this.eventAggregator = eventAggregator;
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            eventAggregator.GetEvent<PaneContextChangedEvent>().Publish(this);
            base.OnNavigatedTo(e, viewModelState);
        }

        public bool CanGoBack
        {
            get
            {
                return false;
            }
        }

        public void GoBack()
        {
            navigationService.GoBack();
        }

        public bool HasChanges
        {
            get
            {
                return false;
            }
        }

        public string Title
        {
            get
            {
                return "Runtime";
            }
        }

        public void DiscardChanges()
        {
            throw new NotImplementedException();
        }
    }
}
