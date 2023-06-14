using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDE_Temperature_Conversion
{
    public class Temperatures
    {
        private decimal? Celcius
        { get; set; }
        private decimal? Farenheit
        { get; set; }
        private decimal? Kelvin
        { get; set; }
        private string? EnteredValue1;
        private string? EnteredValue2;

        //EnteredValue1 = eUnit (Get Set) 
        public void setEnteredValue1(string value)
        {
            if (value == "K" || value == "C" || value == "F")
            {
                EnteredValue1 = value;
            }
        }
        public string getEnteredValue1()
        {
            return EnteredValue1;
        }

        // UserTermperature = eTemp (Set Check) 
        public void setUserTemperature(decimal temperature1)
        {
            switch (this.EnteredValue1)
            {
                case "C":
                    Celcius = temperature1;
                    break;
                case "F":
                    Farenheit = temperature1;
                    break;
                case "K":
                    Kelvin = temperature1;
                    break;
            }
        } 
        // EnteredValue2 = eCoUnit (Get Set) 
        public void setEnteredvalue2(string value)
        {
            if (value == "K" || value == "C" || value == "F")
            {
                EnteredValue2 = value;
            }
        }

        public string getEnteredvalue2()
        {
            return EnteredValue2;
        }

        public decimal Conversion()
        {
            Formulae formulae = new Formulae(); 

            switch(this.EnteredValue1) 
            {
                case "C":
                    if(EnteredValue2 == "K")
                    {
                        return formulae.CtoK((decimal)Celcius);
                    }
                    else if(EnteredValue2 == "F")
                    {
                        return formulae.CtoF((decimal)Celcius);
                    }
                    else
                    {
                        return (decimal)Celcius;
                    }
                    
                case "F":
                    if(EnteredValue2 == "C")
                    {
                        return formulae.FtoC((decimal)Farenheit);
                    }
                    else if (EnteredValue2 == "K")
                    {
                        return formulae.FtoK((decimal)Farenheit);
                    }
                    else
                    {
                        return (decimal)Farenheit;
                    }

                case "K":
                    if(EnteredValue2 == "F")
                    {
                        return formulae.KtoF((decimal)Kelvin);
                    }
                    else if (EnteredValue2 == "C")
                    { 
                        return formulae.KtoC((decimal)Kelvin);
                    }
                    else
                    {
                        return (decimal)Kelvin;
                    }
                default: throw new ArgumentException();
            }
        }
    }
}
