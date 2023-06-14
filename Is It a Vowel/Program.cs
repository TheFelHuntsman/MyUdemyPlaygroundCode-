using Is_It_a_Vowel;
using System;
using System.Diagnostics.Metrics;

char? key = new char?();
// Array for the vowel check loop - this will check all the of the letters of the alphabet automatically as they have been declared here as Char Array"[]" // 
char[] Letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
// Main Method // 
Vowel_method vowel_Method = new Vowel_method();

while (key == null)
{
    Console.WriteLine("Press any key: ");
    try
    {
        key = char.Parse(Console.ReadLine().ToUpper());
    }
    catch
    {
        Console.WriteLine("Please enter a valid letter: ");
    }
}

// For each loops take one action at a time and processes them, in this case to our array delcared above (in order) //
//foreach(var letter in Letters)

// Parallel Loops process multiple parts of the delcared Array all at once, this is known as multi-threadding as the process being entered (be it auto or manually) are all processed together. // 
//Parallel.ForEach(Letters, letter =>

//Loop method for calling to the declared Array // 
/*{
    Vowel_method vowel_Method = new Vowel_method();
    var letterUpper = char.Parse(letter.ToString().ToUpper());
    vowel_Method.setEnteredValue(letterUpper);
    Console.WriteLine($"The letter you entered: {letter} {vowel_Method.getenteredvalue()} a Vowel");
});*/

// Main method // 
vowel_Method.setEnteredValue(key);

Console.Clear();

Console.WriteLine($"The letter you entered: {key} {vowel_Method.getenteredvalue()} a Vowel");