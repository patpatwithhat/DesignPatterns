using BuilderB.Entities;

namespace BuilderB.Builders
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer _computer;

        public OfficeComputerBuilder()
        {
            _computer = new Computer();
        }

        public void SetProcessor(string processor)
        {
            _computer.Processor = processor + " (Efficient)";
        }

        public void SetGraphicsCard(string graphicsCard)
        {
            _computer.GraphicsCard = graphicsCard + " (Basic)";
        }

        public void AddMemory(int memory)
        {
            _computer.Memory = memory;
        }

        public void SetStorage(string storage)
        {
            _computer.Storage = storage + " SSD";
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}
