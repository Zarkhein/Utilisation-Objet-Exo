using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student : Person1
    {
        
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class");
        }

        public void DisplayAge()
        {
            Console.WriteLine("My age is: " + age + " Year old");
        }
    }
}
