using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncasulationDemoWithDieClass
{
    /// <summary>
    /// this will represent a single die
    /// </summary>
    class Die
    {
        public byte Value { get; private set; }

        public bool IsHeld { get; set; }

        //roll method here
    }
}
