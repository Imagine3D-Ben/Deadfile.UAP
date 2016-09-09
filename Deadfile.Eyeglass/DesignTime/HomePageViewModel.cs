using Deadfile.Eyeglass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.DesignTime
{
    public class HomePageViewModel : IHomePageViewModel
    {
        public bool CanGoBack
        {
            get
            {
                return false;
            }
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
                return "Design Time";
            }
        }

        public void DiscardChanges()
        {
            throw new NotImplementedException();
        }

        public void GoBack()
        {
            throw new NotImplementedException();
        }
    }
}
