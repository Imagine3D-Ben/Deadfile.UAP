using Deadfile.Eyeglass.Interfaces;
using Deadfile.Eyeglass.Undoable;
using Prism.Windows.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.Models
{
    public class ClientModel : UndoableValidatableBindableBase
    {
        int _Id;
        public int Id { get { return _Id; } set { SetValue(ref _Id, value); } }

        string _FirstName;
        public string FirstName { get { return _FirstName; } set { SetValue(ref _FirstName, value); } }

        string _MiddleName;
        public string MiddleName { get { return _MiddleName; } set { SetValue(ref _MiddleName, value); } }

        string _LastName;
        public string LastName { get { return _LastName; } set { SetValue(ref _LastName, value); } }

        string _AddressLine1;
        public string AddressLine1 { get { return _AddressLine1; } set { SetValue(ref _AddressLine1, value); } }

        string _AddressLine2;
        public string AddressLine2 { get { return _AddressLine2; } set { SetValue(ref _AddressLine2, value); } }

        string _AddressTown;
        public string AddressTown { get { return _AddressTown; } set { SetValue(ref _AddressTown, value); } }

        string _AddressPostCode;
        public string AddressPostCode { get { return _AddressPostCode; } set { SetValue(ref _AddressPostCode, value); } }

        string _PhoneNumber1;
        public string PhoneNumber1 { get { return _PhoneNumber1; } set { SetValue(ref _PhoneNumber1, value); } }

        string _PhoneNumber2;
        public string PhoneNumber2 { get { return _PhoneNumber2; } set { SetValue(ref _PhoneNumber2, value); } }

        string _PhoneNumber3;
        public string PhoneNumber3 { get { return _PhoneNumber3; } set { SetValue(ref _PhoneNumber3, value); } }

        string _EmailAddress;
        public string EmailAddress { get { return _EmailAddress; } set { SetValue(ref _EmailAddress, value); } }

        ClientState _State;
        public ClientState State { get { return _State; } set { SetValue(ref _State, value); } }

        string _Notes;
        public string Notes { get { return _Notes; } set { SetValue(ref _Notes, value); } }
    }
}