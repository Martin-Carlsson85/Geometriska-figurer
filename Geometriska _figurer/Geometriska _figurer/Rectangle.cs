using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometriska__figurer
{
    public class Rectangle : Shape
    {
        //Egenskap
        public override double Area
        {
            get { return Length * Width; }

        }

        //Egenskap
        public override double Perimiter
        {
            get { return 2 * Length + 2 * Width; }
        }

        //Konstruktor
        public Rectangle(double length, double width)
            : base(length, width)
        {

        }
    }
}
