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
        public HomePageViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService, eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            eventAggregator.GetEvent<PaneContextChangedEvent>().Publish(this);
            base.OnNavigatedTo(e, viewModelState);
        }

        public override bool CanGoBack
        {
            get
            {
                return false;
            }
        }

        public override void GoBack()
        {
            navigationService.GoBack();
        }

        public override bool HasChanges
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

        public override void DiscardChanges()
        {
            throw new NotImplementedException();
        }
    }
}
