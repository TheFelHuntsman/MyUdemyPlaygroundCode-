﻿using Recurring_Meeting;
using System.Runtime.InteropServices;
using System.Text.Json;
string StartDate, EndDate;
bool ValidValue;

// method
Meeting MeetingDetails = new Meeting();
// params

// call previous saves

// start date 

//Console.WriteLine("Meeting Start Date & Time: ");
//StartDate = Console.ReadLine();
StartDate = "2023-09-01 08:00";
MeetingDetails.setStartDate(StartDate);

// end date 
/*ValidValue = false;
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
}*/
EndDate = "2023-09-01 09:00";
MeetingDetails.setEndDate(EndDate);

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
    Console.WriteLine("Do the meeting occur over the weekends [Y)es, (N)o]?: ");
    Skip = char.Parse(Console.ReadLine());
    Console.WriteLine("\n");
    ValidValue = MeetingDetails.setSkip(Skip);
    if (!ValidValue)
    {
        Console.WriteLine("Please eneter a valid letter [Y)es, (N)o]:");
    }
}

// save meeting dates 
var save = JsonSerializer.Serialize(MeetingDetails);
string filepath = Environment.ExpandEnvironmentVariables("%Userprofile%\\Documents\\Meetings.Json");
File.WriteAllText(filepath,save);
// reviews what is being saved into the json
Console.WriteLine(save);
//Meeting MeetingDetails2 = new Meeting();
//Writes saved json file to class (prints out to console as per saved config details) 
/*MeetingDetails2 = JsonSerializer.Deserialize<Meeting>(save);
Console.WriteLine(MeetingDetails2.StartDate1.ToString());*/

Recurrences rec = new Recurrences();
rec.Daylist(MeetingDetails);

// Print meeting dates 
/* create class "list" 
 * call recurrences method 
 * add date to "list" class 
 * break out of the list when end date it hit
 * save class list to json from "list class"
 * write line "list"
*/
