using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Notation
    {
        public static string CountNotation(int i, int number) 
        {
            string result = "";
            while (number > i)
            {
                if (number % i > 9)
                {
                    if (number % i == 10)
                    {
                        result = "A" + result;
                    }
                    else
                    {
                        result = "B" + result;
                    }
                }
                else
                {
                    result = Convert.ToString(number % i) + result;
                }
                    number /= i;
            }
            if (number > 9 && number < 12)
            {
                if (number == 10)
                {
                    result = "A" + result;
                }
                else
                {
                    result = "B" + result;
                }
            }
            else
            {
                result = Convert.ToString(number % i) + result;
            }
            if (number / i != 0)
            {
                result = Convert.ToString(number / i) + result;
            }
            return result;
        }
    }
}
