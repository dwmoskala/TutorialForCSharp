using System;

namespace Lesson24
{
    class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string Model, int Year)
        {
            this.Model = Model;
            this.Year = Year;
        }

        public bool Equals(Car car)
        {
            return car.Model == this.Model && car.Year == this.Year;
        }
    }
}
