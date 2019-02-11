using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class YarisFactory : ToyotaFactory
    {
        public override Body MakeBody()
        {
            return new YarisBody();            
        }

        public override Engine MakeEngine()
        {
            return new YarisEngine();            
        }
    }
}
