using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person1
    {
        public int age;
        
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public void setAge(int age)
        {
            this.age = age; 
        }
    }
}
