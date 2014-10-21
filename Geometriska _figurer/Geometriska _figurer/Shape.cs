using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometriska_figurer
{
    //Typen ShapeType används för att definiera vilka typer av figurer programmet kan hantera. Typen används då metoden Main anropar CreatShape för att 
    //informera vilken typ av figur som ska skapas.
    public enum ShapeType
    {
        Rectangle,
        Ellipse
    }
    public abstract class Shape
    {
        // Fält
        private double _length;
        private double _width;

        // Egenskapen area som ska behandla figurernas area
        public abstract double Area { get; }

        //Egenskap som kapslar in och validerar fältet length.
        public double Length
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _length = value;
            }
        }

        //Engeskap som ska representera figurens omkrets
        public abstract double Perimeter { get; }

        //Egenskap som kapslar in och validerar fältet width.
        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }

        // Konstruktor som ansvarar för att fälten, via egenskaperna, tilldelas de värden konstruktorns paramter har
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// Metodens uppgift är att överskugga basklassen objekt
        /// </summary>
        /// <returns>Metoden returnerar en sträng representerad av värdet av en instans.</returns>
        public override string ToString()
        {
            return string.Format("\n{0,-10} | {1,10:F2}\n{2,-10} | {3,10:F2}\n{4,-10} | {5,10:F2}\n{6,-10} | {7,10:F2}", "Längd", Length, "Bredd", Width, "Omkrets", Perimeter, "Area", Area);
        }
    }
}