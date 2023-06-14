// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
var injection = "';Drop table cocochanel--";

var sqlquery = string.Format("INSERT INTO DndDb.dbo.Users VALUES({0})",injection);
Console.WriteLine(sqlquery);