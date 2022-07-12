using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class House
    {
        public int surface;
        public Door door;
        public House(int surface)
        {
            this.surface = surface;
            door = new Door();
        }

        public void SetSurface(int surface)
        {
            this.surface = surface;            
        }
        public int GetSurface()
        {
            return surface;
        }

        public void SetDoor(Door door)
        {
            this.door = door;
        }

        public Door GetDoor()
        {
            return door;
        }
      
        public void Display()
        {
            Console.WriteLine("Je suis une maison, ma surface est de " + surface + "m2");
        }
    }
}
