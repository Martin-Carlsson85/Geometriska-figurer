using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometriska_figurer
{
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

        // Egenskaper
        public abstract double Area { get; }

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
        public abstract double Perimeter { get; }

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

        // Konstruktor
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// Metodens uppgift är att överskugga basklassen objekt
        /// </summary>
        /// <returns>En sträng med objektets längd, bredd, omkrets och area.</returns>
        public override string ToString()
        {
            return string.Format("\n{0,-10} | {1,10:F2}\n{2,-10} | {3,10:F2}\n{4,-10} | {5,10:F2}\n{6,-10} | {7,10:F2}", "Längd", Length, "Bredd", Width, "Omkrets", Perimeter, "Area", Area);
        }
    }
}