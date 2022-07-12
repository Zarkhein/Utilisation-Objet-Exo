using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class cercle
    {
        double rayon;
        public cercle(double rayon)
        {
            this.rayon = rayon;
        }

        public float getArea()
        {
            return (float)((this.rayon * this.rayon) * Math.PI);
        }

        public float GetPerimeter()
        {
            return (float)(this.rayon * (Math.PI * 2));
        }
    }
}
