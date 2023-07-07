using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min__Max_and_Skip
{
    internal class Condition
    {
        private int value1, value2, value3;

        //Sets the Condition value ( += / -= )
        public void setValue1(int value)
        {
            this.value1 = value;
        }
        public void setValue2(int value)
        {
            this.value2 = value;
        } 
        public void setValue3(int value)
        {
            this.value3 = value;
        }

        public bool validateValues()
        {
            bool retresponse = false;
            switch (this.value2)
            {
                case > 0:
                    if (value1 < value3)
                        retresponse = true;
                    break;
                case < 0:
                    if (value1 > value3)
                        retresponse =  false;
                    break;
            }
            return retresponse;
        }
                    
    }
}



            