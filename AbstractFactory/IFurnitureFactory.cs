namespace AbstractFactory
{
    interface IFurnitureFactory
    {
        public IChair CreateChair();
        public ISofa CreateSofa();
        public ITable CreateTable();
    }
}
