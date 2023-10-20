using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Recurring_Meeting
{
    public class Lists
    {
        private List<Start_EndTimes> times = new List<Start_EndTimes>();

        internal List<Start_EndTimes> Times { get => times; set => times = value; }

    }

}
