using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_It_a_Vowel
{
    public class Vowel_method
    {
         private string? EnteredValue;
        public void setEnteredValue(char? value)
        {
          switch (value)
            {
                case 'A' or 'E' or 'I' or 'O' or 'U':
                {
                    EnteredValue = "is";
                    break;      
                }
                case 'Y':
                {
                    EnteredValue = "Sometimes is" ;
                    break;
                }
                default:
                    {
                        EnteredValue = "is Not"; 
                        break;
                    }
            }  
        }

        public string? getenteredvalue()
        {
            return EnteredValue;
        }
    }
}
