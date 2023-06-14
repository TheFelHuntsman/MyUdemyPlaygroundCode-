Random rng = new Random();
int first, second;
string Uguess;


first = rng.Next(1, 11);
second = rng.Next(1, 11);

Console.WriteLine($"The First Number is {first}.");
Console.Write("Will the second number be (H)igher, (L)ower or (E)qual: ");
Uguess = Console.ReadLine().ToUpper();

Console.Clear();

Console.WriteLine($"The Numbers were {first} and {second}");

if (Uguess == "H" || Uguess == "h")
{
    if (first < second)
    {
        Console.WriteLine("You guessed Higher and you were right!");
    }
    else
    {
        Console.WriteLine("You guessed Higher and you were wrong!");
    }

}
else if (Uguess == "L")
{
    if (first > second)
    {
        Console.WriteLine("You guessed Lower and you were right!");
    }
    else
    {
        Console.WriteLine("You guessed Lower and you were wrong!");
    }
}
else if (Uguess == "E")
{
    if (first == second)
    {
        Console.WriteLine("You guessed is Equal to and you were right!");
    }
    else
    {
        Console.WriteLine("You guessed is Equal to and you were wrong!");
    }
}
else
{
    Console.WriteLine("That wasn't a valid guess. Game Over!");
}

