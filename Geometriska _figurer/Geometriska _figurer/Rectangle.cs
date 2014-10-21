using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    public class Rectangle : Shape
    {
        //Egenskap som ska ge rektangels area
        public override double Area
        {
            get { return Length * Width; }

        }

        //Egenskap som ska ge rektangels omkrets
        public override double Perimeter
        {
            get { return 2 * Length + 2 * Width; }
        }

        //Konstruktor som genom anrop av basklassen konstruktor sser till så att det nya objektets längd och bredd sätts.
        public Rectangle(double length, double width)
            : base(length, width)
        {

        }
    }
}
