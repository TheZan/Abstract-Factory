using System;

namespace AbstractFactory
{
    class VictorianSofa : ISofa
    {
        public void PrintInfo()
        {
            Console.WriteLine("Created Victorian Sofa!");
        }
    }
}
