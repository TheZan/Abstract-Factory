using System;

namespace AbstractFactory
{
    class ModernTable : ITable
    {
        public void PrintInfo()
        {
            Console.WriteLine("Created Modern Table!");
        }
    }
}
