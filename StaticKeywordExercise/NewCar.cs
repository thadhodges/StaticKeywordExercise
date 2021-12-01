using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordExercise
{
    public class NewCar
    {
        public NewCar()
        {
            CarLot.numberOfCars += 1; 
        }

        public int Year { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
    }
}
