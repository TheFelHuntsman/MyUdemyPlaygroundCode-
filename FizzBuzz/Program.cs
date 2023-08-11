//int divisor = new int();


for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0) && (i % 7 == 0))
    {
        Console.WriteLine("FizzBuzzWhizz");
    }
    else if ((i % 5 == 0) && (i % 7 == 0))
    {
        Console.WriteLine("BuzzWhizz");
    }
    else if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 7 == 0)
    {
        Console.WriteLine("Whizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

// Experimenting with switch for FizzBuzzWhizz 

/* for (int i = 1; i <= 100; i++)
{
    if(i % divisor == 0)
        switch (divisor)
        {
            case 3:
                Console.WriteLine();
                break;
            case 5:
                Console.WriteLine();
                break;
            case 7:
                Console.WriteLine();
                break;
            default: Console.WriteLine(i); break;
        }

}
*/

