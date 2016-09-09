using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Deadfile.Eyeglass.Interfaces;
using Deadfile.Eyeglass.Models;
using Windows.UI.Xaml.Data;

namespace Deadfile.Eyeglass.DesignTime
{
    public class ClientsPageViewModel : IClientsPageViewModel
    {
        IDeadfileRepository deadfileRepository = new DeadfileRepository();
        CollectionViewSource clients = new CollectionViewSource();

        public ClientsPageViewModel()
        {
            clients.Source = deadfileRepository.GetClients();
        }

        public bool CanGoBack
        {
            get
            {
                return true;
            }
        }

        public void GoBack()
        {
            throw new NotImplementedException();
        }

        public bool HasChanges
        {
            get
            {
                return false;
            }
        }

        public string Title { get { return "Clients design time"; } }

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
                return clients.View;
            }
        }

        public string FilterText
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void DiscardChanges()
        {
            throw new NotImplementedException();
        }
    }
}
