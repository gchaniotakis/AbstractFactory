using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var EuropeFactory = new ToyotaAssemblyLine(new YarisFactory());

            var EuropeYaris = EuropeFactory.AssembleCar();
            Console.WriteLine(EuropeYaris);
            EuropeYaris.Engine.Start();

            var JapanFactory = new ToyotaAssemblyLine(new AvensisFactory());

            var JapanAvensis = JapanFactory.AssembleCar();
            Console.WriteLine(JapanAvensis);
            JapanAvensis.Engine.Start();

            Console.Read();
        }
    }
}
