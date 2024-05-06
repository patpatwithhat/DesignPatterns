using BuilderB.Builders;
using BuilderB.Entities;

namespace BuilderB.Services
{
    public class ComputerShop
    {
        public Computer BuildComputer(IComputerBuilder builder)
        {
            builder.SetProcessor("Intel i7");
            builder.SetGraphicsCard("NVIDIA RTX 3080");
            builder.AddMemory(32);
            builder.SetStorage("1TB SSD");
            return builder.Build();
        }
    }
}

