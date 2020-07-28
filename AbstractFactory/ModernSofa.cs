using System;

namespace AbstractFactory
{
    class ModernSofa : ISofa
    {
        public void PrintInfo()
        {
            Console.WriteLine("Created Modern Sofa!");
        }
    }
}
