//https://web.telegram.org/01f1b7c1-f927-4448-af28-157b3ceddbc4

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
        private double skalar;
        private double vectornoe;

        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vector(double skalar)
        {
            this.Skalar = skalar;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }

        public double Skalar { get => skalar; set => skalar = value; }

        public double Vectornoe { get => vectornoe; set => vectornoe = value; }

        public override string ToString()
        {
            return this.X + "," + this.Y + "," + this.Z;
        }
        //ф-я для нахождения длинны
        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2) + Math.Pow(this.Z, 2));
        }

        /* Перезагрузка - в классе прописывается как функция для операторов типо + * - /.  
        К примеру: есть два вектора и просто так их не суммировать и можно прописать 
        чтоб оно по формуле через + суммировало. */

        //перегрузка оператора сложения
        public static Vector operator + (Vector vector1, Vector vector2)
        {
            Vector vector = new Vector();
            vector.X = vector1.X + vector2.X;
            vector.Y = vector1.Y + vector2.Y;
            vector.Z = vector1.X + vector2.Z;
            return vector;
        }

        //перегрузка векторного произведения векторов
        public static Vector operator *(Vector vector1, Vector vector2)
        {
            Vector vector = new Vector();
            vector.X = vector1.Y * vector2.Z - vector1.Z - vector2.Y;
            vector.Y = vector1.X * vector2.Z - vector1.Z - vector2.X;
            vector.Z = vector1.X * vector2.Y - vector1.Y - vector2.X;
            return vector;
        }

        //перегрузка скалярного произведения векторов
        public static Vector operator %(Vector vector1, Vector vector2)
        {
            Vector vector = new Vector();
            vector.Skalar = vector1.X * vector2.X + vector1.Y * vector2.Y + vector1.Z * vector2.Z;
            return vector;
        }
    }
}
