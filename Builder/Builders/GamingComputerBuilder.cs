using Builder.Entities;

namespace Builder.Builders
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public IComputerBuilder SetProcessor(string processor)
        {
            _computer.Processor = processor;
            return this;
        }

        public IComputerBuilder SetGraphicsCard(string graphicsCard)
        {
            _computer.GraphicsCard = graphicsCard;
            return this;
        }

        public IComputerBuilder AddMemory(int memory)
        {
            _computer.Memory = memory;
            return this;
        }

        public IComputerBuilder SetStorage(string storage)
        {
            _computer.Storage = storage;
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}
