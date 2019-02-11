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


        public override string ToString()
        {
            return $"{Body} with a weight of {Body.Weight}kg and a {Engine}";

        }
    }

}
