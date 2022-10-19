using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // The base Component interface defines operations that can be altered by
    // decorators.
    internal abstract class Component
    {
        public abstract string Operation();
    }
}
