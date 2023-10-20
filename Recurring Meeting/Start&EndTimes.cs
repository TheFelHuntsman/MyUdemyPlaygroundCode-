using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurring_Meeting
{
    internal class Start_EndTimes
    {
        private DateTime _start;
        private DateTime _end;

        public DateTime Start { get => _start; set => _start = value; }
        public DateTime End { get => _end; set => _end = value; }
    }
}
