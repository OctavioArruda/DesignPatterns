using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Components
{
    class Engine
    {
        public Engine(uint power)
        {
            this._power = power;
        }

        private uint _power;
        public uint Power 
        {
            get => _power;
            set => _power = value;
        }
    }
}
