using System;

namespace AbstractFactory
{
    class ModernChair : IChair
    {
        public void PrintInfo()
        {
            Console.WriteLine("Created Modern Chair!");
        }
    }
}
