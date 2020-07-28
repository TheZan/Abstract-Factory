namespace AbstractFactory
{
    class ModernFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ModernChair();

        public ISofa CreateSofa() => new ModernSofa();

        public ITable CreateTable() => new ModernTable();
    }
}
