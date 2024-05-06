using Builder.Builders;
using Builder.Entities;
using Builder.Services;

ComputerShop shop = new ComputerShop();
IComputerBuilder builder = new GamingComputerBuilder();
Computer gamingPC = shop.BuildComputer(builder);
Console.WriteLine(gamingPC);