using Deadfile.Eyeglass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Deadfile.Eyeglass.Interfaces
{
    public interface IClientsPageViewModel : IDeadfileViewModelBase
    {
        ClientModel SelectedClient { get; }
        ICollectionView Clients { get; }
        string FilterText { get; set; }
    }
}
