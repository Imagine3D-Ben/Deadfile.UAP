using Deadfile.Eyeglass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deadfile.Eyeglass.Models;

namespace Deadfile.Eyeglass.Repositories
{
    public class DeadfileRepository : IDeadfileRepository
    {
        readonly IDeadfileContext deadfileContext;
        public DeadfileRepository(IDeadfileContext deadfileContext)
        {
            this.deadfileContext = deadfileContext;
        }

        public ClientModel GetClientById(int clientId)
        {
            throw new NotImplementedException();
        }

        public List<ClientModel> GetClients()
        {
            return new List<ClientModel>(this.deadfileContext.Clients.Select((client) => new ClientModel { FirstName = client.FirstName, MiddleName = client.MiddleName, LastName = client.LastName, AddressLine1 = client.AddressLine1, AddressLine2 = client.AddressLine2, AddressTown = client.AddressTown, PhoneNumber1 = client.PhoneNumber1, PhoneNumber2 = client.PhoneNumber2, PhoneNumber3 = client.PhoneNumber3, EmailAddress = client.EmailAddress, State = client.State, Notes = client.Notes }));
        }
    }
}
