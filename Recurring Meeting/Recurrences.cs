using Recurring_Meeting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Recurring_Meeting
{
    internal class Recurrences
    {
        private Lists Meetinglists;
        private DateTime meetingstarttime = new DateTime();
        private DateTime meetingendtime = new DateTime();

        public Recurrences(Lists comp)
        {
            Meetinglists = comp;
        }    
       
        public void Daylist(Meeting value)
        {
            meetingstarttime = value.StartDate1;
            meetingendtime = value.EndDate1;

            Console.WriteLine("Meeting Recurrence dates");
            // sets the number of loops - Main Reccurences loop.
            for (int i = 1; i <= 11; i++)
            {
                Start_EndTimes start_EndTimes = new Start_EndTimes();
                meetingstarttime = NextMeeting(meetingstarttime, value.Freq1);
                meetingendtime = NextMeeting(meetingendtime, value.Freq1);
                if (!value.Skip1)
                {
                    while (!IsWeekday(meetingstarttime))
                    {
                        start_EndTimes.Start = meetingstarttime.AddDays(1);
                        start_EndTimes.End = meetingendtime.AddDays(1);
                    }
                }
                else
                {
                    start_EndTimes.Start = meetingstarttime;
                    start_EndTimes.End = meetingendtime;
                }
                
                Meetinglists.Times.Add(start_EndTimes);

                Console.WriteLine($"Start date:{start_EndTimes.Start} End Date:{start_EndTimes.End}");
            }
        }
        // is the entered day a weekday
        private bool IsWeekday(DateTime value)
        {
            if (value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private DateTime NextMeeting(DateTime time, char Freq)
        {
            if (Meetinglists.Times.Count == 0)
            {
                return time;
            }
            else
            {
                switch (Freq)
                {
                    case 'd':
                        time = time.AddDays(1);
                            return time;
                    case 'w':
                        time = time.AddDays(7);
                            return time;
                    case 'm':
                        time = time.AddMonths(1);
                            return time;
                    case 'y':
                        time = time.AddYears(1);
                        return time;
                            
                }
                return time;
            }
        }
    }
}
