using Builder.Entities;

namespace Builder.Builders
{
    public interface IComputerBuilder
    {
        IComputerBuilder SetProcessor(string processor);
        IComputerBuilder SetGraphicsCard(string graphicsCard);
        IComputerBuilder AddMemory(int memory);
        IComputerBuilder SetStorage(string storage);
        Computer Build();
    }

}
