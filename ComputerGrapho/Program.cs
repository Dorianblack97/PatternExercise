// Composite Pattern and Visitor Pattern

using ComputerGrapho.Components;
using ComputerGrapho.Components.Leaf;
using ComputerGrapho.Components.Nodes;

var cpu = new Cpu(550);
var monitor = new MonitorPc(250);
var ram = new Memory(160);
var keyboard = new Keyboard(35);
var computer = new Computer();
computer.Add(cpu);
computer.Add(monitor);
computer.Add(ram);
computer.Add(keyboard);

var gpu = new Gpu(140);
var gpuRam = new Memory(80);
var graphicCard = new GraphicCard();
graphicCard.Add(gpu);
graphicCard.Add(gpuRam);
computer.Add(graphicCard);

Console.WriteLine("Costo del pc completo: " + computer.CalculatePrice());
Console.WriteLine("Costo della gpu: " + graphicCard.CalculatePrice());

var priceCalculator = new PriceCalculator();

computer.Accept(priceCalculator);

Console.WriteLine("Costo delle memorie: " + priceCalculator.TotalPrice);

