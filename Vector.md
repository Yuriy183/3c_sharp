using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c_sharp
{
    class Vector
    {
        public Vector()
        {

        }

        private double x, y, z;

        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }

        public override string ToString()
        {
            return this.X + "," + this.Y + "," + this.Z;
        }
        //ф-я для нахождения длинны
        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2) + Math.Pow(this.Z, 2));
        }
    }
}
