using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class calcController
    {
        private double current_value = 0;
        private double total_value = 0;
        private string current_string = "0";
        private char sign = '\0';
        

        public string buttonNumberPress(string n)
        {
            if (current_string == "Imaginary Number" || current_string == "Undefined") 
            {
                return current_string;
            }
            else if (current_value == 0) 
            {
                current_string = n;
                current_value = Double.Parse(current_string);
                return current_string;
            }
            else
            {
                current_string += n;
                current_value = Double.Parse(current_string);
                return current_string;
            }
        }

        public string buttonclear()
        {
            current_string = "0";
            current_value = 0;
            return current_string;
        }

        public string buttonAllClear()
        {
            current_string = "0";
            current_value = 0;
            total_value = 0;
            sign = '\0';
            return current_string;
        }

        public string arithmetic(char n)
        {
            if (total_value != 0)
            {
                if (sign == '+')
                {
                    total_value += current_value;
                    current_value = 0;
                    current_string = total_value.ToString();
                    sign = n;
                }
                else if (sign == '-')
                {
                    total_value -= current_value;
                    current_value = 0;
                    current_string = total_value.ToString();
                    sign = n;
                }
                else if (sign == '*')
                {
                    total_value *= current_value;
                    current_value = 0;
                    current_string = total_value.ToString();
                    sign = n;
                }
                else if (sign == '/')
                {
                    if (current_value == 0)
                    {
                        return "Undefined";
                    }
                    else
                    {
                        total_value /= current_value;
                        current_value = 0;
                        current_string = total_value.ToString();
                        sign = n;
                    }
                }
            }
            else
            {
                total_value = current_value;
                current_string = total_value.ToString();
                current_value = 0;
                sign = n;
            }
            return current_string;
        }

        public string equals()
        {
            if (sign == '+')
            {
                total_value += current_value;
                current_value = 0;
                current_string = total_value.ToString();
                sign = '\0';
            }
            else if (sign == '-')
            {
                total_value -= current_value;
                current_value = 0;
                current_string = total_value.ToString();
                sign = '\0';
            }
            else if (sign == '*')
            {
                total_value *= current_value;
                current_value = 0;
                current_string = total_value.ToString();
                sign = '\0';
            }

            else if (sign == '/')
            {
                if (current_value == 0)
                {
                    return "Undefined";
                }
                else
                {
                    total_value /= current_value;
                    current_value = 0;
                    current_string = total_value.ToString();
                    sign = '\0';
                }
            }
            else
            {
                total_value = current_value;
            }
            return current_string;
        }
    }
}
