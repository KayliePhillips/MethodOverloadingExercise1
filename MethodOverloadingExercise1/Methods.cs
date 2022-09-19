using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExercise1
{
    internal class Methods
    {
        public static int Add(int num1, int num2)
        {
            return (num1 + num2);
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return (num1 + num2);
        }

        public static string Add(int num1, int num2, bool mybool)
        {
            int sum = num1 + num2;
            if (mybool && (num1 + num2 > 1))
            {
                return $"{sum} dollars";
            }

            else if (mybool && ((num1 + num2 == 1) || (num1 + num2 == -1)))
            {
                  return ($"{num1 + num2} dollar");
            }

            else if (mybool && (num1 + num2 <1))
            {
                return ($"{num1 + num2} dollars");
            }

            else
            {
                return $"{num1 + num2}";
            }
        }
    }
}
