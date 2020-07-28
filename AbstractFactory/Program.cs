using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите стиль мебели:");
            Console.WriteLine("1. Готика");
            Console.WriteLine("2. Модерн");
            Console.WriteLine("3. Викторианский");

            if (int.TryParse(Console.ReadLine(), out int number) && number < 4 && number > 0)
            {
                switch (number)
                {
                    case 1:
                        CreateFurniture(new GothicFactory());
                        break;
                    case 2:
                        CreateFurniture(new ModernFactory());
                        break;
                    case 3:
                        CreateFurniture(new VictorianFactory());
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неверное значение!");
            }

            Console.ReadKey();
        }

        private static void CreateFurniture(IFurnitureFactory factory)
        {
            var chair = factory.CreateChair();
            var sofa = factory.CreateSofa();
            var table = factory.CreateTable();

            chair.PrintInfo();
            sofa.PrintInfo();
            table.PrintInfo();
        }
    }
}
