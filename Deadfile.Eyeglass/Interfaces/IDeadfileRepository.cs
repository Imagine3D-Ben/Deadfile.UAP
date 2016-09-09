using Deadfile.Eyeglass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.Interfaces
{
    public interface IDeadfileRepository
    {
        List<ClientModel> GetClients();
        ClientModel GetClientById(int clientId);
    }
}
