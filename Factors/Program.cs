int num;

while (true)
{

    try
    {
        Console.Write("Enter a number greater than 1: ");
        num = int.Parse(Console.ReadLine());
        if (num > 1)
        {
            break;
        }
    }
    catch
    {
        Console.WriteLine("Invalid input, please enter number greater than 1: ");
    }
}
    Console.Write($"The Factors of {num} are: ");

    for (int i = 1; i <= num / 2; i++)
    {
        if (num % i == 0)
        {
            Console.WriteLine($"{i}, ");
        }
    }
    Console.WriteLine($"{num}");


