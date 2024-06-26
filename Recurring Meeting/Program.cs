﻿using Recurring_Meeting;
using System.Runtime.InteropServices;
using System.Text.Json;
string StartDate, EndDate;
bool ValidValue;

// method
Meeting MeetingDetails = new Meeting();

// start date 

Console.WriteLine("Meeting Start Date & Time: ");
StartDate = Console.ReadLine();
MeetingDetails.setStartDate(StartDate);

// end date 
ValidValue = false;
while (ValidValue == false)
{
    Console.WriteLine("Meeting End Date & time: ");
    EndDate = Console.ReadLine();
    Console.WriteLine("\n");
    ValidValue = MeetingDetails.setEndDate(EndDate);
    if (ValidValue == false)
    {
        Console.WriteLine("Please enter a meeting end date/time greater than the start:  ");
    }
}

// Frequency 

ValidValue = false;
while (ValidValue == false)
{
    char Freq;
    Console.WriteLine("Frequency [(D)aily,(W)eekly, (M)onthly, (Y)early]: ");
    Freq = Console.ReadKey().KeyChar;
    Console.WriteLine("\n");
    ValidValue = MeetingDetails.setFrequency(Freq);
    if (!ValidValue)
    {
        Console.WriteLine("Please Press a valid key: [(D)aily,(W)eekly, (M)onthly, (Y)early]: ");
    }
}
// Skip Weekends

ValidValue = false;
while (ValidValue == false)
{
    char Skip;
    Console.WriteLine("Does the meeting occur over the weekends [Y)es, (N)o]?: ");
    Skip = Console.ReadKey().KeyChar;
    Console.WriteLine("\n");
    ValidValue = MeetingDetails.setSkip(Skip);
    if (!ValidValue)
    {
        Console.WriteLine("Please eneter a valid letter [Y)es, (N)o]:");
    }
}
Lists RecLists = new Lists();

// Print meeting dates 
Recurrences rec = new Recurrences(RecLists);
rec.Daylist(MeetingDetails);

/* create class "list" - Done 
 * call recurrences method (program.cs)  - Done 
 * add dates to "list" class (Depency injection seen on recurrences class) - done  
 * break out of the list when end date is hit - Done 
 * save class list to json from "list class" - Done 
 * write line "list" - Done 
*/
// save meeting dates 

var saveM = JsonSerializer.Serialize(MeetingDetails);
string filepathM = Environment.ExpandEnvironmentVariables("%Userprofile%\\Documents\\MeetingMain.Json");
File.WriteAllText(filepathM, saveM);

var saveR = JsonSerializer.Serialize(RecLists.Times);
string filepathR = Environment.ExpandEnvironmentVariables("%Userprofile%\\Documents\\MeetingRecurrences.Json");
File.WriteAllText(filepathR, saveR);

// reviews what is being saved into the json
Console.WriteLine($"{saveM} {saveR}");
//Meeting MeetingDetails2 = new Meeting();
//Writes saved json file to class (prints out to console as per saved config details) 
/*MeetingDetails2 = JsonSerializer.Deserialize<Meeting>(save);
Console.WriteLine(MeetingDetails2.StartDate1.ToString());*/
