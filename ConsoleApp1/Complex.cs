using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Complex
    {
        int reelle;
        int imaginaire;
        public Complex(int reelle, int imaginaire)
        {
            this.reelle = reelle;
            this.imaginaire = imaginaire;     
        }

        public void SetReelle(int reelle)
        {
            this.reelle = reelle;
        }

        public int GetReelle()
        {
            return reelle;
        }

        public void SetImaginaire(int imaginaire)
        {
            this.imaginaire = imaginaire;
        }

        public int getImaginaire()
        {
            return imaginaire;
        }

        public double getMagnitude()
        {
            int magnitude = (reelle * reelle) + (imaginaire * imaginaire);
            return Math.Sqrt(magnitude);


        }

        public void Sum(Complex c)
        {
            reelle += c.GetReelle();
            imaginaire += c.getImaginaire();
            Console.WriteLine("En cours de résolution....");
        }

        public new string ToString()
        {
            return "(" + reelle + "," + imaginaire + ")";
        }

    }
}
