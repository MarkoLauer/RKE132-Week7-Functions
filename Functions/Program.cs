
using System.ComponentModel.Design;

Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}

PrintHello();
PrintGoodBye();

static void PrintHello() //function / (call on) method
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, alligator.");
}