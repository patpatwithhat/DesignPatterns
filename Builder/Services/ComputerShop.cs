using Builder.Builders;
using Builder.Entities;

namespace Builder.Services
{
    public class ComputerShop
    {
        public Computer BuildComputer(IComputerBuilder builder)
        {
            return builder.SetProcessor("Intel i7")
                          .SetGraphicsCard("NVIDIA RTX 3080")
                          .AddMemory(32)
                          .SetStorage("1TB SSD")
                          .Build();
        }
    }

}
