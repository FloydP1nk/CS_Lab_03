using System;

namespace Lab_03_2
{
    public class Car : IEquatable<Car>
    {
        private string Name { get; set; }
        private string Engine { get; set; }
        private string MaxSpeed { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

        public bool Equals(Car other)
        {
            if (other == null)
                return false;
            return Name == other.Name &&
                   Engine == other.Engine &&
                   MaxSpeed == other.MaxSpeed;
        }
    }
}