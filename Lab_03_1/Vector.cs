using System;

namespace Lab_03_1
{
    struct Vector
    {
        private double x;
        private double y;
        private double z;

        static public Vector operator +(Vector a, Vector b)
        {
            Vector c;
            c.x = a.x + b.x;
            c.y = a.y + b.y;
            c.z = a.z + b.z;
            return c;
        }

        static public Vector operator *(Vector a, double n)
        {
            Vector c;
            c.x = a.x * n;
            c.y = a.y * n;
            c.z = a.z * n;
            return c;
        }

        static public double operator *(Vector a, Vector b)
        {
            Vector c;
            c.x = a.x * b.x;
            c.y = a.y * b.y;
            c.z = a.z * c.y;
            return c.x + c.y + c.z;
        }

        public double LenCalc()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y);
        }

        static public bool operator >(Vector a, Vector b)
        {
            return a.LenCalc() > b.LenCalc();
        }

        static public bool operator <(Vector a, Vector b)
        {
            return a.LenCalc() < b.LenCalc();
        }

        static public bool operator >=(Vector a, Vector b)
        {
            return a.LenCalc() >= b.LenCalc();
        }

        static public bool operator <=(Vector a, Vector b)
        {
            return a.LenCalc() <= b.LenCalc();
        }

        static public bool operator ==(Vector a, Vector b)
        {
            return a.LenCalc() == b.LenCalc();
        }

        static public bool operator !=(Vector a, Vector b)
        {
            return !(a == b);
        }

        public bool Equals(Vector other)
        {
            return x == other.x && y == other.y && z == other.z;
        }
    }
}