namespace BuilderB.Entities
{
    public class Computer
    {
        public string Processor { get; set; }
        public string GraphicsCard { get; set; }
        public int Memory { get; set; }
        public string Storage { get; set; }

        public override string ToString()
        {
            return $"Computer with Processor: {Processor}, Graphics Card: {GraphicsCard}, Memory: {Memory} GB, Storage: {Storage}";
        }
    }

}
