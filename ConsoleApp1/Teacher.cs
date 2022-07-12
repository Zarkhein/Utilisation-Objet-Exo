using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Teacher : Person1
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins...");
        }
    }
}
