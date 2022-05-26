using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Triangle : IFigure
    {
        private readonly double A, B, C;

        public Triangle (double a, double b, double c) : base()
        {
            A = a;
            B = b;
            C = c;
        }

        public double Square()
        {
            double s = 0;

            if (IsRight())
            {
                double[] catetus = Catets();

                s = catetus[0] * catetus[1] / 2;
            }
            else
            {
                double p = (A + B + C) / 2;
                s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
            

            return s;
        }

        private bool IsRight()
        {
            double hypotenuse = MaxSide();
            double[] catetus = Catets();

            if (catetus[0]*catetus[0] + catetus[1]+catetus[1] == hypotenuse * hypotenuse)
                    return true;
            else return false;
        }

        private double MaxSide()
        {
            return Math.Max(Math.Max(A, B), C);
        }

        private double[] Catets()
        {
            double[] sides = new double[3] { A, B, C };
            double[] catetus = sides.Where(x => x != MaxSide()).ToArray();

            return catetus;
        }
    }
}
