using Deadfile.Eyeglass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace Deadfile.Eyeglass.Messaging
{
    public sealed class PaneContextChangedEvent : PubSubEvent<IDeadfileViewModelBase>
    {
    }
}
