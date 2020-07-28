using System;

namespace AbstractFactory
{
    class VictorianTable : ITable
    {
        public void PrintInfo()
        {
            Console.WriteLine("Created Victorian Table!");
        }
    }
}
