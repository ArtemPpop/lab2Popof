using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Popof.model
{
    internal class Rightriangle:Triangle
    {
        public double Firstside { get; set; }
        public double Secondside { get; set; }
        public double AngleBetween { get; set; }

       

        public Rightriangle(double length)
        {
            this.Firstside = this.Secondside = length;
            this.AngleBetween = 90;
        }

        public Rightriangle(double length, double side2, double angle) : this(length)
        {
        }

        public  double Perimetr()
        {
            return (this.Firstside * this.Secondside) / 2;
        }

        public double Square()
        {
            return this.Firstside + this.Secondside + Math.Sqrt(this.Firstside * this.Firstside + this.Secondside * this.Secondside);
        }
    }
}

