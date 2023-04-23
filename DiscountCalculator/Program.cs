// <10 - 1%
// >=10 && < 20 - 5%
// >=20 -10%


// void - tühju, peale funktsiooni kasutamist info kustutatakse
//double, int, string - info on tagasikutsutav peale kasutamist vastava andmetüübina



Console.WriteLine("Provide total:");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInput);

Console.WriteLine($"Your discount is: {discount} %");

double newTotal = CalculateNewTotal(userInput, discount);

Console.WriteLine($"Your updated total with {discount}% {newTotal}");



static double CalculateDiscount(int total)
{
    if(total < 10)
    {
        return 1;
    }
    else if(total >=10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}