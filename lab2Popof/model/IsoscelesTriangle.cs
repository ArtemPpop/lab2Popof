using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Popof.model
{
    internal class IsoscelesTriangle:Triangle
    {

        public double Firstside { get; set; }
        public double Secondside { get; set; }
        public double AngleBetween { get; set; }

        public IsoscelesTriangle(double length)
        {
            this.Firstside = this.Secondside = length;
            this.AngleBetween = AngleBetween;
        }

        public IsoscelesTriangle(double length, double side2, double angle) : this(length)
        {
        }

        public double Perimetr()
        {
            return 2 * this.Firstside + this.Secondside;
        }

        public double Square()
        {
            return this.Firstside * this.Secondside * Math.Sin(this.AngleBetween);
        }
    }
}

