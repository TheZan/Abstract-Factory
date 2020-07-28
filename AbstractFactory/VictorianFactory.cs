namespace AbstractFactory
{
    class VictorianFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new VictorianChair();

        public ISofa CreateSofa() => new VictorianSofa();

        public ITable CreateTable() => new VictorianTable();
    }
}
