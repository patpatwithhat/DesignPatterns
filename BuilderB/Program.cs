using BuilderB.Builders;
using BuilderB.Entities;
using BuilderB.Services;

ComputerShop shop = new ComputerShop();

// Building an office computer
IComputerBuilder officeBuilder = new OfficeComputerBuilder();
Computer officeComputer = shop.BuildComputer(officeBuilder);
Console.WriteLine(officeComputer);

// Building a multimedia computer
IComputerBuilder multimediaBuilder = new MultimediaComputerBuilder();
Computer multimediaComputer = shop.BuildComputer(multimediaBuilder);
Console.WriteLine(multimediaComputer);