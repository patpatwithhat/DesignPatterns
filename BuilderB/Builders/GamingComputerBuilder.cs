using BuilderB.Entities;

namespace BuilderB.Builders
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetProcessor(string processor)
        {
            _computer.Processor = processor;
        }

        public void SetGraphicsCard(string graphicsCard)
        {
            _computer.GraphicsCard = graphicsCard;
        }

        public void AddMemory(int memory)
        {
            _computer.Memory = memory;
        }

        public void SetStorage(string storage)
        {
            _computer.Storage = storage;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}
