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
        readonly IDeadfileRepository deadfileRepository;

        public ClientsPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator, IDeadfileRepository deadfileRepository) : base(navigationService, eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            this.deadfileRepository = deadfileRepository;
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(e, viewModelState);
        }

        public override bool CanGoBack
        {
            get
            {
                return navigationService.CanGoBack();
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

        public override void DiscardChanges()
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
