using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometriska__figurer
{
    public class Shape : Program
    {
        //Fält
        private double _length;
        private double _width;

        //Egenkaper
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

        public double Perimeter { get; }

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

        //Konstruktor
        protected Shape(double length, double width)
        {
              Length = _length;
              Width = _width;

        }

        public override string ToString()
        {

           

        }
    }
}
