// See https://aka.ms/new-console-template for more information

using Strategy;
using StrategySample;


Console.WriteLine("Hello, World!");

var context = new Context(new ConcreteStrategyA());

Console.WriteLine("Client: Strategy is set to normal sorting.");

context.DoSomeBusinessLogic();

Console.WriteLine();

context = new Context(new ConcreteStrategyB());

Console.WriteLine("Client: Strategy is set to reverse sorting.");
context.DoSomeBusinessLogic();

Console.ReadKey();

