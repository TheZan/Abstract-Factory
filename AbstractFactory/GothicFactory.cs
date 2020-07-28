namespace AbstractFactory
{
    class GothicFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new GothicChair();

        public ISofa CreateSofa() => new GothicSofa();

        public ITable CreateTable() => new GothicTable();
    }
}
