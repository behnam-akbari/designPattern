// See https://aka.ms/new-console-template for more information
using ObserverSample.models;
using ObserverSample.Observer;

Console.WriteLine("Hello, World!");

var subject = new Subject();
var observerA = new ConcreteObserverA();
subject.Attach(observerA);

var observerB = new ConcreteObserverB();
subject.Attach(observerB);

subject.SomeBusinessLogic();
//subject.SomeBusinessLogic();

//subject.Detach(observerB);

//subject.SomeBusinessLogic();

Console.ReadKey();
