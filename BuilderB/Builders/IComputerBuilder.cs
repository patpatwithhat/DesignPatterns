using BuilderB.Entities;

namespace BuilderB.Builders
{
    public interface IComputerBuilder
    {
        void SetProcessor(string processor);
        void SetGraphicsCard(string graphicsCard);
        void AddMemory(int memory);
        void SetStorage(string storage);
        Computer Build();
    }
}
