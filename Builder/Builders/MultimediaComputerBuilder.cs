using Builder.Entities;

namespace Builder.Builders
{
    public class MultimediaComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public IComputerBuilder SetProcessor(string processor)
        {
            _computer.Processor = "High-end " + processor;
            return this;
        }

        public IComputerBuilder SetGraphicsCard(string graphicsCard)
        {
            _computer.GraphicsCard = "High-performance " + graphicsCard;
            return this;
        }

        public IComputerBuilder AddMemory(int memory)
        {
            _computer.Memory = memory;
            return this;
        }

        public IComputerBuilder SetStorage(string storage)
        {
            _computer.Storage = "Large HDD " + storage;
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}
