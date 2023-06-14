using HTTP_Status_Codes;
using System;
using System.Net;

int? StatusCode = new int?();
StatusCodes statusCodes = new StatusCodes();

while (StatusCode == null)  
{
    try
    {
        Console.WriteLine("Enter your status code: ");
        StatusCode = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Please enter a valid HTTP Status Code: ");
    }
}

Console.WriteLine($"{StatusCode} is a {statusCodes.getResponse(StatusCode)}");