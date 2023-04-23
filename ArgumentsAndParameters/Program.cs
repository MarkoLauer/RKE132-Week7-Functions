
//Console.WriteLine("Enter a word");
//string userInput = Console.ReadLine();

//PrintAnyWord(userInput); //userInput - argument

//static void PrintAnyWord(string anyString) //anyStrin - parameter
//{
//    anyString = anyString.ToUpper();
//    for (int i = 0; i < 5; i++)
//    {
//        Console.WriteLine(anyString);
//    }
//}

Console.WriteLine("How many steps have you walked today?");
int usersSteps = Int32.Parse(Console.ReadLine());

string result = HealthMonitor(usersSteps);

Console.WriteLine(result);

static string HealthMonitor(int steps)
{
    if (steps < 4000)
    {

        return "You need to move more.";
    }
    else if (steps >= 4000 && steps < 8000)
    {

        return "Health goal achieved,";
    }
    else
    {

        return "Well done!";
    }
}