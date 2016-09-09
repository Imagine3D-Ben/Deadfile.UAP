using Deadfile.Eyeglass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deadfile.Eyeglass.Models;

namespace Deadfile.Eyeglass.DesignTime
{
    public class DeadfileRepository : IDeadfileRepository
    {
        public static List<ClientModel> FakeClients
        {
            get
            {
                return
                    new List<ClientModel>
                    {
                        new ClientModel { Id = 0, FirstName = "Hugh", MiddleName = "Graham", LastName = "Mungus", AddressLine1 = "111 Bateman Gardens", AddressLine2 = "", AddressTown = "Enfield", AddressPostCode = "EN5 3ZN", PhoneNumber1 = "07123456789", PhoneNumber2 = "", PhoneNumber3 = "", EmailAddress = "abc.def@gmail.com", State = ClientState.Active, Notes = null },
                        new ClientModel { Id = 0, FirstName = "Mike", MiddleName = null, LastName = "Oxlong", AddressLine1 = "5 Wakefield Street", AddressLine2 = "", AddressTown = "Barnet", AddressPostCode = "EN2 5NS", PhoneNumber1 = "07545485612", PhoneNumber2 = "", PhoneNumber3 = "", EmailAddress = "def.abc@gmail.com", State = ClientState.Active, Notes = null }
                    };
            }
        }

        public ClientModel GetClientById(int clientId)
        {
            throw new NotImplementedException();
        }

        public List<ClientModel> GetClients()
        {
            return FakeClients;
        }
    }
}
