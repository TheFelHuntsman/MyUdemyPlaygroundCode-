int total = new int();
while (true)
{
    Console.WriteLine("Enter A number, Press Q to Quit: ");
    string value = Console.ReadLine().ToUpper();
    if (value == "Q")
        break;
    try
    {
       total += int.Parse(value);
    }
    catch
    {
        Console.WriteLine("please entere a valid number or Q to exit: ");
    }  
} Console.WriteLine($"Your total is: {total}");



