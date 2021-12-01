using System;

namespace StaticKeywordExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Start of Exercise 1
            Console.WriteLine("First Static Class Exercise");
            TempConverter.FtoC(212);
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            TempConverter.CtoF(100);

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            ///End of Exercise 1
            ///

            Console.WriteLine("Second Static Class Exercise");
            var car1 = new NewCar();
            car1.Make = "Ford";
            car1.Year = 2010;
            car1.Color = "Red";
            Console.WriteLine($"Added a {car1.Year} {car1.Color} {car1.Make}");
            Console.WriteLine($" Total # of Cars in the Lot: {CarLot.numberOfCars}");

            var car2 = new NewCar();
            car2.Make = "Chevy";
            car2.Year = 2010;
            car2.Color = "Red";
            Console.WriteLine($"Added a {car2.Year} {car2.Color} {car2.Make}");
            Console.WriteLine($" Total # of Cars in the Lot: {CarLot.numberOfCars}");

            var car3 = new NewCar();
            car3.Make = "Nissan";
            car3.Year = 2010;
            car3.Color = "Red";
            Console.WriteLine($"Added a {car3.Year} {car3.Color} {car3.Make}");
            Console.WriteLine($" Total # of Cars in the Lot: {CarLot.numberOfCars}");

            //end exercise 2


        }
    }
}
