using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Popof.model
{
    internal class EquilateralTriangle:Triangle
    {
        public double Firstside { get; set; }
        public double Secondside { get; set; }
        public double AngleBetween { get; set; }

        public EquilateralTriangle(double length)
        {
            this.Firstside = this.Secondside = length;
            this.AngleBetween = 60;
        }

        public  double Perimetr()
        {
            return 3 * this.Firstside;
        }

        public  double Square()
        {
            return (Math.Sqrt(3) / 4) * Firstside * Secondside;
        }
    }
}
