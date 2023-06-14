using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HTTP_Status_Codes
{

    internal class StatusCodes
    {
        
        public string getResponse(int? value)
        {
            var range = value / 100;
            switch (range)
            {
                case (1):
                    {
                        return "Informational response"; 
                        
                    }
                case (2):
                    {
                        return "Successful response";
                        
                    }
                case (3):
                    {
                        return "Rediretion message";
                    }
                case (4):
                    {
                        return "Client Error message";
                    }
                case (5):
                    {
                        return "Server Error response";
                    }
                default:
                    {
                        return "That is not a known HTTP Status Code";
                    }
            }
        }
    }
}
