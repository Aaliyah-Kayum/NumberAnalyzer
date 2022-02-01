// See https://aka.ms/new-console-template for more information


//Welcome message
Console.WriteLine("Hello, what is your name?");
string name = Console.ReadLine();
Console.WriteLine(name);

do
{
    Console.WriteLine("Please enter a number that is not 0 " + name);
    int number = int.Parse(Console.ReadLine());
    if ((number % 2 == 0) && (number > 60))
    {
        Console.WriteLine("This number is even and greater than 60 " + name);
    }
    else if ((number % 2 != 0) && (number < 60))
    {
        Console.WriteLine("This number is odd and less than 60 " + name);
    }
    else if ((number % 2 == 0) && (number >= 2) && (number <= 25))
    {
        Console.WriteLine("This number is even and less than 25" + name);
    }
    else if ((number % 2 == 0) && (number >= 26) && (number <= 60))
    {
        Console.WriteLine("This number is even and between 26 and 60 inclusive" + name);
    }
    else if ((number % 2 != 0) && (number > 60))
    {
        Console.WriteLine("This number is odd and greater than 60 " + name);
    }

Console.WriteLine("Do you wish to keep looping? y/n");
string looping = Console.ReadLine();

if (looping == "y")

    continue;
    {
        if (looping == "n")
        {
            break;
        }
    }
}
while (true) ;