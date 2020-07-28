using System;

namespace AbstractFactory
{
    class GothicChair : IChair
    {
        public void PrintInfo()
        {
            Console.WriteLine("Created Gothic Chair!");
        }
    }
}
