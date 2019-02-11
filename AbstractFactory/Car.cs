using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Car
    {
        public Body Body { get; }

        public Engine Engine { get; }

        public Car (Body body, Engine engine)
        {
            Body = body;

            Engine = engine;
        }

        public void StartEngine()
        {
            Engine.Start();
        }

        public override string ToString()
        {
            return $"An {Body} with a weight of {Body.Weight}kg and an {Engine}";

        }
    }


    class ToyotaAssemblyLine
    {

        private ToyotaFactory _factory;

        public ToyotaAssemblyLine(ToyotaFactory factory)
        {
            _factory = factory;
        }

        public Car AssembleCar()
        {
            var body = _factory.MakeBody();
            var engine = _factory.MakeEngine(); 

            return new Car(body, engine);
        }
    }
}
