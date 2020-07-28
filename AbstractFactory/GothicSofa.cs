using System;

namespace AbstractFactory
{
    class GothicSofa : ISofa
    {
        public void PrintInfo()
        {
            Console.WriteLine("Created Gothic Sofa!");
        }
    }
}
