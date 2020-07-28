using System;

namespace AbstractFactory
{
    class GothicTable : ITable
    {
        public void PrintInfo()
        {
            Console.WriteLine("Created Gothic Table!");
        }
    }
}
