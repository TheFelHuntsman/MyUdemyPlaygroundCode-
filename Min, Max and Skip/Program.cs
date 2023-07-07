using Min__Max_and_Skip;

int init, condition, increment;
Condition condition1 = new Condition();
while (true)
{
    Console.WriteLine("Enter loop start: ");
    try
    {
        init = int.Parse(Console.ReadLine());
        condition1.setValue1(init);
        break;
    }
    catch
    {
        Console.WriteLine("That was not a valid int: ");
    }
}

while (true)
{
    Console.WriteLine("Enter loop increment: ");
    try
    {
        increment = int.Parse(Console.ReadLine());
        if (increment == 0)
        {
          Console.WriteLine("Please enter a valid number: ");
        }
        else
        {
            break;
        } 
    }
    catch
    {
        Console.WriteLine("That was not a valid int: ");
    }
}

while (true)
{
    Console.WriteLine("Enter loop end: ");
    try
    {
        condition = int.Parse(Console.ReadLine());
        if (increment > 0)
        {
            if (condition > init)
            {
                for (int i = init; i <= condition; i += increment)
                {
                    Console.WriteLine(i);
                } break;
            }
        }
        else
        {
            if (condition < init)
            {
                {
                    for (int i = init; i >= condition; i += increment)
                    {
                        Console.WriteLine(i);
                    }break;
                }
            }
        }
        
        
    }
    catch
    {
        Console.WriteLine("That was not a valid int: ");
    }
}
