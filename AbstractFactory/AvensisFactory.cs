using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AvensisFactory : ToyotaFactory
    {
        public override Body MakeBody()
        {
            return new AvensisBody();
        }

        public override Engine MakeEngine()
        {
            return new AvensisEngine();
        }
    }
}
