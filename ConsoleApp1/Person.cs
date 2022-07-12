using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        protected string nom;
        protected House house;

        public Person()
        {
            nom = "Albert";
            house = new House(-1);
        }

        public Person(string nom, House house)
        {
            this.nom = nom; 
            this.house = house;
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }    
        }

        public House House
        {
            get { return this.house; }
            set { this.house = value; }
        }

        public void Display()
        {
            Console.WriteLine("Mr." + nom);
            house.Display();
            house.door.Display();
        }
    }
}
