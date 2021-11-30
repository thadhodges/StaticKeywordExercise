using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordExercise
{
    public static class TempConverter
    {

        public static double FtoC(double ftemp)
        {
            double newTemp =  (ftemp - 32) * 5 / 9;
            
            Console.WriteLine($"{ftemp} F is {newTemp} C");
            return newTemp;
        }

        public static double CtoF(double ctemp)
        {
            double newTemp = ((ctemp / 5) * 9) + 32;
            Console.WriteLine($"{ctemp} C is {newTemp} F");
            return newTemp;
        }

    }
}
