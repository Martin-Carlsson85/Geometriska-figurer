using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometriska__figurer
{
    public class Elipse : Shape
    {
        //Egenskap
        public override double Area        {
            get { return Math.PI * (Length / 2) * (Width / 2); }
        }

        //Egenskap
        public override double Permitter
        {
            get { return (Math.PI * Math.Sqrt(2 * (Length / 2) * (Length / 2) + 2 * (Width / 2) * (Width / 2))); }
        }

        //Konstruktor
        public Elipse(double length, double width)
            : base(length, width)
        {

        }
    }
}
