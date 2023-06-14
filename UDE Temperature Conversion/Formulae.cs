using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDE_Temperature_Conversion
{
    public class Formulae
    {
        public decimal CtoK(decimal C)
        {
             return Math.Round(C + 273.15m);
        }

        public decimal CtoF(decimal C)
        {
            return Math.Round(C * (9m / 5m) + 32m);
        }

        public decimal KtoC(decimal K)
        {
            return Math.Round(K - 273.15m);
        }

        public decimal KtoF(decimal K)
        {
            return Math.Round(((K - 273.15m) * (9m / 5m)) + 32m);
        }
   
        public decimal FtoK(decimal F)
        {
            return Math.Round((F - 32m) * (5m / 9m) + 273.15m);
        }

        public decimal FtoC(decimal F)
        {
            return Math.Round((F - 32) * (5 / 9));
        }
  
    }

    

}
