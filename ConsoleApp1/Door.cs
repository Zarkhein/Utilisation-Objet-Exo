using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Door
    {
        public string color;
        public Door()
        {
            this.color = "blue";
        }

        public Door(string color)
        {
            this.color=color;
        }

        public void Display()
        {
            Console.WriteLine("Je suis une porte, ma couleur est " + color);
        }

        public void SetColor(string color)
        {
            this.color = color;
        }
        public string getColor()
        {
            return this.color;
        }

    }
}
