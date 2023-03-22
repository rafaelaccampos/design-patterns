// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility.Example1;

var monkey = new MonkeyHandler();
var squirrel = new SquirrelHandler();
var dog = new DogHandler();

var chain = monkey
    .AddNext(squirrel)
    .AddNext(dog);

Console.WriteLine("Chain > Monkey > Squirrel > Dog\n");
Client.ClientCode(monkey);
Console.WriteLine();

Console.WriteLine("Subchain: Squirrel > Dog\n");
Client.ClientCode(squirrel);