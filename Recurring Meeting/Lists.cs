using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurring_Meeting
{
    internal class Lists
    {
        private List<Start_EndTimes> _times = new List<Start_EndTimes>();

        internal List<Start_EndTimes> Times { get => _times; set => _times = value; }
    }
}
