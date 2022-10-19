using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample.Implementor
{
    public interface IOrderingSystem
    {
        void Place(string order);
    }
}
