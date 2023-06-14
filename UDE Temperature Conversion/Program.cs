using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using UDE_Temperature_Conversion;

decimal? eTemp = new decimal?();
string eUnit = string.Empty, eCoUnit = string.Empty;
Temperatures temperatures = new Temperatures();

Console.Write($"Welcome to the Temperature Converter!" +
    $"\n ===============================================" +
    $"\n Available Units are: " +
    $"\n (C)elcius. (F)ahrenheit. (K)elvin"
    );

while (eTemp == null)
{
    Console.WriteLine("\n Enter Temperature: ");
    try
    {
        eTemp = decimal.Parse(Console.ReadLine());

    }
    catch
    {
        Console.WriteLine("Please enter a valid number");
    }
    
}

while (temperatures.getEnteredValue1() == null)
{
    Console.WriteLine("\n Enter Unit: ");
    eUnit = Console.ReadLine().ToUpper();
    temperatures.setEnteredValue1(eUnit);
    if(temperatures.getEnteredValue1() == null)
    {
        Console.WriteLine("\n That was not a valid entry, please try again");
    }
}

temperatures.setUserTemperature((decimal)eTemp);

while (temperatures.getEnteredvalue2() == null)
{
    Console.WriteLine("\n Enter Conversion Unit: ");
    eCoUnit = Console.ReadLine().ToUpper();
    temperatures.setEnteredvalue2(eCoUnit);
    if(temperatures.getEnteredvalue2() == null)
    {
        Console.WriteLine(" \n That was not a valid entry please try again");
    }

}

Console.Clear();

Console.WriteLine($"\n Entered Temperature: {eTemp}{eUnit}" +
    $"\n Entered Conversion Unit: {eCoUnit}" +
    $"\n \n Press Enter to Convert ");
Console.ReadLine();

Console.WriteLine($" \n Conversion: {temperatures.Conversion()}{eCoUnit}");


