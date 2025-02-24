// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;
using ChainOfResponsibility.Conceptual;

Console.WriteLine("Hello, World!");

var monkey = new MonkeyHandler();
var squirrel = new SquirrelHandler();
var dog = new DogHandler();

monkey.SetNext(squirrel).SetNext(dog);

// The client should be able to send a request to any handler, not
// just the first one in the chain.
Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
Client.ClientCode(monkey);
Console.WriteLine();

//Console.WriteLine("Subchain: Squirrel > Dog\n");
//Client.ClientCode(squirrel);

//Console.WriteLine("Subchain: Squirrel > Dog\n");
//Client.ClientCode(dog);

Console.ReadKey();

