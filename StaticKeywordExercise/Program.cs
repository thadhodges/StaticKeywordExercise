using System;

namespace StaticKeywordExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            TempConverter.FtoC(212);
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            TempConverter.CtoF(100);
        }
    }
}
