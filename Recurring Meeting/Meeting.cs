using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurring_Meeting
{
    public class Meeting
    {
        private DateTime StartDate;
        private DateTime EndDate;
        private char Freq;
        private bool Skip;

        public DateTime StartDate1 { get => StartDate; set => StartDate = value; }
        public DateTime EndDate1 { get => EndDate; set => EndDate = value; }
        public char Freq1 { get => Freq; set => Freq = value; }
        public bool Skip1 { get => Skip; set => Skip = value; }

        // start
        public void setStartDate(string value)
        {
            StartDate1 = DateTime.Parse(value);
        }
        //end
        public bool setEndDate(string value)
        {
            if (DateTime.Parse(value) > StartDate1)
            {
               EndDate1 = DateTime.Parse(value);
                return true;
            }
            else
            {
                return false;
            }
            
        }
        //frequency
        public bool setFrequency(char value)
        {
            if (value == 'd' || value == 'w' || value == 'm' || value == 'y')
            {
                Freq1 = value;
                return true;
            }
            else
            {
                return false;
            }
        }
        // Skip 
        public bool setSkip(char value)
        {
            switch (value)
            {
                case 'Y':
                    Skip = true;
                    return true;
                case 'N':
                    Skip = false;
                    return true;
                default:
                    return false;
            }
        }
    }
}
