int num;

Console.WriteLine("Enter your Number: ");
num = int.Parse(Console.ReadLine());

if (num == 0)
{
    Console.WriteLine("Zero");

}
else if (num % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}