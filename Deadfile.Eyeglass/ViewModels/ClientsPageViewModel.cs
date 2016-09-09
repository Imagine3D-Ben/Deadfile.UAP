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
using Deadfile.Eyeglass.Models;
using Windows.UI.Xaml.Data;
using Prism.Windows.AppModel;

namespace Deadfile.Eyeglass.ViewModels
{
    public class ClientsPageViewModel : DeadfileViewModelBase, IClientsPageViewModel
    {
        readonly IEventAggregator eventAggregator;

        public ClientsPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService)
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
                return navigationService.CanGoBack();
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
                return "Clients run time";
            }
        }

        public ClientModel SelectedClient
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollectionView Clients
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void DiscardChanges()
        {
            throw new NotImplementedException();
        }

        private string filterText;
        public string FilterText
        {
            get { return filterText; }
            set { SetProperty(ref filterText, value); }
        }
    }
}
