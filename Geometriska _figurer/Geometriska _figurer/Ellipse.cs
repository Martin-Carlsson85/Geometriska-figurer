using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    public class Ellipse : Shape
    {
        //Egenskap som ger ellips arean
        public override double Area
        {
            get { return Math.PI * (Length / 2) * (Width / 2); }
        }

        //Egenskap som ger ellips omkretsen
        public override double Perimeter
        {
            get { return (Math.PI * Math.Sqrt(2 * (Length / 2) * (Length / 2) + 2 * (Width / 2) * (Width / 2))); }
        }

        //Konstruktor som genom anrop av basklassens konstruktor ser till så att det nya objektets längd och bredd sätts
        public Ellipse(double length, double width)
            : base(length, width)
        {

        }
    }
}
