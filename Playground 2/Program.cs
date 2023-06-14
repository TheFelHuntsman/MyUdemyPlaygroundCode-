Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Black;

//declare variables 
decimal entTotal;
int entTip;
decimal fTotal;
decimal fTip;

//promt the user for the amounts
Console.WriteLine(" Enter Total: ");
entTotal = decimal.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine(" Enter Tip %");
entTip = int.Parse(Console.ReadLine());
Console.Clear();
// Convert the Tip to Decimal mulitplier
fTip = (decimal) entTip / 100;
fTotal = entTotal;
//Console display 
Console.WriteLine($" Tip Calculator " +
    $"\n ================ \n Entered Amount: {entTotal:c} " +
    $"\n Entered Tip (%): {fTip:p0}" +
    $" \n \n Press Enter to Calculate");
    Console.ReadLine();
Console.Clear();
//Last printout line 
Console.WriteLine($"\n A {fTip:p0} tip on your total of {fTotal:c} is: {(fTotal * fTip):c}" +
    $"\n \n Press any key to exit");







