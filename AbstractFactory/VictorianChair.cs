using System;

namespace AbstractFactory
{
    class VictorianChair : IChair
    {
        public void PrintInfo()
        {
            Console.WriteLine("Created Victorian Chair!");
        }
    }
}
