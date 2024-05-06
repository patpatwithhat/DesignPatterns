using BuilderB.Entities;

namespace BuilderB.Builders
{
    public class MultimediaComputerBuilder : IComputerBuilder
    {
        private Computer _computer;

        public MultimediaComputerBuilder()
        {
            _computer = new Computer();
        }

        public void SetProcessor(string processor)
        {
            _computer.Processor = processor + " (High-performance)";
        }

        public void SetGraphicsCard(string graphicsCard)
        {
            _computer.GraphicsCard = graphicsCard + " (High-end)";
        }

        public void AddMemory(int memory)
        {
            _computer.Memory = memory;
        }

        public void SetStorage(string storage)
        {
            _computer.Storage = "2TB HDD + 512GB SSD";
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}
